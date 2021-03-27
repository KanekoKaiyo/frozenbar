using System;
using System.Collections.Generic;
using System.Text;

namespace hackaton
{
    class DarkShip :Entity, IControlable
    {
        public DarkShip(int x, int y)
    : base(x, y, "D:\\appez\\Download\\hackaton\\hackaton\\img\\player.png")
        {
        }

        public void Shoot(Map map)
        {
            map.SetInMap(new Monster(this.X, this.Y + 1), this.X, this.Y + 1);
        }
    }
}
