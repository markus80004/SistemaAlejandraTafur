using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entContrato
    {
        public int idContrato { get; set; }
        public int idEmpleado { get; set; }
        public string tipoContrato { get; set; }
        public int horasSemanales { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime? fechaFin { get; set; }
        public string estado { get; set; }       // Activo o Inactivo
        public string nombreEmpleado { get; set; }
    }
}
