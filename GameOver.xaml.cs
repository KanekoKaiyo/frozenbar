using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace hackaton.view
{
    /// <summary>
    /// Interaction logic for GameOver.xaml
    /// </summary>
    public partial class GameOver : Window
    {
        ImageBrush gameover = new ImageBrush();
        public GameOver(double count)
        {
            InitializeComponent();
            //changer pour bonnes images
            gameover.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"\img\" + "wtfFabi.jpg"));
            over.Fill = gameover;
            string nbrkill = "Vous avez tuez : " + IControlable.Hit + " méchant Fabion";
            killTB.Text = nbrkill;
            double time = count / 1000;
            string timeplayed = "Vous avez joué un total de " + Convert.ToInt32(time) + " secondes";
            countTB.Text = timeplayed;
            //myCanvas.Focus;
        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow restart = new MainWindow();
            restart.Show();
            this.Close();
        }
    }
}
