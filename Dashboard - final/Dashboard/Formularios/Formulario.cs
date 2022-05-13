
using Dashboard.ControlesUsuario;
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
using Utilidades.VO;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;


namespace Dashboard.Formularios
{
    public partial class Formulario : Form
    {
        //Inicio de todos los UserControl que vamos a utilizar y del tlp en el que se encuentran
        //string idCliente;
        private GraficoUC grafico;
        private TableLayoutPanel tlp;
        private InformacionUC informacion;
        private ListUC productos;
        private GraficoTartaUC graficoTarta;
        private MenuBotones menuBotones;
        public Formulario()
        {
            //Propiedades de inicio
            InitializeComponent();
            InicioComboBox();
            desactivarRadios();
            tlp = tLP7;
            grafico = new ControlesUsuario.GraficoUC();
            informacion = new InformacionUC();
            productos = new ListUC();
            graficoTarta = new GraficoTartaUC();
            menuBotones = new MenuBotones();
            ayuda();
        }
         private void ayuda()
        {
            this.toolTip1.SetToolTip(this.comboBox1, "Escoge el cliente del que quieres conocer informacion");
            this.toolTip1.SetToolTip(this.comboBox2, "Escoge el pais para filtrar el cliente");
            this.toolTip1.SetToolTip(this.radButProducto, "Muestra los productos más consumidos del cliente");
            this.toolTip1.SetToolTip(this.radButCategoria, "Muestra las categorias más consumidos del cliente");
            this.toolTip1.SetToolTip(this.radButData, "Muestra la información básica del cliente");
            this.toolTip1.SetToolTip(this.radButGrafico, "Muestra la facturación anual del cliente en un gráfico");
            this.toolTip1.SetToolTip(this.button1, "Muestra diferentes opciones de informes");
        }

        //ComboBox1 que nos permite visionar todos los nombres de los clientes  y comboBox2 que nos permite poder filtrar por país de los clientes
        private void InicioComboBox()
        {
            List<InfoClienteVO> clientes = GestorBLL.InformacionGeneralCliente();
            List<string> paises = new List<string>();
            foreach (InfoClienteVO cliente in clientes)
            {
                comboBox1.Items.Add(cliente.NombreEmpresa);
                paises.Add(cliente.Pais);
                
            }
            List<string> paisesSinDuplicados = paises.Distinct().ToList();
            comboBox2.Items.Add("Todos");
            foreach (string pais in paisesSinDuplicados)
            {
                comboBox2.Items.Add(pais);
            }
            
        }

        //Cada vez que se selecciona un nuevo cliente en el comboBox se desactivan los radios para que no se quede la peticiona anterior seleccionada y se limpia el tlp
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            desactivarRadios();
            activarRadios();
            tlp.Controls.Clear();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        //Método que nos permite filtrar lo que aparece en el comboBox1 por la selección del país que hagamos en el comboBox2
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            desactivarRadios();
            string paisSeleccionado = comboBox2.SelectedItem.ToString();
            comboBox1.Items.Clear();
            List<InfoClienteVO> clientes = GestorBLL.InformacionGeneralCliente();
            foreach (InfoClienteVO cliente in clientes)
            {
                if (cliente.Pais == paisSeleccionado)
                {
                    comboBox1.Items.Add(cliente.NombreEmpresa);                  
                }
                else if(paisSeleccionado == "Todos")
                {
                    comboBox1.Items.Add(cliente.NombreEmpresa);
                }
            }


         
        }
        //Radio que nos permite visionar los productos comprados por un cliente
        private void radButProducto_CheckedChanged(object sender, EventArgs e)
        {
            
            tlp.Controls.Clear();
            string clienteSeleccionado = comboBox1.SelectedItem.ToString();
            productos.crearListaViewProductos(clienteSeleccionado);
            tlp.Controls.Add(productos, 1, 0);
            if (radButProducto.Checked)
            {
                PopUp.PopUp pop = new PopUp.PopUp("productos comprados");
                pop.Show();
            }
           
        }
        //Radio que nos permite visionar los datos generales de un cliente
        private void radButData_CheckedChanged(object sender, EventArgs e)
        {
            tlp.Controls.Clear();
            string clienteSeleccionado = comboBox1.SelectedItem.ToString();
            informacion.crearDataGridView(clienteSeleccionado);
            tlp.Controls.Add(informacion, 1, 0);
            if (radButData.Checked)
            {
                PopUp.PopUp pop = new PopUp.PopUp("datos básicos del cliente");
                pop.Show();
            }
        }
        //Radio que nos permite visionar la facturacion anual de un cliente
        private void radButGrafico_CheckedChanged(object sender, EventArgs e)
        {
            tlp.Controls.Clear();
            string clienteSeleccionado = comboBox1.SelectedItem.ToString();
            grafico.crearGrafico(clienteSeleccionado);
            //UserControl grafico = new GraficoUC();
            tlp.Controls.Add(grafico, 1, 0);
            if (radButGrafico.Checked)
            {
                PopUp.PopUp pop = new PopUp.PopUp("facturación cliente");
                pop.Show();
            }

        }
        //Radio que nos permite visionar la categoría de productos más consumida por un cliente
        private void radioButCategoria_CheckedChanged(object sender, EventArgs e)
        {
            tlp.Controls.Clear();
            string clienteSeleccionado = comboBox1.SelectedItem.ToString();
            graficoTarta.CrearGraficoTarta(clienteSeleccionado);
            tlp.Controls.Add(graficoTarta, 1, 0);
            if (radButCategoria.Checked)
            {
                PopUp.PopUp pop = new PopUp.PopUp("categorías más compradas");
                pop.Show();
            }
        }

        //Se desactivan los radios y el tlp donde se muestran los datos
        private void desactivarRadios()
        {
            
            radButData.Checked = false;
            radButProducto.Checked = false;
            radButGrafico.Checked = false;
            radButCategoria.Checked = false;
            tLPRadios.Enabled = false;
            
        }

        //Se activan los radios y el tlp donde se muestran los datos
        private void activarRadios()
        {
            tlp.Enabled = true;
            tLPRadios.Enabled = true;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tLP7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tLP7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tlp.Controls.Clear();
            tlp.Controls.Add(menuBotones, 1, 0);


            /*
            InformeVentas informe = new InformeVentas();
            informe.cargarDatos();
            informe.Show(); */
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "..\\..\\..\\html\\ficherosCHM.chm");
            Help.ShowHelp(this, "html\\ficherosCHM.chm");
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
