
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

namespace Dashboard.ControlesUsuario
{
    public partial class ListUC : UserControl
    {
        //User Control que nos permite gestionar una listaview de los productos comprados por cantidad
        public ListUC()
        {
            InitializeComponent();
        }

        //Método para crear un 
        public void crearListaViewProductos(string nombreClienteSeleccionado)
        {
            listView1.Items.Clear();

            //Lista para gestionar los datos de los productos comprados por un cliente
            List<string> productos = GestorBLL.InformacionProductosComprados(nombreClienteSeleccionado);

            //Este atributo nos permite agrupar el nombre de los productos para que no se repitan y sumar las veces que se repiten para saber la cantidad de veces que se han obtenido
            var q = productos.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(x => x.Count);


            //Añade los datos al listView
            foreach (var x in q)
            {
                var item1 = new ListViewItem(new[] { x.Value, x.Count.ToString() });
                listView1.Items.Add(item1);
                Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
            }
            

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
