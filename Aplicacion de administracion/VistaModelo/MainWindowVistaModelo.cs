using Aplicacion_de_administracion.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_Administracion.VistaModelo
{
    public class MainWindowVistaModelo : INotifyPropertyChanged
    {
        public float AlturaResolucion { get; set; }
        public float AnchuraResolucion { get; set; }

        public MainWindowVistaModelo()
        {
            ApiRestService.RunAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool CompruebaModoOscuro()
        {
            return Aplicacion_de_administracion.Properties.Settings.Default.ModoOscuro;
        }
    }
}
