   M S B A M L   `   `   `  ����H  DTarea3_Cap6y7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Tarea3_Cap6y7.UI.Capitulo6Tarea3_Cap6y7.UI.Capitulo6  5   	   -    'Tarea3_Cap6y7.UI.Capitulo6.Ejercicio1_3   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Tarea3_Cap6y7.UI.Capitulo6     5   	     � Title$  Ejercicios1-2y3��5   	   $	��400��6!   $	��400��6.    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ CanMinimize=�6_   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   $��10,10,10,10q�6,   .+�5      �� $@��:Calcular el promedio de calificaciones con arreglos jagged��6   $
��Bold"�6Y   $��14(�6k   $	��780��6y   $��19��6�   $��	5,-1,5,-4q�6�   �� 5      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5      �� $��Salones��6   $��50��6*   $
��Left=�65   �� 5      -   5        $��cantSalonesTextBox��5      $��20��64   $��20��6?   �� 5      -   5        $��insertarButton��5      $��Insertar��6/   $��20��6B   $��15,0,0,0q�6N   6`   �� 5      -   5        $��estadoSalonLabel��5      $
��Bold"�60   $��1,0,0,0q�6C   5      �� 5      $6��0Introduzca la cantidad de estudiantes por salon:��6   $
��Bold"�6O   $��0,19,0,0q�6a   �� 5      $ 
Horizontal=�6   .+�5      �� -   5        $��
salonLabel��5      $��Salon 1:��6*   �� 5      -   5        $��cantEstudiantesTextBox��5      $��20��68   $��20��6C   $
��Left=�6O   $��5,0,0,0q�6j   �� 5      -   5        $��insertEstudianteButton��5      $��Insertar��67   $��20��6J   $��13,0,0,0q�6V   6h   �� 5      -   5        $��estadoEstuLabel��5      $
��Bold"�6/   $��1,0,0,0q�6B   5      �� 5      $$��Introduzca las calificaciones:��6   $
��Bold"�6=   $��0,19,0,0q�6O   �� 5      $ 
Horizontal=�6   .+�5       �� -   5        $��salonEstuLabel��5       $��Salon 1: Estudiante 1:��6.   �� 5!      -	   5        $��calificacionesTextBox��5!      $��20��67   $��20��6B   $
��Left=�6N   $��5,0,0,0q�6i   �� 5"      -
   5        $ ��insertCalificacionesButton��5"      $��Insertar��6;   $��20��6N   $��13,0,0,0q�6Z   6l   �� 5#      -   5        $��estadoCaliLabel��5#      $
��Bold"�6/   $��1,0,0,0q�6B   5$      �� 5&      $ 
Horizontal=�6   $��6,12,0,0q�62   .+�5'      �� -   5        $��calcularButton��5'      $��Calcular��6/   6B   �� 5(      -   5        $��limpiarButton��5(      $��Limbiar��6.   $��14,0,0,0q�6@   6R   5*      �� 5,      $ Vertical=�6   $��0,12,0,0q�60   .+�5-      �� $��
Resultado:��6   $
��Bold"�6-   $��1q�6?   $��22��6K   $��5,4,5,0q�6W   �� 5.      -   5        $��resultadoTextBlock��5.      
�������$
��Left=�6M   $	��108��6h   $	��144��6u   $��5,0,0,0q�6�   5/      51      52      53      