using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace hackaton
{

    class Ship : Entity, IControlable
    {
        public int Kill { get; set; }
        public Ship(int x, int y)
            :base(x,y, AppDomain.CurrentDomain.BaseDirectory + imagePath + "ship.png")
        {

        }
        public Ship()
            : base(0,0, AppDomain.CurrentDomain.BaseDirectory + imagePath + "ship.png")
        { 
        }

        public void Shoot(Map map)
        {
            map.SetInMap(new Bullet(this.X, this.Y - 1), this.X, this.Y - 1);
        }
       
    }
}
