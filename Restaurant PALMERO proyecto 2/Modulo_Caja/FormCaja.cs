using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant_PALMERO_proyecto_2.Modulo_Caja
{
    public partial class FormCaja : Form
    {
        // Lista del carrito
        List<ItemVenta> carrito = new List<ItemVenta>();

        // --- 1. AQUÍ ES DONDE OCURRE LA MAGIA ---
        public FormCaja()
        {
            InitializeComponent(); // Esto dibuja la ventana

            // --- PEGAMOS EL CÓDIGO AQUÍ PARA OBLIGARLO A CORRER ---

            // A. Creamos una lista temporal de productos
            List<ProductoSimple> menuRapido = new List<ProductoSimple>();

            menuRapido.Add(new ProductoSimple("Linguinis con langostinos", 15));
            menuRapido.Add(new ProductoSimple("Degustación de mejillones", 12));
            menuRapido.Add(new ProductoSimple("Quesillo", 4));
            menuRapido.Add(new ProductoSimple("Jugo de Parchita", 3));

            // B. Llenamos el ComboBox a la fuerza
            cmbPlatos.DataSource = null;
            cmbPlatos.DataSource = menuRapido;
            cmbPlatos.DisplayMember = "Nombre"; // Lo que se ve
            cmbPlatos.ValueMember = "Precio";   // Lo que vale

            // C. Iniciamos el total
            lblTotal.Text = "Total: $0.00";
        }

        // --- 2. BOTÓN AGREGAR ---


        // --- 3. ACTUALIZAR TABLA Y SUMA ---
        private void RefrescarTodo()
        {
            dgvCaja.DataSource = null;
            dgvCaja.DataSource = carrito;

            decimal total = 0;
            foreach (var item in carrito)
            {
                total += item.Subtotal;
            }
            lblTotal.Text = $"Total: ${total}";
        }

        // --- 4. BOTÓN COBRAR ---

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Tomamos el producto seleccionado
            ProductoSimple producto = (ProductoSimple)cmbPlatos.SelectedItem;

            if (producto == null) return;

            int cantidad = (int)numCantidad.Value;
            decimal totalLinea = producto.Precio * cantidad;

            // Agregamos al carrito
            carrito.Add(new ItemVenta(producto.Nombre, cantidad, producto.Precio, totalLinea));

            RefrescarTodo();
        }

        private void btnCobrar_Click_1(object sender, EventArgs e)
        {
            if (carrito.Count == 0) return;
            MessageBox.Show($"Cobro Exitoso.\n{lblTotal.Text}");
            carrito.Clear();
            RefrescarTodo();
            numCantidad.Value = 1;
        }
    }

    // --- CLASES SIMPLES PARA QUE NO FALLEN ---
    // (Ponlas aquí abajo, dentro del namespace)

    public class ProductoSimple
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public ProductoSimple(string n, decimal p) { Nombre = n; Precio = p; }
    }

    public class ItemVenta
    {
        public string Producto { get; set; }
        public int Cant { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
        public ItemVenta(string n, int c, decimal p, decimal s)
        { Producto = n; Cant = c; Precio = p; Subtotal = s; }
    }
}