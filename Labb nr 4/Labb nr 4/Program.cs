using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Program
    {

       /* static char[,] Map()
        {
            char[,] map = new char[8, 22]{{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                                          {'#','@','#','K','#','K','.','.','.','.','.','#','.','.','D','.','#','.','.','.','.','#'},
                                          {'#','.','#','.','#','.','.','#','.','#','.','#','.','.','#','.','#','.','#','.','#','#'},
                                          {'#','.','#','.','#','.','.','#','.','#','.','#','.','.','#','.','#','.','#','.','E','#'},
                                          {'#','.','#','.','#','.','#','.','.','M','K','#','.','.','#','.','D','.','#','.','.','#'},
                                          {'#','.','.','.','#','.','#','#','.','#','#','#','.','.','#','#','#','#','#','#','.','#'},
                                          {'#','.','.','.','.','.','K','#','.','.','D','D','.','M','D','.','.','.','.','.','.','#'},
                                          {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'} };

            return map;
        }
        static void PrintMap(char[,] map)
        {
            Console.Clear();
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 22; x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
            int a = map.Length;
            Console.WriteLine(a);
        }*/

        static void Main(string[] args)
        {

            Map a = new Map();

            a.

            
            

           
            
            
            /* char[,] map = Map();
            PrintMap(map);*/
            

           /* int playersPositionX = 1;
            int playersPositionY = 1;
            char player = map[playersPositionY, playersPositionX];

            while (true)
            {
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo movePlayer = Console.ReadKey();
                    switch (movePlayer.KeyChar)
                    {
                        case 'w': 
                            var moveUp = map[playersPositionY - 1, playersPositionX];
                            if (moveUp != '#')
                            {
                                map[playersPositionY - 1, playersPositionX] = player;
                                map[playersPositionY, playersPositionX] = moveUp;
                                playersPositionY -= 1;
                            }

                            PrintMap(map);
                            break;
                        case 's':
                            var moveDown = map[playersPositionY + 1, playersPositionX];
                            

                            if (moveDown != '#')
                            {
                                map[playersPositionY + 1, playersPositionX] = player;
                                map[playersPositionY, playersPositionX] = moveDown;
                                playersPositionY += 1;
                            }
                            

                            PrintMap(map);
                            break;
                        case 'a':
                            var moveLeft = map[playersPositionY, playersPositionX - 1];
                            if (moveLeft != '#')
                            {
                                map[playersPositionY, playersPositionX - 1] = player;
                                map[playersPositionY, playersPositionX] = moveLeft;
                                playersPositionX -= 1;
                            }

                            PrintMap(map);
                            break;
                        case 'd':
                            var moveRight = map[playersPositionY, playersPositionX + 1];
                            if (moveRight != '#')
                            {
                                map[playersPositionY, playersPositionX + 1] = player;
                                map[playersPositionY, playersPositionX] = moveRight;
                                playersPositionX += 1;
                            }

                            PrintMap(map);
                            break;

                        default:
                            break;
                    }
                }
            }*/
        }
    }
}
