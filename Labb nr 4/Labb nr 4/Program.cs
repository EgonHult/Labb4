﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_nr_4
{
    class Program
    {
        static void Plan()
        {         
            gameFild[0, 0] = new Wall(); 
            gameFild[0, 1] = new Wall(); 
            gameFild[0, 2] = new Wall();
            gameFild[0, 3] = new Wall();
            gameFild[0, 4] = new Wall();
            gameFild[0, 5] = new Wall();
            gameFild[0, 6] = new Wall();
            gameFild[0, 7] = new Wall();
            gameFild[0, 8] = new Wall();
            gameFild[0, 9] = new Wall();
            gameFild[0, 10] = new Wall();
            gameFild[0, 11] = new Wall();
            gameFild[0, 12] = new Wall();
            gameFild[0, 13] = new Wall();          
            gameFild[0, 14] = new Wall();
            gameFild[0, 15] = new Wall();
            gameFild[0, 16] = new Wall();
            gameFild[0, 17] = new Wall();
            gameFild[0, 18] = new Wall();
            gameFild[0, 19] = new Wall();
            gameFild[0, 20] = new Wall();
            gameFild[0, 21] = new Wall();

            gameFild[1, 0] = new Wall();
            gameFild[1, 1] = new Floor();
            gameFild[1, 2] = new Wall();
            gameFild[1, 3] = new Key();
            gameFild[1, 4] = new Wall();
            gameFild[1, 5] = new Key();
            gameFild[1, 6] = new Floor();
            gameFild[1, 7] = new Floor();
            gameFild[1, 8] = new Floor();
            gameFild[1, 9] = new Floor();
            gameFild[1, 10] = new Floor();
            gameFild[1, 11] = new Wall();
            gameFild[1, 12] = new Floor();
            gameFild[1, 13] = new Floor();
            gameFild[1, 14] = new Door();
            gameFild[1, 15] = new Floor();
            gameFild[1, 16] = new Wall();
            gameFild[1, 17] = new Floor();
            gameFild[1, 18] = new Floor();
            gameFild[1, 19] = new Floor();
            gameFild[1, 20] = new Floor();
            gameFild[1, 21] = new Wall();

            gameFild[2, 0] = new Wall();
            gameFild[2, 1] = new Floor();
            gameFild[2, 2] = new Wall();
            gameFild[2, 3] = new Floor();
            gameFild[2, 4] = new Wall();
            gameFild[2, 5] = new Floor();
            gameFild[2, 6] = new Floor();
            gameFild[2, 7] = new Wall();
            gameFild[2, 8] = new Floor();
            gameFild[2, 9] = new Wall();
            gameFild[2, 10] = new Floor();
            gameFild[2, 11] = new Wall();
            gameFild[2, 12] = new Floor();
            gameFild[2, 13] = new Floor();
            gameFild[2, 14] = new Wall();
            gameFild[2, 15] = new Floor();
            gameFild[2, 16] = new Wall();
            gameFild[2, 17] = new Floor();
            gameFild[2, 18] = new Wall();
            gameFild[2, 19] = new Floor();
            gameFild[2, 20] = new Wall();
            gameFild[2, 21] = new Wall();

            gameFild[3, 0] = new Wall();
            gameFild[3, 1] = new Floor();
            gameFild[3, 2] = new Wall();
            gameFild[3, 3] = new Floor();
            gameFild[3, 4] = new Wall();
            gameFild[3, 5] = new Floor();
            gameFild[3, 6] = new Floor();
            gameFild[3, 7] = new Wall();
            gameFild[3, 8] = new Floor();
            gameFild[3, 9] = new Wall();
            gameFild[3, 10] = new Floor();
            gameFild[3, 11] = new Wall();
            gameFild[3, 12] = new Floor();
            gameFild[3, 13] = new Floor();
            gameFild[3, 14] = new Wall();
            gameFild[3, 15] = new Floor();
            gameFild[3, 16] = new Wall();
            gameFild[3, 17] = new Floor();
            gameFild[3, 18] = new Wall();
            gameFild[3, 19] = new Floor();
            gameFild[3, 20] = new Exit();
            gameFild[3, 21] = new Wall();

            gameFild[4, 0] = new Wall();
            gameFild[4, 1] = new Floor();
            gameFild[4, 2] = new Wall();
            gameFild[4, 3] = new Floor();
            gameFild[4, 4] = new Wall();
            gameFild[4, 5] = new Floor();
            gameFild[4, 6] = new Wall();
            gameFild[4, 7] = new Floor();
            gameFild[4, 8] = new Floor();
            gameFild[4, 9] = new Monster();
            gameFild[4, 10] = new Key();
            gameFild[4, 11] = new Wall();
            gameFild[4, 12] = new Floor();
            gameFild[4, 13] = new Floor();
            gameFild[4, 14] = new Wall();
            gameFild[4, 15] = new Floor();
            gameFild[4, 16] = new Door();
            gameFild[4, 17] = new Floor();
            gameFild[4, 18] = new Wall();
            gameFild[4, 19] = new Floor();
            gameFild[4, 20] = new Floor();
            gameFild[4, 21] = new Wall();
        
            gameFild[5, 0] = new Wall();
            gameFild[5, 1] = new Floor();
            gameFild[5, 2] = new Floor();
            gameFild[5, 3] = new Floor();
            gameFild[5, 4] = new Wall();
            gameFild[5, 5] = new Floor();
            gameFild[5, 6] = new Wall();
            gameFild[5, 7] = new Wall();
            gameFild[5, 8] = new Floor();
            gameFild[5, 9] = new Wall();
            gameFild[5, 10] = new Wall();
            gameFild[5, 11] = new Wall();
            gameFild[5, 12] = new Floor();
            gameFild[5, 13] = new Floor();
            gameFild[5, 14] = new Wall();
            gameFild[5, 15] = new Wall();
            gameFild[5, 16] = new Wall();
            gameFild[5, 17] = new Wall();
            gameFild[5, 18] = new Wall();
            gameFild[5, 19] = new Wall();
            gameFild[5, 20] = new Floor();
            gameFild[5, 21] = new Wall();

            gameFild[6, 0] = new Wall();
            gameFild[6, 1] = new Floor();
            gameFild[6, 2] = new Floor();
            gameFild[6, 3] = new Floor();
            gameFild[6, 4] = new Floor();
            gameFild[6, 5] = new Floor();
            gameFild[6, 6] = new Key();
            gameFild[6, 7] = new Wall();
            gameFild[6, 8] = new Floor();
            gameFild[6, 9] = new Floor();
            gameFild[6, 10] = new Door();
            gameFild[6, 11] = new Door();
            gameFild[6, 12] = new Floor();
            gameFild[6, 13] = new Monster();
            gameFild[6, 14] = new Door();
            gameFild[6, 15] = new Floor();
            gameFild[6, 16] = new Floor();
            gameFild[6, 17] = new Floor();
            gameFild[6, 18] = new Floor();
            gameFild[6, 19] = new Floor();
            gameFild[6, 20] = new Floor();
            gameFild[6, 21] = new Wall();

            gameFild[7, 0] = new Wall();
            gameFild[7, 1] = new Wall();
            gameFild[7, 2] = new Wall();
            gameFild[7, 3] = new Wall();
            gameFild[7, 4] = new Wall();
            gameFild[7, 5] = new Wall();
            gameFild[7, 6] = new Wall();
            gameFild[7, 7] = new Wall();
            gameFild[7, 8] = new Wall();
            gameFild[7, 9] = new Wall();
            gameFild[7, 10] = new Wall();
            gameFild[7, 11] = new Wall();
            gameFild[7, 12] = new Wall();
            gameFild[7, 13] = new Wall();
            gameFild[7, 14] = new Wall();
            gameFild[7, 15] = new Wall();
            gameFild[7, 16] = new Wall();
            gameFild[7, 17] = new Wall();
            gameFild[7, 18] = new Wall();
            gameFild[7, 19] = new Wall();
            gameFild[7, 20] = new Wall();
            gameFild[7, 21] = new Wall();
        }

        static char[,] Map()
         {                                 //  0   1    2  3   4   5   6   7   8   9   10  11  12  13  14 15  16  17  18  19   20  21
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
        static void PrintMap()
        {
            for (int y = 0; y < gameFild.GetLength(0); y++)
            {
                for (int x = 0; x < gameFild.GetLength(1); x++)
                {
                        if (x == 1 && y ==1)
                        Console.Write('@');
                        else
                        Console.Write(gameFild[y, x].MapPieces);
                    
                }
                Console.WriteLine();
            }
        }

        static readonly MapParts[,] gameFild = new MapParts[8, 22];
       static Player player = new Player();
        static void PrintMap(char[,] map)
        {
          
          //  Console.Clear();
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 22; x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }               
        }

        static void Main(string[] args)
        {
            Plan();
            PrintMap();
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
