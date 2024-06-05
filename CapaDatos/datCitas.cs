using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaDatos
{
    public class datCitas
    {
        #region sigleton

        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCitas _instancia = new datCitas();
        //privado para evitar la instanciación directa
        public static datCitas Instancia
        {
            get
            {
                return datCitas._instancia;
            }
        }
        #endregion singleton

        public List<entCitas> ListarCitas()
        {
            SqlCommand cmd = null;
            List<entCitas> lista = new List<entCitas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entCitas citas = new entCitas();
                        citas.codCitas = Convert.ToInt16(dr["C_CITAS"].ToString());
                        citas.nombres = dr["NOMBRES"].ToString();
                        citas.apellidoPaterno = dr["APELLIDO_PATERNO"].ToString();
                        citas.apellidoMaterno = dr["APELLIDO_MATERNO"].ToString();
                        citas.fechaNacimiento = Convert.ToDateTime(dr["FECHA_DE_NACIMIENTO"].ToString());
                        citas.celular = dr["CELULAR"].ToString();
                        citas.fechaEntrevista = Convert.ToDateTime(dr["FECHA_DE_ENTREVISTA"].ToString());
                        citas.horaEntrevista = TimeSpan.Parse(dr["HORA_DE_ENTREVISTA"].ToString());
                        citas.edad = Convert.ToInt16(dr["EDAD"].ToString());
                        citas.refLlegada = dr["RefLlegada"].ToString();
                        citas.rangoEdad = dr["RANGO_DE_EDAD"].ToString();
                        citas.mes = Convert.ToInt16(dr["MES"].ToString());
                        citas.año = Convert.ToInt16(dr["ANIO"].ToString());
                        citas.distrito = dr["DISTRITO"].ToString();
                        citas.provincia = dr["PROVINCIA"].ToString();
                        citas.departamento = dr["DEPARTAMENTO"].ToString();
                        citas.direccion = dr["DIRECCION"].ToString();
                        citas.refDomicilio = dr["REFERENCIA_DE_DOMICILIO"].ToString();
                        citas.UserId = Convert.ToInt16(dr["USUARIO_ID"].ToString());
                        citas.dni = dr["DNI"].ToString();
                        lista.Add(citas);

                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }
        public List<entCitasBuscar> BuscarCitaDni(string id)
        {
            SqlCommand cmd = null;
            List<entCitasBuscar> lista = new List<entCitasBuscar>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("spListarCitasPorDNI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_dni", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCitasBuscar citas = new entCitasBuscar();
                    citas.codCitas = Convert.ToInt16(dr["C_CITAS"].ToString());
                    citas.fechaEntrevista = Convert.ToDateTime(dr["FECHA_DE_ENTREVISTA"].ToString());
                    citas.dni = dr["DNI"].ToString();
                    lista.Add(citas);
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
            lista = lista.OrderByDescending(c => c.fechaEntrevista).ToList();
            return lista;
        }

        public Boolean InsertaCitas(entCitas cita)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCitas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombres", cita.nombres);
                cmd.Parameters.AddWithValue("@apellido_paterno", cita.apellidoPaterno);
                cmd.Parameters.AddWithValue("@apellido_materno", cita.apellidoMaterno);
                cmd.Parameters.AddWithValue("@fecha_de_nacimiento", cita.fechaNacimiento);
                cmd.Parameters.AddWithValue("@celular", cita.celular);
                cmd.Parameters.AddWithValue("@fecha_de_entrevista", cita.fechaEntrevista);
                cmd.Parameters.AddWithValue("@hora_de_entrevista", cita.horaEntrevista);
                cmd.Parameters.AddWithValue("@edad", cita.edad);
                cmd.Parameters.AddWithValue("@ref_llegada", cita.refLlegada);
                cmd.Parameters.AddWithValue("@rango_de_edad", cita.rangoEdad);
                cmd.Parameters.AddWithValue("@mes", cita.mes);
                cmd.Parameters.AddWithValue("@anio", cita.año);
                cmd.Parameters.AddWithValue("@distrito", cita.distrito);
                cmd.Parameters.AddWithValue("@provincia", cita.provincia);
                cmd.Parameters.AddWithValue("@departamento", cita.departamento);
                cmd.Parameters.AddWithValue("@direccion", cita.direccion);
                cmd.Parameters.AddWithValue("@qreferencia_de_domicilio", cita.refDomicilio);
                cmd.Parameters.AddWithValue("@usuario_id", cita.UserId);
                cmd.Parameters.AddWithValue("@dni", cita.dni);
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

        public bool EditarCita(entCitas cita)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_c_citas", cita.codCitas);
                cmd.Parameters.AddWithValue("@p_nombres", cita.nombres);
                cmd.Parameters.AddWithValue("@p_apellido_paterno", cita.apellidoPaterno);
                cmd.Parameters.AddWithValue("@p_apellido_materno", cita.apellidoMaterno);
                cmd.Parameters.AddWithValue("@p_fecha_de_nacimiento", cita.fechaNacimiento);
                cmd.Parameters.AddWithValue("@p_celular", cita.celular);
                cmd.Parameters.AddWithValue("@p_fecha_de_entrevista", cita.fechaEntrevista);
                cmd.Parameters.AddWithValue("@p_hora_de_entrevista", cita.horaEntrevista);
                cmd.Parameters.AddWithValue("@p_edad", cita.edad);
                cmd.Parameters.AddWithValue("@p_ref_llegada", cita.refLlegada);
                cmd.Parameters.AddWithValue("@p_rango_de_edad", cita.rangoEdad);
                cmd.Parameters.AddWithValue("@p_mes", cita.mes);
                cmd.Parameters.AddWithValue("@p_anio", cita.año);
                cmd.Parameters.AddWithValue("@p_distrito", cita.distrito);
                cmd.Parameters.AddWithValue("@p_provincia", cita.provincia);
                cmd.Parameters.AddWithValue("@p_departamento", cita.departamento);
                cmd.Parameters.AddWithValue("@p_direccion", cita.direccion);
                cmd.Parameters.AddWithValue("@p_referencia_de_domicilio", cita.refDomicilio);
                cmd.Parameters.AddWithValue("@p_usuario_id", cita.UserId);
                cmd.Parameters.AddWithValue("@p_dni", cita.dni);
                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
        }

        public bool EliminarCita(entCitas citas)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCita", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_c_citas", citas.codCitas);
                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
        }


    }
}
