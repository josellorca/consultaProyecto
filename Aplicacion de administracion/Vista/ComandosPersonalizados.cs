using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Aplicacion_de_administracion.Vista
{
    public static class ComandosPersonalizados
    {
        public static readonly RoutedUICommand Examinar = new RoutedUICommand(
            "Examinar",
            "Examinar",
            typeof(ComandosPersonalizados),
            new InputGestureCollection()
            {
                new KeyGesture(Key.E,ModifierKeys.Control)
            }
        );

        public static readonly RoutedUICommand Crear = new RoutedUICommand(
            "Crear",
            "Crear",
            typeof(ComandosPersonalizados),
            new InputGestureCollection()
            {
                new KeyGesture(Key.A, ModifierKeys.Control)
            }
        );

        public static readonly RoutedUICommand Modificar = new RoutedUICommand(
            "Modificar",
            "Modificar",
            typeof(ComandosPersonalizados),
            new InputGestureCollection()
            {
                new KeyGesture(Key.M, ModifierKeys.Control)
            }
        );

        public static readonly RoutedUICommand Eliminar = new RoutedUICommand(
            "Eliminar",
            "Eliminar",
            typeof(ComandosPersonalizados),
            new InputGestureCollection()
            {
                        new KeyGesture(Key.E, ModifierKeys.Control)
            }
        );
    }
}
