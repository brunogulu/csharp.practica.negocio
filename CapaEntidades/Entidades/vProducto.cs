using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Entidades
{
    // Clase que corresponde a la Vista "vPRODUCTOS" de la BD para mostrar
    // los productos en el DataGridView de Productos.
    public partial class vProducto
    {
        public int Id { get; set; }

        public string Categoria { get; set; }

        public string Marca { get; set; }

        public string Descripcion { get; set; }

        public decimal Costo { get; set; }

        public decimal Ganancia { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal Precio { get; set; }

        public int Existencia { get; set; }
    }
}
