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
            factura = new Label();
            lblTotalPagar = new Label();
            btnPagar = new Button();
            lstVentasDia = new ListBox();
            lblTotalDia = new Label();
            btnCierreCaja = new Button();
            ((System.ComponentModel.ISupportInitialize)CajaImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).BeginInit();
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
            CajaImg.Location = new Point(1116, 2);
            CajaImg.Name = "CajaImg";
            CajaImg.Size = new Size(197, 182);
            CajaImg.SizeMode = PictureBoxSizeMode.Zoom;
            CajaImg.TabIndex = 15;
            CajaImg.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CajaTxt;
            pictureBox1.Location = new Point(921, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dgvCaja
            // 
            dgvCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaja.BackgroundColor = Color.White;
            dgvCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaja.Location = new Point(43, 74);
            dgvCaja.Margin = new Padding(3, 2, 3, 2);
            dgvCaja.Name = "dgvCaja";
            dgvCaja.ReadOnly = true;
            dgvCaja.RowHeadersVisible = false;
            dgvCaja.RowHeadersWidth = 51;
            dgvCaja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaja.Size = new Size(680, 480);
            dgvCaja.TabIndex = 17;
            dgvCaja.CellClick += dgvCaja_CellClick;
            // 
            // factura
            // 
            factura.AutoSize = true;
            factura.Font = new Font("Segoe UI", 18F);
            factura.Location = new Point(52, 26);
            factura.Name = "factura";
            factura.Size = new Size(126, 32);
            factura.TabIndex = 18;
            factura.Text = "FACTURAS";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 15F);
            lblTotalPagar.ForeColor = Color.SeaGreen;
            lblTotalPagar.Location = new Point(576, 23);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(123, 28);
            lblTotalPagar.TabIndex = 19;
            lblTotalPagar.Text = "TOTAL: $0.00";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkGreen;
            btnPagar.Font = new Font("Segoe UI", 20F);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(745, 413);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(389, 150);
            btnPagar.TabIndex = 20;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lstVentasDia
            // 
            lstVentasDia.FormattingEnabled = true;
            lstVentasDia.Location = new Point(930, 269);
            lstVentasDia.Name = "lstVentasDia";
            lstVentasDia.Size = new Size(309, 124);
            lstVentasDia.TabIndex = 21;
            // 
            // lblTotalDia
            // 
            lblTotalDia.AutoSize = true;
            lblTotalDia.Location = new Point(1252, 381);
            lblTotalDia.Name = "lblTotalDia";
            lblTotalDia.Size = new Size(65, 15);
            lblTotalDia.TabIndex = 22;
            lblTotalDia.Text = "Cerrar Caja";
            // 
            // btnCierreCaja
            // 
            btnCierreCaja.Location = new Point(1140, 413);
            btnCierreCaja.Name = "btnCierreCaja";
            btnCierreCaja.Size = new Size(211, 150);
            btnCierreCaja.TabIndex = 23;
            btnCierreCaja.Text = "CERRAR CAJA";
            btnCierreCaja.UseVisualStyleBackColor = true;
            btnCierreCaja.Click += button1_Click;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 638);
            Controls.Add(btnCierreCaja);
            Controls.Add(lblTotalDia);
            Controls.Add(lstVentasDia);
            Controls.Add(btnPagar);
            Controls.Add(lblTotalPagar);
            Controls.Add(factura);
            Controls.Add(dgvCaja);
            Controls.Add(pictureBox1);
            Controls.Add(CajaImg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCaja";
            Text = "CAJA";
            Load += FormCaja_Load;
            ((System.ComponentModel.ISupportInitialize)CajaImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox CajaImg;
        private PictureBox pictureBox1;
        private DataGridView dgvCaja;
        private Label factura;
        private Label lblTotalPagar;
        private Button btnPagar;
        private ListBox lstVentasDia;
        private Label lblTotalDia;
        private Button btnCierreCaja;
    }
}