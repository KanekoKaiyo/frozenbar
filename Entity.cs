using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace hackaton
{
    abstract class Entity 
    {

        public int X { get; set; }
        public int Y { get; set; }
        public ImageBrush Sprite { get; set; }
        public static string imagePath = @"\img\";
        public Entity(int x, int y, String sprite)
        {
            X = x;
            Y = y;
            Sprite = new ImageBrush();
            Sprite.ImageSource = new BitmapImage(new Uri(sprite));
        }

    }
}

