using System;
using System.Collections.Generic;
using System.Text;

namespace hackaton
{
    class Monster : Entity
    {
        static Random rdm;
        static Monster(){
            rdm = new Random();
        }
        public Monster(int x, int y)
            : base(x, y, AppDomain.CurrentDomain.BaseDirectory + imagePath + $"Fabi{rdm.Next(1,7)}.jpg")
        {

        }
        
    }
}
