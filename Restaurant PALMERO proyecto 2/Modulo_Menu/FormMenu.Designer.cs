namespace Restaurant_PALMERO_proyecto_2.Modulo_Menu
{
    partial class FormMenu
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
            MenuImg = new PictureBox();
            MenuTxt = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtPrecio = new TextBox();
            dolarimg = new PictureBox();
            btnSubirFoto = new Button();
            ReferenciaImg = new PictureBox();
            CamaraImg = new PictureBox();
            pictureBox2 = new PictureBox();
            txIngredientes = new TextBox();
            DescripcionTxt = new PictureBox();
            cmbCategoria = new ComboBox();
            CategoriaTxt = new PictureBox();
            PrecioTxt = new PictureBox();
            txtNombre = new TextBox();
            NombreTxt = new PictureBox();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvPlatos = new DataGridView();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaPrecio = new DataGridViewTextBoxColumn();
            ColumnaCategoría = new DataGridViewTextBoxColumn();
            ColumnaDescripción = new DataGridViewTextBoxColumn();
            textoenelmenu = new Label();
            txtBuscar = new TextBox();
            LupaImg = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MenuImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MenuTxt).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dolarimg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReferenciaImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CamaraImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DescripcionTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoriaTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrecioTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NombreTxt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LupaImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuImg
            // 
            MenuImg.BackColor = Color.Transparent;
            MenuImg.Image = Properties.Resources.menu;
            MenuImg.Location = new Point(-3, -35);
            MenuImg.Name = "MenuImg";
            MenuImg.Size = new Size(192, 189);
            MenuImg.SizeMode = PictureBoxSizeMode.Zoom;
            MenuImg.TabIndex = 0;
            MenuImg.TabStop = false;
            // 
            // MenuTxt
            // 
            MenuTxt.BackColor = Color.Transparent;
            MenuTxt.Image = Properties.Resources.MenuTxt;
            MenuTxt.Location = new Point(126, 12);
            MenuTxt.Name = "MenuTxt";
            MenuTxt.Size = new Size(155, 102);
            MenuTxt.SizeMode = PictureBoxSizeMode.Zoom;
            MenuTxt.TabIndex = 1;
            MenuTxt.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.BackgroundImage = Properties.Resources.logo_completo;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(873, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 598);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(dolarimg);
            panel2.Controls.Add(btnSubirFoto);
            panel2.Controls.Add(ReferenciaImg);
            panel2.Controls.Add(CamaraImg);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txIngredientes);
            panel2.Controls.Add(DescripcionTxt);
            panel2.Controls.Add(cmbCategoria);
            panel2.Controls.Add(CategoriaTxt);
            panel2.Controls.Add(PrecioTxt);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(NombreTxt);
            panel2.Location = new Point(18, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 553);
            panel2.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Cursor = Cursors.IBeam;
            txtPrecio.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(46, 141);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(212, 39);
            txtPrecio.TabIndex = 4;
            // 
            // dolarimg
            // 
            dolarimg.BackColor = Color.Transparent;
            dolarimg.Image = Properties.Resources.DolarImg;
            dolarimg.Location = new Point(236, 132);
            dolarimg.Name = "dolarimg";
            dolarimg.Size = new Size(81, 57);
            dolarimg.SizeMode = PictureBoxSizeMode.Zoom;
            dolarimg.TabIndex = 3;
            dolarimg.TabStop = false;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.BackColor = Color.Transparent;
            btnSubirFoto.BackgroundImage = Properties.Resources.logo_completo;
            btnSubirFoto.FlatAppearance.BorderSize = 0;
            btnSubirFoto.FlatStyle = FlatStyle.Flat;
            btnSubirFoto.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirFoto.ForeColor = Color.White;
            btnSubirFoto.Location = new Point(56, 493);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(122, 31);
            btnSubirFoto.TabIndex = 3;
            btnSubirFoto.Text = "SUBIR FOTO";
            btnSubirFoto.UseVisualStyleBackColor = false;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // ReferenciaImg
            // 
            ReferenciaImg.BackColor = Color.Transparent;
            ReferenciaImg.BorderStyle = BorderStyle.FixedSingle;
            ReferenciaImg.Location = new Point(211, 444);
            ReferenciaImg.Name = "ReferenciaImg";
            ReferenciaImg.Size = new Size(125, 95);
            ReferenciaImg.TabIndex = 3;
            ReferenciaImg.TabStop = false;
            ReferenciaImg.Click += pictureBox1_Click;
            // 
            // CamaraImg
            // 
            CamaraImg.Image = Properties.Resources.CamaraImg1;
            CamaraImg.Location = new Point(-15, 466);
            CamaraImg.Name = "CamaraImg";
            CamaraImg.Size = new Size(110, 87);
            CamaraImg.SizeMode = PictureBoxSizeMode.Zoom;
            CamaraImg.TabIndex = 3;
            CamaraImg.TabStop = false;
            CamaraImg.Click += pictureBox3_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ReferenciaTxt;
            pictureBox2.Location = new Point(24, 421);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // txIngredientes
            // 
            txIngredientes.BackColor = Color.White;
            txIngredientes.BorderStyle = BorderStyle.FixedSingle;
            txIngredientes.Cursor = Cursors.IBeam;
            txIngredientes.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txIngredientes.ForeColor = Color.Black;
            txIngredientes.Location = new Point(46, 337);
            txIngredientes.Multiline = true;
            txIngredientes.Name = "txIngredientes";
            txIngredientes.Size = new Size(262, 78);
            txIngredientes.TabIndex = 5;
            txIngredientes.TextChanged += txIngredientes_TextChanged;
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.Image = Properties.Resources.DescripcionTxt;
            DescripcionTxt.Location = new Point(17, 287);
            DescripcionTxt.Name = "DescripcionTxt";
            DescripcionTxt.Size = new Size(203, 69);
            DescripcionTxt.SizeMode = PictureBoxSizeMode.Zoom;
            DescripcionTxt.TabIndex = 9;
            DescripcionTxt.TabStop = false;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.Cursor = Cursors.Hand;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.ForeColor = Color.Black;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(46, 244);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(262, 25);
            cmbCategoria.TabIndex = 3;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // CategoriaTxt
            // 
            CategoriaTxt.Image = Properties.Resources.CategoriaTxt;
            CategoriaTxt.Location = new Point(3, 195);
            CategoriaTxt.Name = "CategoriaTxt";
            CategoriaTxt.Size = new Size(217, 63);
            CategoriaTxt.SizeMode = PictureBoxSizeMode.Zoom;
            CategoriaTxt.TabIndex = 8;
            CategoriaTxt.TabStop = false;
            // 
            // PrecioTxt
            // 
            PrecioTxt.Image = Properties.Resources.PrecioTxt;
            PrecioTxt.Location = new Point(-9, 104);
            PrecioTxt.Name = "PrecioTxt";
            PrecioTxt.Size = new Size(198, 42);
            PrecioTxt.SizeMode = PictureBoxSizeMode.Zoom;
            PrecioTxt.TabIndex = 7;
            PrecioTxt.TabStop = false;
            PrecioTxt.Click += pictureBox3_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(46, 51);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(262, 38);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // NombreTxt
            // 
            NombreTxt.Image = Properties.Resources.NombreTxt;
            NombreTxt.Location = new Point(3, 3);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(189, 61);
            NombreTxt.SizeMode = PictureBoxSizeMode.Zoom;
            NombreTxt.TabIndex = 6;
            NombreTxt.TabStop = false;
            NombreTxt.Click += NombreTxt_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BackgroundImage = Properties.Resources.logo_completo;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(808, 632);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(172, 27);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkSlateGray;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(986, 632);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 27);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(64, 0, 0);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1164, 632);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(172, 27);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvPlatos
            // 
            dgvPlatos.AllowUserToAddRows = false;
            dgvPlatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlatos.BackgroundColor = Color.White;
            dgvPlatos.BorderStyle = BorderStyle.None;
            dgvPlatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPlatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaNombre, ColumnaPrecio, ColumnaCategoría, ColumnaDescripción });
            dgvPlatos.EnableHeadersVisualStyles = false;
            dgvPlatos.Location = new Point(17, 124);
            dgvPlatos.MultiSelect = false;
            dgvPlatos.Name = "dgvPlatos";
            dgvPlatos.ReadOnly = true;
            dgvPlatos.RowHeadersVisible = false;
            dgvPlatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlatos.Size = new Size(785, 535);
            dgvPlatos.TabIndex = 14;
            dgvPlatos.CellContentClick += dgvPlatos_CellContentClick;
            // 
            // ColumnaNombre
            // 
            ColumnaNombre.HeaderText = "NOMBRE";
            ColumnaNombre.Name = "ColumnaNombre";
            ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaPrecio
            // 
            ColumnaPrecio.HeaderText = "PRECIO";
            ColumnaPrecio.Name = "ColumnaPrecio";
            ColumnaPrecio.ReadOnly = true;
            // 
            // ColumnaCategoría
            // 
            ColumnaCategoría.HeaderText = "CATEGORIA";
            ColumnaCategoría.Name = "ColumnaCategoría";
            ColumnaCategoría.ReadOnly = true;
            // 
            // ColumnaDescripción
            // 
            ColumnaDescripción.HeaderText = "DESCRIPCION";
            ColumnaDescripción.Name = "ColumnaDescripción";
            ColumnaDescripción.ReadOnly = true;
            // 
            // textoenelmenu
            // 
            textoenelmenu.AutoSize = true;
            textoenelmenu.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textoenelmenu.ForeColor = Color.SlateGray;
            textoenelmenu.Location = new Point(287, 49);
            textoenelmenu.Name = "textoenelmenu";
            textoenelmenu.Size = new Size(350, 17);
            textoenelmenu.TabIndex = 15;
            textoenelmenu.Text = "Administra los platillos del menu, agrega, edita y eliminalos";
            textoenelmenu.Click += label1_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.WhiteSmoke;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Cursor = Cursors.IBeam;
            txtBuscar.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(493, 93);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(274, 25);
            txtBuscar.TabIndex = 16;
            // 
            // LupaImg
            // 
            LupaImg.Image = Properties.Resources.LupaImg;
            LupaImg.Location = new Point(763, 79);
            LupaImg.Name = "LupaImg";
            LupaImg.Size = new Size(51, 50);
            LupaImg.SizeMode = PictureBoxSizeMode.Zoom;
            LupaImg.TabIndex = 17;
            LupaImg.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BuscarTxt;
            pictureBox1.Location = new Point(409, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1348, 671);
            Controls.Add(txtBuscar);
            Controls.Add(textoenelmenu);
            Controls.Add(dgvPlatos);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(MenuTxt);
            Controls.Add(panel1);
            Controls.Add(MenuImg);
            Controls.Add(LupaImg);
            Controls.Add(pictureBox1);
            Name = "FormMenu";
            Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)MenuImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)MenuTxt).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dolarimg).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReferenciaImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)CamaraImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DescripcionTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoriaTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrecioTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)NombreTxt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)LupaImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MenuImg;
        private PictureBox MenuTxt;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtNombre;
        private ComboBox cmbCategoria;
        private TextBox txtPrecio;
        private TextBox txIngredientes;
        private PictureBox ReferenciaImg;
        private PictureBox PrecioTxt;
        private PictureBox NombreTxt;
        private PictureBox DescripcionTxt;
        private PictureBox CategoriaTxt;
        private PictureBox pictureBox2;
        private Button btnSubirFoto;
        private PictureBox CamaraImg;
        private PictureBox dolarimg;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvPlatos;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaPrecio;
        private DataGridViewTextBoxColumn ColumnaCategoría;
        private DataGridViewTextBoxColumn ColumnaDescripción;
        private Label textoenelmenu;
        private TextBox txtBuscar;
        private PictureBox LupaImg;
        private PictureBox pictureBox1;
    }
}