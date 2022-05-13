using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class InfoVentasVO
    {
        #region Atributos
        private string pedidoId;
        private string clienteId;
        private string empleadoId;
        private DateTime fechaPedido;
        private DateTime fechaEntrega;
        private DateTime fechaEnvio;
        private int viaEntregaTransporte;
        private double precio;
        private string nombreCliente;
        private string direccion;
        private string ciudad;
        private string region;
        private string codigoPostal;
        private string pais;

        public InfoVentasVO()
        {
            this.PedidoId = pedidoId;
            this.ClienteId = clienteId;
            this.EmpleadoId = empleadoId;
            this.FechaPedido = fechaPedido;
            this.FechaEntrega = fechaEntrega;
            this.FechaEnvio = fechaEnvio;
            this.ViaEntregaTransporte = viaEntregaTransporte;
            this.Precio = precio;
            this.NombreCliente = nombreCliente;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Region = region;
            this.CodigoPostal = codigoPostal;
            this.Pais = pais;
        }

        public string PedidoId { get => pedidoId; set => pedidoId = value; }
        public string ClienteId { get => clienteId; set => clienteId = value; }
        public string EmpleadoId { get => empleadoId; set => empleadoId = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public DateTime FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public int ViaEntregaTransporte { get => viaEntregaTransporte; set => viaEntregaTransporte = value; }
        public double Precio { get => precio; set => precio = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Region { get => region; set => region = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Pais { get => pais; set => pais = value; }








        #endregion
    }
}
