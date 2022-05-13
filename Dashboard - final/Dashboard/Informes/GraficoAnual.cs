using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dashboard.Informes
{
    public partial class GraficoAnual : Form
    {
        public GraficoAnual()
        {
            InitializeComponent();
        }

        private void GraficoAnual_Load(object sender, EventArgs e)
        {
            ConsultaAnual();
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.DataTable2' Puede moverla o quitarla según sea necesario.
            this.dataTable2TableAdapter.Fill(this.dataSet1.DataTable2);

            //Enseña el informe
            this.reportViewer1.RefreshReport();
        }


        //Rellena el combobox con los años existentes
        private void ConsultaAnual()
        {
            List<int> years = GestorBLL.InformacionAnual();
            comboBox1.Items.Add("Todos");
            foreach (int year in years)
            {
                comboBox1.Items.Add(year);
            }
        }

        //Si se selecciona otro año en el combobox cambia el gráfico
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedItem.ToString() == "Todos")
                {
                    this.dataTable2TableAdapter.Fill(this.dataSet1.DataTable2);
                }
                else
                {
                    this.dataTable2TableAdapter.FillBy(this.dataSet1.DataTable2, ((decimal)(System.Convert.ChangeType(comboBox1.SelectedItem, typeof(decimal)))));
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
