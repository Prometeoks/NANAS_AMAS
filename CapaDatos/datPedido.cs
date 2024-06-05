using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class datPedido
    {
        #region Singleton
        // Patrón Singleton
        private static readonly datPedido _instancia = new datPedido();
        // Constructor privado para evitar la instanciación directa
        private datPedido() { }

        public static datPedido Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion Singleton

        public List<entPedido> ListarPedidos()
        {
            SqlCommand cmd = null;
            List<entPedido> lista = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entPedido pedido = new entPedido
                        {
                            codPedido = dr["CODPEDIDO"].ToString(),
                            dni_empleador = dr["DNI_EMPLEADOR"].ToString(),
                            edad_minima = dr["EDAD_MINIMA"].ToString(),
                            edad_maxima = dr["EDAD_MAXIMA"].ToString(),
                            puesto = dr["PUESTO"].ToString(),
                            funciones = dr["FUNCIONES"].ToString(),
                            rutina = dr["RUTINA"].ToString(),
                            observaciones = dr["OBSERVACIONES"].ToString(),
                            estado = dr["ESTADO"].ToString(),
                            hora_de_inicio = Convert.ToDateTime(dr["HORA_DE_INICIO"].ToString()),
                            hora_final = Convert.ToDateTime(dr["HORA_FINAL"].ToString()),
                            cant_horas = dr["CANTIDAD_DE_HORAS"].ToString(),
                            sueldo = Convert.ToSingle(dr["SUELDO"].ToString()),
                            modalidad = dr["MODALIDAD"].ToString(),
                            usuario_id = Convert.ToInt32(dr["USUARIO_ID"].ToString())
                        };
                        lista.Add(pedido);
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

        public List<entPedido> BuscarPedidoPorCodigo(string codPedido)
        {
            SqlCommand cmd = null;
            List<entPedido> lista = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPedidoPorCodigo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_cod_pedido", codPedido);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entPedido pedido = new entPedido
                        {
                            codPedido = dr["CODPEDIDO"].ToString(),
                            dni_empleador = dr["DNI_EMPLEADOR"].ToString(),
                            edad_minima = dr["EDAD_MINIMA"].ToString(),
                            edad_maxima = dr["EDAD_MAXIMA"].ToString(),
                            puesto = dr["PUESTO"].ToString(),
                            funciones = dr["FUNCIONES"].ToString(),
                            rutina = dr["RUTINA"].ToString(),
                            observaciones = dr["OBSERVACIONES"].ToString(),
                            estado = dr["ESTADO"].ToString(),
                            hora_de_inicio = Convert.ToDateTime(dr["HORA_DE_INICIO"].ToString()),
                            hora_final = Convert.ToDateTime(dr["HORA_FINAL"].ToString()),
                            cant_horas = dr["CANTIDAD_DE_HORAS"].ToString(),
                            sueldo = Convert.ToSingle(dr["SUELDO"].ToString()),
                            modalidad = dr["MODALIDAD"].ToString(),
                            usuario_id = Convert.ToInt32(dr["USUARIO_ID"].ToString())
                        };
                        lista.Add(pedido);
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

        public bool InsertaPedido(entPedido pedido)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codpedido", pedido.codPedido);
                cmd.Parameters.AddWithValue("dni_empleador", pedido.dni_empleador);
                cmd.Parameters.AddWithValue("edadminima", pedido.edad_minima);
                cmd.Parameters.AddWithValue("edadmaxima", pedido.edad_maxima);
                cmd.Parameters.AddWithValue("puesto", pedido.puesto);
                cmd.Parameters.AddWithValue("funciones", pedido.funciones);
                cmd.Parameters.AddWithValue("rutina", pedido.rutina);
                cmd.Parameters.AddWithValue("observaciones", pedido.observaciones);
                cmd.Parameters.AddWithValue("estado", pedido.estado);
                cmd.Parameters.AddWithValue("horaInicio", pedido.hora_de_inicio);
                cmd.Parameters.AddWithValue("horaFinal", pedido.hora_final);
                cmd.Parameters.AddWithValue("cantidadHoras", pedido.cant_horas);
                cmd.Parameters.AddWithValue("sueldo", pedido.sueldo);
                cmd.Parameters.AddWithValue("modalidad", pedido.modalidad);
                cmd.Parameters.AddWithValue("usuarioId", pedido.usuario_id);
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
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }

        public bool EditarPedido(entPedido pedido)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_codpedido", pedido.codPedido);
                cmd.Parameters.AddWithValue("p_dni_empleador", pedido.dni_empleador);
                cmd.Parameters.AddWithValue("p_edadMinima", pedido.edad_minima);
                cmd.Parameters.AddWithValue("p_edadMaxima", pedido.edad_maxima);
                cmd.Parameters.AddWithValue("p_puesto", pedido.puesto);
                cmd.Parameters.AddWithValue("p_funciones", pedido.funciones);
                cmd.Parameters.AddWithValue("p_rutina", pedido.rutina);
                cmd.Parameters.AddWithValue("p_observaciones", pedido.observaciones);
                cmd.Parameters.AddWithValue("p_estado", pedido.estado);
                cmd.Parameters.AddWithValue("p_horainicio", pedido.hora_de_inicio);
                cmd.Parameters.AddWithValue("p_horafinal", pedido.hora_final);
                cmd.Parameters.AddWithValue("p_cantidadhoras", pedido.cant_horas);
                cmd.Parameters.AddWithValue("p_sueldo", pedido.sueldo);
                cmd.Parameters.AddWithValue("p_modalidad", pedido.modalidad);
                cmd.Parameters.AddWithValue("p_usuarioid", pedido.usuario_id);
                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
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
        }

        public bool EliminarPedido(string codPedido)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_codpedido", codPedido);
                cn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
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
        }
    }
}
