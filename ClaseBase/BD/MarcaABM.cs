using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClaseBase.BD {
    public class MarcaABM {

        public static DataTable list_Marca(int id) {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "venta_Marca";
            // cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@idM", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = id;


            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Parameters.Add(param);
            // Llena los datos de la consulta en el DataTable


            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_Marca() {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "marca_lista";
            //    cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void agregarMarca(Marca marca)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_marca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@desc", marca.Mar_descripcion);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static void editarMarca(Marca marca)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "edit_marca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@id", marca.Mar_id);
            cmd.Parameters.AddWithValue("@desc", marca.Mar_descripcion);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static void eliminarMarca(Marca marca)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminar_marca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@id", marca.Mar_id);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
