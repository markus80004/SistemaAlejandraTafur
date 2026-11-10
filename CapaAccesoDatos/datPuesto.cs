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
    public class datPuesto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPuesto _instancia = new datPuesto();
        //privado para evitar la instanciación directa
        public static datPuesto Instancia
        {
            get
            {
                return datPuesto._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ////////////////////ListarPuesto
        public List<entPuesto> ListarPuesto()
        {
            SqlCommand cmd = null;
            List<entPuesto> lista = new List<entPuesto>();
            SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
            try
            {
                cmd = new SqlCommand("spListarPuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(leerPuesto(dr));
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

        /////////////////////////InsertarPuesto
        public Boolean InsertarPuesto(entPuesto Pue)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spInsertarPuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", Pue.codigo);
                cmd.Parameters.AddWithValue("@nombre", Pue.nombre);
                cmd.Parameters.AddWithValue("@idArea", Pue.idArea);
                cmd.Parameters.AddWithValue("@tarifaSueldo", Pue.tarifaSueldo);
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

        /////////////////////////EditarPuesto
        public Boolean EditarPuesto(entPuesto Pue)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spEditarPuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPuesto", Pue.idPuesto);
                cmd.Parameters.AddWithValue("@codigo", Pue.codigo);
                cmd.Parameters.AddWithValue("@nombre", Pue.nombre);
                cmd.Parameters.AddWithValue("@idArea", Pue.idArea);
                cmd.Parameters.AddWithValue("@tarifaSueldo", Pue.tarifaSueldo);
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

        /////////////////////////DeshabilitarPuesto
        public Boolean DeshabilitarPuesto(entPuesto Pue)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spDeshabilitarPuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPuesto", Pue.idPuesto);
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

        // pasa los datos del reader a un objeto entPuesto
        private entPuesto leerPuesto(SqlDataReader dr)
        {
            entPuesto Pue = new entPuesto();
            Pue.idPuesto = Convert.ToInt32(dr["id_puesto"]);
            Pue.codigo = dr["codigo"].ToString();
            Pue.nombre = dr["nombre"].ToString();
            Pue.idArea = Convert.ToInt32(dr["id_area"]);
            Pue.tarifaSueldo = Convert.ToDecimal(dr["tarifa_sueldo"]);
            Pue.estado = dr["estado"].ToString();
            Pue.nombreArea = dr["nombreArea"].ToString();
            return Pue;
        }
        #endregion metodos
    }
}
