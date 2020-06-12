using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClaseBase.BD {
    public class LineaABM {

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


    }
}
