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
    class ModificarTransportistaVistaModelo:INotifyPropertyChanged
    {
        public static List<Transportistas> Transportistas { get; set; }

        public Transportistas Transportista { get; set; }

        public ModificarTransportistaVistaModelo()
        {
            Transportistas = ApiRestService.Transportistas;
        }

        public async Task ModificarTransportistaExecutedAsync()
        {
            bool response = await ApiRestService.PutTransportista(Transportista);
            if (response)
            {
                MessageBox.Show("Transportista modificado correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                await ApiRestService.RunAsync();
                ApiRestService.Refresh();
            }
            else
            {
                MessageBox.Show("No se ha podido modificar el transportista", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public bool ModificarTransportistaCanExecute()
        {
            return Transportista != null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
