using Aplicacion_de_administracion.Modelo;
using Aplicacion_de_administracion.VistaModelo;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aplicacion_de_administracion.Vista
{
    /// <summary>
    /// Lógica de interacción para ModificarCategoriaUserControl.xaml
    /// </summary>
    public partial class ModificarCategoriaUserControl : UserControl, INotifyPropertyChanged
    {
        public ModificarCategoriaUserControl()
        {
            this.DataContext = new ModificarCategoriaVistaModelo();
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

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
                CategoriaImage.Source = myBitmapImage;
                (this.DataContext as ModificarCategoriaVistaModelo).NomFotoProp = dialog.SafeFileName;
            }
        }

        private void ModificarCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Categoria categoria = (Categoria)CategoriasComboBox.SelectedItem;
            (this.DataContext as ModificarCategoriaVistaModelo).ModificarCategoriaExecutedAsync(categoria,CategoriaImage.Source);
            reset();
        }

        private void ModificarCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (this.DataContext as ModificarCategoriaVistaModelo).ModificarCategoriaCanExecute();
        }
        private void reset()
        {

            NombreTextBox.Text = "";
            DescripcionTextBox.Text = "";
            CategoriaImage.Source = null;
        }
    }
}
