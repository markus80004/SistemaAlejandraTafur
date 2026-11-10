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
    public class datTipoTurno
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTipoTurno _instancia = new datTipoTurno();
        //privado para evitar la instanciación directa
        public static datTipoTurno Instancia
        {
            get
            {
                return datTipoTurno._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ////////////////////ListarTipoTurno
        public List<entTipoTurno> ListarTipoTurno()
        {
            SqlCommand cmd = null;
            List<entTipoTurno> lista = new List<entTipoTurno>();
            SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
            try
            {
                cmd = new SqlCommand("spListarTipoTurno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(leerTipoTurno(dr));
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

        /////////////////////////InsertarTipoTurno
        public Boolean InsertarTipoTurno(entTipoTurno Tur)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spInsertarTipoTurno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", Tur.codigo);
                cmd.Parameters.AddWithValue("@nombre", Tur.nombre);
                cmd.Parameters.AddWithValue("@horaEntrada", Tur.horaEntrada);
                cmd.Parameters.AddWithValue("@horaSalida", Tur.horaSalida);
                cmd.Parameters.AddWithValue("@duracionHoras", Tur.duracionHoras);
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

        /////////////////////////EditarTipoTurno
        public Boolean EditarTipoTurno(entTipoTurno Tur)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spEditarTipoTurno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoTurno", Tur.idTipoTurno);
                cmd.Parameters.AddWithValue("@codigo", Tur.codigo);
                cmd.Parameters.AddWithValue("@nombre", Tur.nombre);
                cmd.Parameters.AddWithValue("@horaEntrada", Tur.horaEntrada);
                cmd.Parameters.AddWithValue("@horaSalida", Tur.horaSalida);
                cmd.Parameters.AddWithValue("@duracionHoras", Tur.duracionHoras);
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

        /////////////////////////DeshabilitarTipoTurno
        public Boolean DeshabilitarTipoTurno(entTipoTurno Tur)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spDeshabilitarTipoTurno", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTipoTurno", Tur.idTipoTurno);
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

        // pasa los datos del reader a un objeto entTipoTurno
        private entTipoTurno leerTipoTurno(SqlDataReader dr)
        {
            entTipoTurno Tur = new entTipoTurno();
            Tur.idTipoTurno = Convert.ToInt32(dr["id_tipo_turno"]);
            Tur.codigo = dr["codigo"].ToString();
            Tur.nombre = dr["nombre"].ToString();
            Tur.horaEntrada = (TimeSpan)dr["hora_entrada"];
            Tur.horaSalida = (TimeSpan)dr["hora_salida"];
            Tur.duracionHoras = Convert.ToDecimal(dr["duracion_horas"]);
            Tur.estado = dr["estado"].ToString();
            return Tur;
        }
        #endregion metodos
    }
}
