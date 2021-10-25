using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            IStreamable file = new File("Anatoly", 50, 1000);
            IStreamable music = new Music("Veselin", "Hushove", 10, 500);



            StreamProgressInfo sPIFile = new StreamProgressInfo(file);
            Console.WriteLine(sPIFile.CalculateCurrentPercent());

            StreamProgressInfo sPIMusic = new StreamProgressInfo(music);
            Console.WriteLine(sPIMusic.CalculateCurrentPercent());

        }
    }
}
