using Dashboard.Informes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.ControlesUsuario
{
    public partial class MenuBotones : UserControl
    {
        public MenuBotones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformeVentas informe = new InformeVentas();
            informe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Informe informeClientes = new Informe();          
            informeClientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformeProductos informeProductos = new InformeProductos();          
            informeProductos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            GraficoAnual informeAnual = new GraficoAnual();
            informeAnual.Show(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
