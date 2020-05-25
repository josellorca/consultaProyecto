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
    /// Lógica de interacción para CrearProductoUserControl.xaml
    /// </summary>
    public partial class CrearProductoUserControl : UserControl
    {
        public CrearProductoUserControl()
        {
            this.DataContext = new CrearProductoVistaModelo();
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
                (this.DataContext as CrearProductoVistaModelo).ImageSourceProp = dialog.FileName;
                (this.DataContext as CrearProductoVistaModelo).NomFichero = dialog.SafeFileName;
            }
        }

        private void CrearCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            float precio = float.Parse(PrecioTextBox.Text);
            int descuento = int.Parse(DescuentoTextBox.Text);
            (this.DataContext as CrearProductoVistaModelo).CrearProductoCommandExecutedAsync(
                    NombreTextBox.Text,
                    DescripcionTextBox.Text,
                    EspecificacionesTextBox.Text,
                    (CategoriasComboBox.SelectedItem as Categoria).IdCategoria,
                    precio,
                    ProductoImage.Source,
                    (bool)DisponibleCheckBox.IsChecked?1:0,
                    descuento
                );
            reset();
        }

        private void CrearCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute=(this.DataContext as CrearProductoVistaModelo).CrearProductoCanExecute();
        }
        private void reset()
        {
            NombreTextBox.Text = "";
            DescripcionTextBox.Text = "";
            CategoriasComboBox.SelectedItem= null;
            EspecificacionesTextBox.Text = "";
            PrecioTextBox.Text = "";
            DisponibleCheckBox.IsChecked = false;
            DescuentoTextBox.Text = "";
            ProductoImage.Source = null;
        }
    }
}
