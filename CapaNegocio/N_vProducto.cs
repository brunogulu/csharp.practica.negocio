using CapaDatos.Repositorios;
using CapaEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_vProducto
    {
        private vProductoRepositorio ovProducto { get; set; }

        public N_vProducto()
        {
            ovProducto = new vProductoRepositorio();
        }

        public IEnumerable<vProducto> MostrarProductos(string condicion)
        {
            return ovProducto.GetProductos(condicion);
        }

        public vProducto ObtenerProductoPorId(int id)
        {
            var producto = ovProducto.GetProductoById(id);
            return producto;
        }
    }
}
