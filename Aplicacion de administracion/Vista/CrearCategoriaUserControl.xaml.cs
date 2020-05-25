using Aplicacion_de_administracion.Servicios;
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
    /// Lógica de interacción para CrearCategoriaUserControl.xaml
    /// </summary>
    public partial class CrearCategoriaUserControl : UserControl
    {
        public CrearCategoriaUserControl()
        {
            this.DataContext = new CrearCategoriaVistaModelo();
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
                (this.DataContext as CrearCategoriaVistaModelo).ImageSourceProp = dialog.FileName;
                (this.DataContext as CrearCategoriaVistaModelo).NomFichero = dialog.SafeFileName;
            }
        }

        private void CrearCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            (this.DataContext as CrearCategoriaVistaModelo).CrearCategoriaCommandExecutedAsync(NombreTextBox.Text, DescripcionTextBox.Text, CategoriaImage.Source);
            reset();
        }

        private void CrearCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (this.DataContext as CrearCategoriaVistaModelo).CrearCategoriaCanExecute();
        }

        private void reset()
        {
            
            NombreTextBox.Text = "";
            DescripcionTextBox.Text = "";
            CategoriaImage.Source = null;
        }
    }
}
