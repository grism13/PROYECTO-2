using System;

namespace Restaurant_PALMERO_proyecto_2
{
    public class DetalleOrden
    {
        // Estas 4 propiedades son las que usa el DataGridView para crear las columnas automáticas
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        // Constructor para crear la línea rápida
        public DetalleOrden(string nombre, int cant, decimal precioUnitario)
        {
            Producto = nombre;
            Cantidad = cant;
            Precio = precioUnitario;
            Total = cant * precioUnitario; // Calcula el total solito
        }
    }
}