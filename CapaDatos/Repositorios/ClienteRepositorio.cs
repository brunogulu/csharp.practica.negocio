using CapaEntidades.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CapaNegocio.Repositorios
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        private NCapasContexto _contexto; // Para utilizar EntityFramework
        private IDbConnection _conexion; // Para utilizar Dapper

        /// <summary>
        /// Obtiene todos los Clientes de la base de datos utilizando el procedimiento
        /// almacenado spCLIENTES_Buscar.
        /// </summary>
        /// <param name="condicion">Condición de búsqueda.</param>
        /// <returns>Lista de Clientes encontrados.</returns>
        public IEnumerable<Cliente> GetClientes(string condicion)
        {
            // Utilizando Dapper
            var listaClientes = new List<Cliente>();

            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@condicion", condicion);

                listaClientes = _conexion.Query<Cliente>(
                    "dbo.spCLIENTES_Buscar",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            return listaClientes;
        }

        /// <summary>
        /// Obtiene el Cliente que coincide con el Id ingresado.
        /// </summary>
        /// <param name="id">Id del Cliente.</param>
        /// <returns>El Cliente que coincide con el Id ingresado.</returns>
        public Cliente GetClienteById(int id)
        {
            // Utilizando Dapper
            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var cliente = new Cliente();
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@id", id);

                cliente = _conexion.Query<Cliente>(
                    "dbo.spCLIENTES_BuscarPorId",
                    p,
                    commandType: CommandType.StoredProcedure).Single();

                return cliente;
            }
        }

        /// <summary>
        /// Agrega un nuevo cliente a la base de datos utilizando el procedimiento
        /// almacenado spCLIENTES_Insertar.
        /// </summary>
        /// <param name="cliente">Objeto Cliente con sus respectivos datos.</param>
        /// <returns>Un objeto Cliente.</returns>
        public Cliente InsertCliente(Cliente cliente)
        {
            // Utilizando Dapper
            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetros
                p.Add("@nombre", cliente.Nombre);
                p.Add("@apellido", cliente.Apellido);
                p.Add("@dni", cliente.Dni);
                p.Add("@direccion", cliente.Direccion);
                p.Add("@ciudad", cliente.Ciudad);
                p.Add("@telefono", cliente.Telefono);
                p.Add("@email", cliente.Email);
                // Parámetro de salida (Indica si el cliente fue registrado)
                p.Add("@mensaje", dbType: DbType.String, size: 100, direction: ParameterDirection.Output);

                // Ejecutar procedimiento almacenado
                _conexion.Execute(
                    "dbo.spCLIENTES_Insertar",
                    p,
                    commandType: CommandType.StoredProcedure);

                Respuesta = p.Get<string>("@mensaje");

                return cliente;
            }
        }

        /// <summary>
        /// Modifica los datos del Cliente que ha sido seleccionado de la tabla de Clientes.
        /// </summary>
        /// <param name="cliente">Cliente a modificar.</param>
        /// <returns>El Cliente con los datos actualizados.</returns>
        public Cliente UpdateCliente(Cliente cliente)
        {
            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetros
                p.Add("@id", cliente.Id);
                p.Add("@nombre", cliente.Nombre);
                p.Add("@apellido", cliente.Apellido);
                p.Add("@dni", cliente.Dni);
                p.Add("@direccion", cliente.Direccion);
                p.Add("@ciudad", cliente.Ciudad);
                p.Add("@telefono", cliente.Telefono);
                p.Add("@email", cliente.Email);

                // Ejecutar procedimiento almacenado
                _conexion.Execute(
                    "dbo.spCLIENTES_Editar",
                    p,
                    commandType: CommandType.StoredProcedure);

                return cliente;
            }
        }
    }
}
