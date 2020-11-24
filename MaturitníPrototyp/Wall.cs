using System;
using System.Collections.Generic;
using System.Text;

namespace MaturitníPrototyp
{
    class Wall : GameObject
    {
        public Wall(ConsoleColor backgroundColor) : base(backgroundColor, " ")
        {
            BackgroundColor = backgroundColor;
        }

        
    }
}
