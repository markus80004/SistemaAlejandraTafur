using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datTipoDesvinculacion
    {
        #region sigleton
        private static readonly datTipoDesvinculacion _instancia = new datTipoDesvinculacion();
        //privado para evitar la instanciación directa
        public static datTipoDesvinculacion Instancia
        {
            get
            {
                return datTipoDesvinculacion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Tipos de Desvinculacion
        public List<entTipoDesvinculacion> ListarTipoDesvinculacion()
        {
            SqlCommand cmd = null;
            List<entTipoDesvinculacion> lista = new List<entTipoDesvinculacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoDesvinculacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoDesvinculacion Tip = new entTipoDesvinculacion();
                    Tip.idTipoDesvinculacion = Convert.ToInt32(dr["idTipoDesvinculacion"]);
                    Tip.nombre = dr["nombre"].ToString();
                    Tip.descripcion = dr["descripcion"].ToString();
                    Tip.reqCartaRenuncia = Convert.ToBoolean(dr["reqCartaRenuncia"]);
                    Tip.reqAprobacion = Convert.ToBoolean(dr["reqAprobacion"]);
                    Tip.estTipoDesvinculacion = Convert.ToBoolean(dr["estTipoDesvinculacion"]);
                    lista.Add(Tip);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        /////////////////////////InsertaTipoDesvinculacion
        public Boolean InsertarTipoDesvinculacion(entTipoDesvinculacion Tip)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoDesvinculacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Tip.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Tip.descripcion);
                cmd.Parameters.AddWithValue("@reqCartaRenuncia", Tip.reqCartaRenuncia);
                cmd.Parameters.AddWithValue("@reqAprobacion", Tip.reqAprobacion);
                cmd.Parameters.AddWithValue("@estTipoDesvinculacion", Tip.estTipoDesvinculacion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //////////////////////////////////EditaTipoDesvinculacion
        public Boolean EditarTipoDesvinculacion(entTipoDesvinculacion Tip)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoDesvinculacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoDesvinculacion", Tip.idTipoDesvinculacion);
                cmd.Parameters.AddWithValue("@nombre", Tip.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Tip.descripcion);
                cmd.Parameters.AddWithValue("@reqCartaRenuncia", Tip.reqCartaRenuncia);
                cmd.Parameters.AddWithValue("@reqAprobacion", Tip.reqAprobacion);
                cmd.Parameters.AddWithValue("@estTipoDesvinculacion", Tip.estTipoDesvinculacion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaTipoDesvinculacion
        public Boolean DeshabilitarTipoDesvinculacion(entTipoDesvinculacion Tip)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipoDesvinculacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoDesvinculacion", Tip.idTipoDesvinculacion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        #endregion metodos
    }
}