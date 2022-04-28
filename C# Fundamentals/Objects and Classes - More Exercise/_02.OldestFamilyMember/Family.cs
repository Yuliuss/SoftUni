using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OldestFamilyMember
{
    class Family
    {
        public List<Person> FamilyMembers { get; set; } = new List<Person>();

        public void AddMember(string[] memberInfo)
        {
            Person newMember = new Person(memberInfo[0], int.Parse(memberInfo[1]));

            this.FamilyMembers.Add(newMember);
        }

        public Person GetOledestMember()
        {
            return FamilyMembers.OrderByDescending(m => m.Age).First();
        }
    }
}
