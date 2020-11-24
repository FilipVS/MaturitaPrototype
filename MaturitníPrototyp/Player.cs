using System;
using System.Collections.Generic;
using System.Text;

namespace MaturitníPrototyp
{
    class Player : GameObject
    {
        public Player(ConsoleColor foregroundColor) : base(foregroundColor, "@")
        {
        }

        private Direction direction = Direction.Left;


        public void PlayerControler(Maze maze)
        {
            if (maze.Player != this)
                throw new ArgumentException();

            while (true)
            {
                switch (direction)
                {
                    case Direction.Top:
                        if()
                        break;
                    case Direction.Down:
                        break;
                    case Direction.Left:
                        break;
                    case Direction.Right:
                        break;
                }
            }
        }


        public enum Direction
        {
            Top,
            Down,
            Left,
            Right
        }
    }
}
