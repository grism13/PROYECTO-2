namespace Restaurant_PALMERO_proyecto_2.Modulo_Ordenes
{
    partial class FormOrdenes
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
            cmbPlatos = new ComboBox();
            label1 = new Label();
            btnAgregar = new Button();
            numCantidad = new NumericUpDown();
            label2 = new Label();
            dgvPedido = new DataGridView();
            label3 = new Label();
            btnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            SuspendLayout();
            // 
            // cmbPlatos
            // 
            cmbPlatos.FormattingEnabled = true;
            cmbPlatos.Location = new Point(77, 147);
            cmbPlatos.Name = "cmbPlatos";
            cmbPlatos.Size = new Size(178, 28);
            cmbPlatos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 87);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "Platos Disponobles";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(77, 320);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(178, 64);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar plato";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(78, 248);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(177, 27);
            numCantidad.TabIndex = 4;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 206);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Numero";
            // 
            // dgvPedido
            // 
            dgvPedido.BackgroundColor = Color.White;
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.GridColor = Color.White;
            dgvPedido.Location = new Point(364, 147);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersWidth = 51;
            dgvPedido.Size = new Size(361, 159);
            dgvPedido.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 87);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "Platos pedidos";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(458, 345);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(178, 64);
            btnFinalizar.TabIndex = 8;
            btnFinalizar.Text = "Realizar Pedido";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click_1;
            // 
            // FormOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 586);
            Controls.Add(btnFinalizar);
            Controls.Add(label3);
            Controls.Add(dgvPedido);
            Controls.Add(label2);
            Controls.Add(numCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(cmbPlatos);
            Name = "FormOrdenes";
            Text = "FormOrdenes";
            Load += FormOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPlatos;
        private Label label1;
        private Button btnAgregar;
        private NumericUpDown numCantidad;
        private Label label2;
        private DataGridView dgvPedido;
        private Label label3;
        private Button btnFinalizar;
    }
}