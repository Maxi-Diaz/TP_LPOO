﻿using System;
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
            cmd.CommandText = "validar_login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1 && (dt.Rows[0][1].ToString() == "True"))
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

        public static string rol_usuario(int id)
        {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT * FROM Usuario";
            cmd.CommandText += " WHERE rol_Codigo = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

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
