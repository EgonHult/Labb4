using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Monster : MapParts
    {        
        private char part = 'M';
        public override char MapPiece { get => part; set => part = value; }

        private bool isDefeated = false;



      //  You will always defeat the monster butt the penalty steps can be different
        public override void Connect(Player player)
        {
            if (!isDefeated)
            {             
                Random randomnum = new Random();
                int slaySteeps = randomnum.Next(3, 10);
                player.step += slaySteeps;
                isDefeated = true;
                part = '.';
            }          

            player.MovePlayer();
        }
        public override void Connect2(WalkingMonster monster)
        {
            monster.MoveMonster();
        }
    }
}
