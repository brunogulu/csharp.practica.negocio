using CapaEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public interface ICategoriaRepositorio
    {
        IEnumerable<Categoria> GetCategorias(string condicion);
    }
}
