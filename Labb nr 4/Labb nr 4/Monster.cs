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

        private bool beaten = false;

      //  The player will always defeat the monster butt the penalty steps can be different
        public override void Connect(Player player)
        {
            if (!beaten)
            {             
                Random randomNum = new Random();
                int slaySteps = randomNum.Next(3, 10);
                player.step += slaySteps;
                beaten = true;
                part = '.';
            }          
            player.MovePlayer();
        }
    }
}
