namespace Vista
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            label1 = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            dgvClientes = new DataGridView();
            btnAgregar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "Informacion de los clientes";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBusqueda.Location = new Point(402, 44);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar Por Nombre";
            txtBusqueda.Size = new Size(305, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(713, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 73);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(776, 347);
            dgvClientes.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(713, 426);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 463);
            panel1.TabIndex = 5;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClientes);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private DataGridView dgvClientes;
        private Button btnAgregar;
        private Panel panel1;
    }
}