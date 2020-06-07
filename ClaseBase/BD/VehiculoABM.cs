using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClaseBase.BD
{
    public class VehiculoABM
    {

        public static DataTable list_Vehiculos() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "vehiculo_lista";
            //  cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

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

        public static DataTable list_Linea(int id) {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "linea_lista";
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

        public static DataTable list_clase() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "clase_lista";
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

        public static DataTable list_tipo() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "tipo_lista";
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

        public static void insertVehiculo(Vehiculo vehiculo) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nuevo_vehiculo";
            // cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@mat", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@idL", vehiculo.Lin_Id);
            cmd.Parameters.AddWithValue("@mod", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@col", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@pue", vehiculo.Veh_Puerta);
            cmd.Parameters.AddWithValue("@gps", vehiculo.Veh_GPS);
            cmd.Parameters.AddWithValue("@tip", vehiculo.Tip_ID);
            cmd.Parameters.AddWithValue("@cla", vehiculo.Cls_ID);
            cmd.Parameters.AddWithValue("@pre", vehiculo.Veh_Precio);

            /*   SqlParameter param;
           
               param = new SqlParameter("@mat", SqlDbType.VarChar);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Veh_Matricula;
               cmd.Parameters.Add(param);

               param = new SqlParameter("@idL", SqlDbType.Int);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Lin_ID;
               cmd.Parameters.Add(param);

               param = new SqlParameter("@mod", SqlDbType.Int);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Veh_Modelo;
               cmd.Parameters.Add(param);

               param = new SqlParameter("@col", SqlDbType.VarChar);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Veh_Color;
               cmd.Parameters.Add(param);

               param = new SqlParameter("@pue", SqlDbType.Int);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Veh_Puertas;
               cmd.Parameters.Add(param);

               param = new SqlParameter("@gps", SqlDbType.Bit);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Veh_GPS;
               cmd.Parameters.Add(param);
  
               param = new SqlParameter("@tip", SqlDbType.VarChar);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Veh_Tipo;
               cmd.Parameters.Add(param);

               param = new SqlParameter("@cla", SqlDbType.VarChar);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Veh_Clase;
               cmd.Parameters.Add(param);

               param = new SqlParameter("@pre", SqlDbType.Decimal);
               param.Direction = ParameterDirection.Input;
               param.Value = Vehiculo.Veh_Precio;
               cmd.Parameters.Add(param);*/

            cnn.Open();
            //    command.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            //    command1.ExecuteNonQuery();
            cnn.Close();

        }

        public static void editarVehiculo(Vehiculo vehiculo) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "modificar_vehiculo";
            // cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idV", vehiculo.Veh_ID);
            cmd.Parameters.AddWithValue("@mat", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@idL", vehiculo.Lin_Id);
            cmd.Parameters.AddWithValue("@mod", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@col", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@pue", vehiculo.Veh_Puerta);
            cmd.Parameters.AddWithValue("@gps", vehiculo.Veh_GPS);
            cmd.Parameters.AddWithValue("@tip", vehiculo.Tip_ID);
            cmd.Parameters.AddWithValue("@cla", vehiculo.Cls_ID);
            cmd.Parameters.AddWithValue("@pre", vehiculo.Veh_Precio);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void eliminarVehiculo(Vehiculo vehiculo) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminar_Vehiculo";
            // cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idV", vehiculo.Veh_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static DataTable list_Vehiculos_lm(int opcion) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            if (opcion == 1) {
                cmd.CommandText = "vehiculo_Linea";
            }
            else {
                cmd.CommandText = "vehiculo_Marca";
            }
            //  cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
