using System;
using System.Collections.Generic;  // Para las Listas
using System.ComponentModel;       // Para BindingList (CRUCIAL para que la tabla se mueva)
using System.Data;                 // Para manejo de datos general
using System.Drawing;              // Para Colores y Fuentes
using System.Linq;                 // Para ordenar y filtrar
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;        // Para Ventanas, Botones y DataGridView
using Restaurant_PALMERO_proyecto_2; // Para ver Form1 y Factura (IMPORTANTE)


namespace Restaurant_PALMERO_proyecto_2.Modulo_Caja
{

    public partial class FormCaja : Form
    {
        // Variable para recordar cuál fila seleccionaste
        Factura facturaSeleccionada = null;

        public FormCaja()
        {
            InitializeComponent();
        }


        // --- FUNCIÓN PARA CARGAR/REFRESCAR LA TABLA (TIPO EXCEL) ---
        private void CargarFacturasPendientes()
        {
            // 1. Desconectar para limpiar
            dgvCaja.DataSource = null;

            // 2. Conectar de nuevo a la lista maestra
            dgvCaja.DataSource = Form1.HistorialFacturas;

            // 3. Ajustes visuales (solo si hay datos, para evitar errores)
            if (dgvCaja.Columns.Count > 0)
            {
                // Ocultar columnas internas feas
                if (dgvCaja.Columns["PlatosComprados"] != null)
                    dgvCaja.Columns["PlatosComprados"].Visible = false;

                // Ocultar la columna de estado de cocina (si la agregaste antes)
                if (dgvCaja.Columns["EnCocina"] != null)
                    dgvCaja.Columns["EnCocina"].Visible = false;

                // Poner la columna Total al final y darle formato de dinero
                if (dgvCaja.Columns["Total"] != null)
                {
                    dgvCaja.Columns["Total"].DisplayIndex = dgvCaja.Columns.Count - 1;
                    dgvCaja.Columns["Total"].DefaultCellStyle.Format = "C2"; // Formato $
                }
            }

            lblTotalPagar.Text = "Seleccione una factura";
            btnPagar.Enabled = false;
        }

        // --- AL HACER CLIC EN UNA FILA ---
        private void dgvCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evitar click en cabecera

            // 1. Obtenemos la factura seleccionada de la lista maestra
            // Como el DataGrid está vinculado a HistorialFacturas, el índice es el mismo
            facturaSeleccionada = Form1.HistorialFacturas[e.RowIndex];

            // 2. Mostramos el total en grande
            lblTotalPagar.Text = $"TOTAL A PAGAR: ${facturaSeleccionada.Total:N2}";

            // 3. Habilitamos el botón de pagar
            btnPagar.Enabled = true;
        }



        private void FormCaja_Load(object sender, EventArgs e)
        {
            dgvCaja.AutoGenerateColumns = true;
            int cantidad = Form1.HistorialFacturas.Count;

            //Aqui se guradan los datos en el excel que no es excel
            BindingSource fuenteDatos = new BindingSource();
            fuenteDatos.DataSource = Form1.HistorialFacturas;
            dgvCaja.DataSource = fuenteDatos;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // 1. Verificar si hay algo seleccionado
            if (facturaSeleccionada == null)
            {
                MessageBox.Show("Seleccione una factura primero.", "Error");
                return;
            }

            // Verifica si la comida sigue en el formOrdenes (en cocina)
            if (facturaSeleccionada.EnCocina == true)
            {
                MessageBox.Show("Por normativas de la empresa, no se permite pagar antes de recibir su comida.",
                                "Pago No Permitido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Aqui seguimos con el pago de forma normal
            DialogResult respuesta = MessageBox.Show(
                $"¿Confirmar pago de la MESA {facturaSeleccionada.NumeroMesa} por ${facturaSeleccionada.Total:N2}?",
                "Procesar Pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // A. Borrar de la lista maestra (Desaparece de Caja y de todo el sistema)
                Form1.HistorialFacturas.Remove(facturaSeleccionada);

                // B. Asegurar que la mesa quede libre en memoria
                if (Form1.MesaOcupada.ContainsKey(facturaSeleccionada.NumeroMesa))
                {
                    Form1.MesaOcupada[facturaSeleccionada.NumeroMesa] = false;
                }

                // C. Refrescar la tabla para que se vea que ya no está
                // (Como usas BindingList, esto se hace casi solo, pero por seguridad:)
                dgvCaja.Refresh();

                // Limpiamos la selección
                lblTotalPagar.Text = "Seleccione una factura";
                facturaSeleccionada = null;
                btnPagar.Enabled = false;

                MessageBox.Show("¡Pago registrado! La factura ha sido cerrada.", "Éxito");
            }
        }
    }
}