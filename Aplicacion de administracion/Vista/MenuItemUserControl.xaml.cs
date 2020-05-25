using Aplicacion_de_administracion.Modelo;
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
    /// Lógica de interacción para MenuItemUserControl.xaml
    /// </summary>
    public partial class MenuItemUserControl : UserControl
    {
        VentanaPrincipal ventanaPrincipal;
        public MenuItemUserControl(ItemMenu menuItem, VentanaPrincipal ventana)
        {
            InitializeComponent();
            
            ExpanderMenu.Visibility = menuItem.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ItemMenuListView.Visibility = menuItem.SubItems == null ? Visibility.Visible : Visibility.Collapsed;
            this.DataContext = menuItem;
            ventanaPrincipal = ventana;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((ListView)sender).SelectedItem != null)
            {
                ventanaPrincipal.CambiaPantalla(((SubItem)((ListView)sender).SelectedItem).Pantalla);
                ((ListView)sender).UnselectAll();
            }
        }
    }
}
