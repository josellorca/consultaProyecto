using Aplicacion_de_administracion.Modelo;
using Aplicacion_de_administracion.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Aplicacion_de_administracion.VistaModelo
{
    class EliminarCategoriaVistaModelo : INotifyPropertyChanged
    {
        public static ObservableCollection<Categoria> Categorias { get; set; }

        public EliminarCategoriaVistaModelo()
        {
            List<Categoria> lista = ApiRestService.Categorias;
            if (lista != null)
            {
                ObservableCollection<Categoria> observable = new ObservableCollection<Categoria>(lista);
                Categorias = observable;
            }
        }

        public async Task DeletePackIconClickAsync(Categoria categoria)
        {
            if (categoria.ImgCategoria != null)
            {
                string[] rutaImagen = categoria.ImgCategoria.Split('/');
                string nomFoto = rutaImagen[rutaImagen.Length - 1];
                StorageService.DeleteImageStorage(nomFoto, "imagenescategorias");
            }
            bool response = await ApiRestService.DeleteCategoria(categoria.IdCategoria);
            if (response)
            {
                MessageBox.Show("Categoria eliminada correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                Categorias.Remove(categoria);
                await ApiRestService.RunAsync();
                ApiRestService.Refresh();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar la categoria", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
    }
}
