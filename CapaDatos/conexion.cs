//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    //public class Conexion
    //{
    //    // Patrón de Diseño Singleton
    //    private static readonly Conexion _instancia = new Conexion();
    //    public static Conexion Instancia
    //    {
    //        get { return Conexion._instancia; }
    //    }

    //    public MySqlConnection Conectar()
    //    {
    //        MySqlConnection cn = new MySqlConnection();
    //        //cn.ConnectionString = "Server=nanasyamasperu.com;Port=3306;Database=nanasyamasperu_Nanas&Amas;Uid=nanasyamasperu_admin;Pwd=H&w]tbSzDlT3;";
    //        cn.ConnectionString = "Server=DESKTOP-GTHVN90; Database=nanasyamasperu_NanasyAmas; Integrated Security=true;";

    //        return cn;
    //    }
    //    public bool ProbarConexion()
    //    {
    //        MySqlConnection conexion = Conectar();
    //        try
    //        {
    //            conexion.Open();
    //            conexion.Close();
    //            return true;
    //        }
    //        catch (MySqlException)
    //        {
    //            return false;
    //        }
    //    }
    //}
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=ElardZ\\SQLEXPRESS; Initial Catalog = nanasyamasperu_Nanas&Amas;" +// "User ID=sa;Password=123"+
                                                               "Integrated Security=true";
            return cn;
        }
    }


}