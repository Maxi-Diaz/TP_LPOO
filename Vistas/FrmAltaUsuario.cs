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
            cargar_Combo();
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
          
        }

        private void cargar_Combo(){
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = UsuarioABM.cargar_roles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lbl_title.Text == "Agregar")
            {
                if (txtApellido.Text != "" && txtUsuario.Text != "" && txtPass.Text != "")
                {
                    Usuario user = new Usuario();
                    user.Rol_Codigo = cmbRol.SelectedValue.ToString();
                    user.Usr_ApellidoNombre = txtApellido.Text;
                    user.Usr_NombreUsuario = txtUsuario.Text;
                    user.Usr_Contrasenia = txtPass.Text;
                    user.Usr_Estado = true;
                    if (UsuarioABM.usuario_existente(user.Usr_NombreUsuario) == 0)
                    {
                        try {
                            UsuarioABM.agregarUsuario(user);
                            MessageBox.Show("Usuario Agregado!");
                            this.Close();
                        }
                        catch (Exception a) {
                            MessageBox.Show("" + a);
                            MessageBox.Show("Usuario no Registrado!");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Usuario Existente");
                        //MessageBox.Show(UsuarioABM.usuario_existente(user.Usr_NombreUsuario).ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            else
            {
                if (txtApellido.Text != "" && txtUsuario.Text != "" && txtPass.Text != "")
                {
                    Usuario user = new Usuario();
                    user.Usr_Id = Convert.ToInt32(txtId.Text);
                    user.Rol_Codigo = cmbRol.SelectedValue.ToString();
                    user.Usr_ApellidoNombre = txtApellido.Text;
                    user.Usr_NombreUsuario = txtUsuario.Text;
                    user.Usr_Contrasenia = txtPass.Text;
                    user.Usr_Estado = true;
                    if (UsuarioABM.usuario_existente(user.Usr_NombreUsuario) <= 1)
                    {
                        try {
                            UsuarioABM.mod_User(user);
                            MessageBox.Show("Usuario Editado");
                            this.Close();
                        }
                        catch (Exception a) {
                            MessageBox.Show("" + a);
                            MessageBox.Show("Usuario no editado!");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario Existente");
                        //MessageBox.Show(UsuarioABM.usuario_existente(user.Usr_NombreUsuario).ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
        }

        private void button1_Click( object sender, EventArgs e ) {
            this.Close();
        }

    }
}
