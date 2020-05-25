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
    /// Lógica de interacción para EliminarProductoUserControl.xaml
    /// </summary>
    public partial class EliminarProductoUserControl : UserControl
    {
        public EliminarProductoUserControl()
        {
            this.DataContext = new EliminarProductoVistaModelo();
            InitializeComponent();
        }

        private void DeletePackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            (this.DataContext as EliminarProductoVistaModelo).DeletePackIconClickAsync(ProductosDataGrid.SelectedItem as Productos);
        }
    }
}
