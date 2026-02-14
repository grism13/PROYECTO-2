using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Restaurant_PALMERO_proyecto_2;

namespace Restaurant_PALMERO_proyecto_2.Modulo_Caja
{
    public partial class FormCaja : Form
    {
        // Variable para recordar cuál fila seleccionaste
        Factura facturaSeleccionada = null;

        // --- MAGIA NUEVA: LA CAJA FUERTE ---
        public static List<Factura> VentasDelDia = new List<Factura>();
        public static decimal TotalAcumulado = 0;
        // -----------------------------------

        public FormCaja()
        {
            InitializeComponent();
        }

        private void CargarFacturasPendientes()
        {
            dgvCaja.DataSource = null;
            dgvCaja.DataSource = Form1.HistorialFacturas;

            if (dgvCaja.Columns.Count > 0)
            {
                if (dgvCaja.Columns["PlatosComprados"] != null)
                    dgvCaja.Columns["PlatosComprados"].Visible = false;

                if (dgvCaja.Columns["EnCocina"] != null)
                    dgvCaja.Columns["EnCocina"].Visible = false;

                if (dgvCaja.Columns["Total"] != null)
                {
                    dgvCaja.Columns["Total"].DisplayIndex = dgvCaja.Columns.Count - 1;
                    dgvCaja.Columns["Total"].DefaultCellStyle.Format = "C2";
                }
            }

            lblTotalPagar.Text = "Seleccione una factura";
            btnPagar.Enabled = false;
        }

        private void dgvCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            facturaSeleccionada = Form1.HistorialFacturas[e.RowIndex];
            lblTotalPagar.Text = $"TOTAL A PAGAR: ${facturaSeleccionada.Total:N2}";
            btnPagar.Enabled = true;
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            dgvCaja.AutoGenerateColumns = true;
            BindingSource fuenteDatos = new BindingSource();
            fuenteDatos.DataSource = Form1.HistorialFacturas;
            dgvCaja.DataSource = fuenteDatos;

            // MAGIA NUEVA: Cargar el historial al abrir la ventana
            RefrescarHistorial();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (facturaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una factura primero.", "Error");
                return;
            }

            if (facturaSeleccionada.EnCocina == true)
            {
                MessageBox.Show("Por normativas de la empresa, no se permite pagar antes de recibir su comida.",
                                "Pago No Permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Confirmar pago de la MESA {facturaSeleccionada.NumeroMesa} por ${facturaSeleccionada.Total:N2}?",
                "Procesar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // --- MAGIA NUEVA: Guardar en el historial antes de borrar ---
                VentasDelDia.Add(facturaSeleccionada);
                TotalAcumulado += facturaSeleccionada.Total;
                RefrescarHistorial();
                // ------------------------------------------------------------

                Form1.HistorialFacturas.Remove(facturaSeleccionada);

                if (Form1.MesaOcupada.ContainsKey(facturaSeleccionada.NumeroMesa))
                {
                    Form1.MesaOcupada[facturaSeleccionada.NumeroMesa] = false;
                }

                // Usamos la función de Eliezer para que la tabla se actualice bien
                CargarFacturasPendientes();

                facturaSeleccionada = null;
                MessageBox.Show("¡Pago registrado! La factura ha sido cerrada.", "Éxito");
            }
        }

        // --- MAGIA NUEVA: Función para actualizar la lista derecha y el total ---
        private void RefrescarHistorial()
        {
            lstVentasDia.Items.Clear();
            foreach (Factura v in VentasDelDia)
            {
                lstVentasDia.Items.Add($"Mesa {v.NumeroMesa} - Pagado: ${v.Total:N2}");
            }
            lblTotalDia.Text = $"TOTAL: ${TotalAcumulado:N2}";
        }

        // --- MAGIA NUEVA: Botón de Cierre de Caja ---
        private void btnCierreCaja_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Verificamos si hay ventas registradas antes de intentar cerrar, Grisangelis Maria
            if (VentasDelDia.Count == 0)
            {
                MessageBox.Show("No hay ventas registradas en este momento para hacer un cierre de caja, Grisangelis Maria.", "Caja Vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Armamos el mensaje detallado con el total vendido en todo el día, Grisangelis Maria
            string reporte = $"=== REPORTE FINAL DEL DÍA ===\n\n";
            reporte += $"Mesas procesadas: {VentasDelDia.Count}\n";
            reporte += $"TOTAL VENDIDO: $ {TotalAcumulado:N2}\n\n";
            reporte += "¿Estás segura de que deseas cerrar la caja, Grisangelis Maria? Al confirmar, se borrará todo el historial de la pantalla para empezar un nuevo turno.";

            // 3. Mostramos la ventana y esperamos la respuesta (Sí o No)
            DialogResult confirmacion = MessageBox.Show(reporte, "Confirmar Cierre de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // 4. Si la respuesta es SÍ, ejecutamos la limpieza total, Grisangelis Maria
            if (confirmacion == DialogResult.Yes)
            {
                // A. Vaciamos la lista de la memoria
                VentasDelDia.Clear();

                // B. Ponemos el contador de dinero en cero
                TotalAcumulado = 0;

                // C. Llamamos a la función que refresca la pantalla para que quede en blanco
                RefrescarHistorial();

                // Mensaje final de éxito
                MessageBox.Show("¡Caja cerrada y limpiada exitosamente, Grisangelis Maria! El sistema está listo para un nuevo día.", "Cierre Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IstVentasDia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}