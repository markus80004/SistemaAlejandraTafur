using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEmpleado _instancia = new logEmpleado();
        //privado para evitar la instanciación directa
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entEmpleado> ListarEmpleado()
        {
            return datEmpleado.Instancia.ListarEmpleado();
        }
        ///listado solo de los activos (para los combos)
        public List<entEmpleado> ListarEmpleadoActivo()
        {
            return datEmpleado.Instancia.ListarEmpleado().Where(x => x.estado == "Activo").ToList();
        }
        ///busca por DNI, nombres o apellidos
        public List<entEmpleado> BuscarEmpleado(string texto)
        {
            return datEmpleado.Instancia.BuscarEmpleado(texto);
        }
        ///inserta
        public Boolean InsertaEmpleado(entEmpleado Emp)
        {
            return datEmpleado.Instancia.InsertarEmpleado(Emp);
        }
        ///edita
        public Boolean EditaEmpleado(entEmpleado Emp)
        {
            return datEmpleado.Instancia.EditarEmpleado(Emp);
        }
        ///deshabilita
        public Boolean DeshabilitarEmpleado(entEmpleado Emp)
        {
            return datEmpleado.Instancia.DeshabilitarEmpleado(Emp);
        }
        #endregion metodos
    }
}
