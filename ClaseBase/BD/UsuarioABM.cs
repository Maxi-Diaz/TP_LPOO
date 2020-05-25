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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPInsertUsuario";
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = usuario.Usr_NombreUsuario;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar).Value = usuario.Usr_Contrasenia;
            cmd.Parameters.Add("@ayp", SqlDbType.VarChar).Value = usuario.Usr_ApellidoNombre;
            cmd.Parameters.Add("@rol", SqlDbType.Int).Value = usuario.Rol_Codigo;

            cmd.Connection = cnn;

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
            //SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "INSERT INTO Usuario(usu_nombreUsuario,usu_contrasenia,usu_apellidoNombre,rol_codigo) values(@name,@pwd,@ayp,@rol)";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);
            //cmd.Parameters.AddWithValue("@name", usuario.Usr_NombreUsuario);
            //cmd.Parameters.AddWithValue("@pwd", usuario.Usr_Contrasenia);
            //cmd.Parameters.AddWithValue("@ayp", usuario.Usr_ApellidoNombre);

            //cnn.Open();
            //cmd.ExecuteNonQuery();
            //cnn.Close();
        }

        public static DataTable cargarUsuarios()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT";
            //cmd.CommandText += " rol_descripcion as 'Rol', ";
            //cmd.CommandText += " usu_nombreUsuario as 'Usuario', ";
            //cmd.CommandText += " usu_contrasenia as 'Contraseña', ";
            //cmd.CommandText += " usu_apellidoNombre as 'Nombre', ";
            //cmd.CommandText += " usu_id as 'Rol Usuario' , U.rol_codigo as 'Rol' ";
            //cmd.CommandText += " FROM Usuario as U ";
            //cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_codigo=U.rol_codigo) ";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = cnn;

            //Ejecuta la consulta.
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "SPUsuarioRol";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();

            //Llena los datos de la consulta en el DataTable.
            DataTable dt = new DataTable();
            da.Fill(ds, "UsuarioRol");
            dt = ds.Tables[0];

            return dt;
        }

        public static DataTable buscarUsuario(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "SPBuscarUsuario";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@pattern", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = sPattern;

            da.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            da.Fill(ds, "UsuarioRol");

            dt = ds.Tables[0];

            return dt;
        }

        //No va
        public static void mod_User(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand("SPModUsuario",cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ayp", SqlDbType.VarChar).Value = usuario.Usr_ApellidoNombre;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = usuario.Usr_NombreUsuario;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar).Value = usuario.Usr_Contrasenia;
            cmd.Parameters.Add("@rol", SqlDbType.Int).Value = usuario.Rol_Codigo;
            cmd.Parameters.Add("@idU", SqlDbType.Int).Value = usuario.Usr_Id;

            cmd.Connection = cnn;

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
            //SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = " UPDATE Usuario SET usu_apellidoNombre = @ayp , ";
            //cmd.CommandText += " usu_nombreUsuario = @name , usu_contrasenia = @pwd, ";
            //cmd.CommandText += " rol_codigo = @rol ";
            //cmd.CommandText += " WHERE ";
            //cmd.CommandText += " usu_id = @idU ";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@idU", usuario.Usr_Id);
            //cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);
            //cmd.Parameters.AddWithValue("@name", usuario.Usr_NombreUsuario);
            //cmd.Parameters.AddWithValue("@pwd", usuario.Usr_Contrasenia);
            //cmd.Parameters.AddWithValue("@ayp", usuario.Usr_ApellidoNombre);

            //cnn.Open();
            //cmd.ExecuteNonQuery();
            //cnn.Close();

        }

        public static void borrarUsuario(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand("SPBorrarUsuario", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idU", SqlDbType.Int).Value = usuario.Usr_Id;

            cmd.Connection = cnn;

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();
            //SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = " DELETE FROM Usuario ";
            //cmd.CommandText += " WHERE ";
            //cmd.CommandText += " usu_id = @idU ";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@idU", usuario.Usr_Id);

            //cnn.Open();
            //cmd.ExecuteNonQuery();
            //cnn.Close();
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
