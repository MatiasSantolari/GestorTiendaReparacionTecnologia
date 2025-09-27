namespace Vista
{
    partial class Tareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tareas));
            lblTareas = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            dgvTareas = new DataGridView();
            btnAgregar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Location = new Point(12, 9);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(39, 15);
            lblTareas.TabIndex = 0;
            lblTareas.Text = "Tareas";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBusqueda.Location = new Point(462, 40);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar por nombre de tarea";
            txtBusqueda.Size = new Size(229, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(697, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvTareas
            // 
            dgvTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(12, 69);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.Size = new Size(760, 352);
            dgvTareas.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(697, 427);
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
            panel1.Controls.Add(dgvTareas);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(btnBuscar);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 465);
            panel1.TabIndex = 5;
            // 
            // Tareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(lblTareas);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "Tareas";
            Text = "Tareas";
            FormClosing += Tareas_FormClosing;
            Load += Tareas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTareas;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private DataGridView dgvTareas;
        private Button btnAgregar;
        private Panel panel1;
    }
}