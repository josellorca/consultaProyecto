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
    class ModificarProductoVistaModelo : INotifyPropertyChanged
    {
        public static List<Categoria> Categorias { get; set; }

        public static List<Productos> Productos { get; set; }

        public string NomFotoProp { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public ModificarProductoVistaModelo()
        {
            Categorias = ApiRestService.Categorias;
            Productos = ApiRestService.Productos;
        }
        public async Task ModificarProductoExecutedAsync(Productos producto, ImageSource imagen)
        {
            if (NomFotoProp != null)
            {
                string[] rutaImagen = producto.ImgProducto.Split('/');
                string nomFoto = rutaImagen[rutaImagen.Length - 1];
                StorageService.DeleteImageStorage(nomFoto, "imagenescategorias");
                byte[] imagenBytes = StorageService.ImageSourceToBytes(new PngBitmapEncoder(), imagen);
                producto.ImgProducto = StorageService.UploadFileToStorage(imagenBytes, NomFotoProp, "imagenescategorias");
            }
            bool response = await ApiRestService.PutProducto(producto);
            if (response)
            {
                MessageBox.Show("Producto actualizado correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                await ApiRestService.RunAsync();
                ApiRestService.Refresh();
            }
            else
            {
                MessageBox.Show("No se ha podido actualizar el producto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool ModificarProductoCanExecute()
        {
            return true;
        }

    }
}
