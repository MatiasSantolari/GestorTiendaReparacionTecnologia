namespace Vista
{
    partial class EmpleadoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtRepPass = new TextBox();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            txtTel = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            cbRol = new ComboBox();
            lblAclaracion = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 66);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 97);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 159);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 191);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "Repetir Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 131);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 5;
            label6.Text = "Rol";
            // 
            // txtRepPass
            // 
            txtRepPass.Location = new Point(148, 188);
            txtRepPass.Name = "txtRepPass";
            txtRepPass.PasswordChar = '*';
            txtRepPass.Size = new Size(231, 23);
            txtRepPass.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(148, 156);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(231, 23);
            txtPass.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(148, 63);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(231, 23);
            txtTel.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(304, 226);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Tecnico", "Admin" });
            cbRol.Location = new Point(148, 127);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(231, 23);
            cbRol.TabIndex = 4;
            // 
            // lblAclaracion
            // 
            lblAclaracion.AutoSize = true;
            lblAclaracion.Location = new Point(12, 282);
            lblAclaracion.Name = "lblAclaracion";
            lblAclaracion.Size = new Size(385, 15);
            lblAclaracion.TabIndex = 9;
            lblAclaracion.Text = "Dejar vacío para mantener la contraseña actual. Rellenar para cambiarla.";
            lblAclaracion.Visible = false;
            // 
            // EmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 311);
            Controls.Add(lblAclaracion);
            Controls.Add(cbRol);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtTel);
            Controls.Add(txtEmail);
            Controls.Add(txtPass);
            Controls.Add(txtRepPass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(430, 350);
            MinimumSize = new Size(430, 350);
            Name = "EmpleadoForm";
            Text = "EmpleadoForm";
            Load += EmpleadoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtRepPass;
        private TextBox txtPass;
        private TextBox txtEmail;
        private TextBox txtTel;
        private TextBox txtNombre;
        private Button btnGuardar;
        private ComboBox cbRol;
        private Label lblAclaracion;
    }
}