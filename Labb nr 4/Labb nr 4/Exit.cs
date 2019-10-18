using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Exit : MapParts
    {
        private char part = 'E';
        public override char MapPiece { get => part; set => part = value; }

        static readonly List<ScoreBoard> Score = new List<ScoreBoard>();

        //The score prints out and after that the score board.
               
        public override void Connect(Player player)
        {
            Score.Add(new ScoreBoard { Name = "Sara", Score = 60 });
            Score.Add(new ScoreBoard { Name = "Ville", Score = 59 });
            Score.Add(new ScoreBoard { Name = "Egon", Score = 63 });
            Score.Add(new ScoreBoard { Name = player.name, Score = player.step + 1 });

            List<ScoreBoard> scoreBoard = Score.OrderBy(i => i.Score).ToList();

            Console.Clear();
            Console.WriteLine($"\nHärligt, ni kom ut!! Ni klarade spelet på {player.step + 1} steg");
            Console.WriteLine("\nTryck på valfri tangent för att se var ni kom på resultatlistan");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\t\tRESULTATLISTA");
            int a = 1;
                       
            foreach (var i in scoreBoard)
            {            
                Console.WriteLine($"\n\t{a}. {i.Name, -10} \t {i.Score} steg\n ");
                a++;
            }
            Console.ReadKey();
            Environment.Exit(0);  //Makes the program stop/end
        }   
    }
}
