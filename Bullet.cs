using System;
using System.Collections.Generic;
using System.Text;

namespace hackaton
{
    class Bullet : Entity{
        public Bullet(int x, int y): base(x, y, AppDomain.CurrentDomain.BaseDirectory + imagePath + "zig.gif"){

        }
    }
}
