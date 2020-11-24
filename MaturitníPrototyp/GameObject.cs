using System;
using System.Collections.Generic;
using System.Text;

namespace MaturitníPrototyp
{
    class GameObject
    {
        public GameObject(ConsoleColor foregroundColor, string design)
        {
            ForeGroundColor = foregroundColor;
            Design = design;
            BackgroundColor = Console.BackgroundColor;
        }

        public string Design { get; } = " ";

        public ConsoleColor ForeGroundColor { get; }

        public ConsoleColor BackgroundColor { get; protected set; }

    }
}
