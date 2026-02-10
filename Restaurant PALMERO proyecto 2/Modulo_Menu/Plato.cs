using System;
using System.Collections.Generic;
using System.Drawing; // <--- Importante para poder guardar la Foto
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_PALMERO_proyecto_2.Modulo_Menu // Se guardará en la misma carpeta del menú
{
    public class Plato
    {
        // 1. CARACTERÍSTICAS
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }

        // 2. CONSTRUCTOR VACÍO
        public Plato() { }

        // 3. CONSTRUCTOR (Solo 4 cosas: SIN FOTO)
        public Plato(string nombre, decimal precio, string categoria, string descripcion)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            Descripcion = descripcion;
        }
    }
}
