using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment3
{
    public class CricketTeam
    {
        public string Team_name { get; set; }
        public int Matches { get; set; }
        public int Sum { get; set; }
        public double Average { get; set; }
        public (int, int, double) PointsCalculation(int no_of_matches)
        {
            Sum = 0;
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score of match {i + 1}: ");
                Sum += Convert.ToInt32(Console.ReadLine());
            }
            Matches = no_of_matches;
            Average = (double)Sum / no_of_matches;
            return (Matches, Sum, Average);
        }
    }
    class Criket
    {
        static void Main()
        {
            CricketTeam team = new CricketTeam();
            Console.Write("Enter the  Team Name : ");
            string T_name = Console.ReadLine();
            team.Team_name = T_name;
            Console.Write("Ente the number of matches: ");
            int noOfMatches = Convert.ToInt32(Console.ReadLine());
            var (matches, sum, average) = team.PointsCalculation(noOfMatches);

            Console.WriteLine("---------------------------------");

            Console.WriteLine($"Team: {team.Team_name}");
            Console.WriteLine($"Matches : {matches}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.ReadKey();
        }
    }
}
