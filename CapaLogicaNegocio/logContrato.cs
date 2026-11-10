using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logContrato
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logContrato _instancia = new logContrato();
        //privado para evitar la instanciación directa
        public static logContrato Instancia
        {
            get
            {
                return logContrato._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entContrato> ListarContrato()
        {
            return datContrato.Instancia.ListarContrato();
        }
        ///inserta
        public Boolean InsertaContrato(entContrato Con)
        {
            return datContrato.Instancia.InsertarContrato(Con);
        }
        ///edita
        public Boolean EditaContrato(entContrato Con)
        {
            return datContrato.Instancia.EditarContrato(Con);
        }
        ///deshabilita
        public Boolean DeshabilitarContrato(entContrato Con)
        {
            return datContrato.Instancia.DeshabilitarContrato(Con);
        }
        #endregion metodos
    }
}
