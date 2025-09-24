namespace Vista
{
    partial class TrabajoForm
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
            txtDispositivo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCliente = new TextBox();
            label4 = new Label();
            btnGuardar = new Button();
            cbEstado = new ComboBox();
            txtProblema = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Dispositivo";
            // 
            // txtDispositivo
            // 
            txtDispositivo.Location = new Point(105, 34);
            txtDispositivo.Name = "txtDispositivo";
            txtDispositivo.Size = new Size(279, 23);
            txtDispositivo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 66);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Problema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 196);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Estado";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(105, 222);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(279, 23);
            txtCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 225);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Cliente";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(344, 253);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente", "Terminado", "Abortado" });
            cbEstado.Location = new Point(105, 193);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(279, 23);
            cbEstado.TabIndex = 3;
            // 
            // txtProblema
            // 
            txtProblema.Location = new Point(105, 66);
            txtProblema.Name = "txtProblema";
            txtProblema.Size = new Size(279, 121);
            txtProblema.TabIndex = 7;
            txtProblema.Text = "";
            // 
            // TrabajoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 291);
            Controls.Add(txtProblema);
            Controls.Add(cbEstado);
            Controls.Add(btnGuardar);
            Controls.Add(txtCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDispositivo);
            Controls.Add(label1);
            MaximumSize = new Size(450, 330);
            MinimumSize = new Size(450, 330);
            Name = "TrabajoForm";
            Text = "TrabajoForm";
            Load += TrabajoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDispositivo;
        private Label label2;
        private Label label3;
        private TextBox txtCliente;
        private Label label4;
        private Button btnGuardar;
        private ComboBox cbEstado;
        private RichTextBox txtProblema;
    }
}