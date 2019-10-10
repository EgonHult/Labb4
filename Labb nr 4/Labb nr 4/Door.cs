using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Door : MapParts
    {
        private char part = 'D';
        public override char MapPiece { get => part; set => part = value; }
        private bool locked = true;
        public override void Connect(Player player)
        {
           
            if (locked)
            {
                if (player.keys > 0)
                {
                    player.keys--;
                    part = '.';
                    locked = false;
                }
            }

            if (!locked)
            {
                player.MovePlayer();
            }
        }
        /*  public void Mover(WalkingMonster monster)
        {
            monster.MoveMonster();
        }*/
        public override void Connect2(WalkingMonster monster)
        {
           
        }


    }
}
