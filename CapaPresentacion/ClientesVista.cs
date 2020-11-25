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
    public partial class ClientesVista : Form
    {
        //TODO - Ver patrón UnitOfWork
        public static N_Cliente oCliente { get; set; }

        public ClientesVista()
        {
            InitializeComponent();
            oCliente = new N_Cliente();
        }

        private void ClienteVista_Load(object sender, EventArgs e)
        {
            TablaClientes.DataSource = oCliente.MostrarClientes(tbBuscarClientes.Text);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            TablaClientes.DataSource = oCliente.MostrarClientes(tbBuscarClientes.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoClienteVista = new NuevoClienteVista();
            nuevoClienteVista.ShowDialog();

            TablaClientes.DataSource = oCliente.MostrarClientes(tbBuscarClientes.Text);
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar que haya un Cliente seleccionado
            if (TablaClientes.SelectedRows.Count > 0)
            {
                // Extrar Id del Cliente
                int id = int.Parse(TablaClientes.CurrentRow.Cells[0].Value.ToString());

                // Obtener el Cliente de la BD
                var cliente = oCliente.ObtenerClientePorId(id);

                // Abrir formulario y pasarle el objeto Cliente
                NuevoClienteVista ncVista = new NuevoClienteVista(cliente);
                ncVista.ShowDialog();

                // Refrescar la tabla de Clientes
                TablaClientes.DataSource = oCliente.MostrarClientes(tbBuscarClientes.Text);
                Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione un Cliente");
            }
        }

        private void ClientesVista_Shown(object sender, EventArgs e)
        {
            TablaClientes.ClearSelection();
        }
    }
}
