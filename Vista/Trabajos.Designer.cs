namespace Vista
{
    partial class Trabajos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trabajos));
            label1 = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            dgvTrabajos = new DataGridView();
            btnAgregar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Informacion de los trabajos";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBusqueda.Location = new Point(379, 33);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Buscar Por Dispositivo";
            txtBusqueda.Size = new Size(313, 23);
            txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(698, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvTrabajos
            // 
            dgvTrabajos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTrabajos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrabajos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTrabajos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajos.Location = new Point(12, 61);
            dgvTrabajos.Name = "dgvTrabajos";
            dgvTrabajos.Size = new Size(760, 359);
            dgvTrabajos.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(698, 427);
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
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(btnBuscar);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 462);
            panel1.TabIndex = 5;
            // 
            // Trabajos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(dgvTrabajos);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "Trabajos";
            Text = "Trabajos";
            Load += Trabajos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrabajos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private DataGridView dgvTrabajos;
        private Button btnAgregar;
        private Panel panel1;
    }
}