    using System;
using System.Collections.Generic;
using System.Text;

namespace hackaton
{
    class Wall : Entity
    {
        public Wall(int x, int y)
    : base(x, y, AppDomain.CurrentDomain.BaseDirectory + imagePath + "wall.png")
        {

        }
        public Wall()
            :base(-1,-1, AppDomain.CurrentDomain.BaseDirectory + imagePath + "wall.png")
        {

        }
    }
}
