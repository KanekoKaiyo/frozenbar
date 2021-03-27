using System;
using System.Collections.Generic;
using System.Text;

namespace hackaton
{
    class Monster : Entity
    {
     
        public Monster(int x, int y)
            : base(x, y, AppDomain.CurrentDomain.BaseDirectory + imagePath + "invader1.gif")
        {

        }
        
    }
}
