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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            MenuImg = new PictureBox();
            MenuTxt = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtPrecio = new TextBox();
            dolarimg = new PictureBox();
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
            MenuImg.Location = new Point(-18, -51);
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
            MenuTxt.Location = new Point(107, -1);
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
            panel1.Size = new Size(396, 507);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(dolarimg);
            panel2.Controls.Add(txIngredientes);
            panel2.Controls.Add(DescripcionTxt);
            panel2.Controls.Add(cmbCategoria);
            panel2.Controls.Add(CategoriaTxt);
            panel2.Controls.Add(PrecioTxt);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(NombreTxt);
            panel2.Location = new Point(18, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 469);
            panel2.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Cursor = Cursors.IBeam;
            txtPrecio.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(55, 158);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(212, 39);
            txtPrecio.TabIndex = 4;
            // 
            // dolarimg
            // 
            dolarimg.BackColor = Color.Transparent;
            dolarimg.Image = Properties.Resources.DolarImg;
            dolarimg.Location = new Point(245, 149);
            dolarimg.Name = "dolarimg";
            dolarimg.Size = new Size(81, 57);
            dolarimg.SizeMode = PictureBoxSizeMode.Zoom;
            dolarimg.TabIndex = 3;
            dolarimg.TabStop = false;
            // 
            // txIngredientes
            // 
            txIngredientes.BackColor = Color.White;
            txIngredientes.BorderStyle = BorderStyle.FixedSingle;
            txIngredientes.Cursor = Cursors.IBeam;
            txIngredientes.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txIngredientes.ForeColor = Color.Black;
            txIngredientes.Location = new Point(55, 354);
            txIngredientes.Multiline = true;
            txIngredientes.Name = "txIngredientes";
            txIngredientes.Size = new Size(262, 78);
            txIngredientes.TabIndex = 5;
            // 
            // DescripcionTxt
            // 
            DescripcionTxt.Image = Properties.Resources.DescripcionTxt;
            DescripcionTxt.Location = new Point(26, 304);
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
            cmbCategoria.Items.AddRange(new object[] { "Entrada", "Plato fuerte", "Postre", "Bebida" });
            cmbCategoria.Location = new Point(55, 261);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(262, 25);
            cmbCategoria.TabIndex = 3;
            // 
            // CategoriaTxt
            // 
            CategoriaTxt.Image = Properties.Resources.CategoriaTxt;
            CategoriaTxt.Location = new Point(12, 212);
            CategoriaTxt.Name = "CategoriaTxt";
            CategoriaTxt.Size = new Size(217, 63);
            CategoriaTxt.SizeMode = PictureBoxSizeMode.Zoom;
            CategoriaTxt.TabIndex = 8;
            CategoriaTxt.TabStop = false;
            // 
            // PrecioTxt
            // 
            PrecioTxt.Image = Properties.Resources.PrecioTxt;
            PrecioTxt.Location = new Point(0, 121);
            PrecioTxt.Name = "PrecioTxt";
            PrecioTxt.Size = new Size(198, 42);
            PrecioTxt.SizeMode = PictureBoxSizeMode.Zoom;
            PrecioTxt.TabIndex = 7;
            PrecioTxt.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(55, 68);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(262, 38);
            txtNombre.TabIndex = 3;
            // 
            // NombreTxt
            // 
            NombreTxt.Image = Properties.Resources.NombreTxt;
            NombreTxt.Location = new Point(12, 20);
            NombreTxt.Name = "NombreTxt";
            NombreTxt.Size = new Size(189, 61);
            NombreTxt.SizeMode = PictureBoxSizeMode.Zoom;
            NombreTxt.TabIndex = 6;
            NombreTxt.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BackgroundImage = Properties.Resources.logo_completo;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(820, 560);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(172, 46);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkSlateGray;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(998, 560);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 46);
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
            btnEliminar.Location = new Point(1176, 560);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(172, 46);
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
            dgvPlatos.RowTemplate.Height = 45;
            dgvPlatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlatos.Size = new Size(785, 535);
            dgvPlatos.TabIndex = 14;
            // 
            // ColumnaNombre
            // 
            ColumnaNombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnaNombre.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnaNombre.HeaderText = "NOMBRE";
            ColumnaNombre.Name = "ColumnaNombre";
            ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaPrecio
            // 
            ColumnaPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnaPrecio.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnaPrecio.HeaderText = "PRECIO";
            ColumnaPrecio.Name = "ColumnaPrecio";
            ColumnaPrecio.ReadOnly = true;
            // 
            // ColumnaCategoría
            // 
            ColumnaCategoría.DataPropertyName = "Categoria";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnaCategoría.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnaCategoría.HeaderText = "CATEGORIA";
            ColumnaCategoría.Name = "ColumnaCategoría";
            ColumnaCategoría.ReadOnly = true;
            // 
            // ColumnaDescripción
            // 
            ColumnaDescripción.DataPropertyName = "Descripcion";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            ColumnaDescripción.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnaDescripción.HeaderText = "DESCRIPCION";
            ColumnaDescripción.Name = "ColumnaDescripción";
            ColumnaDescripción.ReadOnly = true;
            // 
            // textoenelmenu
            // 
            textoenelmenu.AutoSize = true;
            textoenelmenu.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textoenelmenu.ForeColor = Color.SlateGray;
            textoenelmenu.Location = new Point(32, 93);
            textoenelmenu.Name = "textoenelmenu";
            textoenelmenu.Size = new Size(350, 17);
            textoenelmenu.TabIndex = 15;
            textoenelmenu.Text = "Administra los platillos del menu, agrega, edita y eliminalos";
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
            LupaImg.Location = new Point(762, 78);
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
            Load += FormMenu_Load;
            ((System.ComponentModel.ISupportInitialize)MenuImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)MenuTxt).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dolarimg).EndInit();
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
        private PictureBox PrecioTxt;
        private PictureBox NombreTxt;
        private PictureBox DescripcionTxt;
        private PictureBox CategoriaTxt;
        private PictureBox dolarimg;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvPlatos;
        private Label textoenelmenu;
        private TextBox txtBuscar;
        private PictureBox LupaImg;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaPrecio;
        private DataGridViewTextBoxColumn ColumnaCategoría;
        private DataGridViewTextBoxColumn ColumnaDescripción;
    }
}