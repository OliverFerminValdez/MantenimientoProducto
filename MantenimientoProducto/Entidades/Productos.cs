using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoProducto.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }

    }
}
