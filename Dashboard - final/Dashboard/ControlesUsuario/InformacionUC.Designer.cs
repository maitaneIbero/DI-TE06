namespace Dashboard.ControlesUsuario
{
    partial class InformacionUC
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
            this.dGV_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_clientes
            // 
            this.dGV_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_clientes.Location = new System.Drawing.Point(0, 0);
            this.dGV_clientes.Name = "dGV_clientes";
            this.dGV_clientes.RowTemplate.Height = 28;
            this.dGV_clientes.Size = new System.Drawing.Size(848, 778);
            this.dGV_clientes.TabIndex = 0;
            // 
            // InformacionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dGV_clientes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InformacionUC";
            this.Size = new System.Drawing.Size(844, 616);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_clientes;
    }
}
