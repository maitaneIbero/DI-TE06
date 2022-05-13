using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class InfoProductoVO
    {
        #region Atributos
        private int productoId;
        private string nombreProducto;
        private int supplierId;
        private int categoriaId;
        private string cantidadPorUnidad;
        private double precioUnitario;
        private int unidadesEnStock;
        private int unidadesEnPedidos;
        private int reordenarNivel;
        private bool discontinuo;

        public InfoProductoVO()
        {

            this.ProductoId = productoId;
            this.NombreProducto = nombreProducto;
            this.SupplierId= supplierId;
            this.CategoriaId = categoriaId;
            this.CantidadPorUnidad = cantidadPorUnidad;
            this.PrecioUnitario = precioUnitario;
            this.UnidadesEnStock = unidadesEnStock;
            this.UnidadesEnPedidos = unidadesEnPedidos;
            this.ReordenarNivel = reordenarNivel;
            this.Discontinuo = discontinuo;         

        }

        public int ProductoId { get => productoId; set => productoId = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public int CategoriaId { get => categoriaId; set => categoriaId = value; }
        public string CantidadPorUnidad { get => cantidadPorUnidad; set => cantidadPorUnidad = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int UnidadesEnStock { get => unidadesEnStock; set => unidadesEnStock = value; }
        public int UnidadesEnPedidos { get => unidadesEnPedidos; set => unidadesEnPedidos = value; }
        public int ReordenarNivel { get => reordenarNivel; set => reordenarNivel = value; }
        public bool Discontinuo { get => discontinuo; set => discontinuo = value; }




        #endregion


    }
}
