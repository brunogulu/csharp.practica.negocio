using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ProductosVista : Form
    {
        public static N_Producto oProducto { get; set; }
        public static N_vProducto ovProducto { get; set; }

        public ProductosVista()
        {
            InitializeComponent();
            oProducto = new N_Producto();
            ovProducto = new N_vProducto();
        }

        private void ProductosVista_Load(object sender, EventArgs e)
        {
            TablaProductos.DataSource = ovProducto.MostrarProductos(tbBuscarProductos.Text);
        }

        private void tbBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            TablaProductos.DataSource = ovProducto.MostrarProductos(tbBuscarProductos.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // TODO - Agregar Producto
            var npVista = new NuevoProductoVista();
            npVista.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar que haya un Producto seleccionado
            if (TablaProductos.SelectedRows.Count > 0)
            {
                // Extrar Id del Producto
                int id = int.Parse(TablaProductos.CurrentRow.Cells[0].Value.ToString());

                // Obtener el Producto de la BD
                var producto = ovProducto.ObtenerProductoPorId(id);

                // Abrir formulario y pasarle el objeto vProducto
                var npVista = new NuevoProductoVista(producto);
                npVista.ShowDialog();

                // Refrescar la tabla de Productos
                TablaProductos.DataSource = ovProducto.MostrarProductos(tbBuscarProductos.Text);
                Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto");
            }
        }

        private void ProductosVista_Shown(object sender, EventArgs e)
        {
            TablaProductos.ClearSelection();
        }
    }
}
