using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_PALMERO_proyecto_2.Modulo_Mesas
{
    public partial class FormMesas : Form
    {
        public FormMesas()
        {
            InitializeComponent();
        }

        private void lblMesa1_Click(object sender, EventArgs e)
        {

            // Preguntamos: ¿Qué color tiene ahorita?
            if (lblMesa1.Text == "DISPONIBLE")
            {
                // SI ESTÁ LIBRE -> LA OCUPAMOS
                lblMesa1.Text = "OCUPADA";
                lblMesa1.BackColor = Color.Firebrick; // Rojo intenso
            }
            else
            {
                // SI YA ESTABA OCUPADA -> LA LIBERAMOS
                lblMesa1.Text = "DISPONIBLE";
                lblMesa1.BackColor = Color.DarkSlateGray; // Tu verde original (o el color que usaste)
            }
        }

        private void lblMesa2_Click(object sender, EventArgs e)
        {
            // Preguntamos: ¿Qué color tiene ahorita?
            if (lblMesa2.Text == "DISPONIBLE")
            {
                // SI ESTÁ LIBRE -> LA OCUPAMOS
                lblMesa2.Text = "OCUPADA";
                lblMesa2.BackColor = Color.Firebrick; // Rojo intenso
            }
            else
            {
                // SI YA ESTABA OCUPADA -> LA LIBERAMOS
                lblMesa2.Text = "DISPONIBLE";
                lblMesa2.BackColor = Color.DarkSlateGray; // Tu verde original (o el color que usaste)
            }
        }

        private void lblMesa3_Click(object sender, EventArgs e)
        {
            // Preguntamos: ¿Qué color tiene ahorita?
            if (lblMesa3.Text == "DISPONIBLE")
            {
                // SI ESTÁ LIBRE -> LA OCUPAMOS
                lblMesa3.Text = "OCUPADA";
                lblMesa3.BackColor = Color.Firebrick; // Rojo intenso
            }
            else
            {
                // SI YA ESTABA OCUPADA -> LA LIBERAMOS
                lblMesa3.Text = "DISPONIBLE";
                lblMesa3.BackColor = Color.DarkSlateGray; // Tu verde original (o el color que usaste)
            }
        }

        private void lblMesa4_Click(object sender, EventArgs e)
        {
            // Preguntamos: ¿Qué color tiene ahorita?
            if (lblMesa4.Text == "DISPONIBLE")
            {
                // SI ESTÁ LIBRE -> LA OCUPAMOS
                lblMesa4.Text = "OCUPADA";
                lblMesa4.BackColor = Color.Firebrick; // Rojo intenso
            }
            else
            {
                // SI YA ESTABA OCUPADA -> LA LIBERAMOS
                lblMesa4.Text = "DISPONIBLE";
                lblMesa4.BackColor = Color.DarkSlateGray; // Tu verde original (o el color que usaste)
            }
        }

        private void lblMesa5_Click(object sender, EventArgs e)
        {
            // Preguntamos: ¿Qué color tiene ahorita?
            if (lblMesa5.Text == "DISPONIBLE")
            {
                // SI ESTÁ LIBRE -> LA OCUPAMOS
                lblMesa5.Text = "OCUPADA";
                lblMesa5.BackColor = Color.Firebrick; // Rojo intenso
            }
            else
            {
                // SI YA ESTABA OCUPADA -> LA LIBERAMOS
                lblMesa5.Text = "DISPONIBLE";
                lblMesa5.BackColor = Color.DarkSlateGray; // Tu verde original (o el color que usaste)
            }
        }

        
    }

}
