using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Wall : MapParts
    {
        private char part = '#';
        public override char MapPiece { get => part; set => part = value; }

        public MapCharacters Character = MapCharacters.Wall;

        //Nothing happens when you try to step in to a wall
        public override void Connect(Player player) { }             
        public override void Connect2(WalkingMonster monster) { }                          
    }
}
