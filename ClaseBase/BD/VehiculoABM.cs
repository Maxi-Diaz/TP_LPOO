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

        public static DataTable list_vehiculos_venta() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT veh_id, veh_matricula + ' ' + lin_nombre + ' ' + mar_nombre + ' ' + veh_color as veh_datos FROM Vehiculo as V ";
            cmd.CommandText += "LEFT JOIN Linea as L ON (L.lin_id=V.lin_id) ";
            cmd.CommandText += "LEFT JOIN Marca as M ON (M.mar_id=L.mar_id) ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static string precio_vehiculo(int id) {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT veh_precio FROM Vehiculo ";
            cmd.CommandText += " WHERE veh_id = @idV ";
            cmd.Parameters.AddWithValue("@idV", id);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1) {

                return dt.Rows[0][0].ToString();
            }
            else {
                return "0";
            }


        }

        public static DataTable list_Vehiculos_disponible() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "vehiculo_disponible";
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
            cmd.Parameters.AddWithValue("@est", vehiculo.Veh_Estado);
         

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static void editarVehiculo(Vehiculo vehiculo) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "modificar_vehiculo";
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
            cmd.Parameters.AddWithValue("@est", vehiculo.Veh_Estado);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void eliminarVehiculo(Vehiculo vehiculo) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminar_Vehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@idV", vehiculo.Veh_ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static DataTable list_Vehiculos_lm(int opcion, string matricula) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            //if (opcion == 1) {
            //    cmd.CommandText = "vehiculo_Linea";
            //}
            //else {
            //    cmd.CommandText = "vehiculo_Marca";
            //}
            cmd.CommandText = "vehiculo_Marca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;

            param = new SqlParameter("@matricula", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = matricula;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@opc", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = opcion;
            cmd.Parameters.Add(param);

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.SelectCommand.Parameters.Add(param);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static void venderVehiculo(Vehiculo vehiculo) {
           
                        
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "vender_vehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            
            cmd.Parameters.AddWithValue("@idV", vehiculo.Veh_ID);
            cmd.Parameters.AddWithValue("@est", vehiculo.Veh_Estado);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarID(int id) {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SPBuscarIDVehiculo";
            // cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlParameter param;
            param = new SqlParameter("@id", SqlDbType.Int);
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

        public static int vehiculo_existente(string matricula) {

            int cantidad_usuario;

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "vehiculo_existente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
          
            SqlParameter param;
            param = new SqlParameter("@matricula", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = matricula;
            cmd.Parameters.Add(param);

            param = new SqlParameter("@existe", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            cantidad_usuario = (int)cmd.Parameters["@existe"].Value;

            return cantidad_usuario;

        }
    }
}
