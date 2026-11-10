using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoAusencia
    {
        public int idTipoAusencia { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Boolean requiereDocumento { get; set; }
        public string estado { get; set; }       // Activo o Inactivo
    }
}
