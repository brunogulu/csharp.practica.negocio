using CapaDatos.Repositorios;
using CapaEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Producto
    {
        private ProductoRepositorio oProducto { get; set; }

        public N_Producto()
        {
            oProducto = new ProductoRepositorio();
        }

        public int AgregarProducto(Producto nuevoProducto)
        {
            oProducto.InsertProducto(nuevoProducto);
            return nuevoProducto.Id;
        }

        public Producto EditarProducto(Producto elProducto)
        {
            var producto = oProducto.UpdateProducto(elProducto);
            return producto;
        }
    }
}
