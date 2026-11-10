using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoTurno
    {
        public int idTipoTurno { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public TimeSpan horaEntrada { get; set; }
        public TimeSpan horaSalida { get; set; }
        public decimal duracionHoras { get; set; }
        public string estado { get; set; }       // Activo o Inactivo
    }
}
