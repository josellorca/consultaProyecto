﻿using Aplicacion_de_administracion.VistaModelo;
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
    /// Lógica de interacción para EliminarTransportistaUserControl.xaml
    /// </summary>
    public partial class EliminarTransportistaUserControl : UserControl
    {
        public EliminarTransportistaUserControl()
        {
            this.DataContext = new EliminarTransportistaVistaModelo();
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as EliminarTransportistaVistaModelo).EliminarTransportistaExecutedAsync();
            reset();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (this.DataContext as EliminarTransportistaVistaModelo).EliminarTransportistaCanExecute();
        }
        private void reset()
        {

            NombreTextBox.Text = "";
            TelefonoTextBox.Text = "";
        }
    }
}
