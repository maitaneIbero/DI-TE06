using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.PopUp
{
    public partial class PopUp : Form
    {
        public PopUp(string texto)
        {
            InitializeComponent();
            this.textBox1.Text = "Mostrando " + texto;
        }

        private void PopUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
