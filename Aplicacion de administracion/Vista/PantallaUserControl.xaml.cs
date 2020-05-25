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

namespace Aplicacion_de_Administracion.Vista
{
    /// <summary>
    /// Lógica de interacción para PantallaUserControl.xaml
    /// </summary>
    public partial class PantallaUserControl : UserControl
    {
        public PantallaUserControl()
        {
            InitializeComponent();
        }

        private void TemaToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Aplicacion_de_administracion.Properties.Settings.Default.WindowState = "Maximized";
            Aplicacion_de_administracion.Properties.Settings.Default.WindowStyle = "None";
            Aplicacion_de_administracion.Properties.Settings.Default.PantallaCompleta = true;
        }

        private void TemaToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Aplicacion_de_administracion.Properties.Settings.Default.WindowState = "Normal";
            Aplicacion_de_administracion.Properties.Settings.Default.WindowStyle = "SingleBorderWindow";
            Aplicacion_de_administracion.Properties.Settings.Default.PantallaCompleta = false;
        }
    }
}
