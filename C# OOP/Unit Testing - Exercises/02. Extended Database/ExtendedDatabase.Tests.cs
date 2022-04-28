using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase extendedDatabase;
        [SetUp]
        public void Setup()
        {
            this.extendedDatabase = new ExtendedDatabase();
        }

        [Test]
        public void Add_ThrowException_WhenCapacityIsExceeded()
        {
            for (int i = 0; i < 16; i++)
            {
                this.extendedDatabase.Add(new Person(i, $"Username{i}"));
            }
            Assert.Throws<InvalidOperationException>(() => 
            this.extendedDatabase.Add(new Person(16, "InvalidUsername")));
        }
        [Test]
        public void Add_ThrowException_WhenUsernameIsUsed()
        {
            string username = "Nasko";
            this.extendedDatabase.Add(new Person(1, username));

            Assert.Throws<InvalidOperationException>(() =>
            this.extendedDatabase.Add(new Person(2, username)));
        }
        [Test]
        public void Add_ThrowException_WhenIdIsUsed()
        {
            long id = 1;
            string username = "RandomUser";
            this.extendedDatabase.Add(new Person(id, "RandomUser"));

            Assert.Throws<InvalidOperationException>(() =>
            this.extendedDatabase.Add(new Person(id, "RandomUser2")));
        }
        [Test]
        public void Add_IncreasesCounter_WhenUserIsValid()
        {
            this.extendedDatabase.Add(new Person(1, "Nasko"));
            this.extendedDatabase.Add(new Person(2, "Stoyan"));

            int expectedCount = 2;

            Assert.That(this
                .extendedDatabase.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void Remove_ThrowsException_WhenDataBaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendedDatabase.Remove());
        }
        [Test]
        public void Remove_RemoveElementFromDatabase()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                this.extendedDatabase.Add(new Person(i, $"Username{i}"));

            }
            this.extendedDatabase.Remove();

            Assert.That(this.extendedDatabase.Count, Is.EqualTo(n - 1));
            Assert.Throws<InvalidOperationException>(() => this.extendedDatabase.FindById(n - 1));
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsername_ThrowsException_WhenArgumentIsNotValid(string username)
        {
            Assert.Throws<ArgumentNullException>(() => this.extendedDatabase.FindByUsername(username));
        }
        [Test]
        public void FindByUsername_ThrowsException_WhenUsernameDoesNOtExist()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendedDatabase.FindByUsername("Username"));
        }
        [Test]
        public void FindByUsername_WhenuserExist()
        {
            Person person = new Person(1, "nasko");

            this.extendedDatabase.Add(person);

            Person dbPerson = this.extendedDatabase.FindByUsername(person.UserName);
            Assert.That(person, Is.EqualTo(dbPerson));
        }
        [Test]
        [TestCase(-1)]
        [TestCase(-25)]
        public void FindById_WhenIdIsLesser(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => this.extendedDatabase.FindById(id));
        }
        [Test]
        public void Findbyid_whenuserwithiddoesnotexist()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendedDatabase.FindById(100));
        }

        [Test]
        public void Findbyid_whenuserExist()
        {
            Person person = new Person(1, "nasko");

            this.extendedDatabase.Add(person);

            Person dbPerson = this.extendedDatabase.FindById(person.Id);
            Assert.That(person, Is.EqualTo(dbPerson));
        }
        [Test]
        public void Ctor_Test_whenCapacity()
        {
            Person[] arguments = new Person[17];

            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = new Person(i, $"Username{i}");
            }
            Assert.Throws<ArgumentException>(() =>
            this.extendedDatabase = new ExtendedDatabase(arguments));
        }
        [Test]
        public void Ctor_AddInitialPpl_ToDatabas()
        {
            Person[] arguments = new Person[5];

            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = new Person(i, $"Username{i}");
            }

            this.extendedDatabase = new ExtendedDatabase(arguments);

            Assert.That(this.extendedDatabase.Count, Is.EqualTo(arguments.Length));

            foreach (var person in arguments)
            {
                Person dbPerson = this.extendedDatabase.FindById(person.Id);
                Assert.That(person, Is.EqualTo(dbPerson));
            }
        }
    }
}