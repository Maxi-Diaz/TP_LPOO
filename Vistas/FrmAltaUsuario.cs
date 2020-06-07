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
            if(lbl_title.Text=="Agregar"){
                if(txtApellido.Text!="" && txtUsuario.Text!="" && txtPass.Text!=""){
                    Usuario user = new Usuario();
                    user.Rol_Codigo = cmbRol.SelectedValue.ToString();
                    user.Usr_ApellidoNombre = txtApellido.Text;
                    user.Usr_NombreUsuario = txtUsuario.Text;
                    user.Usr_Contrasenia = txtPass.Text;

                    UsuarioABM.agregarUsuario(user);
                    this.Close();
                } else {
                    MessageBox.Show("Complete todos los campos");
                }
                
            } else {
                if (txtApellido.Text != "" && txtUsuario.Text != "" && txtPass.Text != "") {
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
    }
}
