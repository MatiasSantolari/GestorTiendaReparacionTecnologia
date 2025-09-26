namespace Vista
{
    partial class AgregarEmpleadoForm
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
            gbTareasTrabajo = new GroupBox();
            cbEmpleados = new ComboBox();
            dgvTareasDeEmpleados = new DataGridView();
            btnVerTareasEmpleado = new Button();
            btnAgregar = new Button();
            gbEmpleadosTrabajo = new GroupBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTareasDeEmpleados).BeginInit();
            SuspendLayout();
            // 
            // gbTareasTrabajo
            // 
            gbTareasTrabajo.Location = new Point(12, 42);
            gbTareasTrabajo.Name = "gbTareasTrabajo";
            gbTareasTrabajo.Size = new Size(182, 255);
            gbTareasTrabajo.TabIndex = 0;
            gbTareasTrabajo.TabStop = false;
            gbTareasTrabajo.Text = "Tareas Del Trabajo";
            // 
            // cbEmpleados
            // 
            cbEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbEmpleados.FormattingEnabled = true;
            cbEmpleados.Location = new Point(12, 13);
            cbEmpleados.Name = "cbEmpleados";
            cbEmpleados.Size = new Size(665, 23);
            cbEmpleados.TabIndex = 1;
            // 
            // dgvTareasDeEmpleados
            // 
            dgvTareasDeEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvTareasDeEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareasDeEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTareasDeEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasDeEmpleados.Location = new Point(201, 42);
            dgvTareasDeEmpleados.Name = "dgvTareasDeEmpleados";
            dgvTareasDeEmpleados.Size = new Size(636, 378);
            dgvTareasDeEmpleados.TabIndex = 2;
            // 
            // btnVerTareasEmpleado
            // 
            btnVerTareasEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnVerTareasEmpleado.Location = new Point(682, 12);
            btnVerTareasEmpleado.Name = "btnVerTareasEmpleado";
            btnVerTareasEmpleado.Size = new Size(155, 23);
            btnVerTareasEmpleado.TabIndex = 3;
            btnVerTareasEmpleado.Text = "Ver Tareas De Empleado";
            btnVerTareasEmpleado.UseVisualStyleBackColor = true;
            btnVerTareasEmpleado.Click += btnVerTareasEmpleado_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.Location = new Point(762, 426);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // gbEmpleadosTrabajo
            // 
            gbEmpleadosTrabajo.Location = new Point(12, 303);
            gbEmpleadosTrabajo.Name = "gbEmpleadosTrabajo";
            gbEmpleadosTrabajo.Size = new Size(182, 115);
            gbEmpleadosTrabajo.TabIndex = 0;
            gbEmpleadosTrabajo.TabStop = false;
            gbEmpleadosTrabajo.Text = "Empleados Del Trabajo";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 461);
            panel1.TabIndex = 5;
            // 
            // AgregarEmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 461);
            Controls.Add(gbEmpleadosTrabajo);
            Controls.Add(btnAgregar);
            Controls.Add(btnVerTareasEmpleado);
            Controls.Add(dgvTareasDeEmpleados);
            Controls.Add(cbEmpleados);
            Controls.Add(gbTareasTrabajo);
            Controls.Add(panel1);
            MaximumSize = new Size(865, 500);
            MinimumSize = new Size(865, 500);
            Name = "AgregarEmpleadoForm";
            Text = "AgregarEmpleadoForm";
            Load += AgregarEmpleadoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTareasDeEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTareasTrabajo;
        private ComboBox cbEmpleados;
        private DataGridView dgvTareasDeEmpleados;
        private Button btnVerTareasEmpleado;
        private Button btnAgregar;
        private GroupBox gbEmpleadosTrabajo;
        private Panel panel1;
    }
}