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
            cmbPlatos = new ComboBox();
            numCantidad = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnAgregar = new Button();
            dgvCaja = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            btnCobrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).BeginInit();
            SuspendLayout();
            // 
            // cmbPlatos
            // 
            cmbPlatos.FormattingEnabled = true;
            cmbPlatos.Location = new Point(86, 112);
            cmbPlatos.Name = "cmbPlatos";
            cmbPlatos.Size = new Size(151, 28);
            cmbPlatos.TabIndex = 0;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(86, 279);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(150, 27);
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
            btnAgregar.Location = new Point(86, 384);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // dgvCaja
            // 
            dgvCaja.BackgroundColor = Color.White;
            dgvCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaja.Location = new Point(391, 188);
            dgvCaja.Name = "dgvCaja";
            dgvCaja.RowHeadersWidth = 51;
            dgvCaja.Size = new Size(300, 188);
            dgvCaja.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 73);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 7;
            label2.Text = "Plato disponibles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 238);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 8;
            label3.Text = "Cantidad deseada";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(507, 147);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 20);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: $0";
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(463, 411);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(140, 29);
            btnCobrar.TabIndex = 10;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click_1;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 647);
            Controls.Add(btnCobrar);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvCaja);
            Controls.Add(btnAgregar);
            Controls.Add(numCantidad);
            Controls.Add(cmbPlatos);
            Name = "FormCaja";
            Text = "FormCaja";
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPlatos;
        private NumericUpDown numCantidad;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnAgregar;
        private DataGridView dgvCaja;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private Button btnCobrar;
    }
}