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
            contextMenuStrip1 = new ContextMenuStrip(components);
            CajaImg = new PictureBox();
            pictureBox1 = new PictureBox();
            dgvCaja = new DataGridView();
            lblTotalPagar = new Label();
            btnPagar = new Button();
            pictureBox2 = new PictureBox();
            porpagar = new GroupBox();
            groupBox1 = new GroupBox();
            lblTotalDia = new Label();
            pictureBox3 = new PictureBox();
            lstVentasDia = new ListBox();
            btnCierreCaja = new Button();
            ((System.ComponentModel.ISupportInitialize)CajaImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            porpagar.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // CajaImg
            // 
            CajaImg.Image = Properties.Resources.caja;
            CajaImg.Location = new Point(-23, -35);
            CajaImg.Name = "CajaImg";
            CajaImg.Size = new Size(197, 182);
            CajaImg.SizeMode = PictureBoxSizeMode.Zoom;
            CajaImg.TabIndex = 15;
            CajaImg.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CajaTxt;
            pictureBox1.Location = new Point(130, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dgvCaja
            // 
            dgvCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaja.BackgroundColor = Color.White;
            dgvCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaja.Location = new Point(54, 108);
            dgvCaja.Margin = new Padding(3, 2, 3, 2);
            dgvCaja.Name = "dgvCaja";
            dgvCaja.ReadOnly = true;
            dgvCaja.RowHeadersVisible = false;
            dgvCaja.RowHeadersWidth = 51;
            dgvCaja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaja.Size = new Size(335, 268);
            dgvCaja.TabIndex = 17;
            dgvCaja.CellClick += dgvCaja_CellClick;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPagar.ForeColor = Color.DarkSlateGray;
            lblTotalPagar.Location = new Point(54, 378);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(130, 22);
            lblTotalPagar.TabIndex = 19;
            lblTotalPagar.Text = "TOTAL: $0.00";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkSlateGray;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(125, 417);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(182, 35);
            btnPagar.TabIndex = 20;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PedidosTxt;
            pictureBox2.Location = new Point(114, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // porpagar
            // 
            porpagar.Controls.Add(dgvCaja);
            porpagar.Controls.Add(btnPagar);
            porpagar.Controls.Add(lblTotalPagar);
            porpagar.Controls.Add(pictureBox2);
            porpagar.FlatStyle = FlatStyle.Flat;
            porpagar.Location = new Point(71, 159);
            porpagar.Name = "porpagar";
            porpagar.Size = new Size(455, 467);
            porpagar.TabIndex = 22;
            porpagar.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalDia);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(lstVentasDia);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(668, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(666, 467);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // lblTotalDia
            // 
            lblTotalDia.AutoSize = true;
            lblTotalDia.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDia.ForeColor = Color.DarkSlateGray;
            lblTotalDia.Location = new Point(322, 380);
            lblTotalDia.Name = "lblTotalDia";
            lblTotalDia.Size = new Size(55, 22);
            lblTotalDia.TabIndex = 2;
            lblTotalDia.Text = "0.00$";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.totalapagarTxt;
            pictureBox3.Location = new Point(270, 310);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(160, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // lstVentasDia
            // 
            lstVentasDia.FormattingEnabled = true;
            lstVentasDia.Location = new Point(87, 56);
            lstVentasDia.Name = "lstVentasDia";
            lstVentasDia.Size = new Size(516, 229);
            lstVentasDia.TabIndex = 0;
            lstVentasDia.SelectedIndexChanged += IstVentasDia_SelectedIndexChanged;
            // 
            // btnCierreCaja
            // 
            btnCierreCaja.BackColor = Color.Maroon;
            btnCierreCaja.FlatStyle = FlatStyle.Flat;
            btnCierreCaja.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCierreCaja.ForeColor = Color.White;
            btnCierreCaja.Location = new Point(916, 512);
            btnCierreCaja.Name = "btnCierreCaja";
            btnCierreCaja.Size = new Size(182, 34);
            btnCierreCaja.TabIndex = 24;
            btnCierreCaja.Text = "CERRAR CAJA";
            btnCierreCaja.UseVisualStyleBackColor = false;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1364, 638);
            Controls.Add(btnCierreCaja);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(CajaImg);
            Controls.Add(porpagar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCaja";
            Text = "CAJA";
            WindowState = FormWindowState.Minimized;
            Load += FormCaja_Load;
            ((System.ComponentModel.ISupportInitialize)CajaImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            porpagar.ResumeLayout(false);
            porpagar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox CajaImg;
        private PictureBox pictureBox1;
        private DataGridView dgvCaja;
        private Label lblTotalPagar;
        private Button btnPagar;
        private PictureBox pictureBox2;
        private GroupBox porpagar;
        private GroupBox groupBox1;
        private ListBox lstVentasDia;
        private Label lblTotalDia;
        private PictureBox pictureBox3;
        private Button btnCierreCaja;
    }
}