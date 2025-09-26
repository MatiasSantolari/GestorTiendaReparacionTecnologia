namespace Vista
{
    partial class GenerarTicket
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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnGenerarTicket = new Button();
            lblCliente = new Label();
            lblDispositivo = new Label();
            lblProblema = new Label();
            gbTareas = new GroupBox();
            SuspendLayout();
            // 
            // btnGenerarTicket
            // 
            btnGenerarTicket.Location = new Point(477, 252);
            btnGenerarTicket.Name = "btnGenerarTicket";
            btnGenerarTicket.Size = new Size(118, 23);
            btnGenerarTicket.TabIndex = 0;
            btnGenerarTicket.Text = "Generar Ticket";
            btnGenerarTicket.UseVisualStyleBackColor = true;
            btnGenerarTicket.Click += btnGenerarTicket_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 9);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(50, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente: ";
            // 
            // lblDispositivo
            // 
            lblDispositivo.AutoSize = true;
            lblDispositivo.Location = new Point(12, 24);
            lblDispositivo.Name = "lblDispositivo";
            lblDispositivo.Size = new Size(71, 15);
            lblDispositivo.TabIndex = 2;
            lblDispositivo.Text = "Dispositivo: ";
            // 
            // lblProblema
            // 
            lblProblema.AutoSize = true;
            lblProblema.Location = new Point(12, 39);
            lblProblema.Name = "lblProblema";
            lblProblema.Size = new Size(64, 15);
            lblProblema.TabIndex = 3;
            lblProblema.Text = "Problema: ";
            // 
            // gbTareas
            // 
            gbTareas.Location = new Point(12, 57);
            gbTareas.Name = "gbTareas";
            gbTareas.Size = new Size(583, 189);
            gbTareas.TabIndex = 4;
            gbTareas.TabStop = false;
            gbTareas.Text = "Tareas realizadas: ";
            // 
            // GenerarTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 287);
            Controls.Add(gbTareas);
            Controls.Add(lblProblema);
            Controls.Add(lblDispositivo);
            Controls.Add(lblCliente);
            Controls.Add(btnGenerarTicket);
            Name = "GenerarTicket";
            Text = "GenerarTicket";
            Load += GenerarTicket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnGenerarTicket;
        private Label lblCliente;
        private Label lblDispositivo;
        private Label lblProblema;
        private GroupBox gbTareas;
    }
}