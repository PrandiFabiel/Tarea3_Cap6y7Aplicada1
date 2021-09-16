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
using System.Windows.Shapes;
using System.Collections;

namespace Tarea3_Cap6y7.UI.Capitulo7
{
    public partial class Ejercicio2Cap7 : Window
    {
        Hashtable palabraHash = new Hashtable();
        private int previousLineCount = 0;
        public Ejercicio2Cap7()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            String palabra = palabraTextBox.Text;
            palabraHash.Add(palabra, definicionTextBox.Text);

            palabraTextBox.Text = "";
            definicionTextBox.Text = "";
        }

        private void buscarButton_Click(object sender, RoutedEventArgs e)
        {
            String palabra = palabraTextBox.Text;

            definicionTextBox.Text = (string)palabraHash[palabra];

        }

        private void definicionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (definicionTextBox.LineCount > previousLineCount)
            {
                previousLineCount = definicionTextBox.LineCount;
            }

        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            palabraTextBox.Text = "";
            definicionTextBox.Text = "";
        }

        public bool Validar()
        {
            bool ok = true;
            String palabra = palabraTextBox.Text;
            if (palabraHash.Contains(palabra) == true)
            {
                MessageBox.Show("Esta palabra ya existe en el diccionario", "Aviso", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                ok = false;
            }

            return ok;
        }
    }
}
