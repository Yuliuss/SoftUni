using System;

namespace AuthorProblem
{
    [Author("Az")]
    [Author("Azz")]
    [Author("Azzz")]
    public class StartUp
    {
        [Author("Otnovo Az")]
        public static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
        [Author("Dimitrichko")]
        private static void NextGet()
        {

        }
    }
}
