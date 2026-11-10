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
    public class datEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEmpleado _instancia = new datEmpleado();
        //privado para evitar la instanciación directa
        public static datEmpleado Instancia
        {
            get
            {
                return datEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ////////////////////ListarEmpleado
        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
            try
            {
                cmd = new SqlCommand("spListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(leerEmpleado(dr));
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

        ////////////////////BuscarEmpleado
        public List<entEmpleado> BuscarEmpleado(string texto)
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
            try
            {
                cmd = new SqlCommand("spBuscarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@texto", texto);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(leerEmpleado(dr));
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

        /////////////////////////InsertarEmpleado
        public Boolean InsertarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spInsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", Emp.dni);
                cmd.Parameters.AddWithValue("@nombres", Emp.nombres);
                cmd.Parameters.AddWithValue("@apellidos", Emp.apellidos);
                cmd.Parameters.AddWithValue("@fechaIngreso", Emp.fechaIngreso);
                cmd.Parameters.AddWithValue("@idArea", Emp.idArea);
                cmd.Parameters.AddWithValue("@idPuesto", Emp.idPuesto);
                cmd.Parameters.AddWithValue("@condicion", Emp.condicion);
                cmd.Parameters.AddWithValue("@sueldoBase", Emp.sueldoBase);
                cmd.Parameters.AddWithValue("@correo", Emp.correo);
                cmd.Parameters.AddWithValue("@telefono", Emp.telefono);
                cmd.Parameters.AddWithValue("@cuentaBancaria", Emp.cuentaBancaria);
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

        /////////////////////////EditarEmpleado
        public Boolean EditarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spEditarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", Emp.idEmpleado);
                cmd.Parameters.AddWithValue("@dni", Emp.dni);
                cmd.Parameters.AddWithValue("@nombres", Emp.nombres);
                cmd.Parameters.AddWithValue("@apellidos", Emp.apellidos);
                cmd.Parameters.AddWithValue("@fechaIngreso", Emp.fechaIngreso);
                cmd.Parameters.AddWithValue("@idArea", Emp.idArea);
                cmd.Parameters.AddWithValue("@idPuesto", Emp.idPuesto);
                cmd.Parameters.AddWithValue("@condicion", Emp.condicion);
                cmd.Parameters.AddWithValue("@sueldoBase", Emp.sueldoBase);
                cmd.Parameters.AddWithValue("@correo", Emp.correo);
                cmd.Parameters.AddWithValue("@telefono", Emp.telefono);
                cmd.Parameters.AddWithValue("@cuentaBancaria", Emp.cuentaBancaria);
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

        /////////////////////////DeshabilitarEmpleado
        public Boolean DeshabilitarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            SqlConnection cn = Conexion.Instancia.Conectar();
            try
            {
                cmd = new SqlCommand("spDeshabilitarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", Emp.idEmpleado);
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

        // pasa los datos del reader a un objeto entEmpleado
        private entEmpleado leerEmpleado(SqlDataReader dr)
        {
            entEmpleado Emp = new entEmpleado();
            Emp.idEmpleado = Convert.ToInt32(dr["id_empleado"]);
            Emp.dni = dr["dni"].ToString();
            Emp.nombres = dr["nombres"].ToString();
            Emp.apellidos = dr["apellidos"].ToString();
            Emp.fechaIngreso = Convert.ToDateTime(dr["fecha_ingreso"]);
            Emp.idArea = Convert.ToInt32(dr["id_area"]);
            Emp.idPuesto = Convert.ToInt32(dr["id_puesto"]);
            Emp.condicion = dr["condicion"].ToString();
            Emp.sueldoBase = Convert.ToDecimal(dr["sueldo_base"]);
            Emp.correo = dr["correo"].ToString();
            Emp.telefono = dr["telefono"].ToString();
            Emp.cuentaBancaria = dr["cuenta_bancaria"].ToString();
            Emp.estado = dr["estado"].ToString();
            Emp.nombreArea = dr["nombreArea"].ToString();
            Emp.nombrePuesto = dr["nombrePuesto"].ToString();
            return Emp;
        }
        #endregion metodos
    }
}
