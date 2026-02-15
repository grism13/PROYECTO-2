using System;


namespace Restaurant_PALMERO_proyecto_2.Modulo_Ordenes
{
    public class DetalleOrden
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total => Cantidad * Precio;

        public DetalleOrden(string nombre, int cant, decimal precio)
        {
            Producto = nombre;
            Cantidad = cant;
            Precio = precio;
        }
    }
}