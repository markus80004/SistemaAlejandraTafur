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
    public class datArea
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datArea _instancia = new datArea();
        //privado para evitar la instanciación directa
        public static datArea Instancia
        {
            get
            {
                return datArea._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ////////////////////ListarArea
        public List<entArea> ListarArea()
        {
            SqlCommand cmd = null;
            List<entArea> lista = new List<entArea>();
            SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
            try
            {
                cmd = new SqlCommand("spListarArea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(leerArea(dr));
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

        /////////////////////////InsertarArea
        public Boolean InsertarArea(entArea Are)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spInsertarArea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Are.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Are.descripcion);
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

        /////////////////////////EditarArea
        public Boolean EditarArea(entArea Are)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spEditarArea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idArea", Are.idArea);
                cmd.Parameters.AddWithValue("@nombre", Are.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Are.descripcion);
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

        /////////////////////////DeshabilitarArea
        public Boolean DeshabilitarArea(entArea Are)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spDeshabilitarArea", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idArea", Are.idArea);
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

        // pasa los datos del reader a un objeto entArea
        private entArea leerArea(SqlDataReader dr)
        {
            entArea Are = new entArea();
            Are.idArea = Convert.ToInt32(dr["id_area"]);
            Are.nombre = dr["nombre"].ToString();
            Are.descripcion = dr["descripcion"].ToString();
            Are.estado = dr["estado"].ToString();
            return Are;
        }
        #endregion metodos
    }
}
