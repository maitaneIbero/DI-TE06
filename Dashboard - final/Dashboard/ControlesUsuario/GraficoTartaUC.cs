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
using Utilidades.VO;

namespace Dashboard.ControlesUsuario
{
    public partial class GraficoTartaUC : UserControl
    {
        public GraficoTartaUC()
        {
            InitializeComponent();
        }

        //Método para crear un gráfico tipo tarta con las categorias de productos más consumidas por un cliente

        public void CrearGraficoTarta(string clienteSeleccionado)
        {
            List<string> x1 = new List<string>();
            List<int> y1 = new List<int>();
            List<InfoCantidadProductoVO> categoria = GestorBLL.InformacionCategorias(clienteSeleccionado);
           
           //Se añade la informacion a los ejes x e y 
            for (int i = 0; i < categoria.Count; i++)
            {
                y1.Add(categoria[i].Cantidad);
                x1.Add(categoria[i].Categoria);

            }
            chartCategorias.Series["Series1"].Points.DataBindXY(x1, y1);

            chartCategorias.Titles.Clear(); 
            chartCategorias.Titles.Add("Categorias más consumidas"); 

        }
    }
}
