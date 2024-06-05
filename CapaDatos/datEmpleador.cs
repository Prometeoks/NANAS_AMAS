using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using static Mysqlx.Crud.Order.Types;
using System.Net;

namespace CapaDatos
{
    public class datEmpleador
    {
        // Variable estática para la instancia
        private static readonly datEmpleador _instancia = new datEmpleador();
        // Privado para evitar la instanciación directa
        public static datEmpleador Instancia
        {
            get
            {
                return _instancia;
            }
        }
        public List<entEmpleador> ListarEmpleadores()
        {
            //MySqlCommand cmd = null;
            SqlCommand cmd = null;
            List<entEmpleador> lista = new List<entEmpleador>(); 
            try
            {
                //MySqlConnection cn = Conexion.Instancia.Conectar();
                //cmd = new MySqlCommand("spListarEmpleador", cn);
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarEmpleador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                //using (MySqlDataReader dr = cmd.ExecuteReader())
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entEmpleador empleadores = new entEmpleador();
                        bool excluido;
                        string valExcluido;

                        empleadores.dni = dr["DNI"].ToString();
                        empleadores.nombre = dr["NOMBRE"].ToString();
                        empleadores.apellidoPaterno = dr["APELLIDO_PATERNO"].ToString();
                        empleadores.apellidoMaterno = dr["APELLIDO_MATERNO"].ToString();
                        empleadores.celular1 = dr["Celular1"].ToString();
                        empleadores.celular2 = dr["Celular1"].ToString();
                        empleadores.direccion = dr["DIRECCION"].ToString();
                        empleadores.distrito = dr["DISTRITO"].ToString();
                        empleadores.provincia = dr["PROVINCIA"].ToString();
                        empleadores.departamento = dr["DEPARTAMENTO"].ToString();
                        empleadores.ref_domicilio = dr["REFERENCIA_DE_DOMICILIO"].ToString();
                        empleadores.transporte_publico = dr["TRANSPORTE_PUBLICO"].ToString();
                        excluido = dr["LISTA_EXCLUIDOS"] != DBNull.Value && Convert.ToBoolean(dr["LISTA_EXCLUIDOS"]);
                        if (excluido == true)
                        {
                            
                        }
                        else
                        {
                           
                        }
                        empleadores.lista_excluidos = excluido;

                        empleadores.motivo_excluido = dr["MOTIVO_EXCLUIDO"].ToString();
                        empleadores.modo_contacto = dr["MODO_DE_CONTACTO"].ToString();
                        empleadores.usuario_id = Convert.ToInt16(dr["USUARIO_ID"].ToString());
                        lista.Add(empleadores);

                    }
                }
            }
            //catch (MySqlException e)
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


        public entEmpleadorMotivo EmpleadorMotivo(string id) {    
            
            SqlCommand cmd = null;
            entEmpleadorMotivo motivoEncontrado = new entEmpleadorMotivo();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("spMotivosDni", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("dni", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleadorMotivo motivo = new entEmpleadorMotivo();
                    motivo.motivo = dr["MOTIVO_EXCLUIDO"].ToString();
                    motivoEncontrado = motivo;
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
            return motivoEncontrado;       
        }

        public List<entEmpleador> ListarEmpleadorPorDni(string id)
        {
            SqlCommand cmd = null;
            List<entEmpleador> lista = new List<entEmpleador>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton

                cmd = new SqlCommand("spListarEmpleadorPorDNI", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("dni", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleador empleadores = new entEmpleador();
                    empleadores.dni = dr["DNI"].ToString();
                    empleadores.nombre = dr["NOMBRE"].ToString();
                    empleadores.apellidoPaterno = dr["APELLIDO_PATERNO"].ToString();
                    empleadores.apellidoMaterno = dr["APELLIDO_MATERNO"].ToString();
                    empleadores.celular1 = dr["Celular1"].ToString();
                    empleadores.celular2 = dr["Celular1"].ToString();
                    empleadores.direccion = dr["DIRECCION"].ToString();
                    empleadores.distrito = dr["DISTRITO"].ToString();
                    empleadores.provincia = dr["PROVINCIA"].ToString();
                    empleadores.departamento = dr["DEPARTAMENTO"].ToString();
                    empleadores.ref_domicilio = dr["REFERENCIA_DE_DOMICILIO"].ToString();
                    empleadores.transporte_publico = dr["TRANSPORTE_PUBLICO"].ToString();
                    empleadores.lista_excluidos = dr["LISTA_EXCLUIDOS"] != DBNull.Value && Convert.ToBoolean(dr["LISTA_EXCLUIDOS"]);
                    empleadores.motivo_excluido = dr["MOTIVO_EXCLUIDO"].ToString();
                    empleadores.modo_contacto = dr["MODO_DE_CONTACTO"].ToString();
                    empleadores.usuario_id = Convert.ToInt16(dr["USUARIO_ID"].ToString());
                    lista.Add(empleadores);
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
            lista = lista.OrderByDescending(c => c.dni).ToList();
            return lista;
        }

        public Boolean InsertarEmpleador(entEmpleador empleador)
        {
            //MySqlCommand cmd = null;
            SqlCommand cmd = null;
            Boolean inserta = false;

            try
            {
                //MySqlConnection cn = Conexion.Instancia.Conectar();
                //cmd = new MySqlCommand("spInsertarEmpleador", cn);
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEmpleador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("DNI", empleador.dni);
                cmd.Parameters.AddWithValue("NOMBRE", empleador.nombre);
                cmd.Parameters.AddWithValue("APELLIDO_PATERNO", empleador.apellidoPaterno);
                cmd.Parameters.AddWithValue("APELLIDO_MATERNO", empleador.apellidoMaterno);
                cmd.Parameters.AddWithValue("Celular1", empleador.celular1);
                cmd.Parameters.AddWithValue("Celular2", empleador.celular2);
                cmd.Parameters.AddWithValue("DIRECCION", empleador.direccion);
                cmd.Parameters.AddWithValue("DISTRITO", empleador.distrito);
                cmd.Parameters.AddWithValue("PROVINCIA", empleador.provincia);
                cmd.Parameters.AddWithValue("DEPARTAMENTO", empleador.departamento);
                cmd.Parameters.AddWithValue("REFERENCIA_DE_DOMICILIO", empleador.ref_domicilio);
                cmd.Parameters.AddWithValue("TRANSPORTE_PUBLICO", empleador.transporte_publico);
                cmd.Parameters.AddWithValue("LISTA_EXCLUIDOS", empleador.lista_excluidos);
                cmd.Parameters.AddWithValue("MOTIVO_EXCLUIDO", empleador.motivo_excluido);
                cmd.Parameters.AddWithValue("MODO_DE_CONTACTO", empleador.modo_contacto);
                cmd.Parameters.AddWithValue("USUARIO_ID", empleador.usuario_id);
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

        public bool EditarEmpleador(entEmpleador empleador)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarEmpleador", cn);
                cmd.Parameters.AddWithValue("dni", empleador.dni);
                cmd.Parameters.AddWithValue("nombre", empleador.nombre);
                cmd.Parameters.AddWithValue("apellidoPaterno", empleador.apellidoPaterno);
                cmd.Parameters.AddWithValue("apellidoMaterno", empleador.apellidoMaterno);
                cmd.Parameters.AddWithValue("celular1", empleador.celular1);
                cmd.Parameters.AddWithValue("celular2", empleador.celular2);
                cmd.Parameters.AddWithValue("direccion", empleador.direccion);
                cmd.Parameters.AddWithValue("distrito", empleador.distrito);
                cmd.Parameters.AddWithValue("provincia", empleador.provincia);
                cmd.Parameters.AddWithValue("departamento", empleador.departamento);
                cmd.Parameters.AddWithValue("referencia_domicilio", empleador.ref_domicilio);
                cmd.Parameters.AddWithValue("transporte_publico", empleador.transporte_publico);
                cmd.Parameters.AddWithValue("lista_excluidos", empleador.lista_excluidos);
                cmd.Parameters.AddWithValue("motivo_excluido", empleador.motivo_excluido);
                cmd.Parameters.AddWithValue("modo_contacto", empleador.modo_contacto);
                cmd.Parameters.AddWithValue("usuario_id", empleador.usuario_id);
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




        public bool EliminarEmpleador(entEmpleador empleador)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarEmpleador", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("dni", empleador.dni);
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
