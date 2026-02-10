using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Restaurant_PALMERO_proyecto_2.Modulo_Menu; // IMPORTANTE: Para ver la clase 'Plato' de Gris

namespace Restaurant_PALMERO_proyecto_2.Modulo_Ordenes
{
    public partial class FormOrdenes : Form
    {
        // --- 1. LAS LISTAS DE DATOS ---
        List<Plato> listaDePlatos = new List<Plato>();      // El Menú
        List<DetalleOrden> ticket = new List<DetalleOrden>(); // La Factura

        public FormOrdenes()
        {
            InitializeComponent();
        }

        // --- 2. CUANDO ABRES LA VENTANA ---
        private void FormOrdenes_Load(object sender, EventArgs e)
        {
            CargarDatosDePrueba(); // Llenamos el menú
            ConfigurarDiseño();    // Ponemos la tabla bonita
        }

        private void CargarDatosDePrueba()
        {
            // OJO ELIEZER: Aquí creamos platos falsos para que pruebes YA.
            // Cuando Gris te pase su base de datos, borras esto y conectas lo de ella.
            listaDePlatos.Add(new Plato("Hamburguesa Palmero", 15, "Carne", "Brutal"));
            listaDePlatos.Add(new Plato("Linguinis Especiales", 12, "Pasta", "Ricos"));
            listaDePlatos.Add(new Plato("Jugo Natural", 5, "Bebida", "Fresco"));
            listaDePlatos.Add(new Plato("Pizza Familiar", 20, "Pizza", "Grande"));

            // Metemos los platos al ComboBox
            cmbPlatos.DataSource = listaDePlatos;
            cmbPlatos.DisplayMember = "Nombre"; // Mostrar nombre
            cmbPlatos.ValueMember = "Precio";   // Guardar precio
        }

        private void ConfigurarDiseño()
        {
            // Limpiamos la tabla visualmente
            dgvPedido.BackgroundColor = Color.White;
            dgvPedido.RowHeadersVisible = false; // Sin columna gris fea
            dgvPedido.AllowUserToAddRows = false; // Sin fila vacía
            dgvPedido.ReadOnly = true;            // Que no editen a mano

            // Estilo de encabezado (Azul como Grisangelys)
            dgvPedido.EnableHeadersVisualStyles = false;
            dgvPedido.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvPedido.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPedido.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        // --- 3. BOTÓN AGREGAR (VERDE) ---


        // --- 4. ACTUALIZAR LA TABLA ---
        private void RefrescarTabla()
        {
            // Truco para que se actualice sola
            dgvPedido.DataSource = null;
            dgvPedido.DataSource = ticket;

            // --- AGREGA ESTAS LÍNEAS AQUÍ: ---
            // Esto oculta la columna 'Total' visualmente, aunque el cálculo sigue existiendo
            if (dgvPedido.Columns["Total"] != null)
            {
                dgvPedido.Columns["Total"].Visible = false;
            }
            // -------------------------------
        }
        // --- 5. BOTÓN FACTURAR (AMARILLO/AZUL) ---


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // A. Revisar que seleccionó algo
            Plato platoSeleccionado = (Plato)cmbPlatos.SelectedItem;
            if (platoSeleccionado == null) return;

            // B. Tomar la cantidad
            int cantidad = (int)numCantidad.Value;

            // C. Crear la línea del ticket
            DetalleOrden nuevaLinea = new DetalleOrden(
                platoSeleccionado.Nombre,
                cantidad,
                platoSeleccionado.Precio
            );

            // D. Guardar y refrescar tabla
            ticket.Add(nuevaLinea);
            RefrescarTabla();
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            if (ticket.Count == 0) return;

            MessageBox.Show($"¡Pedido Realizado!\nPor favor espere", "Factura");

            // Limpiar todo
            ticket.Clear();
            RefrescarTabla();
            numCantidad.Value = 1;
        }

       
    }
}