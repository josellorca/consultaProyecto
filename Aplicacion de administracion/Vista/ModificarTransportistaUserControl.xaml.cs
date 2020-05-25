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
    /// Lógica de interacción para ModificarTransportistaUserControl.xaml
    /// </summary>
    public partial class ModificarTransportistaUserControl : UserControl
    {
        public ModificarTransportistaUserControl()
        {
            this.DataContext = new ModificarTransportistaVistaModelo();
            InitializeComponent();
        }

        private void TelefonoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (e.Key <= Key.D0 || e.Key >= Key.D9)&&(e.Key<=Key.NumPad0 || e.Key >=Key.NumPad9);
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as ModificarTransportistaVistaModelo).ModificarTransportistaExecutedAsync();
            reset();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (this.DataContext as ModificarTransportistaVistaModelo).ModificarTransportistaCanExecute();
        }
        private void reset()
        {

            NombreTextBox.Text = "";
            TelefonoTextBox.Text = "";
        }
    }
}
