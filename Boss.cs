using System;
using System.Collections.Generic;
using System.Text;

namespace hackaton
{
    class Boss : Entity
    {
        public Boss()
            : base(7,0, AppDomain.CurrentDomain.BaseDirectory + imagePath + "wtfFabi.jpg") 
        {

        }

        public void Invo(Map map)
        {
            map.SetInMap(new Monster(this.X, this.Y + 2), this.X, this.Y + 2);
        }

        public void WallInvo(Map map)
        {
            for(int i = 0; i < map.MapGame.Length; i++)
            {
                map.SetInMap(new Monster(i, 3), i, 3);
                map.SetInMap(new Monster(i, 2), i, 2);
            }
        }



    }
}
