using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic; 
using Restaurant_PALMERO_proyecto_2; // ESte es para aedeer a la informacion de Form1 y despues a la infomacion de acturas

namespace Restaurant_PALMERO_proyecto_2.Modulo_Ordenes
{
    public partial class FormOrdenes : Form
    {
        Factura? ordenMesa1 = null;
        Factura? ordenMesa2 = null;
        Factura? ordenMesa3 = null;
        Factura? ordenMesa4 = null;
        Factura? ordenMesa5 = null;

        public FormOrdenes()
        {
            InitializeComponent();
        }



        private void FormOrdenes_Load(object sender, EventArgs e)
        {
            

            foreach (Factura factura in Form1.HistorialFacturas)
            {
                // FILTRO NUEVO: Solo cargamos si SIGUE EN COCINA
                if (factura.EnCocina == true)
                {
                    switch (factura.NumeroMesa)
                    {
                        case 1: 
                            ordenMesa1 = factura; 
                            break;

                        case 2: 
                            ordenMesa2 = factura; 
                            break;

                        case 3:
                            ordenMesa3 = factura; 
                            break;

                        case 4:
                            ordenMesa4 = factura;
                            break;

                        case 5: 
                            ordenMesa5 = factura; 
                            break;
                    }
                }
            }

           
        }

        //Funcion paara colocar los mensajes de los botones sin tanto codigo
        private void MostrarMensajePedido(Factura orden)
        {
            
            if (orden == null)
            {
                MessageBox.Show("Esta mesa está libre (Sin pedidos).", "Información");
                return;
            }

            string mensaje = $"=== PEDIDO MESA {orden.NumeroMesa} ===\n\n";


            foreach (var item in orden.PlatosComprados)
            {
                mensaje += $"• {item.Cantidad} x {item.Producto}\n";
            }

            mensaje += "\n--------------------------------\n";
            mensaje += $"TOTAL ACUMULADO: ${orden.Total}";

            MessageBox.Show(mensaje, "Detalle de Orden");
        }


        //Aqui es donde deberian ir el coñazo de botones :) TE ODIO C# (Eliezer)
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMensajePedido(ordenMesa1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarMensajePedido(ordenMesa2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarMensajePedido(ordenMesa3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarMensajePedido(ordenMesa4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarMensajePedido(ordenMesa5);
        }

       
        private void MarcarPedidoListo(int numeroMesa, Button boton)
        {
       
            Factura facturaActual = null;
            switch (numeroMesa)
            {
                case 1: facturaActual = ordenMesa1; break;
                case 2: facturaActual = ordenMesa2; break;
                case 3: facturaActual = ordenMesa3; break;
                case 4: facturaActual = ordenMesa4; break;
                case 5: facturaActual = ordenMesa5; break;
            }

            if (facturaActual == null) return;

         
            facturaActual.EnCocina = false; 

           
            Form1.PedidosListosParaServir.Add(facturaActual);

            
            switch (numeroMesa)
            {
                case 1: ordenMesa1 = null; break;
                case 2: ordenMesa2 = null; break;
                case 3: ordenMesa3 = null; break;
                case 4: ordenMesa4 = null; break;
                case 5: ordenMesa5 = null; break;
            }

            boton.Enabled = false;
            boton.Text = "SERVIDO";

            MessageBox.Show($"Mesa {numeroMesa} lista. Detalles enviados al mesero.", "Cocina");
        }

        //Otro coñazo de botones 

        private void button6_Click(object sender, EventArgs e)
        {
            MarcarPedidoListo(1, (Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MarcarPedidoListo(2, (Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarcarPedidoListo(3, (Button)sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MarcarPedidoListo(4, (Button)sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MarcarPedidoListo(5, (Button)sender);
        }
    }
}
