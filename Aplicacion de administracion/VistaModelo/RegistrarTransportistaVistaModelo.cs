using Aplicacion_de_administracion.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aplicacion_de_administracion.VistaModelo
{
    class RegistrarTransportistaVistaModelo
    {
        public RegistrarTransportistaVistaModelo()
        {

        }

        public async Task RegistrarTransportistaExecutedAsync(string nombreEmpresa, string numeroTelefono)
        {
            Transportistas transportistas = new Transportistas(nombreEmpresa, numeroTelefono);
            bool response = await ApiRestService.PostTransportista(transportistas);
            if (response)
            {
                MessageBox.Show("Transportisa registrado correctamente", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                await ApiRestService.RunAsync();
                ApiRestService.Refresh();
            }
            else
            {
                MessageBox.Show("No se ha podido registrar el transportista", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        public bool RegistrarTransportistaCanExecute()
        {
            return true;
        }
    }
}
