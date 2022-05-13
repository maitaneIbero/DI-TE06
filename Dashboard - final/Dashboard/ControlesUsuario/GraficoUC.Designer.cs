namespace Dashboard.ControlesUsuario
{
    partial class GraficoUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_pedidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_pedidos
            // 
            this.chart_pedidos.BackColor = System.Drawing.Color.DimGray;
            this.chart_pedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_pedidos.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart_pedidos.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart_pedidos.BorderlineColor = System.Drawing.Color.Silver;
            this.chart_pedidos.BorderSkin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chart_pedidos.BorderSkin.PageColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.Name = "ChartArea1";
            this.chart_pedidos.ChartAreas.Add(chartArea1);
            this.chart_pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_pedidos.Legends.Add(legend1);
            this.chart_pedidos.Location = new System.Drawing.Point(0, 0);
            this.chart_pedidos.Name = "chart_pedidos";
            this.chart_pedidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_pedidos.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))))};
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Facturacion";
            this.chart_pedidos.Series.Add(series1);
            this.chart_pedidos.Size = new System.Drawing.Size(844, 616);
            this.chart_pedidos.TabIndex = 0;
            this.chart_pedidos.Text = "chart1";
            title1.Name = "Title1";
            this.chart_pedidos.Titles.Add(title1);
            this.chart_pedidos.Click += new System.EventHandler(this.chart1_Click);
            // 
            // GraficoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_pedidos);
            this.Name = "GraficoUC";
            this.Size = new System.Drawing.Size(844, 616);
            ((System.ComponentModel.ISupportInitialize)(this.chart_pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pedidos;
    }
}
