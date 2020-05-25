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
    class ModificarCategoriaVistaModelo : INotifyPropertyChanged
    {
        public static List<Categoria> Categorias { get; set; }

        public string NomFotoProp { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public ModificarCategoriaVistaModelo()
        {
            Categorias = ApiRestService.Categorias;
        }


        public async Task ModificarCategoriaExecutedAsync(Categoria categoria, ImageSource imagen)
        {
            if (NomFotoProp != null)
            {
                string[] rutaImagen = categoria.ImgCategoria.Split('/');
                string nomFoto = rutaImagen[rutaImagen.Length - 1];
                StorageService.DeleteImageStorage(nomFoto, "imagenescategorias");
                byte[] imagenBytes = StorageService.ImageSourceToBytes(new PngBitmapEncoder(), imagen);
                categoria.ImgCategoria = StorageService.UploadFileToStorage(imagenBytes, NomFotoProp, "imagenescategorias");
            }
            bool response = await ApiRestService.PutCategoria(categoria);
            if (response)
            {
                MessageBox.Show("Categoria actualizada correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                await ApiRestService.RunAsync();
                ApiRestService.Refresh();
            }
            else
            {
                MessageBox.Show("No se ha podido actualizar la categoria", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public bool ModificarCategoriaCanExecute()
        {
            return true;
        }
    }
}
