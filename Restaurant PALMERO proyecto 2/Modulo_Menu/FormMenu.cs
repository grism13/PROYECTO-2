using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_PALMERO_proyecto_2.Modulo_Menu
{
    public partial class FormMenu : Form
    {

        public static List<Plato> listaPlatos = new List<Plato>();
        public FormMenu()
        {
            InitializeComponent();

        }
        private void FormMenu_Load(object sender, EventArgs e)

        {
            EstilizarTabla();
            // --- 1. CONFIGURACIÓN VISUAL DE LA TABLA ---
            dgvPlatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlatos.AutoGenerateColumns = false;

            // --- 2. CREACIÓN DE LOS OBJETOS (LOS PLATOS) ---

            // Plato 1: El Fuerte
            Plato p1 = new Plato("Linguinis con langostinos", 15m, "Plato fuerte", "Pasta al dente bañada en una suave salsa de vino blanco y ajo, coronada con langostinos frescos salteados.");

            // Plato 2: La Entrada
            Plato p2 = new Plato("Degustación de mejillones", 12m, "Entrada", "Selección de mejillones frescos preparados con la receta especial de la casa, toques cítricos y especias.");

            // Plato 3: El Postre
            Plato p3 = new Plato("Quesillo", 4m, "Postre", "El clásico postre venezolano: cremoso, suave y bañado en su inconfundible caramelo oscuro artesanal.");

            // Plato 4: La Bebida
            Plato p4 = new Plato("Jugo de Parchita", 3m, "Bebida", "Bebida natural concentrada, dulce y refrescante, servida con abundante hielo para el calor.");

            // --- 3. GUARDADO EN LA LISTA (MEMORIA) ---
            listaPlatos.Add(p1);
            listaPlatos.Add(p2);
            listaPlatos.Add(p3);
            listaPlatos.Add(p4);

            listaPlatos = listaPlatos.OrderBy(x => x.Categoria).ThenBy(x => x.Nombre).ToList();

            // --- 4. MOSTRAR EN PANTALLA ---
            dgvPlatos.DataSource = null;        // Limpiamos la conexión anterior
            dgvPlatos.DataSource = listaPlatos; // Conectamos la lista nueva


        }
        private void EstilizarTabla()
        {
            // 1. Fondo general y bordes
            dgvPlatos.BackgroundColor = Color.White; // El fondo gris/negro se va
            dgvPlatos.BorderStyle = BorderStyle.None; // Quitamos el borde feo 3D
            dgvPlatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Líneas sutiles

            // 2. Cabecera (Títulos: NOMBRE, PRECIO...)
            dgvPlatos.EnableHeadersVisualStyles = false; // ¡IMPORTANTE! Sin esto no cambian los colores
            dgvPlatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 60); // Un azul oscuro elegante (o el color que gustes)
            dgvPlatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Letras blancas
            dgvPlatos.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold); // Fuente moderna
            dgvPlatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centrados
            dgvPlatos.ColumnHeadersHeight = 35; // Un poco más altos para que respiren

            // 3. Filas (Los datos)
            dgvPlatos.DefaultCellStyle.BackColor = Color.White;
            dgvPlatos.DefaultCellStyle.ForeColor = Color.Black;
            dgvPlatos.DefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            dgvPlatos.DefaultCellStyle.SelectionBackColor = Color.SlateGray; // Color al seleccionar
            dgvPlatos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPlatos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 4. Quitar la columna gris fea de la izquierda
            dgvPlatos.RowHeadersVisible = false;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // 1. VALIDAR PRECIO (Esto ya lo tenías)
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número.", "Error");
                return;
            }



            // "Busca si existe ALGÚN (Any) plato cuyo nombre sea igual al que escribí"
            bool existe = listaPlatos.Any(x => x.Nombre.ToLower() == txtNombre.Text.ToLower());

            if (existe == true)
            {
                MessageBox.Show("¡Cuidado! Ya existe un plato con ese nombre.", "Duplicado");
                return; // SE DETIENE AQUÍ. No guarda nada.
            }
            // ---------------------------------------------------------

            // 2. CREAR EL PLATO (Si pasó el filtro anterior)
            string nombre = txtNombre.Text;
            string categoria = cmbCategoria.Text;
            string descripcion = txtDescripcion.Text;

            Plato nuevoPlato = new Plato(nombre, precio, categoria, descripcion);

            // 3. GUARDAR Y REFRESCAR
            listaPlatos.Add(nuevoPlato);


            // Esto agrupa las categorías (Ej. Todas las "Bebidas" juntas)
            listaPlatos = listaPlatos.OrderBy(x => x.Categoria).ThenBy(x => x.Nombre).ToList();

            // 4. REFRESCAR LA TABLA
            dgvPlatos.DataSource = null;
            dgvPlatos.DataSource = listaPlatos;


            // 4. LIMPIAR
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("¡Plato guardado!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Evita editar fila vacía
            if (dgvPlatos.CurrentRow == null || dgvPlatos.CurrentRow.DataBoundItem == null) return;

            // Obtiene el plato real (Truco Pro)
            Plato platoEdit = (Plato)dgvPlatos.CurrentRow.DataBoundItem;

            // Valida que el precio sea número
            decimal precioFinal;
            if (!decimal.TryParse(txtPrecio.Text, out precioFinal))
            {
                MessageBox.Show("¡El precio debe ser número!");
                return;
            }

            // Asigna valores desde los controles correctos
            platoEdit.Nombre = txtNombre.Text;
            platoEdit.Precio = precioFinal;
            platoEdit.Categoria = cmbCategoria.Text;
            platoEdit.Descripcion = txtDescripcion.Text;

            // Refresca la tabla
            dgvPlatos.DataSource = null;
            dgvPlatos.DataSource = listaPlatos;

            // Limpia las cajas
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("¡Plato editado!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Valida si hay selección
            if (dgvPlatos.CurrentRow == null) return;

            // Pregunta antes de borrar
            if (MessageBox.Show("¿Borrar plato?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Borra plato de memoria
                int indice = dgvPlatos.CurrentRow.Index;
                listaPlatos.RemoveAt(indice);

                // Actualiza la vista
                dgvPlatos.DataSource = null;
                dgvPlatos.DataSource = listaPlatos;

                // Limpia todo
                txtNombre.Clear();
                txtPrecio.Clear();
                txtDescripcion.Clear();
                cmbCategoria.SelectedIndex = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Borra el texto de las cajas
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();

            // 2. Quita la selección de la categoría
            cmbCategoria.SelectedIndex = -1;

            // 3. Quita el resaltado azul de la tabla (Visualmente suelta el plato)
            dgvPlatos.ClearSelection();

            // 4. Pone el cursor en el Nombre para escribir rápido
            txtNombre.Focus();
        }

        private void dgvPlatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                // Agarrar el plato directamente de la fila (funciona perfecto con el buscador)
                Plato platoSeleccionado = (Plato)dgvPlatos.Rows[e.RowIndex].DataBoundItem;

                //  Pasar los datos a las cajitas
                txtNombre.Text = platoSeleccionado.Nombre;
                txtPrecio.Text = platoSeleccionado.Precio.ToString(); // Convierte numero a texto
                cmbCategoria.Text = platoSeleccionado.Categoria;
                txtDescripcion.Text = platoSeleccionado.Descripcion;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // 1. Guardamos lo que escribiste (y lo pasamos a minúsculas para que no importen las mayúsculas)
            string busqueda = txtBuscar.Text.ToLower();

            // 2. FILTRO MÁGICO (LINQ)
            // "De la lista completa, fíltrame (Where) aquellos platos cuyo NOMBRE contenga lo que escribí
            //  O (||) cuya CATEGORÍA contenga lo que escribí".
            var listaFiltrada = listaPlatos.Where(x =>
                                                  x.Nombre.ToLower().Contains(busqueda) ||
                                                  x.Categoria.ToLower().Contains(busqueda)
                                                  ).ToList();

            // 3. Actualizamos la tabla visualmente
            dgvPlatos.DataSource = null;
            dgvPlatos.DataSource = listaFiltrada;
        }

        //Aqui trato de no caer en la locura (Eliezer) 

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // SE ve si no existen los datos y se agregan a inicio en esta parte
            foreach (var platoLocal in listaPlatos)
            {
                // Verificamos si ya existe un plato con ese nombre en el Form1
                bool yaExiste = Form1.MenuGlobal.Any(p => p.Nombre == platoLocal.Nombre);

                // Si NO existe, lo agregamos (así evitamos duplicados)
                if (yaExiste == false)
                {
                    Form1.MenuGlobal.Add(platoLocal);
                }
            }
        }
    }
}