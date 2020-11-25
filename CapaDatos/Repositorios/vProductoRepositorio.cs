using CapaEntidades.Entidades;
using CapaNegocio;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class vProductoRepositorio : RepositorioBase<vProducto>, IvProductoRepositorio
    {
        private NCapasContexto _contexto; // Para utilizar EntityFramework
        private IDbConnection _conexion; // Para utilizar Dapper

        /// <summary>
        /// Obtiene todos los Productos de la vista vPRODUCTOS de la base de datos
        /// utilizando el procedimiento almacenado spPRODUCTOS_Buscar.
        /// </summary>
        /// <param name="condition">Condición de búsqueda.</param>
        /// <returns>Lista de Productos encontrados.</returns>
        public IEnumerable<vProducto> GetProductos(string condicion)
        {
            // Utilizando Dapper
            var listaProductos = new List<vProducto>();

            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@condicion", condicion);

                listaProductos = _conexion.Query<vProducto>(
                    "dbo.spPRODUCTOS_Buscar",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            return listaProductos;
        }

        /// <summary>
        /// Obtiene el Producto que coincide con el Id ingresado.
        /// </summary>
        /// <param name="id">Id del Producto.</param>
        /// <returns>El Producto que coincide con el Id ingresado.</returns>
        public vProducto GetProductoById(int id)
        {
            // Utilizando Dapper
            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var producto = new vProducto();
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@id", id);

                producto = _conexion.Query<vProducto>(
                    "dbo.spPRODUCTOS_BuscarPorId",
                    p,
                    commandType: CommandType.StoredProcedure).Single();

                return producto;
            }
        }
    }
}
