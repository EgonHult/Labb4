using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Labb_nr_4
{
    class Door : MapParts
    {
        private char part = 'D';
        
        public override char MapPiece { get => part; set => part = value; }
       
        private bool locked = true;

        //Step through the door if the player has a key.
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
    }
}
