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
    class CrearProductoVistaModelo:INotifyPropertyChanged
    {
        public static List<Categoria> Categorias { get; set; }
        public string ImageSourceProp { get; set; }
        public string NomFichero { get; set; }

        public CrearProductoVistaModelo()
        {
            Categorias = ApiRestService.Categorias;
        }



        public async Task CrearProductoCommandExecutedAsync(string nomProducto, string descProducto, string especificaciones, int idCategoria, float precio, ImageSource imageSource, int disponible, int descuento)
        {
            Productos producto = new Productos(nomProducto, descProducto, especificaciones, idCategoria, precio, disponible);
            producto.Descuento = descuento;
            byte[] stream = StorageService.ImageSourceToBytes(new PngBitmapEncoder(), imageSource);
            string url = StorageService.UploadFileToStorage(stream, NomFichero, "imagenesproductos");
            producto.ImgProducto = url;
            bool response = await ApiRestService.PostProducto(producto);
            if (response)
            {
                await ApiRestService.RunAsync();
                ApiRestService.Refresh();
                MessageBox.Show("Se ha creado el producto correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se ha podido crear el producto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool CrearProductoCanExecute()
        {
            return ImageSourceProp!=null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
