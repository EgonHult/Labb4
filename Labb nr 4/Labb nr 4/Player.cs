using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    public class Player
    {
        public int step = 0;
        public int course = 0;
        public int x = 0;
        public int y = 0;
        public const int right = 1;
        public const int left = 2;
        public const int up = 3;
        public const int down = 4;
        public int keys = 0;
        public string name = string.Empty;
      

        public void MovePlayer()
        {
            if (course == right)
                x++;
            if (course == left)
                x--;
            if (course == up)
                y--;
            if (course == down)
                y++;
            step++;          
        }
    }
}
