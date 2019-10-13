using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Key : MapParts
    {
        private char part = 'K';
        public override char MapPiece { get => part; set => part = value; }

        private bool picked = false;

        // Picking up key when player (@) steps ona a key (K)
        public override void Connect(Player player)
        {
            if (!picked)
            {
                player.keys++;
                picked = true;
                part = '.';
            }
            player.MovePlayer();
        }
        public override void Connect2(WalkingMonster monster)
        {
           
        }
    }
}
