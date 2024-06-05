using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datUser
    {
        #region sigleton

        // Variable estática para la instancia
        private static readonly datUser _instancia = new datUser();
        // Privado para evitar la instanciación directa
        public static datUser Instancia
        {
            get
            {
                return _instancia;
            }
        }

        #endregion singleton

        public List<entUser> ListarUser()
        {
            SqlCommand cmd = null;
            List<entUser> lista = new List<entUser>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entUser user = new entUser();
                        user.usuario_id = Convert.ToInt16(dr["USUARIO_ID"].ToString());
                        user.nombre = dr["NOMBRE"].ToString();
                        user.apellidoPaterno = dr["APELLIDO_PATERNO"].ToString();
                        user.apellidoMaterno = dr["APELLIDO_MATERNO"].ToString();
                        user.contraseña = dr["CONTRASENA"].ToString();
                        user.correo_electronico = dr["CORREO_ELECTRONICO"].ToString();
                        user.username = dr["USERNAME"].ToString();
                        lista.Add(user);
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

        public Boolean InsertaUser(entUser user)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaUser", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("usuario_id", user.nombre);
                cmd.Parameters.AddWithValue("apellido_paterno", user.apellidoPaterno);
                cmd.Parameters.AddWithValue("apellido_materno", user.apellidoMaterno);
                cmd.Parameters.AddWithValue("contraseña", user.contraseña);
                cmd.Parameters.AddWithValue("correo_electronico", user.correo_electronico);
                cmd.Parameters.AddWithValue("username", user.username);

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
    }
}
