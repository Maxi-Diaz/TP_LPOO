using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClaseBase.BD {

   public class Validaciones
    {
        public int validar(String user, String pwd)
        {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT rol_Codigo FROM Usuario";
            cmd.CommandText += " WHERE usu_nombreUsuario = @user AND ";
            cmd.CommandText += " usu_contrasenia = @pwd ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    return 1;
                }
                else
                {
                    if (dt.Rows[0][0].ToString() == "2")
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
            else
            {
                return 0;
            }
        }

        public static string nombre_usuario(string user, string pwd)
        {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT * FROM Usuario";
            cmd.CommandText += " WHERE usu_nombreUsuario = @user AND ";
            cmd.CommandText += " usu_contrasenia = @pwd ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                return dt.Rows[0][3].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
