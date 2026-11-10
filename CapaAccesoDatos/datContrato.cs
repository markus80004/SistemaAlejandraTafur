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
    public class datContrato
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datContrato _instancia = new datContrato();
        //privado para evitar la instanciación directa
        public static datContrato Instancia
        {
            get
            {
                return datContrato._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ////////////////////ListarContrato
        public List<entContrato> ListarContrato()
        {
            SqlCommand cmd = null;
            List<entContrato> lista = new List<entContrato>();
            SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
            try
            {
                cmd = new SqlCommand("spListarContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(leerContrato(dr));
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

        /////////////////////////InsertarContrato
        public Boolean InsertarContrato(entContrato Con)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spInsertarContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", Con.idEmpleado);
                cmd.Parameters.AddWithValue("@tipoContrato", Con.tipoContrato);
                cmd.Parameters.AddWithValue("@horasSemanales", Con.horasSemanales);
                cmd.Parameters.AddWithValue("@fechaInicio", Con.fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", (object)Con.fechaFin ?? DBNull.Value);
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

        /////////////////////////EditarContrato
        public Boolean EditarContrato(entContrato Con)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spEditarContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idContrato", Con.idContrato);
                cmd.Parameters.AddWithValue("@idEmpleado", Con.idEmpleado);
                cmd.Parameters.AddWithValue("@tipoContrato", Con.tipoContrato);
                cmd.Parameters.AddWithValue("@horasSemanales", Con.horasSemanales);
                cmd.Parameters.AddWithValue("@fechaInicio", Con.fechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", (object)Con.fechaFin ?? DBNull.Value);
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

        /////////////////////////DeshabilitarContrato
        public Boolean DeshabilitarContrato(entContrato Con)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spDeshabilitarContrato", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idContrato", Con.idContrato);
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

        // pasa los datos del reader a un objeto entContrato
        private entContrato leerContrato(SqlDataReader dr)
        {
            entContrato Con = new entContrato();
            Con.idContrato = Convert.ToInt32(dr["id_contrato"]);
            Con.idEmpleado = Convert.ToInt32(dr["id_empleado"]);
            Con.tipoContrato = dr["tipo_contrato"].ToString();
            Con.horasSemanales = Convert.ToInt32(dr["horas_semanales"]);
            Con.fechaInicio = Convert.ToDateTime(dr["fecha_inicio"]);
            if (dr["fecha_fin"] != DBNull.Value)
            {
                Con.fechaFin = Convert.ToDateTime(dr["fecha_fin"]);
            }
            Con.estado = dr["estado"].ToString();
            Con.nombreEmpleado = dr["nombreEmpleado"].ToString();
            return Con;
        }
        #endregion metodos
    }
}
