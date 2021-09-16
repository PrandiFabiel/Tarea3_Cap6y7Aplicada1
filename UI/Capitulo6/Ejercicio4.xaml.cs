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

namespace Tarea3_Cap6y7.UI.Capitulo6
{
    //Ejericio 4, lo mismo que los ejercicio 1,2,3, pero implementado con funciones
    public partial class Ejercicio4 : Window
    {
        int n = 0; 
        int m = 0; 
        int salones = 0;
        int cantidadAlumnos = 0;
        float[,] calif;

        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void insertarDatosButton_Click(object sender, RoutedEventArgs e)
        {
            salones = int.Parse(salonesTextBox.Text); 
            cantidadAlumnos = int.Parse(alumnosTextBox.Text); 
            calif = new float[salones, cantidadAlumnos];

            salonesTextBox.IsEnabled = false;
            alumnosTextBox.IsEnabled = false;
            insertarDatosButton.IsEnabled = false;
        }

        private void insertarButton_Click(object sender, RoutedEventArgs e)
        {

            calif[n, m] = float.Parse(califTextBox.Text);
            califTextBox.Text = "";

            if (m == cantidadAlumnos - 1)
            {
                n++;
                if (n == salones)
                {
                    insertarButton.IsEnabled = false;
                    califTextBox.IsEnabled = false;
                    return;
                }

                m = 0;
                int s = n + 1;
                contadorSalon.Content = $"Salones: {s}";
                contadorCalifiLabel.Content = $"Calificacion: {1}";
            }
            else
            {

                m++;
                int c = m + 1;
                contadorCalifiLabel.Content = $"Calificacion: {c}";

            }
            if (n == salones)
            {
                insertarButton.IsEnabled = false;
                califTextBox.IsEnabled = false;
            }

        }


        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {

            CalcularPromedioMinMax();
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            n = 0;
            m = 0; 
            calif = new float[0, 0];

            salonesTextBox.IsEnabled = true;
            alumnosTextBox.IsEnabled = true;
            insertarDatosButton.IsEnabled = true;
            insertarButton.IsEnabled = true;
            califTextBox.IsEnabled = true;
        }

 
        public void CalcularPromedioMinMax()
        {
            Promedio();
            Minima();
            Maxima();

        }


        public void Promedio()
        {

            float suma = 0, promedio = 0;
            for (int n = 0; n < salones; n++) 
            {
                for (int m = 0; m < cantidadAlumnos; m++) 
                {
                    suma += calif[n, m];
                }
            }

            promedio = suma / (cantidadAlumnos * salones);

            resultadoTextBlock.Text = $"Promedio: {promedio}\n";
        }

        public void Minima()
        {
            float minima = 10.0f;
            
            for (int n = 0; n < salones; n++) 
            {
                for (int m = 0; m < cantidadAlumnos; m++) 
                {
                    if (calif[n, m] < minima)
                        minima = calif[n, m];
                }
            }

            resultadoTextBlock.Text += $"Minima: {minima}\n";
        }


        public void Maxima()
        {
            float maxima = 0;
           
            for (int n = 0; n < salones; n++) 
            {
                for (int m = 0; m < cantidadAlumnos; m++) 
                {
                    if (calif[n, m] > maxima)
                        maxima = calif[n, m];
                }
            }
            resultadoTextBlock.Text += $"Maxima: {maxima}";
        }

    }
}
