using System;

namespace CISMOD2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nflteams = { "Steelers", "Colts", "Chiefs", "Bills", "Titans", "Falcons", "Jaguars", "Vikings", "Panthers", "Broncos" };
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