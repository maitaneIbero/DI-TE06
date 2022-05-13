
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Utilidades.VO;

namespace Dashboard.ControlesUsuario
{
    //User Control para gestionr un gráfico
    public partial class GraficoUC : UserControl
    {
     
        public GraficoUC()
        {
            InitializeComponent();
        }


        //Metodo para crear un gráfico con los datos de un cliente en particular. Se visionará el conjunto de año con la facturacion total del mismo
        public void crearGrafico (string clienteSeleccionado)
        {
            
            //Listas para recoger los datos del eje x e y      
            List<double> y1 = new List<double>();
            List<int> x1 = new List<int>();

            //Recoge el id del cliente del que queremos la infromacion
            string idCliente = GestorBLL.InformacionIdCliente(clienteSeleccionado);

            //Lista que recoge los datos de la facturacion
            List<InfoFacturacionFechaVO> facturacion = GestorBLL.InformacionComprasCliente(idCliente);
          
            //Bucle para introducir los datos en x e y
            for (int i = 0; i < facturacion.Count; i++)
            { 
                
                x1.Add(facturacion[i].FechaPedido);
                y1.Add(facturacion[i].Precio);

            } 

            //Se introducen los datos guardados en chart_pedidos para que se puedan visionar en el gráfico
            chart_pedidos.Series["Facturacion"].Points.DataBindXY(x1.ToArray(), y1.ToArray());

            chart_pedidos.ChartAreas[0].AxisX.Title = "Fecha Pedido";
            chart_pedidos.ChartAreas[0].AxisY.Title = "Precio";
            chart_pedidos.Titles.Clear();
            chart_pedidos.Titles.Add("Facturación por años");          
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
