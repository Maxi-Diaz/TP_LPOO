﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClaseBase.BD
{
    public class ClienteABM
    {
        public static void agregarCliente(Cliente cliente)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "inset_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@dire", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@tel", cliente.Cli_Telefono);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static void editarCliente(Cliente cliente)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "edit_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@idC", cliente.Cli_Id);
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@dire", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@tel", cliente.Cli_Telefono);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static void eliminarCliente(Cliente cliente)
        {
            SqlConnection conexion = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminar_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public static DataTable listarClientes()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable BuscarClientes(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ordenarPorApellido()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ordenar_por_apellido_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        ///////////////////////////////////AGREGADO 29/5 //////////////////////////////////////////////////////

        public static DataTable cliente_apellido() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "cliente_apellido";
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

        public static DataTable list_cliente() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT cli_ID, Apellido+' '+Nombre+' DNI '+ DNI AS Cliente FROM View_Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable BuscarCliNyPD( string datos ) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SPBuscarIDCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@datos",datos);

            // Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int cliente_existente(string clienteDni)
        {
            int cantidad_dni;
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "dni_existente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlParameter param;
            param = new SqlParameter("@cliente", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = clienteDni;
            cmd.Parameters.Add(param);
            param = new SqlParameter("@existe", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            // Obtengo el valor del Parametro de Salida
            cantidad_dni = (int)cmd.Parameters["@existe"].Value;

            return cantidad_dni;

        }

        public static int cliente_compras(int cliente) {
            int cantidad_dni;
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.Conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "cliente_compras";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlParameter param;
            param = new SqlParameter("@cliente", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = cliente;
            cmd.Parameters.Add(param);
            param = new SqlParameter("@existe", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            // Obtengo el valor del Parametro de Salida
            cantidad_dni = (int)cmd.Parameters["@existe"].Value;

            return cantidad_dni;

        }
    }
}
