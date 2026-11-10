using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logTipoTurno
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoTurno _instancia = new logTipoTurno();
        //privado para evitar la instanciación directa
        public static logTipoTurno Instancia
        {
            get
            {
                return logTipoTurno._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entTipoTurno> ListarTipoTurno()
        {
            return datTipoTurno.Instancia.ListarTipoTurno();
        }
        ///inserta
        public Boolean InsertaTipoTurno(entTipoTurno Tur)
        {
            return datTipoTurno.Instancia.InsertarTipoTurno(Tur);
        }
        ///edita
        public Boolean EditaTipoTurno(entTipoTurno Tur)
        {
            return datTipoTurno.Instancia.EditarTipoTurno(Tur);
        }
        ///deshabilita
        public Boolean DeshabilitarTipoTurno(entTipoTurno Tur)
        {
            return datTipoTurno.Instancia.DeshabilitarTipoTurno(Tur);
        }
        #endregion metodos
    }
}
