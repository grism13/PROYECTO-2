using System;

namespace Restaurant_PALMERO_proyecto_2
{
    public class DetalleOrden
    {
        // Estas 4 cosas serán LAS COLUMNAS de tu tabla automáticamente
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        // Este es el constructor para crear filas rápido
        public DetalleOrden(string nombre, int cant, decimal precioUnitario)
        {
            Producto = nombre;
            Cantidad = cant;
            Precio = precioUnitario;
            Total = cant * precioUnitario; // Se calcula solo
        }
    }
}