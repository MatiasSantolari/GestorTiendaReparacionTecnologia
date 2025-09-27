namespace Vista
{
    partial class InformeDemandaDeTrabajos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeDemandaDeTrabajos));
            label1 = new Label();
            chartInformeCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cbAno = new ComboBox();
            label3 = new Label();
            btnBuscar = new Button();
            chartInformeRecaudacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)chartInformeCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartInformeRecaudacion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(374, 30);
            label1.TabIndex = 0;
            label1.Text = "Informe anual de demanda de trabajos";
            // 
            // chartInformeCantidad
            // 
            chartInformeCantidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartInformeCantidad.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartInformeCantidad.Legends.Add(legend1);
            chartInformeCantidad.Location = new Point(12, 58);
            chartInformeCantidad.Name = "chartInformeCantidad";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartInformeCantidad.Series.Add(series1);
            chartInformeCantidad.Size = new Size(780, 317);
            chartInformeCantidad.TabIndex = 1;
            chartInformeCantidad.Text = "chart1";
            // 
            // cbAno
            // 
            cbAno.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbAno.FormattingEnabled = true;
            cbAno.Location = new Point(630, 27);
            cbAno.Name = "cbAno";
            cbAno.Size = new Size(92, 23);
            cbAno.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(630, 9);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 5;
            label3.Text = "Seleccionar Año";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(734, 9);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(56, 41);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // chartInformeRecaudacion
            // 
            chartInformeRecaudacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartInformeRecaudacion.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartInformeRecaudacion.Legends.Add(legend2);
            chartInformeRecaudacion.Location = new Point(12, 384);
            chartInformeRecaudacion.Name = "chartInformeRecaudacion";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartInformeRecaudacion.Series.Add(series2);
            chartInformeRecaudacion.Size = new Size(780, 211);
            chartInformeRecaudacion.TabIndex = 7;
            chartInformeRecaudacion.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cbAno);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 613);
            panel1.TabIndex = 8;
            // 
            // InformeDemandaDeTrabajos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 611);
            Controls.Add(chartInformeRecaudacion);
            Controls.Add(chartInformeCantidad);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(820, 650);
            Name = "InformeDemandaDeTrabajos";
            Text = "InformeDemandaDeTrabajos";
            Load += InformeDemandaDeTrabajos_Load;
            ((System.ComponentModel.ISupportInitialize)chartInformeCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartInformeRecaudacion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInformeCantidad;
        private ComboBox cbAno;
        private Label label3;
        private Button btnBuscar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInformeRecaudacion;
        private Panel panel1;
    }
}