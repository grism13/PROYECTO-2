using System;
using System.Collections.Generic;
using Restaurant_PALMERO_proyecto_2.Modulo_Ordenes;

namespace Restaurant_PALMERO_proyecto_2
{
    public class Factura
    {
        public int NumeroMesa { get; set; }
        public decimal Total { get; set; }
        public List<DetalleOrden> PlatosComprados { get; set; }

        public bool EnCocina { get; set; }

        public Factura(int mesa, decimal total, List<DetalleOrden> listaPlatos)
        {

            NumeroMesa = mesa;
            Total = total;
            PlatosComprados = listaPlatos;
            EnCocina = true;
        }
    }
}