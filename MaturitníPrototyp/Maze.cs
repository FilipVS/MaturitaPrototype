using System;
using System.Collections.Generic;
using System.Text;

namespace MaturitníPrototyp
{
    class Maze
    {
        static int X_OFFSET = 1;
        static int Y_OFFSET = 1;


        public Maze(IEnumerable<Ghost> ghostes, Player player)
        {
            Tiles = new GameObject[10, 10];

            for(int x = 0; x < Tiles.GetLength(0); x++)
            {
                Tiles[x, 0] = new Wall(ConsoleColor.DarkBlue);
                Tiles[x, (Tiles.GetLength(1) - 1)] = new Wall(ConsoleColor.DarkBlue);
            }
            for(int y = 0; y < Tiles.GetLength(1); y++)
            {
                Tiles[0, y] = new Wall(ConsoleColor.DarkBlue);
                Tiles[(Tiles.GetLength(0) - 1), y] = new Wall(ConsoleColor.DarkBlue);
            }

            Tiles[2, 5] = new Wall(ConsoleColor.DarkBlue);
            Tiles[2, 7] = new Wall(ConsoleColor.DarkBlue);
            Tiles[4, 5] = new Wall(ConsoleColor.DarkBlue);
            Tiles[6, 3] = new Wall(ConsoleColor.DarkBlue);

            for(int x = 0; x < Tiles.GetLength(0); x++)
            {
                for(int y = 0; y < Tiles.GetLength(1); y++)
                {
                    if (Tiles[x, y] == null)
                        Tiles[x, y] = new GameObject(Console.ForegroundColor, " ");
                }
            }


            Ghostes = new List<Ghost>(ghostes).ToArray();

            Player = player;

            Tiles[1, 1] = player;
            Tiles[8, 8] = Ghostes[0];
        }

        public GameObject[,] Tiles { get; }

        public Ghost[] Ghostes { get; }

        public Player Player { get; }


        public void Draw()
        {
            for(int y = 0; y < Tiles.GetLength(1); y++)
            {
                for(int x = 0; x < Tiles.GetLength(0); x++)
                {
                    Console.ForegroundColor = Tiles[x,y].ForeGroundColor;
                    Console.BackgroundColor = Tiles[x, y].BackgroundColor;

                    Console.SetCursorPosition((x + X_OFFSET), (y + Y_OFFSET));

                    Console.Write(Tiles[x, y].Design);

                    Console.ResetColor();
                }
            }
        }


       /* public static Maze LoadMaze()
        {
            Maze maze = new Maze();

            return maze;
        }*/

        public static void SaveMaze(Maze maze)
        {

        }
    }
}
