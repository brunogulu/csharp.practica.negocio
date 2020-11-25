using CapaEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public interface IMarcaRepositorio
    {
        IEnumerable<Marca> GetMarcas(string condicion);
    }
}
