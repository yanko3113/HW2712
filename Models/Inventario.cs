using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW27122021.Models
{
    public class Inventario
    {
        public int id { get; set; }
        public string producto { get; set; }
        public string usuario { get; set; }
        public int cantidadAntigua { get; set; }
        public int cantidadNueva { get; set; }
        public byte estado { get; set; }
    }
}
