using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClaseBase.BD
{
    public class UsuarioABM
    {
        public static DataTable cargar_roles()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void agregarUsuario(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(usu_nombreUsuario,usu_contrasenia,usu_apellidoNombre,rol_codigo) values(@name,@pwd,@ayp,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);
            cmd.Parameters.AddWithValue("@name", usuario.Usr_NombreUsuario);
            cmd.Parameters.AddWithValue("@pwd", usuario.Usr_Contrasenia);
            cmd.Parameters.AddWithValue("@ayp", usuario.Usr_ApellidoNombre);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable cargarUsuarios()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_nombreUsuario as 'Usuario', ";
            cmd.CommandText += " usu_contrasenia as 'Contraseña', ";
            cmd.CommandText += " usu_apellidoNombre as 'Nombre', ";
            cmd.CommandText += " usu_id as 'Rol Usuario' , U.rol_codigo as 'Rol' ";
            cmd.CommandText += " FROM Usuario as U ";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_codigo=U.rol_codigo) ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarUsuario(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText += "SELECT rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_nombreUsuario as 'Usuario', ";
            cmd.CommandText += " usu_Contrasenia as 'Contraseña', ";
            cmd.CommandText += " usu_ApellidoNombre as 'Nombre', ";
            cmd.CommandText += " usu_id , U.rol_codigo ";
            cmd.CommandText += " FROM Usuario as U ";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_codigo=U.rol_codigo) ";

            cmd.CommandText += " WHERE ";
            cmd.CommandText += " usu_apellidoNombre LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //No va
        public static void mod_User(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " UPDATE Usuario SET usu_apellidoNombre = @ayp , ";
            cmd.CommandText += " usu_nombreUsuario = @name , usu_contrasenia = @pwd, ";
            cmd.CommandText += " rol_codigo = @rol ";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " usu_id = @idU ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idU", usuario.Usr_Id);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);
            cmd.Parameters.AddWithValue("@name", usuario.Usr_NombreUsuario);
            cmd.Parameters.AddWithValue("@pwd", usuario.Usr_Contrasenia);
            cmd.Parameters.AddWithValue("@ayp", usuario.Usr_ApellidoNombre);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void borrarUsuario(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " DELETE FROM Usuario ";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " usu_id = @idU ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idU", usuario.Usr_Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static Boolean admin(String band)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();

            int admins = 0;
            cmd.CommandText = " SELECT COUNT(rol_codigo) FROM Usuario ";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " rol_codigo = '1' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            admins = (int)cmd.ExecuteScalar();
            cnn.Close();

            if (band == "1")
            {
                if (admins > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public static Boolean adminM(String band)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            int admins = 0;
            cmd.CommandText = " SELECT COUNT(rol_codigo) FROM Usuario ";
            cmd.CommandText += " WHERE ";
            cmd.CommandText += " rol_codigo = '1' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();
            admins = (int)cmd.ExecuteScalar();
            cnn.Close();

            if (band != "1")
            {
                if (admins > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
