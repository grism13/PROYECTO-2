namespace Restaurant_PALMERO_proyecto_2.Modulo_Caja
{
    partial class FormCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaja));
            cmbPlatos = new ComboBox();
            numCantidad = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnAgregar = new Button();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            btnCobrar = new Button();
            CajaImg = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CajaImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbPlatos
            // 
            cmbPlatos.FormattingEnabled = true;
            cmbPlatos.Location = new Point(985, 375);
            cmbPlatos.Margin = new Padding(3, 2, 3, 2);
            cmbPlatos.Name = "cmbPlatos";
            cmbPlatos.Size = new Size(133, 23);
            cmbPlatos.TabIndex = 0;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(1080, 307);
            numCantidad.Margin = new Padding(3, 2, 3, 2);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(131, 23);
            numCantidad.TabIndex = 1;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(911, 244);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 22);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(994, 346);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 7;
            label2.Text = "Plato disponibles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1089, 276);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Cantidad deseada";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1184, 232);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: $0";
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(1145, 430);
            btnCobrar.Margin = new Padding(3, 2, 3, 2);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(122, 22);
            btnCobrar.TabIndex = 10;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click_1;
            // 
            // CajaImg
            // 
            CajaImg.Image = Properties.Resources.caja;
            CajaImg.Location = new Point(-18, -21);
            CajaImg.Name = "CajaImg";
            CajaImg.Size = new Size(197, 182);
            CajaImg.SizeMode = PictureBoxSizeMode.Zoom;
            CajaImg.TabIndex = 15;
            CajaImg.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CajaTxt;
            pictureBox1.Location = new Point(132, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 638);
            Controls.Add(pictureBox1);
            Controls.Add(CajaImg);
            Controls.Add(btnCobrar);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(numCantidad);
            Controls.Add(cmbPlatos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCaja";
            Text = "CAJA";
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)CajaImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPlatos;
        private NumericUpDown numCantidad;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnAgregar;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private Button btnCobrar;
        private PictureBox CajaImg;
        private PictureBox pictureBox1;
    }
}