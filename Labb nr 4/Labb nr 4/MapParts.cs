using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    public abstract class MapParts : IPieceOnMap
    {
        public abstract char MapPiece { get; set; }
        public abstract void Connect(Player player);
    }










}

