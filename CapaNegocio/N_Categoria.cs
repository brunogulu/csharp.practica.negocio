using CapaDatos.Repositorios;
using CapaEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class N_Categoria
    {
        public CategoriaRepositorio oCategoria { get; set; }

        public N_Categoria()
        {
            oCategoria = new CategoriaRepositorio();
        }

        public List<string> MostrarCategorias(string condicion)
        {
            List<string> categorias = new List<string>();
            var lista = oCategoria.GetCategorias(condicion).ToList();

            foreach (var c in lista)
            {
                categorias.Add(c.Descripcion);
            }

            return categorias;
        }

        public int ObtenerIdCategoria(string condicion)
        {
            return oCategoria.GetIdCategoria(condicion);
        }
    }
}
