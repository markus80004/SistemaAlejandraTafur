using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logArea
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logArea _instancia = new logArea();
        //privado para evitar la instanciación directa
        public static logArea Instancia
        {
            get
            {
                return logArea._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entArea> ListarArea()
        {
            return datArea.Instancia.ListarArea();
        }
        ///listado solo de los activos (para los combos)
        public List<entArea> ListarAreaActivo()
        {
            return datArea.Instancia.ListarArea().Where(x => x.estado == "Activo").ToList();
        }
        ///inserta
        public Boolean InsertaArea(entArea Are)
        {
            return datArea.Instancia.InsertarArea(Are);
        }
        ///edita
        public Boolean EditaArea(entArea Are)
        {
            return datArea.Instancia.EditarArea(Are);
        }
        ///deshabilita
        public Boolean DeshabilitarArea(entArea Are)
        {
            return datArea.Instancia.DeshabilitarArea(Are);
        }
        #endregion metodos
    }
}
