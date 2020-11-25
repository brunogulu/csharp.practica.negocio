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
    public class CategoriaRepositorio : RepositorioBase<Categoria>, ICategoriaRepositorio
    {
        private NCapasContexto _contexto; // Para utilizar EntityFramework
        private IDbConnection _conexion; // Para utilizar Dapper

        /// <summary>
        /// Obtiene todas las Categorías de la base de datos utilizando el procedimiento
        /// almacenado spCATEGORIAS_Buscar.
        /// </summary>
        /// <param name="condicion">Condición de búsqueda.</param>
        /// <returns>Lista de Categorías encontradas.</returns>
        public IEnumerable<Categoria> GetCategorias(string condicion)
        {
            // Utilizando Dapper
            var listaCategorias = new List<Categoria>();

            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@condicion", condicion);

                listaCategorias = _conexion.Query<Categoria>(
                    "dbo.spCATEGORIAS_Buscar",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            return listaCategorias;
        }

        /// <summary>
        /// Obtiene el Id de la Categoría seleccionada en el formulario.
        /// </summary>
        /// <param name="condicion">Descripción de la Categoría.</param>
        /// <returns>El Id de la Categoría.</returns>
        public int GetIdCategoria(string condicion)
        {
            // Utilizando Dapper
            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var categoria = new Categoria();
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@condicion", condicion);

                categoria = _conexion.Query<Categoria>(
                    "dbo.spCATEGORIAS_BuscarId",
                    p,
                    commandType: CommandType.StoredProcedure).Single();

                return categoria.Id;
            }
        }
    }
}
