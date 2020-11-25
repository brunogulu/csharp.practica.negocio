using CapaEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public interface IProductoRepositorio
    {
        IEnumerable<Producto> GetProductos(string condicion);
        Producto InsertProducto(Producto producto);
    }
}
