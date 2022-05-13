using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Informes
{
    public partial class InformeProductos : Form
    {
        public InformeProductos()
        {
            InitializeComponent();
        }

        //Muestra un informe con todos los productos disponibles
        private void InformeProductos_Load(object sender, EventArgs e)
        {
            //Rellena el texto predictivo
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // TODO: esta línea de código carga datos en la tabla 'northwindDS.Products' Puede moverla o quitarla según sea necesario.
            this.productsTableAdapter.Fill(this.northwindDS.Products);
         
            //Enseña el informe
            this.reportViewer1.RefreshReport();
        }

        //Al seleccionar un producto cambia el aspecto del informe
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text == "Todos")
                {
                    this.productsTableAdapter.Fill(this.northwindDS.Products);
                }
                else
                {
                    this.productsTableAdapter.FillBy1(this.northwindDS.Products, textBox2.Text);
                }               
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /*
private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
{
   try
   {
       this.productsTableAdapter.FillBy1(this.northwindDS.Products, productNameToolStripTextBox.Text);
   }
   catch (System.Exception ex)
   {
       System.Windows.Forms.MessageBox.Show(ex.Message);
   }

} */
    }
}
