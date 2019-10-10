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

        public override void Connect(Player player)
        {
            Console.Clear();
            Console.WriteLine($"\nHärligt, ni kom ut!! Ni klarade spelet på {player.step+1} steg");
            Console.ReadLine();
            Environment.Exit(0);  //Makes the program stop/end
        }
        public override void Connect2(WalkingMonster monster)
        {
            monster.MoveMonster();
        }
    }
}
