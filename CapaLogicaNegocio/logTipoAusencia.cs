using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logTipoAusencia
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoAusencia _instancia = new logTipoAusencia();
        //privado para evitar la instanciación directa
        public static logTipoAusencia Instancia
        {
            get
            {
                return logTipoAusencia._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entTipoAusencia> ListarTipoAusencia()
        {
            return datTipoAusencia.Instancia.ListarTipoAusencia();
        }
        ///inserta
        public Boolean InsertaTipoAusencia(entTipoAusencia Aus)
        {
            return datTipoAusencia.Instancia.InsertarTipoAusencia(Aus);
        }
        ///edita
        public Boolean EditaTipoAusencia(entTipoAusencia Aus)
        {
            return datTipoAusencia.Instancia.EditarTipoAusencia(Aus);
        }
        ///deshabilita
        public Boolean DeshabilitarTipoAusencia(entTipoAusencia Aus)
        {
            return datTipoAusencia.Instancia.DeshabilitarTipoAusencia(Aus);
        }
        #endregion metodos
    }
}
