namespace Restaurant_PALMERO_proyecto_2.Modulo_Mesas
{
    partial class FormMesas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMesas));
            mesastxt = new PictureBox();
            MesaImg = new PictureBox();
            lblMesa1 = new Button();
            lblMesa2 = new Button();
            lblMesa3 = new Button();
            lblMesa4 = new Button();
            lblMesa5 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pedido = new GroupBox();
            pictureBox12 = new PictureBox();
            pictureBox11 = new PictureBox();
            numCantidad = new NumericUpDown();
            btnAgregarPlato = new Button();
            btnOcupar = new Button();
            cmbPlatos = new ComboBox();
            lblTotal = new Label();
            dgvPedido = new DataGridView();
            lblMesaSeleccionada = new Label();
            btnFacturar = new Button();
            ((System.ComponentModel.ISupportInitialize)mesastxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MesaImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            pedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            SuspendLayout();
            // 
            // mesastxt
            // 
            mesastxt.Enabled = false;
            mesastxt.Image = Properties.Resources.MesasTxt;
            mesastxt.Location = new Point(96, 25);
            mesastxt.Name = "mesastxt";
            mesastxt.Size = new Size(218, 88);
            mesastxt.SizeMode = PictureBoxSizeMode.Zoom;
            mesastxt.TabIndex = 0;
            mesastxt.TabStop = false;
            // 
            // MesaImg
            // 
            MesaImg.Image = Properties.Resources.mesadisponibleImg;
            MesaImg.Location = new Point(12, 12);
            MesaImg.Name = "MesaImg";
            MesaImg.Size = new Size(93, 114);
            MesaImg.SizeMode = PictureBoxSizeMode.Zoom;
            MesaImg.TabIndex = 13;
            MesaImg.TabStop = false;
            // 
            // lblMesa1
            // 
            lblMesa1.BackColor = Color.DarkSlateGray;
            lblMesa1.Cursor = Cursors.Hand;
            lblMesa1.FlatStyle = FlatStyle.Flat;
            lblMesa1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesa1.ForeColor = Color.White;
            lblMesa1.Location = new Point(71, 291);
            lblMesa1.Name = "lblMesa1";
            lblMesa1.Size = new Size(188, 54);
            lblMesa1.TabIndex = 14;
            lblMesa1.Text = "DISPONIBLE";
            lblMesa1.UseVisualStyleBackColor = false;
            lblMesa1.Click += lblMesa1_Click;
            // 
            // lblMesa2
            // 
            lblMesa2.BackColor = Color.DarkSlateGray;
            lblMesa2.Cursor = Cursors.Hand;
            lblMesa2.FlatStyle = FlatStyle.Flat;
            lblMesa2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesa2.ForeColor = Color.White;
            lblMesa2.Location = new Point(362, 291);
            lblMesa2.Name = "lblMesa2";
            lblMesa2.Size = new Size(188, 54);
            lblMesa2.TabIndex = 15;
            lblMesa2.Text = "DISPONIBLE";
            lblMesa2.UseVisualStyleBackColor = false;
            lblMesa2.Click += lblMesa2_Click;
            // 
            // lblMesa3
            // 
            lblMesa3.BackColor = Color.DarkSlateGray;
            lblMesa3.Cursor = Cursors.Hand;
            lblMesa3.FlatStyle = FlatStyle.Flat;
            lblMesa3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesa3.ForeColor = Color.White;
            lblMesa3.Location = new Point(659, 291);
            lblMesa3.Name = "lblMesa3";
            lblMesa3.Size = new Size(188, 54);
            lblMesa3.TabIndex = 16;
            lblMesa3.Text = "DISPONIBLE";
            lblMesa3.UseVisualStyleBackColor = false;
            lblMesa3.Click += lblMesa3_Click;
            // 
            // lblMesa4
            // 
            lblMesa4.BackColor = Color.DarkSlateGray;
            lblMesa4.Cursor = Cursors.Hand;
            lblMesa4.FlatStyle = FlatStyle.Flat;
            lblMesa4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesa4.ForeColor = Color.White;
            lblMesa4.Location = new Point(209, 521);
            lblMesa4.Name = "lblMesa4";
            lblMesa4.Size = new Size(188, 54);
            lblMesa4.TabIndex = 17;
            lblMesa4.Text = "DISPONIBLE";
            lblMesa4.UseVisualStyleBackColor = false;
            lblMesa4.Click += lblMesa4_Click;
            // 
            // lblMesa5
            // 
            lblMesa5.BackColor = Color.DarkSlateGray;
            lblMesa5.Cursor = Cursors.Hand;
            lblMesa5.FlatStyle = FlatStyle.Flat;
            lblMesa5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesa5.ForeColor = Color.White;
            lblMesa5.Location = new Point(502, 521);
            lblMesa5.Name = "lblMesa5";
            lblMesa5.Size = new Size(188, 54);
            lblMesa5.TabIndex = 18;
            lblMesa5.Text = "DISPONIBLE";
            lblMesa5.UseVisualStyleBackColor = false;
            lblMesa5.Click += lblMesa5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mesadisponibleImg;
            pictureBox1.Location = new Point(96, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.mesadisponibleImg;
            pictureBox2.Location = new Point(385, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.mesadisponibleImg;
            pictureBox3.Location = new Point(682, 169);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.mesadisponibleImg;
            pictureBox5.Location = new Point(528, 398);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(142, 126);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.mesadisponibleImg;
            pictureBox4.Location = new Point(233, 398);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(142, 126);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Enabled = false;
            pictureBox6.Image = Properties.Resources.Mesa1txt;
            pictureBox6.Location = new Point(116, 169);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(107, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Enabled = false;
            pictureBox7.Image = Properties.Resources.Mesa2txt;
            pictureBox7.Location = new Point(405, 169);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(107, 38);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Enabled = false;
            pictureBox8.Image = Properties.Resources.Mesa3txt;
            pictureBox8.Location = new Point(700, 169);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(107, 38);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 27;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Enabled = false;
            pictureBox9.Image = Properties.Resources.Mesa4txt;
            pictureBox9.Location = new Point(252, 398);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(107, 38);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 28;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Enabled = false;
            pictureBox10.Image = Properties.Resources.Mesa5txt;
            pictureBox10.Location = new Point(545, 398);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(107, 38);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 29;
            pictureBox10.TabStop = false;
            // 
            // pedido
            // 
            pedido.Controls.Add(pictureBox12);
            pedido.Controls.Add(pictureBox11);
            pedido.Controls.Add(numCantidad);
            pedido.Controls.Add(btnAgregarPlato);
            pedido.Controls.Add(btnOcupar);
            pedido.Controls.Add(cmbPlatos);
            pedido.Controls.Add(lblTotal);
            pedido.Controls.Add(dgvPedido);
            pedido.Controls.Add(lblMesaSeleccionada);
            pedido.FlatStyle = FlatStyle.Flat;
            pedido.Location = new Point(929, 55);
            pedido.Name = "pedido";
            pedido.Size = new Size(361, 552);
            pedido.TabIndex = 30;
            pedido.TabStop = false;
            pedido.Text = " ";
            // 
            // pictureBox12
            // 
            pictureBox12.Enabled = false;
            pictureBox12.Image = Properties.Resources.CantidadTxt;
            pictureBox12.Location = new Point(110, 375);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(164, 33);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 35;
            pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Enabled = false;
            pictureBox11.Image = Properties.Resources.SeleccionePlatoTxt;
            pictureBox11.Location = new Point(67, 295);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(241, 43);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 33;
            pictureBox11.TabStop = false;
            // 
            // numCantidad
            // 
            numCantidad.BackColor = Color.White;
            numCantidad.BorderStyle = BorderStyle.FixedSingle;
            numCantidad.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numCantidad.ForeColor = Color.Black;
            numCantidad.Location = new Point(163, 423);
            numCantidad.Margin = new Padding(3, 2, 3, 2);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(56, 26);
            numCantidad.TabIndex = 34;
            numCantidad.ValueChanged += numCantidad_ValueChanged;
            // 
            // btnAgregarPlato
            // 
            btnAgregarPlato.BackColor = Color.DarkSlateGray;
            btnAgregarPlato.BackgroundImage = Properties.Resources.logo_completo;
            btnAgregarPlato.Cursor = Cursors.Hand;
            btnAgregarPlato.FlatStyle = FlatStyle.Flat;
            btnAgregarPlato.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPlato.ForeColor = Color.White;
            btnAgregarPlato.Location = new Point(110, 466);
            btnAgregarPlato.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPlato.Name = "btnAgregarPlato";
            btnAgregarPlato.Size = new Size(164, 39);
            btnAgregarPlato.TabIndex = 31;
            btnAgregarPlato.Text = "AGREGAR PLATO";
            btnAgregarPlato.UseVisualStyleBackColor = false;
            btnAgregarPlato.Click += btnAgregarPlato_Click;
            // 
            // btnOcupar
            // 
            btnOcupar.BackColor = Color.DarkSlateGray;
            btnOcupar.Cursor = Cursors.Hand;
            btnOcupar.FlatStyle = FlatStyle.Flat;
            btnOcupar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOcupar.ForeColor = Color.White;
            btnOcupar.Location = new Point(212, 520);
            btnOcupar.Margin = new Padding(3, 2, 3, 2);
            btnOcupar.Name = "btnOcupar";
            btnOcupar.Size = new Size(143, 27);
            btnOcupar.TabIndex = 33;
            btnOcupar.Text = "OCUPAR MESA";
            btnOcupar.UseVisualStyleBackColor = false;
            btnOcupar.Visible = false;
            btnOcupar.Click += btnOcupar_Click;
            // 
            // cmbPlatos
            // 
            cmbPlatos.BackColor = Color.White;
            cmbPlatos.FlatStyle = FlatStyle.Popup;
            cmbPlatos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPlatos.ForeColor = Color.Black;
            cmbPlatos.FormattingEnabled = true;
            cmbPlatos.Location = new Point(135, 343);
            cmbPlatos.Margin = new Padding(3, 2, 3, 2);
            cmbPlatos.Name = "cmbPlatos";
            cmbPlatos.Size = new Size(106, 27);
            cmbPlatos.TabIndex = 33;
            cmbPlatos.SelectedIndexChanged += cmbPlatos_SelectedIndexChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.DarkSlateGray;
            lblTotal.Location = new Point(6, 523);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(166, 26);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "TOTAL: $ 0.00";
            // 
            // dgvPedido
            // 
            dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedido.BackgroundColor = Color.White;
            dgvPedido.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPedido.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPedido.EnableHeadersVisualStyles = false;
            dgvPedido.GridColor = Color.White;
            dgvPedido.Location = new Point(31, 58);
            dgvPedido.Margin = new Padding(3, 2, 3, 2);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersVisible = false;
            dgvPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedido.Size = new Size(300, 232);
            dgvPedido.TabIndex = 31;
            // 
            // lblMesaSeleccionada
            // 
            lblMesaSeleccionada.AutoSize = true;
            lblMesaSeleccionada.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesaSeleccionada.ForeColor = Color.DarkSlateGray;
            lblMesaSeleccionada.Location = new Point(31, 19);
            lblMesaSeleccionada.Name = "lblMesaSeleccionada";
            lblMesaSeleccionada.Size = new Size(299, 26);
            lblMesaSeleccionada.TabIndex = 31;
            lblMesaSeleccionada.Text = "SELECCIONE UNA MESA";
            // 
            // btnFacturar
            // 
            btnFacturar.BackColor = Color.DarkSlateGray;
            btnFacturar.Cursor = Cursors.Hand;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Location = new Point(1027, 625);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(188, 35);
            btnFacturar.TabIndex = 32;
            btnFacturar.Text = "FACTURAR";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // FormMesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1352, 672);
            Controls.Add(btnFacturar);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(lblMesa5);
            Controls.Add(lblMesa4);
            Controls.Add(lblMesa3);
            Controls.Add(lblMesa2);
            Controls.Add(lblMesa1);
            Controls.Add(MesaImg);
            Controls.Add(mesastxt);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pedido);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMesas";
            Text = "GESTION DE MESAS Y PEDIDOS";
            Load += FormMesas_Load;
            ((System.ComponentModel.ISupportInitialize)mesastxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)MesaImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            pedido.ResumeLayout(false);
            pedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mesastxt;
        private PictureBox MesaImg;
        private Button lblMesa1;
        private Button lblMesa2;
        private Button lblMesa3;
        private Button lblMesa4;
        private Button lblMesa5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private GroupBox pedido;
        private Label lblMesaSeleccionada;
        private DataGridView dgvPedido;
        private Label lblTotal;
        private Button btnAgregarPlato;
        private Button btnFacturar;
        private ComboBox cmbPlatos;
        private NumericUpDown numCantidad;
        private Button btnOcupar;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
    }
}