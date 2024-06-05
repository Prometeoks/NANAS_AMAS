using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datTrabajador
    {
        #region sigleton

        // Variable estática para la instancia
        private static readonly datTrabajador _instancia = new datTrabajador();
        // Privado para evitar la instanciación directa
        public static datTrabajador Instancia
        {
            get
            {
                return _instancia;
            }
        }

        #endregion singleton

        public List<entTrabajador> ListarTrabajadores()
        {
            SqlCommand cmd = null;
            List<entTrabajador> lista = new List<entTrabajador>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDniTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entTrabajador trabajadores = new entTrabajador();
                        trabajadores.idTrabajador = Convert.ToInt16(dr["CC_TRABAJADOR"].ToString());
                        trabajadores.dni = dr["DNI"].ToString();
                        trabajadores.cTrabajador = dr["C_TRABAJADOR"].ToString();
                        trabajadores.gradoInstruccion = dr["GRADO_DE_INSTRUCCION"].ToString();
                        trabajadores.evaluacionPsicologica = dr["EVALUACION_PSICOLOGICA"].ToString();
                        trabajadores.ubicacionArchivo = dr["UBICACION_DE_ARCHIVO"].ToString();
                        trabajadores.horaInicio = TimeSpan.Parse(dr["HORA_DE_INICIO"].ToString());
                        trabajadores.horaCierre = TimeSpan.Parse(dr["HORA_DE_CIERRE"].ToString());
                        trabajadores.salario = Convert.ToInt16(dr["SALARIO"].ToString());
                        trabajadores.fechaRegistro = Convert.ToDateTime(dr["FECHA_REGISTRO"].ToString());
                        trabajadores.mes = Convert.ToInt16(dr["MES"].ToString());
                        trabajadores.año = Convert.ToInt16(dr["ANIO"].ToString());
                        trabajadores.razon = dr["RAZON"].ToString();
                        trabajadores.userId = Convert.ToInt16(dr["USUARIO_ID"].ToString());
                        trabajadores.codCitas = Convert.ToInt16(dr["C_CITAS"].ToString());
                        lista.Add(trabajadores);

                    }
                }
            }
            catch (MySqlException e)
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
        public List<entTrabajadorDni> BuscarTrabajadorDni(string id)
        {
            SqlCommand cmd = null;
            List<entTrabajadorDni> lista = new List<entTrabajadorDni>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("spListarTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_dni", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTrabajadorDni worker = new entTrabajadorDni();
                    worker.idTrabajador = Convert.ToInt16(dr["CC_TRABAJADOR"].ToString());
                    worker.dni = dr["DNI"].ToString();
                    lista.Add(worker);
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
        public List<entTrabajadorModalidad> ListarTrabajadoresModalidad()
        {
            SqlCommand cmd = null;
            List<entTrabajadorModalidad> listam = new List<entTrabajadorModalidad>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDniTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entTrabajadorModalidad trabajadores = new entTrabajadorModalidad();
                        trabajadores.camaDentro = bool.Parse(dr["CAMA_DENTRO"].ToString());
                        trabajadores.camaAfuera = bool.Parse(dr["CAMA_DENTRO"].ToString());
                        trabajadores.porDias = dr["CAMA_DENTRO"].ToString();
                        trabajadores.medioTiempoM = bool.Parse(dr["CAMA_DENTRO"].ToString());
                        trabajadores.medioTiempoT = bool.Parse(dr["CAMA_DENTRO"].ToString());
                        trabajadores.turnoNoche = bool.Parse(dr["CAMA_DENTRO"].ToString());
                        trabajadores.codTrabajador = int.Parse(dr["C_TRABAJADOR"].ToString());

                        listam.Add(trabajadores);

                    }
                }
            }
            catch (MySqlException e)
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

            return listam;
        }

        public List<entTrabajadorPuesto> BuscarTrabajadorPuesto(string id)
        {
            SqlCommand cmd = null;
            List<entTrabajadorPuesto> lista = new List<entTrabajadorPuesto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("spPuestosDni", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni_param", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTrabajadorPuesto puesto = new entTrabajadorPuesto();
                    puesto.puesto = dr["PUESTO"].ToString();
                    lista.Add(puesto);
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
        public List<entTrabajadorModalidad> BuscarTrabajadorModalidad(int id)
        {
            SqlCommand cmd = null;
            List<entTrabajadorModalidad> lista = new List<entTrabajadorModalidad>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("spModalidadDNI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_c_trabajador", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTrabajadorModalidad modalidad = new entTrabajadorModalidad();
                    modalidad.camaAfuera = Convert.ToBoolean(dr["CAMA_AFUERA"].ToString());
                    modalidad.camaDentro = Convert.ToBoolean(dr["CAMA_DENTRO"].ToString());
                    modalidad.medioTiempoM = Convert.ToBoolean(dr["MEDIO_TIEMPO_MANANA"].ToString());
                    modalidad.medioTiempoT = Convert.ToBoolean(dr["MEDIO_TIEMPO_TARDE"].ToString());
                    modalidad.porDias = dr["POR_DIAS"].ToString();
                    modalidad.turnoNoche = Convert.ToBoolean(dr["TURNO_NOCHE"].ToString());
                    lista.Add(modalidad);
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
        public Boolean InsertaTrabajador(entTrabajadorInsertar trabajador)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaTrabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", trabajador.dni);
                cmd.Parameters.AddWithValue("@c_trabajador", trabajador.cTrabajador);
                cmd.Parameters.AddWithValue("@grado_de_instruccion", trabajador.gradoInstruccion);
                cmd.Parameters.AddWithValue("@puesto", trabajador.puesto);
                cmd.Parameters.AddWithValue("@evaluacion_psicologica", trabajador.evaluacionPsicologica);
                cmd.Parameters.AddWithValue("@ubicacion_de_archivo", trabajador.ubicacionArchivo);
                cmd.Parameters.AddWithValue("@hora_de_inicio", trabajador.horaInicio);
                cmd.Parameters.AddWithValue("@hora_de_cierre", trabajador.horaCierre);
                cmd.Parameters.AddWithValue("@salario", trabajador.salario);
                cmd.Parameters.AddWithValue("@fecha_registro", trabajador.fechaRegistro);
                cmd.Parameters.AddWithValue("@mes", trabajador.mes);
                cmd.Parameters.AddWithValue("@anio", trabajador.año);
                cmd.Parameters.AddWithValue("@razon", trabajador.razon);
                cmd.Parameters.AddWithValue("@usuario_id", trabajador.userId);
                cmd.Parameters.AddWithValue("@c_citas", trabajador.codCitas);
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

        public Boolean InsertaModalidad(entTrabajadorModalidad trabajador)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaModalidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_cama_dentro", trabajador.camaDentro);
                cmd.Parameters.AddWithValue("@p_cama_afuera", trabajador.camaAfuera);
                if (trabajador.porDias == null)
                {
                    cmd.Parameters.AddWithValue("@p_por_dias", "0");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@p_por_dias", trabajador.porDias);
                }

                cmd.Parameters.AddWithValue("@p_medio_tiempo_manana", trabajador.medioTiempoM);
                cmd.Parameters.AddWithValue("@p_medio_tiempo_tarde", trabajador.medioTiempoT);
                cmd.Parameters.AddWithValue("@p_turno_noche", trabajador.turnoNoche);
                cmd.Parameters.AddWithValue("@p_c_trabajador", trabajador.codTrabajador);
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

        public bool EliminarTrabajador(entTrabajador trabajador)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarTrabajadores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_dni", trabajador.dni);
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
