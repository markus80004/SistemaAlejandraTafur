using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleado
    {
        public int idEmpleado { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int idArea { get; set; }
        public int idPuesto { get; set; }
        public string condicion { get; set; }
        public decimal sueldoBase { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string cuentaBancaria { get; set; }
        public string estado { get; set; }       // Activo o Inactivo
        public string nombreArea { get; set; }
        public string nombrePuesto { get; set; }
        public string nombreCompleto { get { return nombres + " " + apellidos; } }
    }
}
