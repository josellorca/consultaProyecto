using Aplicacion_de_administracion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aplicacion_de_administracion.VistaModelo
{
    class EliminarTransportistaVistaModelo : INotifyPropertyChanged
    {
        public static List<Transportistas> Transportistas { get; set; }

        public Transportistas Transportista { get; set; }

        public EliminarTransportistaVistaModelo()
        {
            Transportistas = ApiRestService.Transportistas;
        }

        public async Task EliminarTransportistaExecutedAsync()
        {
            bool response = await ApiRestService.DeleteTransportista(Transportista);
            if (response)
            {
                MessageBox.Show("Transportista eliminado correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                await ApiRestService.RunAsync();
                ApiRestService.Refresh();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar el transportista", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public bool EliminarTransportistaCanExecute()
        {
            return Transportista != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
