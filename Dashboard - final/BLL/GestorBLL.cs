using ConexionBD;
using System;
using System.Collections.Generic;
using Utilidades.VO;

namespace BLL
{
    public class GestorBLL
    {
        //BLL para la gestion de los métodos de la base de datos.


        #region Métodos


        //Método para obtener la informacion general de todos los clientes.Devuelve una lista de InfoClienteVO
        public static List<InfoClienteVO> InformacionGeneralCliente()
        {
            List<InfoClienteVO> infoCliente = GestorBDDAL.RealizarConsultaClientes();
            return infoCliente;

        }
        //Método para obtener la informacion general de las ventas. Devuelve una lista de InfoVentasVO
        public static List<InfoVentasVO> InformacionGeneralVentas()
        {
            List<InfoVentasVO> infoVentas = GestorBDDAL.RealizarConsultaVentas();
            return infoVentas;

        }
        //Método para obtener la informacion general de todos los productos.Devuelve una lista de InfoProductoVO
        public static List<InfoProductoVO> InformacionGeneralProductos()
        {
            List<InfoProductoVO> infoProductos= GestorBDDAL.RealizarConsultaProductos();
            return infoProductos;

        }
        //Método para obtener el id de un cliente.Devuelve un string con el id
        public static string InformacionIdCliente(string nombreCliente)
        {
            string idCliente = GestorBDDAL.RealizarConsultaId(nombreCliente);
            return idCliente;

        }

        //Método para obtener la informacion general de un cliente en particular.Devuelve una lista de InfoCliente.
        public static List<InfoClienteVO> InformacionParticularCliente(string nombreCliente)
        {
            List<InfoClienteVO> infoCliente = GestorBDDAL.RealizarConsultaInformacionCliente(nombreCliente);
            return infoCliente;

        }
        //Método para obtener la informacion general de los productos comprador por un cliente particular.Devuelve una lista de string
        public static List<string> InformacionProductosComprados(string nombreCliente)
        {
            List<string> infoProductos= GestorBDDAL.RealizarConsultaProductosComprados(nombreCliente);
            return infoProductos;

        }
        //Método para obtener la informacion general de la facturacion de un cliente a lo largo de los años.Devuelve una lista de InfoFacturacionFechaVO
        public static List<InfoFacturacionFechaVO> InformacionComprasCliente(string idCliente)
        {
            List<InfoFacturacionFechaVO> infoVentasCliente = GestorBDDAL.RealizarConsultaVentasCliente(idCliente);
            return infoVentasCliente;

        }

        public static List<InfoCantidadProductoVO> InformacionCategorias(string nombreCliente)
        {
            List<InfoCantidadProductoVO> infoCategorias = GestorBDDAL.RealizarConsultaCategoriaProductos(nombreCliente);
            return infoCategorias;

        }
        public static List<int> InformacionAnual()
        {
            List<int> years = GestorBDDAL.RealizarConsultaAnual();
            return years;

        }


        #endregion
    }
}

