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
using System.Windows.Shapes;

namespace Aplicacion_de_Administracion.Vista
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public Configuracion()
        {
            this.DataContext = new ConfiguracionVistaModelo();
            InitializeComponent();
        }

        private void ListViewItemTheme_Selected(object sender, RoutedEventArgs e)
        {
            TemaUserControl tema = new TemaUserControl();
            VistaPrincipalStackPanel.Children.Clear();
            VistaPrincipalStackPanel.Children.Add(tema);
        }

        private void ListViewItemWindow_Selected(object sender, RoutedEventArgs e)
        {
            PantallaUserControl pantallaUserControl = new PantallaUserControl();
            VistaPrincipalStackPanel.Children.Clear();
            VistaPrincipalStackPanel.Children.Add(pantallaUserControl);
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as ConfiguracionVistaModelo).AceptarButtonClick();
            DialogResult = true;
            MessageBox.Show("Cambios aplicados. Para visualizar los cambios de la pantalla debes de reiniciar la aplicacion", "Configuracion", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
