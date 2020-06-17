using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Usuario
    {
        private int usr_Id;
        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }
        private string usr_NombreUsuario;

        public string Usr_NombreUsuario
        {
            get { return usr_NombreUsuario; }
            set { usr_NombreUsuario = value; }
        }
        private string usr_Contrasenia;

        public string Usr_Contrasenia
        {
            get { return usr_Contrasenia; }
            set { usr_Contrasenia = value; }
        }
        private string usr_ApellidoNombre;

        public string Usr_ApellidoNombre
        {
            get { return usr_ApellidoNombre; }
            set { usr_ApellidoNombre = value; }
        }
        private string rol_Codigo;
        public string Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public Usuario(string nombreusuario, string password)
        {
            Usr_NombreUsuario = nombreusuario;
            Usr_Contrasenia = password;
        }

        public Usuario()
        {
        }

        private Boolean usr_Estado;

        public Boolean Usr_Estado {
            get { return usr_Estado; }
            set { usr_Estado = value; }
        }
    }
}
