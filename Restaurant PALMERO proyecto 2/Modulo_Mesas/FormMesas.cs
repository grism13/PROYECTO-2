using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel; // Necesario para las listas inteligentes
using System.Linq; // Necesario para buscar y sumar
using Restaurant_PALMERO_proyecto_2;                // Para ver Form1
using Restaurant_PALMERO_proyecto_2.Modulo_Menu;    // Para ver la clase Plato
using Restaurant_PALMERO_proyecto_2.Modulo_Ordenes; // Para ver DetalleOrden

namespace Restaurant_PALMERO_proyecto_2.Modulo_Mesas
{
    public partial class FormMesas : Form
    {

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

        //Edito esto
        private void FormMesas_Load(object sender, EventArgs e)
        {
            // 1. CONFIGURACIÓN VISUAL DE LA TABLA
            dgvPedido.DataSource = null;
            dgvPedido.Columns.Clear();

            dgvPedido.BackgroundColor = Color.White;
            dgvPedido.DefaultCellStyle.BackColor = Color.White;
            dgvPedido.DefaultCellStyle.ForeColor = Color.Black;
            dgvPedido.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
            dgvPedido.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPedido.RowHeadersVisible = false;
            dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. CARGAR EL MENÚ EN EL COMBOBOX
            if (cmbPlatos != null)
            {
                cmbPlatos.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbPlatos.DataSource = null;
                cmbPlatos.DataSource = Form1.MenuGlobal;
                cmbPlatos.DisplayMember = "Nombre";
                cmbPlatos.ValueMember = "Precio";
                cmbPlatos.SelectedIndex = -1;
            }

            // 3. RECUPERAR COLORES (MESAS OCUPADAS)
            foreach (var item in Form1.MesaOcupada)
            {
                int numeroMesa = item.Key;
                bool estaOcupada = item.Value;

                if (estaOcupada && botonesMesas.ContainsKey(numeroMesa))
                {
                    botonesMesas[numeroMesa].BackColor = Color.DarkRed;
                    botonesMesas[numeroMesa].Text = "EN ESPERA";
                }
            }

            // 4. Estos son mensajes para los pedidos listos

            if (Form1.PedidosListosParaServir.Count > 0)
            {
                string mensajeAlerta = "🔔 ¡PEDIDOS LISTOS PARA ENTREGAR!\n\n";

                // Usamos .ToList() para evitar errores al modificar la lista
                foreach (Factura f in Form1.PedidosListosParaServir.ToList())
                {
                    mensajeAlerta += $"✅ MESA {f.NumeroMesa}\n";
                    mensajeAlerta += "--------------------------------\n";

                    // Detalle de platos
                    foreach (var plato in f.PlatosComprados)
                    {
                        mensajeAlerta += $"   • {plato.Cantidad} x {plato.Producto} (${plato.Precio})\n";
                    }

                    mensajeAlerta += "--------------------------------\n";
                    mensajeAlerta += $"💰 TOTAL A COBRAR: ${f.Total}\n\n";

                    // LIBERAR LA MESA
                    int numMesa = f.NumeroMesa;

                    if (pedidosPorMesa.ContainsKey(numMesa)) pedidosPorMesa[numMesa].Clear();
                    if (Form1.MesaOcupada.ContainsKey(numMesa)) Form1.MesaOcupada[numMesa] = false;

                    if (botonesMesas.ContainsKey(numMesa))
                    {
                        botonesMesas[numMesa].BackColor = Color.DarkSlateGray;
                        botonesMesas[numMesa].Text = "DISPONIBLE";
                    }

                    // Borramos la factura del buzón porque ya la vimos
                    Form1.PedidosListosParaServir.Remove(f);
                }

                MessageBox.Show(mensajeAlerta, "Cocina Informa");
            }


            foreach (var item in Form1.MesaOcupada)
            {
                int numeroMesa = item.Key;
                bool estaOcupada = item.Value;

                // Si la memoria dice que está ocupada (TRUE), la pintamos de ROJO
                if (estaOcupada == true)
                {
                    if (botonesMesas.ContainsKey(numeroMesa))
                    {
                        botonesMesas[numeroMesa].BackColor = Color.DarkRed; 
                        botonesMesas[numeroMesa].Text = "EN ESPERA";        
                    }
                }

            }
        }


        // --- LÓGICA DE AGREGAR PLATO ---
        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (mesaActual == 0) { MessageBox.Show("Seleccione una mesa."); return; }
            if (cmbPlatos.SelectedItem == null) { MessageBox.Show("Seleccione un plato."); return; }

            // 1. OBTENER EL PLATO SELECCIONADO (Ahora es un Objeto, no solo texto)
            Plato platoSeleccionado = (Plato)cmbPlatos.SelectedItem;

            // 2. Extraer datos directamente del objeto
            string nombrePlato = platoSeleccionado.Nombre;
            decimal precioPlato = platoSeleccionado.Precio; // ¡El precio viene automático!
            int cantidad = (int)numCantidad.Value;

            // 3. Buscar si ya existe en la mesa (Lógica de suma)
            var pedidoExistente = pedidosPorMesa[mesaActual].FirstOrDefault(p => p.Plato == nombrePlato);

            if (pedidoExistente != null)
            {
                pedidoExistente.Cantidad += cantidad;
                pedidosPorMesa[mesaActual].ResetBindings();
            }
            else
            {
                pedidosPorMesa[mesaActual].Add(new DetallePedido
                {
                    Cantidad = cantidad,
                    Plato = nombrePlato,
                    Precio = precioPlato
                });
            }

            CalcularTotalPantalla();
        }

        // --- SELECCIONAR MESA ---
        private void SeleccionarMesa(int numeroMesa)
        {
            // 1. Guardar qué mesa estamos tocando
            mesaActual = numeroMesa;
            lblMesaSeleccionada.Text = "MESA " + numeroMesa;

            // 2. SIEMPRE MOSTRAR EL PANEL (Para ver qué pidieron o para pedir nuevo)
            MostrarPanelDerecho();

            // 3. CARGAR LA LISTA DE PLATOS (Si está vacía, mostrará tabla vacía)
            if (pedidosPorMesa.ContainsKey(mesaActual))
            {
                dgvPedido.DataSource = pedidosPorMesa[mesaActual];
            }

            // 4. Calcular Total Visual
            CalcularTotalPantalla();

            // 5. ¡AQUÍ ESTÁ LA CLAVE! APLICAR EL CANDADO DE SEGURIDAD
            BloquearBotonSiEstaOcupada();
        }

        // --- BOTÓN FACTURAR ---

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (mesaActual == 0) return;
            if (pedidosPorMesa[mesaActual].Count == 0)
            {
                MessageBox.Show("No hay pedidos para enviar a cocina.");
                return;
            }

            decimal totalCalculado = 0;
            foreach (var item in pedidosPorMesa[mesaActual]) totalCalculado += item.Total;

            List<Restaurant_PALMERO_proyecto_2.Modulo_Ordenes.DetalleOrden> listaParaGuardar = new List<Restaurant_PALMERO_proyecto_2.Modulo_Ordenes.DetalleOrden>();
            foreach (var item in pedidosPorMesa[mesaActual])
            {
                listaParaGuardar.Add(new Restaurant_PALMERO_proyecto_2.Modulo_Ordenes.DetalleOrden(item.Plato, item.Cantidad, item.Precio));
            }

            // Se guarda en el inicio
            Factura nuevaFactura = new Factura(mesaActual, totalCalculado, listaParaGuardar);
            Form1.HistorialFacturas.Add(nuevaFactura);

            
            Form1.MesaOcupada[mesaActual] = true; 

            // Visualmente la dejamos ROJA (Ocupada)
            if (botonesMesas.ContainsKey(mesaActual))
            {
                botonesMesas[mesaActual].BackColor = Color.DarkRed; // O el color de ocupado que uses
                botonesMesas[mesaActual].Text = "EN ESPERA"; // Cambio de texto opcional
            }

            // --- CAMBIO 3: ¡NO BORRAMOS NADA! (Comentamos la limpieza) ---
            // pedidosPorMesa[mesaActual].Clear();  <-- NO BORRAR AÚN
            // mesaActual = 0;                      <-- NO SOLTAR LA MESA


            OcultarPanelDerecho();
            lblMesaSeleccionada.Text = "SELECCIONE UNA MESA";
            mesaActual = 0; // Soltamos la selección, pero la mesa sigue llena en memoria

            // 4. MENSAJE FINAL
            MessageBox.Show("Su pedido ha sido creado con éxito y enviado a cocina.", "Pedido Creado");
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
    

    // Esta funcion se usa para bloquear los botones, cada vez que se necesite bloquear es llaada la funcion
        private void BloquearBotonSiEstaOcupada()
        {
            // 1. Consultar a la memoria suprema (Form1)
            bool estaOcupada = false;
            if (Form1.MesaOcupada.ContainsKey(mesaActual))
            {
                estaOcupada = Form1.MesaOcupada[mesaActual];
            }

            // 2. Aplicar bloqueo según el estado
            if (estaOcupada == true)
            {
                // --- MESA OCUPADA (MODO LECTURA) ---
                if (btnFacturar != null)
                {
                    btnFacturar.Enabled = false;             
                    btnFacturar.Text = "EN ESPERA...";       
                    btnFacturar.BackColor = Color.Gray;      
                }

                // Bloquear controles de agregar
                if (btnAgregarPlato != null) btnAgregarPlato.Enabled = false;
                if (cmbPlatos != null) cmbPlatos.Enabled = false;
                if (numCantidad != null) numCantidad.Enabled = false;
            }
            else
            {
                // --- MESA LIBRE (MODO EDICIÓN) ---
                if (btnFacturar != null)
                {
                    btnFacturar.Enabled = true;              // Desbloqueado
                    btnFacturar.Text = "CREAR PEDIDO";       
                    btnFacturar.BackColor = Color.SeaGreen;  // Tu color verde
                }

                // Reactivar controles
                if (btnAgregarPlato != null) btnAgregarPlato.Enabled = true;
                if (cmbPlatos != null) cmbPlatos.Enabled = true;
                if (numCantidad != null) numCantidad.Enabled = true;
            }
        }

        // --- FUNCIÓN RECUPERADA: BOTÓN OCUPAR (Para corregir error de diseño) ---
        private void btnOcupar_Click(object sender, EventArgs e)
        {
            // Aunque ya no lo uses mucho, el diseñador lo busca.
            // Si quieres que funcione manualmente:
            if (mesaActual == 0) return;

            if (botonesMesas.ContainsKey(mesaActual))
            {
                // Solo cambio visual manual
                botonesMesas[mesaActual].Text = "OCUPADA";
                botonesMesas[mesaActual].BackColor = Color.Firebrick;
            }
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
}

