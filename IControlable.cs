using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace hackaton
{
    interface IControlable
    {
        public static int Hit { get; set; }
        public void Shoot(Map map);
        public static void Kill(){
            Hit++;
            Sound.SoundEffect();
        }
    }
}
