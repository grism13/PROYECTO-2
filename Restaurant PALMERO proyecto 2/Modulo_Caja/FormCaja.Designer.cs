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
            CajaImg.Location = new Point(1275, 2);
            CajaImg.Margin = new Padding(3, 4, 3, 4);
            CajaImg.Name = "CajaImg";
            CajaImg.Size = new Size(225, 243);
            CajaImg.SizeMode = PictureBoxSizeMode.Zoom;
            CajaImg.TabIndex = 15;
            CajaImg.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CajaTxt;
            pictureBox1.Location = new Point(1053, 31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dgvCaja
            // 
            dgvCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaja.BackgroundColor = Color.White;
            dgvCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaja.Location = new Point(49, 99);
            dgvCaja.Name = "dgvCaja";
            dgvCaja.ReadOnly = true;
            dgvCaja.RowHeadersVisible = false;
            dgvCaja.RowHeadersWidth = 51;
            dgvCaja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaja.Size = new Size(777, 640);
            dgvCaja.TabIndex = 17;
            dgvCaja.CellClick += dgvCaja_CellClick;
            // 
            // factura
            // 
            factura.AutoSize = true;
            factura.Font = new Font("Segoe UI", 18F);
            factura.Location = new Point(60, 35);
            factura.Name = "factura";
            factura.Size = new Size(158, 41);
            factura.TabIndex = 18;
            factura.Text = "FACTURAS";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 15F);
            lblTotalPagar.ForeColor = Color.SeaGreen;
            lblTotalPagar.Location = new Point(658, 31);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(153, 35);
            lblTotalPagar.TabIndex = 19;
            lblTotalPagar.Text = "TOTAL: $0.00";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkGreen;
            btnPagar.Font = new Font("Segoe UI", 20F);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(971, 539);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(445, 200);
            btnPagar.TabIndex = 20;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1542, 851);
            Controls.Add(btnPagar);
            Controls.Add(lblTotalPagar);
            Controls.Add(factura);
            Controls.Add(dgvCaja);
            Controls.Add(pictureBox1);
            Controls.Add(CajaImg);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
    }
}