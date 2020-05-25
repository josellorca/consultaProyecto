using Aplicacion_de_administracion.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aplicacion_de_administracion.VistaModelo
{
    class EliminarProductoVistaModelo : INotifyPropertyChanged
    {

        public static ObservableCollection<Productos> ProductosList { get; set; }
        public EliminarProductoVistaModelo()
        {
            List<Productos> lista = ApiRestService.Productos;
            if (lista != null)
            {
                ObservableCollection<Productos> observable = new ObservableCollection<Productos>(lista);
                ProductosList = observable;
            }
        }
        public async Task DeletePackIconClickAsync(Productos producto)
        {
            if (producto != null)
            {
                if (producto.ImgProducto != null)
                {
                    string[] rutaImagen = producto.ImgProducto.Split('/');
                    string nomFoto = rutaImagen[rutaImagen.Length - 1];
                    StorageService.DeleteImageStorage(nomFoto, "imagenesproductos");
                }
                bool response = await ApiRestService.DeleteProducto(producto.IdProducto);
                if (response)
                {
                    MessageBox.Show("Producto eliminado correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    ProductosList.Remove(producto);
                    await ApiRestService.RunAsync();
                    ApiRestService.Refresh();
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar el producto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto para eliminarlo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
