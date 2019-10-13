using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
   public class WalkingMonster: MapParts
    {
        public int step = 0;
        public int course = 0;
        public int x = 0;
        public int y = 0;
        public const int right = 1;
        public const int left = 2;
        public char part = '?';
        public override char MapPiece { get => part; set => part = value; }

        private bool beaten = false;

        //  You will always defeat the monster butt the penalty steps can be different
        public override void Connect(Player player)
        {
            if (!beaten)
            {
                Random randomNum = new Random();
                int slaySteeps = randomNum.Next(3, 10);
                player.step += slaySteeps;
                beaten = true;
                part = '.';
            }

            player.MovePlayer();          
        }
        public override void Connect2(WalkingMonster monster)
        { 
            
        }
        public void MoveMonster()
        {
            if (course == right)
                x++;
            if (course == left)
                x--;
            step++;
        }
    }
}
