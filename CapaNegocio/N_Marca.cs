using CapaDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Marca
    {
        public MarcaRepositorio oMarca { get; set; }

        public N_Marca()
        {
            oMarca = new MarcaRepositorio();
        }

        public List<string> MostrarMarcas(string condicion)
        {
            List<string> marcas = new List<string>();
            var lista = oMarca.GetMarcas(condicion).ToList();

            foreach (var m in lista)
            {
                marcas.Add(m.Descripcion);
            }

            return marcas;
        }

        public int ObtenerIdMarca(string condicion)
        {
            return oMarca.GetIdMarca(condicion);
        }
    }
}
