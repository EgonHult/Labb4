using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Floor : MapParts
    {
        private char part = '.';
        public override char MapPiece { get => part; set => part = value; }
       
        //The palyer just move along 
        public override void Connect(Player player)
        {
            player.MovePlayer();
          
        }          
    }
}
