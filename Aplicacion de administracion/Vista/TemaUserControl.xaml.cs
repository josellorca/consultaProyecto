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

namespace Aplicacion_de_Administracion.Vista
{
    /// <summary>
    /// Lógica de interacción para TemaUserControl.xaml
    /// </summary>
    public partial class TemaUserControl : UserControl
    {
        public TemaUserControl()
        {
            InitializeComponent();
        }

        private void TemaToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            Theme theme = (Theme)ResourceDictionaryExtensions.GetTheme(Application.Current.Resources);
            ThemeExtensions.SetBaseTheme(theme, Theme.Dark);
            ResourceDictionaryExtensions.SetTheme(Application.Current.Resources, theme);
        }

        private void TemaToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Theme theme = (Theme)ResourceDictionaryExtensions.GetTheme(Application.Current.Resources);
            ThemeExtensions.SetBaseTheme(theme, Theme.Light);
            ResourceDictionaryExtensions.SetTheme(Application.Current.Resources, theme);
        }

    }
}
