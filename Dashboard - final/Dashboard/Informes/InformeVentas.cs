using Dashboard.ControlesUsuario;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.VO;

namespace Dashboard.Informes
{
    public partial class InformeVentas : Form
    {
        //List<InfoVentasVO> infoVentas = new List<InfoVentasVO>();
      
        public InformeVentas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Permite completar el texto predictivo
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // TODO: esta línea de código carga datos en la tabla 'northwindDS.Orders' Puede moverla o quitarla según sea necesario.
            this.ordersTableAdapter3.Fill(this.northwindDS.Orders);
    
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSNorthwind", infoVentas));
            //this.ordersTableAdapter.Fill(this.dSNorthwind.Orders);

            //Enseña el informe
            this.reportViewer1.RefreshReport();

        }

        //Al pulsar buscar cambia el informe a lo que decida el usuario
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text == "TODOS")
                {
                    this.ordersTableAdapter3.Fill(this.northwindDS.Orders);
                }
                else
                {
                    this.ordersTableAdapter3.FillBy(this.northwindDS.Orders, textBox2.Text);
                }
                
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

            
        }

       
    }
}
