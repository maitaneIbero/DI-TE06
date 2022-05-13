using Dashboard.ControlesUsuario;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.VO;

namespace Dashboard.Informes
{
    public partial class Informe: Form
    {

      
        public Informe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Completa el texto predictivo
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            // TODO: esta línea de código carga datos en la tabla 'northwindDS.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDS.Customers);
    
            //Enseña el informe
            this.reportViewer1.RefreshReport();


        }

        //Al buscar  un cliente se actualizan los datos del informe
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text == "Todos")
                {
                    this.customersTableAdapter.Fill(this.northwindDS.Customers);
                }
                else
                {
                    this.customersTableAdapter.FillBy(this.northwindDS.Customers, textBox2.Text);
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

        

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customersTableAdapter.FillBy2(this.northwindDS.Customers, companyNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
