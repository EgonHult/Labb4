using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Program
    {

        static char[,] Map()
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
           
        }

        static void Main(string[] args)
        {
            char[,] map = Map();
            PrintMap(map);

            

            

            int key = 0;
            printKeys(key);
            int playerMovements = 0;
            printPlayerMovementTotal(playerMovements);

            int playersPositionX = 1;
            int playersPositionY = 1;
            char player = map[playersPositionY, playersPositionX];
            MovingPlayer(map, ref key, ref playerMovements, ref playersPositionX, ref playersPositionY, player);
        }

        private static void MovingPlayer(char[,] map, ref int key, ref int playerMovements, ref int playersPositionX,
            ref int playersPositionY, char player)
        {
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
                                if (moveUp == 'K')
                                {
                                    key++;
                                    playerMovements++;
                                    playerMovesUp(map, playersPositionY, playersPositionX, moveUp, player);
                                    playersPositionY -= 1;
                                }
                                else if (moveUp == 'D' && key >= 1)
                                {
                                    key--;
                                    playerMovements++;
                                    playerMovesUp(map, playersPositionY, playersPositionX, moveUp, player);
                                    playersPositionY -= 1;
                                }
                                else if (moveUp == 'D')
                                { }
                                else if (moveUp == 'M')
                                {
                                    playerMovements = playerMovements + 8;
                                    playerMovesUp(map, playersPositionY, playersPositionX, moveUp, player);
                                    playersPositionY -= 1;
                                    Console.WriteLine("You defeat the monster but it took alot of moves to do it.");
                                }
                                else
                                {
                                    playerMovements++;
                                    playerMovesUp(map, playersPositionY, playersPositionX, moveUp, player);
                                    playersPositionY -= 1;
                                }
                            }

                            PrintMap(map);
                            printKeys(key);
                            printPlayerMovementTotal(playerMovements);
                            break;
                        case 's':
                            var moveDown = map[playersPositionY + 1, playersPositionX];


                            if (moveDown != '#')
                            {
                                if (moveDown == 'K')
                                {
                                    key++;
                                    playerMovements++;
                                    playerMovesDown(map, playersPositionY, playersPositionX, moveDown, player);
                                    playersPositionY += 1;
                                }
                                else if (moveDown == 'D' && key >= 1)
                                {
                                    key--;
                                    playerMovements++;
                                    playerMovesDown(map, playersPositionY, playersPositionX, moveDown, player);
                                    playersPositionY += 1;
                                }
                                else if (moveDown == 'D')
                                { }
                                else if (moveDown == 'M')
                                {
                                    playerMovements = playerMovements + 8;
                                    playerMovesDown(map, playersPositionY, playersPositionX, moveDown, player);
                                    playersPositionY += 1;
                                    Console.WriteLine("You defeat the monster but it took alot of moves to do it.");
                                }
                                else
                                {
                                    playerMovements++;
                                    playerMovesDown(map, playersPositionY, playersPositionX, moveDown, player);
                                    playersPositionY += 1;
                                }
                            }
                            PrintMap(map);
                            printKeys(key);
                            printPlayerMovementTotal(playerMovements);
                            break;
                        case 'a':
                            var moveLeft = map[playersPositionY, playersPositionX - 1];
                            if (moveLeft != '#')
                            {
                                if (moveLeft == 'K')
                                {
                                    key++;
                                    playerMovements++;
                                    playerMovesToLeft(map, playersPositionY, playersPositionX, moveLeft, player);
                                    playersPositionX -= 1;
                                }
                                else if (moveLeft == 'D' && key >= 1)
                                {
                                    key--;
                                    playerMovements++;
                                    playerMovesToLeft(map, playersPositionY, playersPositionX, moveLeft, player);
                                    playersPositionX -= 1;
                                }
                                else if (moveLeft == 'D')
                                { }
                                else if (moveLeft == 'M')
                                {
                                    playerMovements = playerMovements + 8;
                                    playerMovesToLeft(map, playersPositionY, playersPositionX, moveLeft, player);
                                    playersPositionX -= 1;
                                    Console.WriteLine("You defeat the monster but it took alot of moves to do it.");
                                }
                                else
                                {
                                    playerMovesToLeft(map, playersPositionY, playersPositionX, moveLeft, player);
                                    playersPositionX -= 1;
                                    playerMovements++;
                                }
                            }

                            PrintMap(map);
                            printKeys(key);
                            printPlayerMovementTotal(playerMovements);
                            break;
                        case 'd':
                            var moveRight = map[playersPositionY, playersPositionX + 1];
                            if (moveRight != '#')
                            {
                                if (moveRight == 'K')
                                {
                                    key++;
                                    playerMovements++;
                                    playerMovesToRight(map, playersPositionY, playersPositionX, moveRight, player);

                                    playersPositionX += 1;
                                }
                                else if (moveRight == 'D' && key >= 1)
                                {
                                    key--;
                                    playerMovements++;
                                    playerMovesToRight(map, playersPositionY, playersPositionX, moveRight, player);
                                    playersPositionX += 1;
                                }
                                else if (moveRight == 'D')
                                { }
                                else if (moveRight == 'M')
                                {
                                    playerMovements = playerMovements + 8;
                                    playerMovesToRight(map, playersPositionY, playersPositionX, moveRight, player);
                                    playersPositionX += 1;
                                    Console.WriteLine("You defeat the monster but it took alot of moves to do it.");
                                }
                                else
                                {
                                    playerMovesToRight(map, playersPositionY, playersPositionX, moveRight, player);
                                    playerMovements++;
                                    playersPositionX += 1;
                                }
                            }

                            PrintMap(map);
                            printKeys(key);
                            printPlayerMovementTotal(playerMovements);
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        static void playerMovesUp(char[,] map, int playersPositionY, int playersPositionX, char moveUp, char player)
        {
            map[playersPositionY - 1, playersPositionX] = player;
            map[playersPositionY, playersPositionX] = moveUp;
            map[playersPositionY, playersPositionX] = '.';
        }
        static void playerMovesDown(char[,] map, int playersPositionY, int playersPositionX, char moveDown, char player)
        {
            map[playersPositionY + 1, playersPositionX] = player;
            map[playersPositionY, playersPositionX] = moveDown;
            map[playersPositionY, playersPositionX] = '.';
        }
        static void playerMovesToLeft(char[,] map, int playersPositionY, int playersPositionX, char moveLeft, char player)
        {
            map[playersPositionY, playersPositionX - 1] = player;
            map[playersPositionY, playersPositionX] = moveLeft;
            map[playersPositionY, playersPositionX] = '.';
        }
        static void playerMovesToRight(char[,] map, int playersPositionY, int playersPositionX, char moveRight, char player)
        {
            map[playersPositionY, playersPositionX + 1] = player;
            map[playersPositionY, playersPositionX] = moveRight;
            map[playersPositionY, playersPositionX] = '.';
        }
        static void printPlayerMovementTotal(int playerMovements)
        {
            Console.WriteLine($"You have made {playerMovements} moves trying to escape.");
        }
        static void printKeys(int key)
        {
            Console.WriteLine($"You have {key} key(s).");
        }
    }
}
