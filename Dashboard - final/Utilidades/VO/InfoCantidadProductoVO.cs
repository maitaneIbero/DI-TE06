using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class InfoCantidadProductoVO
    {
        private string categoria;
        private int cantidad;

        public InfoCantidadProductoVO()
        {
            this.Categoria = Categoria;
            this.Cantidad = Cantidad;
        }

        public string Categoria { get => categoria; set => categoria = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}

