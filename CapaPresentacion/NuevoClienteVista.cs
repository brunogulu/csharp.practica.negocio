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
    public partial class NuevoClienteVista : Form
    {
        private char opcion { get; set; }
        private int idCliente { get; set; }

        public NuevoClienteVista()
        {
            InitializeComponent();

            // 'A' = Agregar (botón)
            // 'E' = Editar (botón)
            opcion = 'A';
        }

        public NuevoClienteVista(Cliente cliente)
        {
            InitializeComponent();

            opcion = 'E';
            idCliente = cliente.Id;

            tbNombre.Text = cliente.Nombre;
            tbApellido.Text = cliente.Apellido;
            tbDni.Text = cliente.Dni;
            tbDireccion.Text = cliente.Direccion;
            tbCiudad.Text = cliente.Ciudad;
            tbTelefono.Text = cliente.Telefono;
            tbEmail.Text = cliente.Email;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = crearNuevoCliente();

            if (opcion == 'A') // AGREGAR Cliente
            {
                ClientesVista.oCliente.AgregarCliente(nuevoCliente);
                opcion = ' ';
                Close();
            }
            else if (opcion == 'E') // EDITAR Cliente
            {
                nuevoCliente.Id = idCliente;
                ClientesVista.oCliente.EditarCliente(nuevoCliente);
                opcion = ' ';
                Close();
            }
            else // ERROR
            {
                MessageBox.Show("Error, el formulario se cerrará.");
                opcion = ' ';
                Close();
            }
        }

        private Cliente crearNuevoCliente()
        {
            var nuevoCliente = new Cliente();

            nuevoCliente.Nombre = tbNombre.Text;
            nuevoCliente.Apellido = tbApellido.Text;
            nuevoCliente.Dni = tbDni.Text;
            nuevoCliente.Direccion = tbDireccion.Text;
            nuevoCliente.Ciudad = tbCiudad.Text;
            nuevoCliente.Telefono = tbTelefono.Text;
            nuevoCliente.Email = tbEmail.Text;

            return nuevoCliente;
        }
    }
}
