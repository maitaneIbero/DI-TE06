using ConexionBD;
using System;
using System.Collections.Generic;
using Utilidades.VO;

namespace ConsolaBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<InfoProductoVO> datosProducto;
            datosProducto = GestorBDDAL.RealizarConsultaProductos();
        }
    }
}
