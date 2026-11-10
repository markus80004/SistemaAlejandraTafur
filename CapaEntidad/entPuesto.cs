using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPuesto
    {
        public int idPuesto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int idArea { get; set; }
        public decimal tarifaSueldo { get; set; }
        public string estado { get; set; }       // Activo o Inactivo
        public string nombreArea { get; set; }
    }
}
