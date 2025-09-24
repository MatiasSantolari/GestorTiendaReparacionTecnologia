namespace GestorTiendaReparacionPC
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuEmpleados = new ToolStripMenuItem();
            mnuClientes = new ToolStripMenuItem();
            mnuTareas = new ToolStripMenuItem();
            mnuInformeTrabajos = new ToolStripMenuItem();
            mnuMisDatos = new ToolStripMenuItem();
            mnuCerrarSesion = new ToolStripMenuItem();
            lblTrabajosPendientes = new Label();
            dgvTrabajosPendientes = new DataGridView();
            btnRecargar = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajosPendientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuEmpleados, mnuClientes, mnuTareas, mnuInformeTrabajos, mnuMisDatos, mnuCerrarSesion });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuEmpleados
            // 
            mnuEmpleados.Name = "mnuEmpleados";
            mnuEmpleados.Size = new Size(77, 20);
            mnuEmpleados.Text = "Empleados";
            mnuEmpleados.Click += mnuEmpleados_Click;
            // 
            // mnuClientes
            // 
            mnuClientes.Name = "mnuClientes";
            mnuClientes.Size = new Size(61, 20);
            mnuClientes.Text = "Clientes";
            mnuClientes.Click += mnuClientes_Click;
            // 
            // mnuTareas
            // 
            mnuTareas.Name = "mnuTareas";
            mnuTareas.Size = new Size(51, 20);
            mnuTareas.Text = "Tareas";
            mnuTareas.Click += mnuTareas_Click;
            // 
            // mnuInformeTrabajos
            // 
            mnuInformeTrabajos.Name = "mnuInformeTrabajos";
            mnuInformeTrabajos.Size = new Size(107, 20);
            mnuInformeTrabajos.Text = "Informe Trabajos";
            mnuInformeTrabajos.Click += mnuInformeTrabajos_Click;
            // 
            // mnuMisDatos
            // 
            mnuMisDatos.Name = "mnuMisDatos";
            mnuMisDatos.Size = new Size(71, 20);
            mnuMisDatos.Text = "Mis Datos";
            mnuMisDatos.Click += mnuMisDatos_Click;
            // 
            // mnuCerrarSesion
            // 
            mnuCerrarSesion.Name = "mnuCerrarSesion";
            mnuCerrarSesion.Size = new Size(88, 20);
            mnuCerrarSesion.Text = "Cerrar Sesion";
            mnuCerrarSesion.Click += mnuCerrarSesion_Click;
            // 
            // lblTrabajosPendientes
            // 
            lblTrabajosPendientes.AutoSize = true;
            lblTrabajosPendientes.Location = new Point(12, 42);
            lblTrabajosPendientes.Name = "lblTrabajosPendientes";
            lblTrabajosPendientes.Size = new Size(111, 15);
            lblTrabajosPendientes.TabIndex = 1;
            lblTrabajosPendientes.Text = "Trabajos Pendientes";
            // 
            // dgvTrabajosPendientes
            // 
            dgvTrabajosPendientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTrabajosPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrabajosPendientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTrabajosPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajosPendientes.Location = new Point(12, 78);
            dgvTrabajosPendientes.Name = "dgvTrabajosPendientes";
            dgvTrabajosPendientes.Size = new Size(776, 360);
            dgvTrabajosPendientes.TabIndex = 2;
            // 
            // btnRecargar
            // 
            btnRecargar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecargar.Location = new Point(682, 38);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(75, 23);
            btnRecargar.TabIndex = 4;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblTrabajosPendientes);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(dgvTrabajosPendientes);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 449);
            panel1.TabIndex = 6;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            Shown += Home_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajosPendientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuEmpleados;
        private ToolStripMenuItem mnuClientes;
        private ToolStripMenuItem mnuTareas;
        private Label lblTrabajosPendientes;
        private DataGridView dgvTrabajosPendientes;
        private ToolStripMenuItem mnuInformeTrabajos;
        private Button btnRecargar;
        private ToolStripMenuItem mnuCerrarSesion;
        private ToolStripMenuItem mnuMisDatos;
        private Panel panel1;
    }
}
