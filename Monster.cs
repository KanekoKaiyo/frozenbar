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
            : base(x, y, "D:\\appez\\Download\\hackaton\\hackaton\\img\\invader1.gif")
        {

        }
        
    }
}
