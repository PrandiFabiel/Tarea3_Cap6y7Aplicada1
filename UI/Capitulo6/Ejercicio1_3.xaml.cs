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

    public partial class Ejercicio1_3 : Window
    {
        //Variables
        float minima = 10.0f, maxima = 0, promedio = 0, cantAlum = 0, suma = 0;
        int cantSalones = 0, alumnos = 0, contadorSalon = 0, indice = 1, indice2 = 1, iterador1 = 0, iterador2 = 0;

        //Arreglo jagged
        float[][] calificaciones;
        public Ejercicio1_3()
        {
            InitializeComponent();
        }

        private void insertarButton_Click(object sender, RoutedEventArgs e)
        {
            cantSalones = int.Parse(cantSalonesTextBox.Text);
            calificaciones = new float[cantSalones][];
            estadoSalonLabel.Content = "Listo";
            insertarButton.IsEnabled = false;
            cantSalonesTextBox.IsEnabled = false;
        }

        private void insertEstudianteButton_Click(object sender, RoutedEventArgs e)
        {
            alumnos = int.Parse(cantEstudiantesTextBox.Text);
            calificaciones[contadorSalon] = new float[alumnos];
            cantEstudiantesTextBox.Text = "";
            contadorSalon++;
            indice++;

            if (contadorSalon == cantSalones)
            {
                estadoEstuLabel.Content = "Listo";
                cantEstudiantesTextBox.IsEnabled = false;
                insertEstudianteButton.IsEnabled = false;
                indice = 1;
                contadorSalon = 0;
            }
            else
            {
                salonLabel.Content = ($"Salon :{indice}");
            }
        }

        private void insertCalificacionesButton_Click(object sender, RoutedEventArgs e)
        {
            salonEstuLabel.Content = ($"Salon {indice = iterador1 + 1}: Estudiante {indice2 = iterador2 + 1}:");
            calificaciones[iterador1][iterador2] = int.Parse(calificacionesTextBox.Text);
            calificacionesTextBox.Text = "";

            if (iterador2 != calificaciones[iterador1].GetLength(0) - 1)
            {
                iterador2++;
            }
            else if (iterador2 == calificaciones[iterador1].GetLength(0) - 1)
            {
                iterador1++;
                iterador2 = 0;
                if (iterador1 == cantSalones)
                {
                    insertCalificacionesButton.IsEnabled = false;
                    iterador1 = 0;
                    estadoCaliLabel.Content = "Listo";
                    return;
                }
            }
            salonEstuLabel.Content = ($"Salon {indice = iterador1 + 1}: Estudiante {indice2 = iterador2 + 1}:");
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {


            for (int i = 0; i < cantSalones; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    suma += calificaciones[i][j];
                    cantAlum++;
                }

            }

            promedio = suma / cantAlum;

            for (int i = 0; i < cantSalones; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] < minima)
                    {
                        minima = calificaciones[i][j];
                    }

                    if (calificaciones[i][j] > maxima)
                    {
                        maxima = calificaciones[i][j];
                    }
                }
            }

            resultadoTextBlock.Text += ($"Promedio: {promedio}\nCalif Maxima: {maxima}\nCalif Minima: {minima}");

        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            minima = 10.0f;
            maxima = 0;
            promedio = 0;
            cantAlum = 0;
            suma = 0;
            cantSalones = 0;
            alumnos = 0;
            contadorSalon = 0;
            indice = 1;
            indice2 = 1;
            iterador1 = 0;
            iterador2 = 0;

            salonEstuLabel.Content = "Salon 1: Estudiante 1:";
            salonLabel.Content = "Salon 1:";
            cantSalonesTextBox.Text = "";
            resultadoTextBlock.Text = "";
            insertarButton.IsEnabled = true;
            insertEstudianteButton.IsEnabled = true;
            insertCalificacionesButton.IsEnabled = true;
            cantSalonesTextBox.IsEnabled = true;
            cantEstudiantesTextBox.IsEnabled = true;
            calificacionesTextBox.IsEnabled = true;


        }

    }
}
