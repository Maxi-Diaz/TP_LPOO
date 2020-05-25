using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Cliente
    {
        private string cli_Dni;

        public string Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        private string cli_Nombre;

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
        private string cli_Apellido;

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }
        private string cli_Direccion;

        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }
        private string cli_Telefono;

        public string Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }

        public Cliente(string dni, string nombre, string ape, string direccion, string tel)
        {
            Cli_Dni = dni;
            Cli_Nombre = nombre;
            Cli_Apellido = ape;
            Cli_Direccion = direccion;
            Cli_Telefono = tel;
        }

        public Cliente() { }

        private int cli_Id;

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }
    }
}
