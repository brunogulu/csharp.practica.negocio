using CapaEntidades.Entidades;
using CapaNegocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class N_Cliente
    {
        private ClienteRepositorio oCliente { get; set; }

        public N_Cliente()
        {
            oCliente = new ClienteRepositorio();
        }
        
        public IEnumerable<Cliente> MostrarClientes(string condicion)
        {
            return oCliente.GetClientes(condicion);
        }

        public int AgregarCliente(Cliente nuevoCliente)
        {
            oCliente.InsertCliente(nuevoCliente);
            return nuevoCliente.Id;
        }

        public Cliente ObtenerClientePorId(int id)
        {
            var cliente = oCliente.GetClienteById(id);
            return cliente;
        }

        public Cliente EditarCliente(Cliente elCliente)
        {
            var cliente = oCliente.UpdateCliente(elCliente);
            return cliente;
        }
    }
}
