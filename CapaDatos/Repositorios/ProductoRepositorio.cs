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
    public class ProductoRepositorio : RepositorioBase<Producto>, IProductoRepositorio
    {
        private NCapasContexto _contexto; // Para utilizar EntityFramework
        private IDbConnection _conexion; // Para utilizar Dapper

        /// <summary>
        /// Obtiene todos los Productos de la base de datos utilizando el procedimiento
        /// almacenado spPRODUCTOS_Buscar.
        /// </summary>
        /// <param name="condition">Condición de búsqueda.</param>
        /// <returns>Lista de Productos encontrados.</returns>
        public IEnumerable<Producto> GetProductos(string condition)
        {
            // Utilizando Dapper
            var listaProductos = new List<Producto>();

            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetro
                p.Add("@condicion", condition);

                listaProductos = _conexion.Query<Producto>(
                    "dbo.spPRODUCTOS_Buscar",
                    p,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            return listaProductos;
        }

        /// <summary>
        /// Agrega un nuevo producto a la base de datos utilizando el procedimiento
        /// almacenado spPRODUTOS_Insertar.
        /// </summary>
        /// <param name="cliente">Objeto Producto con sus respectivos datos.</param>
        /// <returns>Un objeto Producto.</returns>
        public Producto InsertProducto(Producto producto)
        {
            // Utilizando Dapper
            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetros
                p.Add("@id_categoria", producto.Id_Categoria);
                p.Add("@id_marca", producto.Id_Marca);
                p.Add("@descripcion", producto.Descripcion);
                p.Add("@costo", producto.Costo);
                p.Add("@ganancia", producto.Ganancia);
                p.Add("@existencia", producto.Existencia);

                // Ejecutar procedimiento almacenado
                _conexion.Execute(
                    "dbo.spPRODUCTOS_Insertar",
                    p,
                    commandType: CommandType.StoredProcedure);
                
                return producto;
            }
        }

        public Producto UpdateProducto(Producto producto)
        {
            // Utilizando Dapper
            using (_conexion = new SqlConnection(
                ConfigurationManager.ConnectionStrings["NCapasContext"].ConnectionString))
            {
                var p = new DynamicParameters();

                // Parámetros
                p.Add("@id", producto.Id);
                p.Add("@id_categoria", producto.Id_Categoria);
                p.Add("@id_marca", producto.Id_Marca);
                p.Add("@descripcion", producto.Descripcion);
                p.Add("@costo", producto.Costo);
                p.Add("@ganancia", producto.Ganancia);
                p.Add("@existencia", producto.Existencia);

                // Ejecutar procedimiento almacenado
                _conexion.Execute(
                    "dbo.spPRODUCTOS_Editar",
                    p,
                    commandType: CommandType.StoredProcedure);

                return producto;
            }
        }
    }
}
