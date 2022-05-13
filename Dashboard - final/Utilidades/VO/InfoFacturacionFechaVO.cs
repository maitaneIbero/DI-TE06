using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class InfoFacturacionFechaVO
    {
        private int fechaPedido;
        private double precio;

        public InfoFacturacionFechaVO()
        {
            this.fechaPedido = fechaPedido;
            this.precio = precio;
        }

        public double Precio { get => precio; set => precio = value; }
        public int FechaPedido { get => fechaPedido; set => fechaPedido = value; }
    }
}
