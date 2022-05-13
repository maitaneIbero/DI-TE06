
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
    //User Control que nos permite gestionar un DataGridView
    public partial class InformacionUC : UserControl
    {
        public InformacionUC()
        {
            InitializeComponent();
        }

        //Se crea un data grid view para visonar los datos generales del cliente que hayamos seleccionado
        public void crearDataGridView(string nombreClienteSeleccionado)
        {
            dGV_clientes.ClearSelection();
            //Lista para recoger los datos requeridos
            List<InfoClienteVO> facturacion = GestorBLL.InformacionParticularCliente(nombreClienteSeleccionado);
            dGV_clientes.DataSource = facturacion;
        }
    



    }
}
