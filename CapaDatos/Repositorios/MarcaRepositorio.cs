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
    public class MarcaRepositorio : RepositorioBase<Marca>, IMarcaRepositorio
    {
        private NCapasContexto _contexto; // Para utilizar EntityFramework
        private IDbConnection _conexion; // Para utilizar Dapper

        /// <summary>
        /// Obtiene todas las Marcas de la base de datos utilizando el procedimiento
        /// almacenado spMARCAS_Buscar.
        /// </summary>
        /// <param name="condicion">Condición de búsqueda.</param>
        /// <returns>Lista de Marcas encontradas.</returns>
        public IEnumerable<Marca> GetMarcas(string condicion)
        {
            // Utilizando Dapper
            var listaMarcas = new List<Marca>();

            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@condicion", condicion);

                listaMarcas = _conexion.Query<Marca>(
                    "dbo.spMARCAS_Buscar",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            return listaMarcas;
        }

        /// <summary>
        /// Obtiene el Id de la Marca seleccionada en el formulario.
        /// </summary>
        /// <param name="condicion">Descripción de la Marca.</param>
        /// <returns>El Id de la Marca.</returns>
        public int GetIdMarca(string condicion)
        {
            // Utilizando Dapper
            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var marca = new Marca();
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@condicion", condicion);

                marca = _conexion.Query<Marca>(
                    "dbo.spMARCAS_BuscarId",
                    p,
                    commandType: CommandType.StoredProcedure).Single();

                return marca.Id;
            }
        }
    }
}
