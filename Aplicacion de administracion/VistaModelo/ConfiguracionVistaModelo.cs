using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_administracion.VistaModelo
{
    class ConfiguracionVistaModelo
    {

        public ConfiguracionVistaModelo()
        {

        }

        public void AceptarButtonClick()
        {
            Properties.Settings.Default.Save();
        }
    }
}
