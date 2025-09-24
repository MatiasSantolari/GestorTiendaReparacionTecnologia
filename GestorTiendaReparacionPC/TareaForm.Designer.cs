namespace Vista
{
    partial class TareaForm
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
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            txtDetalle = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(319, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 58);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Detalle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 217);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(85, 209);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(319, 23);
            txtPrecio.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(357, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(85, 55);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(319, 148);
            txtDetalle.TabIndex = 7;
            txtDetalle.Text = "";
            // 
            // TareaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 281);
            Controls.Add(txtDetalle);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MaximumSize = new Size(460, 320);
            MinimumSize = new Size(460, 320);
            Name = "TareaForm";
            Text = "TareaForm";
            Load += TareaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private RichTextBox txtDetalle;
    }
}