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
    public partial class FrmModiUsuario : Form
    {
        public FrmModiUsuario()
        {
            InitializeComponent();
        }

        private void FrmModiUsuario_Load(object sender, EventArgs e)
        {
            cargar_Combo();
        }

        public void cargar_Combo()
        {
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = UsuarioABM.cargar_roles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Usr_Id = Convert.ToInt32(txtId.Text);
            user.Rol_Codigo = cmbRol.SelectedValue.ToString();
            user.Usr_ApellidoNombre = txtApellido.Text;
            user.Usr_NombreUsuario = txtUsuario.Text;
            user.Usr_Contrasenia = txtPass.Text;
            
            UsuarioABM.mod_User(user);
            this.Close();
        }
    }
}
