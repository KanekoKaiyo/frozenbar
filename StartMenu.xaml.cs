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

namespace hackaton {
    /// <summary>
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Window {
        public StartMenu() {
            InitializeComponent();
        }

        private void start(object sender, RoutedEventArgs e) {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }
    }
}
