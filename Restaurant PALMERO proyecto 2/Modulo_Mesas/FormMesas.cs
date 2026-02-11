using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel; // Necesario para las listas inteligentes
using System.Linq; // Necesario para buscar y sumar

namespace Restaurant_PALMERO_proyecto_2.Modulo_Mesas
{
    public partial class FormMesas : Form
    {
        // --- 1. MEMORIA DEL SISTEMA ---
        int mesaActual = 0;

        // Usamos BindingList para que la tabla se actualice sola
        Dictionary<int, BindingList<DetallePedido>> pedidosPorMesa = new Dictionary<int, BindingList<DetallePedido>>();

        // Mapa para ubicar los botones de las mesas
        Dictionary<int, Button> botonesMesas = new Dictionary<int, Button>();

        public FormMesas()
        {
            InitializeComponent();

            // Inicializamos las 5 mesas vacías
            for (int i = 1; i <= 5; i++)
            {
                pedidosPorMesa.Add(i, new BindingList<DetallePedido>());
            }

            // Conectamos los botones (Protegido por si cambias nombres en el diseño)
            try
            {
                // Asegúrate que en el diseño tus botones se llamen así:
                botonesMesas.Add(1, lblMesa1);
                botonesMesas.Add(2, lblMesa2);
                botonesMesas.Add(3, lblMesa3);
                botonesMesas.Add(4, lblMesa4);
                botonesMesas.Add(5, lblMesa5);
            }
            catch { }
        }

        private void FormMesas_Load(object sender, EventArgs e)
        {
            // --- 2. CONFIGURACIÓN VISUAL DE LA TABLA (Anti-Errores) ---
            dgvPedido.DataSource = null;
            dgvPedido.Columns.Clear();

            // Estilo Visual: Letra Negra sobre Fondo Blanco
            dgvPedido.BackgroundColor = Color.White;
            dgvPedido.DefaultCellStyle.BackColor = Color.White;
            dgvPedido.DefaultCellStyle.ForeColor = Color.Black;
            dgvPedido.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
            dgvPedido.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvPedido.RowHeadersVisible = false;
            dgvPedido.AutoGenerateColumns = true;
            dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- 3. CARGAR EL MENÚ ---
            if (cmbPlatos != null)
            {
                cmbPlatos.DropDownStyle = ComboBoxStyle.DropDownList; // Bloquear escritura
                cmbPlatos.Items.Clear();
                cmbPlatos.Items.Add("Linguinis con langostinos");
                cmbPlatos.Items.Add("Degustación de mejillones");
                cmbPlatos.Items.Add("Quesillo");
                cmbPlatos.Items.Add("Jugo de Parchita");
                cmbPlatos.SelectedIndex = -1; // Sin selección inicial
            }

            // --- 4. INICIO LIMPIO ---
            OcultarPanelDerecho();
            if (lblMesaSeleccionada != null) lblMesaSeleccionada.Text = "SELECCIONE UNA MESA";
        }

        // --- LÓGICA DE AGREGAR PLATO ---
        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            if (mesaActual == 0) { MessageBox.Show("Seleccione una mesa."); return; }
            if (cmbPlatos.SelectedIndex == -1) { MessageBox.Show("Seleccione un plato."); return; }

            string plato = cmbPlatos.Text;
            int cantidad = (int)numCantidad.Value;
            decimal precio = ObtenerPrecio(plato);

            // Buscar si ya existe para sumar
            var pedidoExistente = pedidosPorMesa[mesaActual].FirstOrDefault(p => p.Plato == plato);

            if (pedidoExistente != null)
            {
                pedidoExistente.Cantidad += cantidad;
                pedidosPorMesa[mesaActual].ResetBindings(); // Actualizar tabla
            }
            else
            {
                pedidosPorMesa[mesaActual].Add(new DetallePedido
                {
                    Cantidad = cantidad,
                    Plato = plato,
                    Precio = precio
                });
            }

            CalcularTotalPantalla();
        }

        // --- SELECCIONAR MESA ---
        private void SeleccionarMesa(int numeroMesa)
        {
            mesaActual = numeroMesa;
            lblMesaSeleccionada.Text = "MESA " + numeroMesa;

            Button botonMesa = botonesMesas.ContainsKey(numeroMesa) ? botonesMesas[numeroMesa] : null;

            if (botonMesa != null && botonMesa.Text == "OCUPADA")
            {
                // MESA OCUPADA: MOSTRAR TODO
                MostrarPanelDerecho();
                dgvPedido.DataSource = pedidosPorMesa[mesaActual];
                CalcularTotalPantalla();
            }
            else
            {
                // MESA DISPONIBLE: SOLO MOSTRAR BOTÓN OCUPAR
                OcultarPanelDerecho();
                if (btnOcupar != null) btnOcupar.Visible = true;
                dgvPedido.DataSource = null;
            }
        }

        // --- BOTÓN OCUPAR (VERDE) ---
        private void btnOcupar_Click(object sender, EventArgs e)
        {
            if (mesaActual == 0) return;

            if (botonesMesas.ContainsKey(mesaActual))
            {
                botonesMesas[mesaActual].Text = "OCUPADA";
                botonesMesas[mesaActual].BackColor = Color.Firebrick;
            }
            SeleccionarMesa(mesaActual);
        }

        // --- BOTÓN FACTURAR ---
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (mesaActual == 0) return;

            if (MessageBox.Show("¿Facturar y liberar mesa?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pedidosPorMesa[mesaActual].Clear();

                if (botonesMesas.ContainsKey(mesaActual))
                {
                    botonesMesas[mesaActual].Text = "DISPONIBLE";
                    botonesMesas[mesaActual].BackColor = Color.DarkSlateGray;
                }
                SeleccionarMesa(mesaActual);
            }
        }

        // --- AUXILIARES ---
        private void CalcularTotalPantalla()
        {
            decimal total = 0;
            foreach (var item in pedidosPorMesa[mesaActual])
            {
                total += item.Total;
            }
            if (lblTotal != null) lblTotal.Text = "TOTAL: $" + total.ToString("N2");
        }

        private decimal ObtenerPrecio(string plato)
        {
            switch (plato)
            {
                case "Linguinis con langostinos": return 15m;
                case "Degustación de mejillones": return 12m;
                case "Quesillo": return 4m;
                case "Jugo de Parchita": return 3m;
                default: return 0m;
            }
        }

        private void OcultarPanelDerecho()
        {
            if (btnOcupar != null) btnOcupar.Visible = false;
            if (cmbPlatos != null) cmbPlatos.Visible = false;
            if (numCantidad != null) numCantidad.Visible = false;
            if (btnAgregarPlato != null) btnAgregarPlato.Visible = false;
            if (dgvPedido != null) dgvPedido.Visible = false;
            if (lblTotal != null) lblTotal.Visible = false;
            if (btnFacturar != null) btnFacturar.Visible = false;
        }

        private void MostrarPanelDerecho()
        {
            if (btnOcupar != null) btnOcupar.Visible = false;
            if (cmbPlatos != null) cmbPlatos.Visible = true;
            if (numCantidad != null) numCantidad.Visible = true;
            if (btnAgregarPlato != null) btnAgregarPlato.Visible = true;
            if (dgvPedido != null) dgvPedido.Visible = true;
            if (lblTotal != null) lblTotal.Visible = true;
            if (btnFacturar != null) btnFacturar.Visible = true;
        }

        // --- EVENTOS CLICK DE LAS MESAS ---
        private void lblMesa1_Click(object sender, EventArgs e) { SeleccionarMesa(1); }
        private void lblMesa2_Click(object sender, EventArgs e) { SeleccionarMesa(2); }
        private void lblMesa3_Click(object sender, EventArgs e) { SeleccionarMesa(3); }
        private void lblMesa4_Click(object sender, EventArgs e) { SeleccionarMesa(4); }
        private void lblMesa5_Click(object sender, EventArgs e) { SeleccionarMesa(5); }

        // Eventos vacíos para evitar errores del diseñador
        private void cmbPlatos_SelectedIndexChanged(object sender, EventArgs e) { }
        private void numCantidad_ValueChanged(object sender, EventArgs e) { }
    }

    // --- CLASE DE DATOS CONFIGURADA ---
    public class DetallePedido
    {
        [DisplayName("Cant")]
        public int Cantidad { get; set; }

        [DisplayName("Plato")]
        public string Plato { get; set; }

        [DisplayName("Precio ($)")]
        public decimal Precio { get; set; }

        [DisplayName("Total ($)")]
        public decimal Total
        {
            get { return Cantidad * Precio; }
        }
    }
}