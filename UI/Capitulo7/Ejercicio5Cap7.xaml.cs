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
    public partial class Ejercicio5Cap7 : Window
    {
        Hashtable agendaHash = new Hashtable();
        public Ejercicio5Cap7()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
            {
                return;
            }
            String nombre = nombreTextBox.Text;
            agendaHash.Add(nombre, numeroTextBox.Text);

            nombreTextBox.Text = "";
            numeroTextBox.Text = "";
        }

        private void buscarButton_Click(object sender, RoutedEventArgs e)
        {
            String nombre = nombreTextBox.Text;

            numeroTextBox.Text = (string)agendaHash[nombre];
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            nombreTextBox.Text = "";
            numeroTextBox.Text = "";
        }

        public bool Validar()
        {
            bool ok = true;
            String numero = numeroTextBox.Text;
            if (agendaHash.ContainsValue(numero) == true)
            {
                MessageBox.Show("Este numero ya existe en la agenda", "Aviso", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                ok = false;
            }

            return ok;
        }
    }
}
