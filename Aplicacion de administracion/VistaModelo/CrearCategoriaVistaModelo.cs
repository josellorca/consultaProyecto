using Aplicacion_de_administracion.Modelo;
using Aplicacion_de_administracion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Aplicacion_de_administracion.VistaModelo
{
    class CrearCategoriaVistaModelo : INotifyPropertyChanged
    {

        public string ImageSourceProp { get; set; }

        public string NomFichero { get; set; }

        public CrearCategoriaVistaModelo()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task CrearCategoriaCommandExecutedAsync(string nombreCat, string descripcionCat, ImageSource imagen)
        {
            Categoria categoria = new Categoria(descripcionCat, ImageSourceProp, nombreCat);

            byte[] stream = StorageService.ImageSourceToBytes(new PngBitmapEncoder(), imagen);
            string url = StorageService.UploadFileToStorage(stream, NomFichero, "imagenescategorias");
            categoria.ImgCategoria = url;
            bool response = await ApiRestService.PostCategoria(categoria);
            if (response)
            {
                MessageBox.Show("Se ha creado la categoria correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                await ApiRestService.RunAsync();
                ApiRestService.Refresh();
            }
            else
            {
                MessageBox.Show("No se ha podido crear la categoria ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public bool CrearCategoriaCanExecute()
        {
            return ImageSourceProp != null;
        }
    }
}
