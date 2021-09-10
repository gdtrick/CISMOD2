using System;

namespace CISMOD2dbl
{
    class Program
    {
        static void Program.Main(double[] args)
        {

            double[] nflteams = { "Steelers", "Colts", "Chiefs", "Bills", "Titans", "Falcons", "Jaguars", "Vikings", "Panthers", "Broncos" };
            Console.WriteLine(nflteams[1]);
            Console.WriteLine(nflteams[5]);
            Console.WriteLine(nflteams[7]);

            for (int i=0; i < nflteams.Length;i++)
            {
                Console.WriteLine(nflteams[i]);
            }
         
        }
    }
}