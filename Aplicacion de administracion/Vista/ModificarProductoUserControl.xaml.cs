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
    /// Lógica de interacción para ModificarProductoUserControl.xaml
    /// </summary>
    public partial class ModificarProductoUserControl : UserControl
    {
        public ModificarProductoUserControl()
        {
            this.DataContext = new ModificarProductoVistaModelo();
            InitializeComponent();
        }

        private void ExaminarButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();

            dialog.Title = "Insertar imagen";
            dialog.Filter = "Formato PNG|*.png";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment
                                                                .SpecialFolder
                                                                .MyComputer);

            if ((bool)dialog.ShowDialog())
            {
                BitmapImage myBitmapImage = new BitmapImage();

                myBitmapImage.BeginInit();
                myBitmapImage.UriSource = new Uri(dialog.FileName);
                myBitmapImage.EndInit();
                ProductoImage.Source = myBitmapImage;
                (this.DataContext as ModificarProductoVistaModelo).NomFotoProp = dialog.SafeFileName;
            }
        }

        private void ModificarCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as ModificarProductoVistaModelo).ModificarProductoExecutedAsync(ProductosComboBox.SelectedItem as Productos, ProductoImage.Source);
            reset();
        }

        private void ModificarCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (this.DataContext as ModificarProductoVistaModelo).ModificarProductoCanExecute();
        }
        private void reset()
        {
            NombreTextBox.Text = "";
            DescripcionTextBox.Text = "";
            CategoriasComboBox.SelectedItem = null;
            EspecificacionesTextBox.Text = "";
            PrecioTextBox.Text = "";
            DisponibleCheckBox.IsChecked = false;
            DescuentoTextBox.Text = "";
            ProductoImage.Source = null;
        }
    }
}
