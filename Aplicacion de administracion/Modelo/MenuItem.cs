using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Aplicacion_de_administracion.Modelo
{
    public class ItemMenu
    {

        public string Cabecera { get; set; }

        public PackIconKind Icono { get; set; }

        public List<SubItem> SubItems { get; set; }

        public UserControl Pantalla { get; set; }

        public ItemMenu(string cabecera, List<SubItem> subItems, PackIconKind icono)
        {
            Cabecera = cabecera;
            SubItems = subItems;
            Icono = icono;
        }


        public ItemMenu(string cabecera, UserControl pantalla, PackIconKind icono)
        {
            Cabecera = cabecera;
            Pantalla = pantalla;
            Icono = icono;
        }
    }
}
