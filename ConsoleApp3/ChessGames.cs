using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ChessGames
    {

        /*private ChessPoint[] towers;
        private ChessPoint[] horses;
        private ChessPoint[] player;
        private ChessPoint[] exits;
        private int life;
        private string place;*/
        public ChessGames(ChessPoint[] towers, ChessPoint[] horses, ChessPoint[] player, ChessPoint[] exits, int life, string place)
        {
            
            bool value = true;

            while (value)
            {
                /*this.towers = towers;
                this.horses = horses;
                this.player = player;
                this.exits = exits;
                this.life = life;
                this.place = place;*/
                ChessPoint[] towers1 = new ChessPoint[] { new ChessPoint(3, 0), new ChessPoint(2, 2), new ChessPoint(3, 3), new ChessPoint(2, 5) };
                ChessPoint[] horses1 = new ChessPoint[] { new ChessPoint(1, 1), new ChessPoint(4, 4) };
                ChessPoint[] player1 = new ChessPoint[] { new ChessPoint(5, 5), new ChessPoint(0, 0) };
                ChessPoint[] exits1 = new ChessPoint[] { new ChessPoint(4, 0), new ChessPoint(1, 5) };
                value = ChessGaming(towers1, horses1, player1, exits1, 0, "Taras przy plaży");
            }
        }
        public bool ChessGaming(ChessPoint[] towers, ChessPoint[] horses, ChessPoint[] player, ChessPoint[] exits, int life, string place)
        {
            ChessPoint[] horsesBackUp = new ChessPoint[horses.Length];
            Array.Copy(horses, horsesBackUp, horses.Length);
            ChessPoint[] playerBackUp = new ChessPoint[player.Length];
            Array.Copy(player, playerBackUp, player.Length);

            const int CHESS_NO = 6;
            bool horseRight = true;
            char[,] chessArray = new char[CHESS_NO, CHESS_NO];

            for (int i = 0; i < CHESS_NO; i++)
            {
                for (int j = 0; j < CHESS_NO; j++)
                {
                    chessArray[i, j] = '.';
                }
            }

            for (int i = 0; i < towers.Length; i++)
            {
                chessArray[towers[i].x, towers[i].y] = 'W';
            }
            for (int i = 0; i < horses.Length; i++)
            {
                chessArray[horses[i].x, horses[i].y] = 'K';
            }
            for (int i = 0; i < player.Length; i++)
            {
                chessArray[player[i].x, player[i].y] = 'P';
            }
            for (int i = 0; i < exits.Length; i++)
            {
                chessArray[exits[i].x, exits[i].y] = 'X';
            }


            for (int i = 0; i < CHESS_NO; i++)
            {
                for (int j = 0; j < CHESS_NO; j++)
                {
                    if (chessArray[j, i] == 'W')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    if (chessArray[j, i] == 'K')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (chessArray[j, i] == 'P' || chessArray[j, i] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(chessArray[j, i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }

            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                bool horseMove = false;
                if (key.Key == ConsoleKey.UpArrow)
                {
                    var tmp = player[0].y;
                    if (tmp - 1 > 5 || tmp - 1 <0)
                    {
                        tmp = tmp + 1;
                    }
                    if (chessArray[player[0].x, tmp - 1] != 'W')
                    {
                        chessArray[player[0].x, player[0].y] = '.';
                        chessArray[player[1].x, player[1].y] = '.';
                        player[0].up(-1);
                        player[1].down(CHESS_NO);
                        for (int i = 0; i < player.Length; i++)
                        {
                            chessArray[player[i].x, player[i].y] = 'P';
                        }
                    }
                    horseMove = true;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    var tmp = player[0].y;
                    if (tmp + 1 > 5 || tmp + 1 < 0)
                    {
                        tmp = tmp - 1;
                    }
                    if (chessArray[player[0].x, tmp + 1] != 'W')
                    {
                        chessArray[player[0].x, player[0].y] = '.';
                        chessArray[player[1].x, player[1].y] = '.';
                        player[0].down(CHESS_NO);
                        player[1].up(-1);
                        for (int i = 0; i < player.Length; i++)
                        {
                            chessArray[player[i].x, player[i].y] = 'P';
                        }
                    }
                    horseMove = true;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    var tmp = player[0].x;
                    if (tmp - 1 > 5 || tmp - 1 < 0)
                    {
                        tmp = tmp + 1;
                    }
                    if (chessArray[tmp - 1, player[0].y] != 'W')
                    {
                        chessArray[player[0].x, player[0].y] = '.';
                        chessArray[player[1].x, player[1].y] = '.';
                        player[0].left(-1);
                        player[1].right(CHESS_NO);
                        for (int i = 0; i < player.Length; i++)
                        {
                            chessArray[player[i].x, player[i].y] = 'P';
                        }
                    }
                    horseMove = true;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    var tmp = player[0].x;
                    if (tmp + 1 > 5 || tmp + 1 < 0)
                    {
                        tmp = tmp - 1;
                    }
                    if (chessArray[tmp + 1, player[0].y] != 'W')
                    {
                        chessArray[player[0].x, player[0].y] = '.';
                        chessArray[player[1].x, player[1].y] = '.';
                        player[0].right(CHESS_NO);
                        player[1].left(-1);
                        for (int i = 0; i < player.Length; i++)
                        {
                            chessArray[player[i].x, player[i].y] = 'P';
                        }
                    }    
                    horseMove = true;
                }
                if (horseMove)
                {
                    chessArray[horses[0].x, horses[0].y] = '.';
                    chessArray[horses[1].x, horses[1].y] = '.';
                    if (horseRight)
                    {
                        horses[0].right(CHESS_NO);
                        if (!horses[1].left(-1))
                        {
                            horses[0].left(-1);
                            horses[1].right(CHESS_NO);
                            horseRight = false;
                        }
                    }
                    else
                    {
                        horses[0].left(-1);
                        if (!horses[1].right(CHESS_NO))
                        {
                            horses[0].right(CHESS_NO);
                            horses[1].left(-1);
                            horseRight = true;
                        }
                    }
                    for (int i = 0; i < horses.Length; i++)
                    {
                        chessArray[horses[i].x, horses[i].y] = 'K';
                    }
                }

                Console.Clear();
                for (int i = 0; i < CHESS_NO; i++)
                {
                    for (int j = 0; j < CHESS_NO; j++)
                    {
                        if (chessArray[j, i] == 'W')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        if (chessArray[j, i] == 'K')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        if (chessArray[j, i] == 'P' || chessArray[j, i] == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        Console.Write(chessArray[j, i] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();
                }

                if (player[0] == horses[0] || player[1] == horses[0] || player[0] == horses[1] || player[1] == horses[1])
                {
                    //lifes
                    if (life == 0)
                    {
                        Console.Clear();
                        Scene fox = new Scene("fox", "YORK", ConsoleColor.DarkRed);
                        fox.DisplayScene(place, "ZACH, musi ci się udać.");
                        Console.ReadKey();
                        Console.Clear();
                        //ChessGames chessGamestmp = new ChessGames(tmptowers, tmphorses, tmpplayer, tmpexits, 0, "Podzamcze");
                        return true;
                    }
                    break;
                }
            }
            while (!(player[0] == exits[0] && player[1] == exits[1] || player[0] == exits[1] && player[1] == exits[0]));
            return false;
        }
    }
}
