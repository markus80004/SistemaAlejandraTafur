using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logPuesto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPuesto _instancia = new logPuesto();
        //privado para evitar la instanciación directa
        public static logPuesto Instancia
        {
            get
            {
                return logPuesto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entPuesto> ListarPuesto()
        {
            return datPuesto.Instancia.ListarPuesto();
        }
        ///listado solo de los activos (para los combos)
        public List<entPuesto> ListarPuestoActivo()
        {
            return datPuesto.Instancia.ListarPuesto().Where(x => x.estado == "Activo").ToList();
        }
        ///inserta
        public Boolean InsertaPuesto(entPuesto Pue)
        {
            return datPuesto.Instancia.InsertarPuesto(Pue);
        }
        ///edita
        public Boolean EditaPuesto(entPuesto Pue)
        {
            return datPuesto.Instancia.EditarPuesto(Pue);
        }
        ///deshabilita
        public Boolean DeshabilitarPuesto(entPuesto Pue)
        {
            return datPuesto.Instancia.DeshabilitarPuesto(Pue);
        }
        #endregion metodos
    }
}
