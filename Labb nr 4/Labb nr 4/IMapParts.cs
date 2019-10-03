using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    public interface IMapParts
    {
        char[,] MapBuilder();
       
        void PrintMap2(char[,] block);
    }
}
