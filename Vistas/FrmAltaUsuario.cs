using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase.BD;
using ClaseBase;

namespace Vistas
{
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargar_Combo();
        }

        private void cargar_Combo(){
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = UsuarioABM.cargar_roles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Rol_Codigo = cmbRol.SelectedValue.ToString();
            user.Usr_ApellidoNombre = txtApellido.Text;
            user.Usr_NombreUsuario = txtUsuario.Text;
            user.Usr_Contrasenia = txtPass.Text;

            UsuarioABM.agregarUsuario(user);
            this.Close();
        }
    }
}
