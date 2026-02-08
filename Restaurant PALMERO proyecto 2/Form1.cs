namespace Restaurant_PALMERO_proyecto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            // Creamos una copia nueva del formulario
            Modulo_Menu.FormMenu ventanaMenu = new Modulo_Menu.FormMenu();

            // La mostramos al usuario
            ventanaMenu.ShowDialog();
        }

        private void mesasbtn_Click(object sender, EventArgs e)
        {
            // Abrimos el gestor de mesas
            Modulo_Mesas.FormMesas ventanaMesas = new Modulo_Mesas.FormMesas();
            ventanaMesas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
