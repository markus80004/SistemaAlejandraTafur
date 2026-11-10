using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logTipoDesvinculacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoDesvinculacion _instancia = new logTipoDesvinculacion();
        //privado para evitar la instanciación directa
        public static logTipoDesvinculacion Instancia
        {
            get
            {
                return logTipoDesvinculacion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entTipoDesvinculacion> ListarTipoDesvinculacion()
        {
            return datTipoDesvinculacion.Instancia.ListarTipoDesvinculacion();
        }

        ///inserta
        public void InsertaTipoDesvinculacion(entTipoDesvinculacion Tip)
        {
            datTipoDesvinculacion.Instancia.InsertarTipoDesvinculacion(Tip);
        }

        //edita
        public void EditaTipoDesvinculacion(entTipoDesvinculacion Tip)
        {
            datTipoDesvinculacion.Instancia.EditarTipoDesvinculacion(Tip);
        }

        //deshabilita
        public void DeshabilitarTipoDesvinculacion(entTipoDesvinculacion Tip)
        {
            datTipoDesvinculacion.Instancia.DeshabilitarTipoDesvinculacion(Tip);
        }
        #endregion metodos
    }
}