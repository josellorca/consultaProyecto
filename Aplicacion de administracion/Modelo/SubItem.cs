using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Aplicacion_de_administracion.Modelo
{
    public class SubItem
    {
        public string Nombre { get; private set; }

        public UserControl Pantalla { get; private set; }

        public SubItem(string nombre, UserControl pantalla = null)
        {
            Nombre = nombre;
            Pantalla = pantalla;
        }
    }
}
