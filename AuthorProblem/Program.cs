using System;

namespace AuthorProblem
{
    [Author("Anatoli")]
    public class StartUp
    {
        [Author("Georgi")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();


        }
    }
}
