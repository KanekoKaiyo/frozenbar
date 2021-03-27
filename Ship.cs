using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace hackaton
{

    class Ship : Entity, IControlable
    {
        public Ship(int x, int y)
            :base(x,y, "D:\\appez\\Download\\hackaton\\hackaton\\img\\ojizenoadfjlonkszerdflmùkojn^vbzrmnojurzgmùonljermkojnmkoezjngrmgnkjzr.jpg")
        {

        }
        public Ship()
            : base(0,0, "D:\\appez\\Download\\hackaton\\hackaton\\img\\ojizenoadfjlonkszerdflmùkojn^vbzrmnojurzgmùonljermkojnmkoezjngrmgnkjzr.jpg")
        {

        }

        public void Shoot(Map map)
        {
            map.SetInMap(new Bullet(this.X, this.Y - 1), this.X, this.Y - 1);
        }
       
    }
}
