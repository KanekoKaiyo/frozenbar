using System;
using System.Collections.Generic;
using System.Text;

namespace hackaton
{
    class Wall : Entity
    {
        public Wall(int x, int y)
    : base(x, y, AppDomain.CurrentDomain.BaseDirectory + imagePath + "150947105_448029799944259_5455403196608113834_n.jpg")
        {

        }
        public Wall()
            :base(-1,-1, AppDomain.CurrentDomain.BaseDirectory + imagePath + "150947105_448029799944259_5455403196608113834_n.jpg")
        {

        }
    }
}
