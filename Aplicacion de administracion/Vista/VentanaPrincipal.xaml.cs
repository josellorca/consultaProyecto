using Aplicacion_de_administracion.Modelo;
using Aplicacion_de_Administracion.Vista;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Aplicacion_de_administracion.Vista
{
    /// <summary>
    /// Lógica de interacción para VentanaPrincipal.xaml
    /// </summary>
    public partial class VentanaPrincipal : Window
    {
        public EliminarCategoriaUserControl EliminarCategoriaUserControl { get; set; }
        public EliminarProductoUserControl EliminarProductoUserControl { get; set; }

        public VentanaPrincipal()
        {
            InitializeComponent();

            EliminarCategoriaUserControl = new EliminarCategoriaUserControl();
            EliminarProductoUserControl = new EliminarProductoUserControl();

            List<SubItem> menuCategoria = new List<SubItem>();
            menuCategoria.Add(new SubItem("Crear categoria",new CrearCategoriaUserControl()));
            menuCategoria.Add(new SubItem("Modificar categoria",new ModificarCategoriaUserControl()));
            menuCategoria.Add(new SubItem("Eliminar categoria",EliminarCategoriaUserControl ));
            ItemMenu menuItemCategoria = new ItemMenu("Categoria", menuCategoria, PackIconKind.Category);

            List<SubItem> menuProductos = new List<SubItem>();
            menuProductos.Add(new SubItem("Crear producto", new CrearProductoUserControl()));
            menuProductos.Add(new SubItem("Modificar producto", new ModificarProductoUserControl()));
            menuProductos.Add(new SubItem("Eliminar producto", EliminarProductoUserControl));
            ItemMenu menuItemProductos = new ItemMenu("Productos", menuProductos, PackIconKind.Computer);

            List<SubItem> menuTransportistas = new List<SubItem>();
            menuTransportistas.Add(new SubItem("Registrar transportista", new RegistrarTransportistaUserControl()));
            menuTransportistas.Add(new SubItem("Modificar transportista", new ModificarTransportistaUserControl()));
            menuTransportistas.Add(new SubItem("Eliminar transportista", new EliminarTransportistaUserControl()));
            ItemMenu menuItemTransportistas = new ItemMenu("Transportistas",menuTransportistas,PackIconKind.Truck);

            ItemMenu menuItemAyuda = new ItemMenu("Ayuda", new UserControl(), PackIconKind.Help);

            MenuItemUserControl menuCategoriaUserControl = new MenuItemUserControl(menuItemCategoria,this);
            MenuStackPanel.Children.Add(menuCategoriaUserControl);

            MenuItemUserControl menuProductosUserControl = new MenuItemUserControl(menuItemProductos,this);
            MenuStackPanel.Children.Add(menuProductosUserControl);

            MenuItemUserControl menuTransportistasUserControl = new MenuItemUserControl(menuItemTransportistas, this);
            MenuStackPanel.Children.Add(menuTransportistasUserControl);

            MenuItemUserControl menuAyudaUserControl = new MenuItemUserControl(menuItemAyuda,this);
            MenuStackPanel.Children.Add(menuAyudaUserControl);
            
            UserControlsGrid.Children.Add(new CrearCategoriaUserControl());
        }
        //Metodo necesario para actualizar los elementos de la app
        private void actualiza()
        {
            MenuStackPanel.Children.Clear();
            List<SubItem> menuCategoria = new List<SubItem>();
            menuCategoria.Add(new SubItem("Crear categoria", new CrearCategoriaUserControl()));
            menuCategoria.Add(new SubItem("Modificar categoria", new ModificarCategoriaUserControl()));
            menuCategoria.Add(new SubItem("Eliminar categoria", EliminarCategoriaUserControl));
            ItemMenu menuItemCategoria = new ItemMenu("Categoria", menuCategoria, PackIconKind.Category);

            List<SubItem> menuProductos = new List<SubItem>();
            menuProductos.Add(new SubItem("Crear producto", new CrearProductoUserControl()));
            menuProductos.Add(new SubItem("Modificar producto", new ModificarProductoUserControl()));
            menuProductos.Add(new SubItem("Eliminar producto", EliminarProductoUserControl));
            ItemMenu menuItemProductos = new ItemMenu("Productos", menuProductos, PackIconKind.Computer);

            List<SubItem> menuTransportistas = new List<SubItem>();
            menuTransportistas.Add(new SubItem("Registrar transportista", new RegistrarTransportistaUserControl()));
            menuTransportistas.Add(new SubItem("Modificar transportista", new ModificarTransportistaUserControl()));
            menuTransportistas.Add(new SubItem("Eliminar transportista", new EliminarTransportistaUserControl()));
            ItemMenu menuItemTransportistas = new ItemMenu("Transportistas", menuTransportistas, PackIconKind.Truck);

            ItemMenu menuItemAyuda = new ItemMenu("Ayuda", new UserControl(), PackIconKind.Help);

            MenuItemUserControl menuCategoriaUserControl = new MenuItemUserControl(menuItemCategoria, this);
            
            MenuStackPanel.Children.Add(menuCategoriaUserControl);

            MenuItemUserControl menuProductosUserControl = new MenuItemUserControl(menuItemProductos, this);
            MenuStackPanel.Children.Add(menuProductosUserControl);

            MenuItemUserControl menuTransportistasUserControl = new MenuItemUserControl(menuItemTransportistas, this);
            MenuStackPanel.Children.Add(menuTransportistasUserControl);

            MenuItemUserControl menuAyudaUserControl = new MenuItemUserControl(menuItemAyuda, this);
            MenuStackPanel.Children.Add(menuAyudaUserControl);

            UserControlsGrid.Children.Add(new CrearCategoriaUserControl());
        }

        public void CambiaPantalla(object sender)
        {
            actualiza();
            var pantalla = ((UserControl)sender);
            if (pantalla != null)
            {
                UserControlsGrid.Children.Clear();
                UserControlsGrid.Children.Add(pantalla);
            }
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            Configuracion config = new Configuracion();
            config.ShowDialog();
        }

        private void SalirButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
