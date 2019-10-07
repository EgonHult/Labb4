using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    public abstract class MapParts : IInterface
    {
        public  abstract  char MapPieces { get; set; }     
    }
    class Wall : MapParts
    {
        private char part = '#';
        public override char MapPieces { get => part; set => part = value; }
    }

    class Floor : MapParts
    {
        private char part = '.';
        public override char MapPieces { get => part; set => part = value; }
    }

    class  Door : MapParts
    {
        private char part = 'D';
        public override char MapPieces { get => part; set => part = value; }
    }

    class Monster : MapParts
    {
        private char part = 'M';
        public override char MapPieces { get => part; set => part = value; }
    }
    class Key : MapParts
    {
        private char part = 'K';

        public override char MapPieces { get => part; set => part = value; }
    }

    class Exit : MapParts
    {
        private char part = 'E';
        public override char MapPieces { get => part; set => part = value; }
    }

}

