using System;
using System.Collections.Generic;
using System.Text;
using Restaurant_PALMERO_proyecto_2.Modulo_Menu; //Para guardar los platos en el inicio

//Esta es la nueva clase ControlDatos para manejar persistencia de datos
namespace Restaurant_PALMERO_proyecto_2
{
    public static class ControlDatos
    {
        // Aqui estoy creando una lista global de platos para que se mantenga en toda la aplicación
        public static List<Plato> MenuGlobal = new List<Plato>();
    }
}
