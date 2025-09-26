namespace Vista
{
    partial class ClienteForm
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
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtTel = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(311, 146);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(231, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(155, 66);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(231, 23);
            txtTel.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 97);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 23);
            txtEmail.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 100);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 69);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 10;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 201);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtTel);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(430, 240);
            MinimumSize = new Size(430, 240);
            Name = "ClienteForm";
            Text = "ClienteForm";
            Load += ClienteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtNombre;
        private TextBox txtTel;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}