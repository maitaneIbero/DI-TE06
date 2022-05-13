
namespace Dashboard.Informes
{
    partial class Informe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDS = new Dashboard.NorthwindDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.companyNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.companyNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customersTableAdapter = new Dashboard.NorthwindDSTableAdapters.CustomersTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.fillBy2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDS;
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
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "NorthwindDS2";
            reportDataSource1.Value = this.customersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dashboard.Informes.ReporteCustomers.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1433, 822);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.56384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.5046F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1436, 113);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpString(this.button1, "Botón de aceptar para filtrar");
            this.button1.Location = new System.Drawing.Point(1050, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 28, 4, 5);
            this.button1.MaximumSize = new System.Drawing.Size(150, 46);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Dashboard.Properties.Resources.logoCortado;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.textBox1.Location = new System.Drawing.Point(139, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 31, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(539, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Filtrar por Company Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(685, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 103);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Todos",
            "Alfreds Futterkiste",
            "Alfreds Futterkiste",
            "Ana Trujillo Emparedados y helados",
            "Antonio Moreno Taquería",
            "Around the Horn",
            "Berglunds snabbköp",
            "Blauer See Delikatessen",
            "Blondesddsl père et fils",
            "Bólido Comidas preparadas",
            "Bon app\'",
            "Bottom-Dollar Markets",
            "B\'s Beverages",
            "Cactus Comidas para llevar",
            "Centro comercial Moctezuma",
            "Chop-suey Chinese",
            "Comércio Mineiro",
            "Consolidated Holdings",
            "Die Wandernde Kuh",
            "Drachenblut Delikatessen",
            "Du monde entier",
            "Eastern Connection",
            "Ernst Handel",
            "Familia Arquibaldo",
            "FISSA Fabrica Inter. Salchichas S.A.",
            "Folies gourmandes",
            "Folk och fä HB",
            "France restauration",
            "Franchi S.p.A.",
            "Frankenversand",
            "Furia Bacalhau e Frutos do Mar",
            "Galería del gastrónomo",
            "Godos Cocina Típica",
            "Gourmet Lanchonetes",
            "Great Lakes Food Market",
            "GROSELLA-Restaurante",
            "Hanari Carnes",
            "HILARION-Abastos",
            "Hungry Coyote Import Store",
            "Hungry Owl All-Night Grocers",
            "Island Trading",
            "Königlich Essen",
            "La corne d\'abondance",
            "La maison d\'Asie",
            "Laughing Bacchus Wine Cellars",
            "Lazy K Kountry Store",
            "Lehmanns Marktstand",
            "Let\'s Stop N Shop",
            "LILA-Supermercado",
            "LINO-Delicateses",
            "Lonesome Pine Restaurant",
            "Magazzini Alimentari Riuniti",
            "Maison Dewey",
            "Mère Paillarde",
            "Morgenstern Gesundkost",
            "North/South",
            "Océano Atlántico Ltda.",
            "Old World Delicatessen",
            "Ottilies Käseladen",
            "Paris spécialités",
            "Pericles Comidas clásicas",
            "Piccolo und mehr",
            "Princesa Isabel Vinhos",
            "Que Delícia",
            "Queen Cozinha",
            "QUICK-Stop",
            "Rancho grande",
            "Rattlesnake Canyon Grocery",
            "Reggiani Caseifici",
            "Ricardo Adocicados",
            "Richter Supermarkt",
            "Romero y tomillo",
            "Santé Gourmet",
            "Save-a-lot Markets",
            "Seven Seas Imports",
            "Simons bistro",
            "Spécialités du monde",
            "Split Rail Beer & Ale",
            "Suprêmes délices",
            "The Big Cheese",
            "The Cracker Box",
            "Toms Spezialitäten",
            "Tortuga Restaurante",
            "Tradição Hipermercados",
            "Trail\'s Head Gourmet Provisioners",
            "Vaffeljernet",
            "Victuailles en stock",
            "Vins et alcools Chevalier",
            "Wartian Herkku",
            "Wellington Importadora",
            "White Clover Markets",
            "Wilman Kala",
            "Wolski  Zajazd"});
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textBox2, "Introduce el nombre de la compañia para filtrar");
            this.textBox2.Location = new System.Drawing.Point(4, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 28, 4, 5);
            this.textBox2.Name = "textBox2";
            this.helpProvider1.SetShowHelp(this.textBox2, true);
            this.textBox2.Size = new System.Drawing.Size(348, 28);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(57)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(203)))));
            this.textBox3.Location = new System.Drawing.Point(1230, 5);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(201, 103);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Para buscar de nuevo todos los resultados escribe Todos";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyNameToolStripLabel,
            this.companyNameToolStripTextBox,
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(1467, 38);
            this.fillBy2ToolStrip.TabIndex = 4;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Visible = false;
            // 
            // companyNameToolStripLabel
            // 
            this.companyNameToolStripLabel.Name = "companyNameToolStripLabel";
            this.companyNameToolStripLabel.Size = new System.Drawing.Size(94, 35);
            this.companyNameToolStripLabel.Text = "CompanyName:";
            // 
            // companyNameToolStripTextBox
            // 
            this.companyNameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.companyNameToolStripTextBox.Name = "companyNameToolStripTextBox";
            this.companyNameToolStripTextBox.Size = new System.Drawing.Size(148, 38);
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 35);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1432, 968);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reportViewer1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Informe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private NorthwindDS northwindDS;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDSTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripLabel companyNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox companyNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}