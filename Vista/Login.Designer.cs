namespace Vista
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            spLogin = new SplitContainer();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            btnRegistrarse = new Button();
            ((System.ComponentModel.ISupportInitialize)spLogin).BeginInit();
            spLogin.Panel1.SuspendLayout();
            spLogin.Panel2.SuspendLayout();
            spLogin.SuspendLayout();
            SuspendLayout();
            // 
            // spLogin
            // 
            spLogin.Location = new Point(12, 12);
            spLogin.Name = "spLogin";
            spLogin.Orientation = Orientation.Horizontal;
            // 
            // spLogin.Panel1
            // 
            spLogin.Panel1.Controls.Add(btnLogin);
            spLogin.Panel1.Controls.Add(lblPassword);
            spLogin.Panel1.Controls.Add(txtPassword);
            spLogin.Panel1.Controls.Add(txtUsuario);
            spLogin.Panel1.Controls.Add(lblUsuario);
            // 
            // spLogin.Panel2
            // 
            spLogin.Panel2.Controls.Add(btnRegistrarse);
            spLogin.Size = new Size(361, 235);
            spLogin.SplitterDistance = 181;
            spLogin.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(133, 143);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 23);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(27, 90);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(123, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Ingrese contraseña del usuario";
            txtPassword.Size = new Size(210, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(123, 40);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese nombre de usuario";
            txtUsuario.Size = new Size(210, 23);
            txtUsuario.TabIndex = 6;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(47, 43);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario:";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(133, 16);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(93, 23);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(spLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 300);
            MinimumSize = new Size(400, 300);
            Name = "Login";
            Text = "Login";
            spLogin.Panel1.ResumeLayout(false);
            spLogin.Panel1.PerformLayout();
            spLogin.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spLogin).EndInit();
            spLogin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spLogin;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Button btnRegistrarse;
    }
}