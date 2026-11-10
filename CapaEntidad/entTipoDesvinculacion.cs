using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoDesvinculacion
    {
        public int idTipoDesvinculacion { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Boolean reqCartaRenuncia { get; set; }
        public Boolean reqAprobacion { get; set; }
        public Boolean estTipoDesvinculacion { get; set; }
    }
}