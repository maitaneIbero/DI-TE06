
namespace Dashboard.Informes
{
    partial class InformeProductos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDS = new Dashboard.NorthwindDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.productNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productsTableAdapter = new Dashboard.NorthwindDSTableAdapters.ProductsTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDS;
            // 
            // northwindDS
            // 
            this.northwindDS.DataSetName = "NorthwindDS";
            this.northwindDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "NorthwindDS3";
            reportDataSource2.Value = this.productsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dashboard.Informes.ReporteProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, 122);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1434, 844);
            this.reportViewer1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.56469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5885F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.84013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.64368F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.21108F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1436, 112);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "Alice Mutton",
            "Alice Mutton",
            "Aniseed Syrup",
            "Boston Crab Meat",
            "Camembert Pierrot",
            "Carnarvon Tigers",
            "Chai",
            "Chang",
            "Chartreuse verte",
            "Chef Anton\'s Cajun Seasoning",
            "Chef Anton\'s Gumbo Mix",
            "Chocolade",
            "Côte de Blaye",
            "Escargots de Bourgogne",
            "Filo Mix",
            "Flotemysost",
            "Geitost",
            "Genen Shouyu",
            "Gnocchi di nonna Alice",
            "Gorgonzola Telino",
            "Grandma\'s Boysenberry Spread",
            "Gravad lax",
            "Guaraná Fantástica",
            "Gudbrandsdalsost",
            "Gula Malacca",
            "Gumbär Gummibärchen",
            "Gustaf\'s Knäckebröd",
            "Ikura",
            "Inlagd Sill",
            "Ipoh Coffee",
            "Jack\'s New England Clam Chowder",
            "Konbu",
            "Lakkalikööri",
            "Laughing Lumberjack Lager",
            "Longlife Tofu",
            "Louisiana Fiery Hot Pepper Sauce",
            "Louisiana Hot Spiced Okra",
            "Manjimup Dried Apples",
            "Mascarpone Fabioli",
            "Maxilaku",
            "Mishi Kobe Niku",
            "Mozzarella di Giovanni",
            "Nord-Ost Matjeshering",
            "Northwoods Cranberry Sauce",
            "NuNuCa Nuß-Nougat-Creme",
            "Original Frankfurter grüne Soße",
            "Outback Lager",
            "Pâté chinois",
            "Pavlova",
            "Perth Pasties",
            "Queso Cabrales",
            "Queso Manchego La Pastora",
            "Raclette Courdavault",
            "Ravioli Angelo",
            "Rhönbräu Klosterbier",
            "Röd Kaviar",
            "Rogede sild",
            "Rössle Sauerkraut",
            "Sasquatch Ale",
            "Schoggi Schokolade",
            "Scottish Longbreads",
            "Singaporean Hokkien Fried Mee",
            "Sir Rodney\'s Marmalade",
            "Sir Rodney\'s Scones",
            "Sirop d\'érable",
            "Spegesild",
            "Steeleye Stout",
            "Tarte au sucre",
            "Teatime Chocolate Biscuits",
            "Thüringer Rostbratwurst",
            "Tofu",
            "Tourtière",
            "Tunnbröd",
            "Uncle Bob\'s Organic Dried Pears",
            "Valkoinen suklaa",
            "Vegie-spread",
            "Wimmers gute Semmelknödel",
            "Zaanse koeken"});
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textBox2, "Introduce el nombre del producto para filtrar");
            this.textBox2.Location = new System.Drawing.Point(638, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 28, 4, 5);
            this.textBox2.Name = "textBox2";
            this.helpProvider1.SetShowHelp(this.textBox2, true);
            this.textBox2.Size = new System.Drawing.Size(406, 28);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Alice Mutton",
            "Alice Mutton",
            "Aniseed Syrup",
            "Boston Crab Meat",
            "Camembert Pierrot",
            "Carnarvon Tigers",
            "Chai",
            "Chang",
            "Chartreuse verte",
            "Chef Anton\'s Cajun Seasoning",
            "Chef Anton\'s Gumbo Mix",
            "Chocolade",
            "Côte de Blaye",
            "Escargots de Bourgogne",
            "Filo Mix",
            "Flotemysost",
            "Geitost",
            "Genen Shouyu",
            "Gnocchi di nonna Alice",
            "Gorgonzola Telino",
            "Grandma\'s Boysenberry Spread",
            "Gravad lax",
            "Guaraná Fantástica",
            "Gudbrandsdalsost",
            "Gula Malacca",
            "Gumbär Gummibärchen",
            "Gustaf\'s Knäckebröd",
            "Ikura",
            "Inlagd Sill",
            "Ipoh Coffee",
            "Jack\'s New England Clam Chowder",
            "Konbu",
            "Lakkalikööri",
            "Laughing Lumberjack Lager",
            "Longlife Tofu",
            "Louisiana Fiery Hot Pepper Sauce",
            "Louisiana Hot Spiced Okra",
            "Manjimup Dried Apples",
            "Mascarpone Fabioli",
            "Maxilaku",
            "Mishi Kobe Niku",
            "Mozzarella di Giovanni",
            "Nord-Ost Matjeshering",
            "Northwoods Cranberry Sauce",
            "NuNuCa Nuß-Nougat-Creme",
            "Original Frankfurter grüne Soße",
            "Outback Lager",
            "Pâté chinois",
            "Pavlova",
            "Perth Pasties",
            "Queso Cabrales",
            "Queso Manchego La Pastora",
            "Raclette Courdavault",
            "Ravioli Angelo",
            "Rhönbräu Klosterbier",
            "Röd Kaviar",
            "Rogede sild",
            "Rössle Sauerkraut",
            "Sasquatch Ale",
            "Schoggi Schokolade",
            "Scottish Longbreads",
            "Singaporean Hokkien Fried Mee",
            "Sir Rodney\'s Marmalade",
            "Sir Rodney\'s Scones",
            "Sirop d\'érable",
            "Spegesild",
            "Steeleye Stout",
            "Tarte au sucre",
            "Teatime Chocolate Biscuits",
            "Thüringer Rostbratwurst",
            "Tofu",
            "Tourtière",
            "Tunnbröd",
            "Uncle Bob\'s Organic Dried Pears",
            "Valkoinen suklaa",
            "Vegie-spread",
            "Wimmers gute Semmelknödel",
            "Zaanse koeken"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.textBox1.Location = new System.Drawing.Point(154, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 31, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(477, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Filtrar por ProductName";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.logoCortado;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpString(this.button1, "Botón de aceptar para filtrar");
            this.button1.Location = new System.Drawing.Point(1052, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 28, 4, 5);
            this.button1.MaximumSize = new System.Drawing.Size(150, 46);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.textBox3.Location = new System.Drawing.Point(1233, 5);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(199, 102);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Para buscar de nuevo todos los resultados escribe Todos";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productNameToolStripLabel,
            this.productNameToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1432, 38);
            this.fillBy1ToolStrip.TabIndex = 6;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // productNameToolStripLabel
            // 
            this.productNameToolStripLabel.Name = "productNameToolStripLabel";
            this.productNameToolStripLabel.Size = new System.Drawing.Size(84, 35);
            this.productNameToolStripLabel.Text = "ProductName:";
            // 
            // productNameToolStripTextBox
            // 
            this.productNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productNameToolStripTextBox.Name = "productNameToolStripTextBox";
            this.productNameToolStripTextBox.Size = new System.Drawing.Size(148, 38);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 35);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // InformeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 968);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reportViewer1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformeProductos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InformeProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private NorthwindDS northwindDS;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDSTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel productNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}