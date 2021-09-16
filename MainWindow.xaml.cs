using System;
using System.Collections.Generic;
using System.Linq;
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
using Tarea3_Cap6y7.UI.Capitulo6;
using Tarea3_Cap6y7.UI.Capitulo7;

namespace Tarea3_Cap6y7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Capitulo 6
        private void Ejercicio1_3MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1_3 ejercicio1_3 = new Ejercicio1_3();
            ejercicio1_3.Show(); 
        }

        private void Ejercicio4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show(); 
        }

        private void Ejercicio5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show(); 
        }

        //capitulo 7
        private void Ejercicio1Cap7MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1Cap7 ejercicio1Cap7 = new Ejercicio1Cap7();
            ejercicio1Cap7.Show();
        }

        private void Ejercicio2Cap7MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2Cap7 ejercicio2Cap7 = new Ejercicio2Cap7(); 
            ejercicio2Cap7.Show(); 
        }

        private void Ejercicio5Cap7MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap7 ejercicio5Cap7 = new Ejercicio5Cap7();
            ejercicio5Cap7.Show(); 
        }
    }
}
