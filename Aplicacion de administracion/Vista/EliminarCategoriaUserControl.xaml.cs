﻿using Aplicacion_de_administracion.Servicios;
using Aplicacion_de_administracion.VistaModelo;
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

namespace Aplicacion_de_administracion.Vista
{
    /// <summary>
    /// Lógica de interacción para EliminarCategoriaUserControl.xaml
    /// </summary>
    public partial class EliminarCategoriaUserControl : UserControl
    {
        public EliminarCategoriaUserControl()
        {
            this.DataContext = new EliminarCategoriaVistaModelo();
            InitializeComponent();
        }

        private void DeletePackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CategoriasDataGrid.SelectedItem != null)
            {
                Categoria categoria = (CategoriasDataGrid.SelectedItem as Categoria);
                (this.DataContext as EliminarCategoriaVistaModelo).DeletePackIconClickAsync(categoria);
                
            }
            else
            {
                MessageBox.Show("Debes seleccionar primero un elemento para borrarlo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

    }
}
