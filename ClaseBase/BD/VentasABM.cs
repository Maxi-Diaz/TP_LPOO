using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClaseBase.BD
{
    public class VentasABM
    {
        public static DataTable list_cliente()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT cli_id, cli_apellido + ' ' + cli_nombre + ' DNI ' + cli_dni as cli_datos FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_vehiculos()
        {
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

        public static string precio_vehiculo(int id)
        {

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

            if (dt.Rows.Count == 1)
            {

                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "0";
            }


        }


        public static DataTable list_forma_pago()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM FormaPago";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;


        }
        public static DataTable set_vendedor(string user, string pwd)
        {

            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT * FROM Usuario ";
            cmd.CommandText += " WHERE usu_nombreUsuario = @user AND ";
            cmd.CommandText += " usu_contrasenia = @pwd ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarMarcaVenta( string sPattern ) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "SPBuscarMarcaVenta";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter param;
            param = new SqlParameter("@mar", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = sPattern;

            da.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            da.Fill(ds, "View_Venta");

            dt = ds.Tables[0];

            return dt;
        }

        public static void insertVenta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertVenta";
            cmd.Parameters.Add("@idC", SqlDbType.Int).Value = venta.Cli_Id;
            cmd.Parameters.Add("@idV", SqlDbType.Int).Value = venta.Veh_Id;
            cmd.Parameters.Add("@idU", SqlDbType.Int).Value = venta.Usr_Id;
            cmd.Parameters.Add("@fec", SqlDbType.DateTime).Value = venta.Vta_Fecha;
            cmd.Parameters.Add("@idP", SqlDbType.Int).Value = venta.Pag_Id;
            cmd.Parameters.Add("@vpf", SqlDbType.Decimal).Value = venta.Vta_PrecioFinal;

            cmd.Connection = cnn;

            cnn.Open();

            cmd.ExecuteNonQuery();

            cnn.Close();

            //SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "INSERT INTO Venta(cli_id,veh_id ,usu_id ,vta_fecha ,pag_id, vta_precioFinal) ";
            //cmd.CommandText += "values(@idC,@idV,@idU,@fec,@idP,@vpf)";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@idC", venta.Cli_Id);
            //cmd.Parameters.AddWithValue("@idV", venta.Veh_Id);
            //cmd.Parameters.AddWithValue("@idU", venta.Usr_Id);
            //cmd.Parameters.AddWithValue("@fec", venta.Vta_Fecha);
            //cmd.Parameters.AddWithValue("@idP", venta.Pag_Id);
            //cmd.Parameters.AddWithValue("@vpf", venta.Vta_PrecioFinal);

            //cnn.Open();
            //cmd.ExecuteNonQuery();
            //cnn.Close();

        }

        public static DataTable list_venta()
        {

            //SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "SELECT vta_id as 'ID', cli_apellido + ' ' + cli_nombre as 'Cliente', ";
            //cmd.CommandText += "veh_matricula as 'Matricula', lin_nombre as 'Linea', ";
            //cmd.CommandText += "mar_nombre as 'Marca', vta_fecha as 'Fecha', pag_forma as 'Forma de Pago', ";
            //cmd.CommandText += "vta_precioFinal as 'Precio Final' ";
            //cmd.CommandText += "FROM Venta as V ";
            //cmd.CommandText += "LEFT JOIN Cliente as C ON (C.cli_id=V.cli_id) ";
            //cmd.CommandText += "LEFT JOIN Vehiculo as VE ON (VE.veh_id=V.veh_id) ";
            //cmd.CommandText += "LEFT JOIN Linea as L ON (L.lin_id=VE.lin_id) ";
            //cmd.CommandText += "LEFT JOIN Marca as M ON (M.mar_id=L.lin_id) ";
            //cmd.CommandText += "LEFT JOIN FormaPago as P ON (P.pag_id=V.pag_id)";
            //cmd.CommandType = CommandType.Text;
            //cmd.Connection = cnn;
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "SPListaVenta";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet ds = new DataSet();

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(ds, "View_Venta");
            dt = ds.Tables[0];

            // Ejecuta la consulta
            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            return dt;
        }
    }
}
