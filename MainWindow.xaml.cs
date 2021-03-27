using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace hackaton
{
   
    public partial class MainWindow : Window
    {
        // truc cool pour paufiner sur la fin
        bool versus = false;
        DarkShip darkShip;


        bool running = true;
        double count = 0; // comteur de temps total passé
        double interval = 800;

        Ship ship;
        Map map = new Map(20);
        DispatcherTimer dispatcherTimerScroll = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            playBGSong();

            // scroll auto
            dispatcherTimerScroll.Tick += ScrollAuto;
            dispatcherTimerScroll.Interval = TimeSpan.FromMilliseconds(interval);
            dispatcherTimerScroll.Start();

            ship = new Ship(5, 10);
            map.SetInMap(ship, 5, 10);
            showMap(map.MapGame);
            DataContext = this;

            if (versus)
            {
                darkShip = new DarkShip(10, 0);
                map.SetInMap(darkShip, 10, 0);
            }
        }

        private void ScrollAuto(object sender, EventArgs e)
        {
            map.Scroll();
            // Test si le joueur est toujours sur la map, si non running = false et si running = false il faut stop le jeux et affiché un écran de game over
            if(map.isOnMap() == false)
            {
                running = false;
                dispatcherTimerScroll.Stop();
                ShowGameOver();
                return;
            }
            count = count + interval;
            UpdateInterval();
            map.AddMonster();
            showMap(map.MapGame);
        }

        private void UpdateInterval()
        {   
            interval = interval * 0.999;
            dispatcherTimerScroll.Interval = TimeSpan.FromMilliseconds(interval);
            if(interval != 800)
            {
                Console.WriteLine();
            }
        }

        private void ShowGameOver()
        {

            // affichage d'une fenetre game over, j'aime pas la partie affichage :') l'iamge est dans img/GameOver.png
            myCanvas.Children.Clear();

        }


       //truc qui fais que quand on appuis sur un bouton ça fais un truc
        private void Canvas_KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left || e.Key == Key.Q)
            {
                
                Move.MoveEntity(ship, MoveDisponible.left, map);

            }
            if (e.Key == Key.Right || e.Key == Key.D)
            {
               
                Move.MoveEntity(ship, MoveDisponible.right, map);


            }
            if (e.Key == Key.Up || e.Key == Key.Z)
            {
               
                Move.MoveEntity(ship, MoveDisponible.up, map);

            }
            if (e.Key == Key.Down || e.Key == Key.S)
            {
               
                Move.MoveEntity(ship, MoveDisponible.down, map);


            }
            if (e.Key == Key.Space)
            {
               //shoot dans le bébé
                ship.Shoot(map);
            }


            if (versus)
            {
                if (e.Key == Key.NumPad1)
                {
                    Move.MoveEntity(darkShip, MoveDisponible.left, map);
                }
                if (e.Key == Key.NumPad3)
                {

                    Move.MoveEntity(darkShip, MoveDisponible.right, map);


                }
                if (e.Key == Key.NumPad5)
                {

                    Move.MoveEntity(darkShip, MoveDisponible.up, map);

                }
                if (e.Key == Key.NumPad2)
                {

                    Move.MoveEntity(darkShip, MoveDisponible.down, map);


                }
                if (e.Key == Key.Enter)
                {
                    //shoot dans le bébé
                    darkShip.Shoot(map);
                }
            }


            //ça affiche ça
            showMap(map.MapGame);
        }

       //the fonction de la muerte elle affiche en gros
        private void showMap(Entity[][] map) 
        {//très important de bien le mettre le clear pour pas perdre 30 min à chercher(ça éfface derrière nous quand on se déplace)
            myCanvas.Children.Clear();
            for (int i = 0; i < map.Length; i++)
            {
                for (int j = 0; j < map[0].Length; j++)
                {
                    if (map[i][j]!=null) 
                    {
                       
                        Rectangle newEntity= new Rectangle
                        {
                            Tag = "entity",
                            Height =  32,
                            Width =  32,
                            Fill = map[i][j].Sprite,


                        };
                        Canvas.SetTop(newEntity, j * 32);
                        Canvas.SetLeft(newEntity, i * 32);
                        myCanvas.Children.Add(newEntity);
                    }
                }
            }
        }
        // Musique de fond pour le menu, en attente
        private void playBGSong() {
            SoundPlayer playSound = new SoundPlayer(Properties.Resources.bg_song);
            playSound.Play();
            playSound.PlayLooping();
        }
    }
}
