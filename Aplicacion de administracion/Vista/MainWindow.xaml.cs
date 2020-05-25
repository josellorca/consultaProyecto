using Aplicacion_de_administracion.Vista;
using Aplicacion_de_Administracion.Vista;
using Aplicacion_de_Administracion.VistaModelo;
using MaterialDesignThemes.Wpf;
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

namespace Aplicacion_de_Administracion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new MainWindowVistaModelo();
            InitializeComponent();
            if((DataContext as MainWindowVistaModelo).CompruebaModoOscuro())
            {
                Theme theme = (Theme)ResourceDictionaryExtensions.GetTheme(Application.Current.Resources);
                ThemeExtensions.SetBaseTheme(theme, Theme.Dark);
                ResourceDictionaryExtensions.SetTheme(Application.Current.Resources, theme);
            }
            else
            {
                Theme theme = (Theme)ResourceDictionaryExtensions.GetTheme(Application.Current.Resources);
                ThemeExtensions.SetBaseTheme(theme, Theme.Light);
                ResourceDictionaryExtensions.SetTheme(Application.Current.Resources, theme);
            }

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Configuracion config = new Configuracion();
            config.ShowDialog();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show();
            //this.Hide();
        }
    }
}
