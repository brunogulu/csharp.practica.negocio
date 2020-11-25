using CapaEntidades.Entidades;
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
    public partial class NuevoProductoVista : Form
    {
        private N_Categoria oCategoria;
        private N_Marca oMarca;
        private char opcion { get; set; }
        private int idProducto { get; set; }

        public NuevoProductoVista()
        {
            InitializeComponent();

            oCategoria = new N_Categoria();
            oMarca = new N_Marca();

            cbCategoria.DataSource = oCategoria.MostrarCategorias(cbCategoria.Text);
            cbMarca.DataSource = oMarca.MostrarMarcas(cbMarca.Text);
            tbPrecio.Text = "0.00";

            // 'A' = Agregar (botón)
            // 'E' = Editar (botón)
            opcion = 'A';
        }

        public NuevoProductoVista(vProducto producto)
        {
            InitializeComponent();

            oCategoria = new N_Categoria();
            oMarca = new N_Marca();

            opcion = 'E';
            idProducto = producto.Id;

            cbCategoria.DataSource = oCategoria.MostrarCategorias("");
            cbCategoria.Text = producto.Categoria;
            cbMarca.DataSource = oMarca.MostrarMarcas("");
            cbMarca.Text = producto.Marca;
            rtbDescripcion.Text = producto.Descripcion;
            tbCosto.Text = producto.Costo.ToString();
            tbGanancia.Text = producto.Ganancia.ToString();
            tbPrecio.Text = producto.Precio.ToString();
            tbCantidad.Text = producto.Existencia.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbGanancia_Leave(object sender, EventArgs e)
        {
            CalcularPrecio();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var nuevoProducto = CrearNuevoProducto();

            if (opcion == 'A') //AGREGAR Producto
            {
                ProductosVista.oProducto.AgregarProducto(nuevoProducto);
                opcion = ' ';
                Close();
            }
            else if (opcion == 'E') //EDITAR Producto
            {
                nuevoProducto.Id = idProducto;
                ProductosVista.oProducto.EditarProducto(nuevoProducto);
                Close();
            }
            else // ERROR
            {
                MessageBox.Show("Error, el formulario se cerrará.");
                opcion = ' ';
                Close();
            }
        }

        private void CalcularPrecio()
        {
            tbPrecio.Text = (decimal.Parse(tbCosto.Text) + 
                            ((decimal.Parse(tbCosto.Text) * decimal.Parse(tbGanancia.Text))) 
                            / 100).ToString();
        } 

        private Producto CrearNuevoProducto()
        {
            var nuevoProducto = new Producto();

            nuevoProducto.Id_Categoria = oCategoria.ObtenerIdCategoria(cbCategoria.Text);
            nuevoProducto.Id_Marca = oMarca.ObtenerIdMarca(cbMarca.Text);
            nuevoProducto.Descripcion = rtbDescripcion.Text;
            nuevoProducto.Costo = decimal.Parse(tbCosto.Text);
            nuevoProducto.Ganancia = decimal.Parse(tbGanancia.Text);
            nuevoProducto.Existencia = int.Parse(tbCantidad.Text);

            return nuevoProducto;
        }
    }
}
