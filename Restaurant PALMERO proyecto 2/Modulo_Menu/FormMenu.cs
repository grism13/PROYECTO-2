using System;
using System.Collections.Generic; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_PALMERO_proyecto_2.Modulo_Menu
{
    public partial class FormMenu : Form
    {
        List<Plato> listaPlatos = new List<Plato>();
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
            Plato p1 = new Plato("Linguinis con langostinos", 15m, "Plato fuerte", "Pasta al dente coronada con langostinos frescos salteados.", null);

            // Plato 2: La Entrada
            Plato p2 = new Plato("Degustación de mejillones", 12m, "Entrada", "Selección de mejillones frescos.", null);

            // Plato 3: El Postre
            Plato p3 = new Plato("Quesillo", 4m, "Postre", "El clásico postre venezolano.", null);

            // Plato 4: La Bebida
            Plato p4 = new Plato("Jugo de Parchita", 3m, "Bebida", "Bebida natural concentrada", null);

            // --- 3. GUARDADO EN LA LISTA (MEMORIA) ---
            listaPlatos.Add(p1);
            listaPlatos.Add(p2);
            listaPlatos.Add(p3);
            listaPlatos.Add(p4);

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


        

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
