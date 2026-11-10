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
    public class datTipoAusencia
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTipoAusencia _instancia = new datTipoAusencia();
        //privado para evitar la instanciación directa
        public static datTipoAusencia Instancia
        {
            get
            {
                return datTipoAusencia._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ////////////////////ListarTipoAusencia
        public List<entTipoAusencia> ListarTipoAusencia()
        {
            SqlCommand cmd = null;
            List<entTipoAusencia> lista = new List<entTipoAusencia>();
            SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
            try
            {
                cmd = new SqlCommand("spListarTipoAusencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(leerTipoAusencia(dr));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return lista;
        }

        /////////////////////////InsertarTipoAusencia
        public Boolean InsertarTipoAusencia(entTipoAusencia Aus)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spInsertarTipoAusencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Aus.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Aus.descripcion);
                cmd.Parameters.AddWithValue("@requiereDocumento", Aus.requiereDocumento);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }
            return inserta;
        }

        /////////////////////////EditarTipoAusencia
        public Boolean EditarTipoAusencia(entTipoAusencia Aus)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spEditarTipoAusencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoAusencia", Aus.idTipoAusencia);
                cmd.Parameters.AddWithValue("@nombre", Aus.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Aus.descripcion);
                cmd.Parameters.AddWithValue("@requiereDocumento", Aus.requiereDocumento);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }
            return edita;
        }

        /////////////////////////DeshabilitarTipoAusencia
        public Boolean DeshabilitarTipoAusencia(entTipoAusencia Aus)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spDeshabilitarTipoAusencia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoAusencia", Aus.idTipoAusencia);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cn.Close(); }
            return delete;
        }

        // pasa los datos del reader a un objeto entTipoAusencia
        private entTipoAusencia leerTipoAusencia(SqlDataReader dr)
        {
            entTipoAusencia Aus = new entTipoAusencia();
            Aus.idTipoAusencia = Convert.ToInt32(dr["id_tipo_ausencia"]);
            Aus.nombre = dr["nombre"].ToString();
            Aus.descripcion = dr["descripcion"].ToString();
            Aus.requiereDocumento = Convert.ToBoolean(dr["requiere_documento"]);
            Aus.estado = dr["estado"].ToString();
            return Aus;
        }
        #endregion metodos
    }
}
