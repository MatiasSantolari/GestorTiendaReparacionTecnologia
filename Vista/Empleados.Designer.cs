namespace Vista
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            lblInfoEmpleados = new Label();
            dgvEmpleados = new DataGridView();
            btnAgregar = new Button();
            btnBuscar = new Button();
            txtBusqueda = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfoEmpleados
            // 
            lblInfoEmpleados.AutoSize = true;
            lblInfoEmpleados.Location = new Point(12, 9);
            lblInfoEmpleados.Name = "lblInfoEmpleados";
            lblInfoEmpleados.Size = new Size(171, 15);
            lblInfoEmpleados.TabIndex = 0;
            lblInfoEmpleados.Text = "Información De Los Empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(13, 72);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(776, 354);
            dgvEmpleados.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(713, 431);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(713, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBusqueda.Location = new Point(400, 42);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar Por Nombre";
            txtBusqueda.Size = new Size(307, 23);
            txtBusqueda.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvEmpleados);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 465);
            panel1.TabIndex = 5;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(lblInfoEmpleados);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "Empleados";
            Text = "Empleados";
            FormClosing += Empleados_FormClosing;
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoEmpleados;
        private DataGridView dgvEmpleados;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox txtBusqueda;
        private Panel panel1;
    }
}