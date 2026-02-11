using Restaurant_PALMERO_proyecto_2.Modulo_Menu;
using System.Collections.Generic;


namespace Restaurant_PALMERO_proyecto_2
{
    public partial class Form1 : Form
    {

        //Aqui añado parte del codigo para guardar los platos en el sistema

        public static List<Plato> MenuGlobal = new List<Plato>();

        //Aqui se añade parte de codigo para facturas


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
            Modulo_Mesas.btnAbrirMesa ventanaMesas = new Modulo_Mesas.btnAbrirMesa();
            ventanaMesas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ordenesbtn_Click(object sender, EventArgs e)
        {
            Modulo_Ordenes.FormOrdenes ventanaOrdenes = new Modulo_Ordenes.FormOrdenes();
            ventanaOrdenes.ShowDialog();
        }

        private void cajabtn_Click(object sender, EventArgs e)
        {
            Modulo_Caja.FormCaja ventanaCaja = new Modulo_Caja.FormCaja();
            ventanaCaja.ShowDialog();
        }

        //Odio c#  (Eliezer)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Esto lo que hace es que si menuGlobal esta vacio lo llena de los platos ya existentes
            if (MenuGlobal.Count == 0)
            {
                MenuGlobal.Add(new Plato("Linguinis con langostinos", 15m, "Plato fuerte", "Pasta con salsa."));
                MenuGlobal.Add(new Plato("Degustación de mejillones", 12m, "Entrada", "Frescos."));
                MenuGlobal.Add(new Plato("Quesillo", 4m, "Postre", "Dulce casero."));
                MenuGlobal.Add(new Plato("Jugo de Parchita", 3m, "Bebida", "Natural."));
            }

            //Esto es para las mesas

            

        }

    }
 }

