
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Utilidades.VO;

namespace ConexionBD
{
    public class GestorBDDAL
    {
        static void Main(string[] args)
        {
            AbrirConexion();
           
        }
        
        //Método para comprobar la conexion a la BBDD
        public static void AbrirConexion()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            try
            {
                conn.Open();
                Console.WriteLine("Conexion abierta satisfactoriamente con la BD");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");

                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<int> RealizarConsultaAnual()
        {
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            string sql = "Select Distinct Year(OrderDate) from dbo.Orders order by Year(OrderDate)";
            SqlDataReader datos;
            List<int> years = new List<int>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();


                //Recogida de datos
                while (datos.Read())
                {
                    int year;
                    year = (int)Int64.Parse(datos.GetValue(0).ToString()); 
                    years.Add(year);
                }
                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
            //Se devuelve la lista con los datos
            return years;
        }

        //Método que permite recuperar la información de todos los clientes. Guarda los datos en una lista InfoClienteVO
        public static List<InfoClienteVO> RealizarConsultaClientes()
        {
            //Datos de conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;

            string sql = "Select * from dbo.Customers";

            SqlDataReader datos;
            List<InfoClienteVO> clientes = new List<InfoClienteVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();

                
                //Recogida de datos
                while (datos.Read())
                {
                    InfoClienteVO cliente = new InfoClienteVO();
                    cliente.IdCliente = datos.GetValue(0).ToString();
                    cliente.NombreEmpresa = datos.GetValue(1).ToString();
                    cliente.NombreContacto = datos.GetValue(2).ToString();
                    cliente.CategoriaContacto = datos.GetValue(3).ToString();
                    cliente.Direccion = datos.GetValue(4).ToString();
                    cliente.Ciudad = datos.GetValue(5).ToString();
                    cliente.Region = datos.GetValue(6).ToString();
                    cliente.CodigoPostal = datos.GetValue(7).ToString();
                    cliente.Pais = datos.GetValue(8).ToString();
                    cliente.Telefono = datos.GetValue(9).ToString();
                    cliente.Fax = datos.GetValue(10).ToString();
                    clientes.Add(cliente);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
            //Se devuelve la lista con los datos
            return clientes;
        }


        //Método que permite recuperar la información de todas las ventas realizadas. Guarda los datos en una lista InfoVentasVO
        public static List<InfoVentasVO> RealizarConsultaVentas()
        {
            //datos de conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;

            string sql = "Select * from dbo.Orders";

            SqlDataReader datos;
            List<InfoVentasVO> ventas = new List<InfoVentasVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();

                //Recogida de datos
                while (datos.Read())
                {
                    InfoVentasVO venta = new InfoVentasVO();
                    venta.PedidoId = datos.GetValue(0).ToString();
                    venta.ClienteId = datos.GetValue(1).ToString();
                    venta.EmpleadoId = datos.GetValue(2).ToString();
                    venta.FechaPedido = DateTime.Parse(datos.GetValue(3).ToString());
                    venta.FechaEntrega = DateTime.Parse(datos.GetValue(4).ToString());
                    venta.FechaEnvio = DateTime.Parse(datos.GetValue(5).ToString());
                    venta.ViaEntregaTransporte = (int)Int64.Parse(datos.GetValue(6).ToString());
                    venta.Precio = (double)Double.Parse(datos.GetValue(7).ToString());
                    venta.NombreCliente = datos.GetValue(8).ToString();
                    venta.Direccion = datos.GetValue(9).ToString();
                    venta.Ciudad = datos.GetValue(10).ToString();
                    venta.Region = datos.GetValue(11).ToString();
                    venta.CodigoPostal = datos.GetValue(12).ToString();
                    venta.Pais = datos.GetValue(13).ToString();
                    ventas.Add(venta);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");                
            }
            //Se devuelve la lista con los datos
            return ventas;
        }


        //Método que permite recuperar la información de todos los productos. Guarda los datos en una lista InfoProductoVO
        public static List<InfoProductoVO> RealizarConsultaProductos()
        {
            //Datos de conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;

            string sql = "Select * from dbo.Products";

            SqlDataReader datos;
            List<InfoProductoVO> productos = new List<InfoProductoVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();

                //Recogida de datos
                
                while (datos.Read())
                {
                    InfoProductoVO producto = new InfoProductoVO();
                    producto.ProductoId =(int)Int64.Parse(datos.GetValue(0).ToString());
                    producto.NombreProducto = datos.GetValue(1).ToString();
                    producto.SupplierId = (int)Int64.Parse(datos.GetValue(2).ToString());
                    producto.CategoriaId = (int)Int64.Parse(datos.GetValue(3).ToString());
                    producto.CantidadPorUnidad = datos.GetValue(4).ToString();
                    producto.PrecioUnitario = (double)Double.Parse(datos.GetValue(5).ToString());
                    producto.UnidadesEnStock = (int)Int64.Parse(datos.GetValue(6).ToString());
                    producto.UnidadesEnPedidos = (int)Int64.Parse(datos.GetValue(7).ToString());
                    producto.ReordenarNivel = (int)Int64.Parse(datos.GetValue(8).ToString());
                    producto.Discontinuo = (bool)Boolean.Parse(datos.GetValue(9).ToString());
                    productos.Add(producto);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
            //Devuelve la lista con los datos 
            return productos;
        }


        //Método que permite recuperar el id de un cliente. Guarda el dato en un string.
        public static string RealizarConsultaId(string nombreCliente)
        {
            //Datos de conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            //Controla aquellos nombres que contienen ' para que no den error al buscarlos
            nombreCliente = nombreCliente.Replace("'", "''");

            string sql = "Select CustomerID from dbo.Customers where CompanyName = '" + nombreCliente + "'";

            SqlDataReader datos;
            string idCliente = "";
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                
                while (datos.Read())
                {
                    idCliente = datos.GetValue(0).ToString();
                }
                //Console.WriteLine(datos.GetValue(0));               

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
            //Devuelve string con el id
            return idCliente;
        }


        //Método que permite recuperar la información de un cliente. Guarda los datos en una lista InfoClienteVO
        public static List<InfoClienteVO> RealizarConsultaInformacionCliente(string nombreCliente)
        {
            //Datos conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            //Controla aquellos nombres que contienen ' para que no den error al buscarlos
            nombreCliente = nombreCliente.Replace("'", "''");
            string sql = "Select * from dbo.Customers where CompanyName = '" + nombreCliente + "'";

            SqlDataReader datos;
            List<InfoClienteVO> clientes = new List<InfoClienteVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();


                //Recogida de datos
                while (datos.Read())
                {
                    InfoClienteVO cliente = new InfoClienteVO();
                    cliente.IdCliente = datos.GetValue(0).ToString();
                    cliente.NombreEmpresa = datos.GetValue(1).ToString();
                    cliente.NombreContacto = datos.GetValue(2).ToString();
                    cliente.CategoriaContacto = datos.GetValue(3).ToString();
                    cliente.Direccion = datos.GetValue(4).ToString();
                    cliente.Ciudad = datos.GetValue(5).ToString();
                    cliente.Region = datos.GetValue(6).ToString();
                    cliente.CodigoPostal = datos.GetValue(7).ToString();
                    cliente.Pais = datos.GetValue(8).ToString();
                    cliente.Telefono = datos.GetValue(9).ToString();
                    cliente.Fax = datos.GetValue(10).ToString();
                    clientes.Add(cliente);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
            //Devuelve la lista con los datos recogidos
            return clientes;
        }


        //Método que permite recuperar la información de los procutos comprados por un cliente. Guarda los datos en una lista string
        public static List<String> RealizarConsultaProductosComprados(string nombreCliente)
        {
            //Datos de conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            string nombre = RealizarConsultaId(nombreCliente);

            //Query que nos permite obtener el nombre de los productos comprados
            string sql = "Select productName from dbo.products " +
                "inner join dbo.[order Details] on dbo.products.productID = dbo.[Order Details].productID " +
                "inner join dbo.orders on dbo.[Order Details].orderId = dbo.orders.orderId " +
                "where dbo.orders.customerId = '" + nombre +"'" ;

            SqlDataReader datos;
            List<String> productos = new List<String>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();


                //Recogida de datos
                while (datos.Read())
                {
                    string nombreProducto = datos.GetValue(0).ToString();
                    productos.Add(nombreProducto);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
            //Devuelve una lista con los datos recogidos
            return productos;
        }


        //Método que permite recuperar la información de las ventas realizadas por un cliente. Guarda los datos en una lista InfoFacturacionFechaVO
        public static List<InfoFacturacionFechaVO> RealizarConsultaVentasCliente(string idCliente)
        {
            //Datos conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;

            //Query que nos permite juntar las fechas en un año concreto y sumar su facturacion total
            string sql = "Select Year(OrderDate), sum(freight) from dbo.orders " +
                "where CustomerID = '" + idCliente +"' " +
                "group by Year(OrderDate)"; 

            SqlDataReader datos;
            List<InfoFacturacionFechaVO> ventas = new List<InfoFacturacionFechaVO>();
 
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();

                //Recogida de datos
                while (datos.Read())
                {
                    InfoFacturacionFechaVO venta = new InfoFacturacionFechaVO();                   
                    venta.FechaPedido = (int)int.Parse(datos.GetValue(0).ToString());                 
                    venta.Precio = (double)Double.Parse(datos.GetValue(1).ToString());                 
                    ventas.Add(venta);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
            //Devuelve la lista con los datos recogidos
            return ventas;
        }

        public static List<InfoCantidadProductoVO> RealizarConsultaCategoriaProductos(string nombreCliente)
        {
            //Datos de conexion
            SqlConnection conn = new SqlConnection(@"Data Source = localhost; Initial Catalog = Northwind; User ID= DI; Password = 1234");
            SqlCommand command;
            string nombre = RealizarConsultaId(nombreCliente);

            //Query que nos permite obtener el nombre de los productos comprados
            string sql = "SELECT categoryName, COUNT(categoryName) FROM dbo.categories " +
                         "inner join dbo.products on dbo.products.categoryID = dbo.categories.categoryID " +
                         "inner join dbo.[order Details] on northwind.dbo.products.productID = northwind.dbo.[Order Details].productID " +
                         "inner join dbo.orders on dbo.[Order Details].orderId = dbo.orders.orderId " +
                         "where dbo.orders.CustomerID = '" + nombre + "' " +
                         "GROUP BY categoryName";


            SqlDataReader datos;
            List<InfoCantidadProductoVO> categorias = new List<InfoCantidadProductoVO>();
            try
            {
                conn.Open();
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();


                //Recogida de datos
                while (datos.Read())
                {
                    InfoCantidadProductoVO categoria = new InfoCantidadProductoVO();
                    categoria.Categoria = datos.GetValue(0).ToString();
                    categoria.Cantidad = (int)Int64.Parse(datos.GetValue(1).ToString());
                    categorias.Add(categoria);
                    Console.WriteLine(datos.GetValue(0));
                }

                datos.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se ha podido establecer conexion con la BD");
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
            //Devuelve una lista con los datos recogidos
            return categorias;
        }
    }
}
