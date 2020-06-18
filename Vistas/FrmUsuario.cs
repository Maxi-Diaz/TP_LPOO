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
    public partial class FrmUsuario : Form
    {
        FrmMenu frmmenu = new FrmMenu();
        public FrmUsuario()
        {
            InitializeComponent();
            
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Cargar_Usuarios();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frm = new FrmAltaUsuario();
            frm.lbl_title.Text = "Agregar";
            frm.txtId.Visible = false;
            frm.ShowDialog();
            Cargar_Usuarios();
        }

        private void Cargar_Usuarios() {
            tblUsuario.DataSource = UsuarioABM.cargarUsuarios();
            tblUsuario.Columns[6].Visible = false;
            tblUsuario.Columns[7].Visible = false;
            tblUsuario.Columns[1].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblUsuario.CurrentRow != null)
            {
                Usuario user = new Usuario();
                user.Usr_Id = int.Parse(tblUsuario.CurrentRow.Cells["ID"].Value.ToString());
                user.Rol_Codigo = tblUsuario.CurrentRow.Cells["rol_Codigo"].Value.ToString();
                user.Usr_ApellidoNombre =tblUsuario.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                user.Usr_NombreUsuario = tblUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                user.Usr_Contrasenia = tblUsuario.CurrentRow.Cells["Contraseña"].Value.ToString();
                if(btnEliminar.Text=="Eliminar"){
                  user.Usr_Estado = false;  
                    if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        UsuarioABM.mod_User(user);
                        MessageBox.Show("Se elimino el usuario correctamente");
                        Cargar_Usuarios();
                    }
                }else{
                    user.Usr_Estado = true;
                    if (MessageBox.Show("Seguro quiere activar el usuario?", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                        UsuarioABM.mod_User(user);
                        MessageBox.Show("Usuario activado");
                        Cargar_Usuarios();
                    }
                }
                
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblUsuario.CurrentRow != null)
            {
                FrmAltaUsuario frm = new FrmAltaUsuario();
                frm.lbl_title.Text = "Modificar";
               // frm.txtId.Visible = true;
               // frm.txtId.Enabled = false;
                //frm.label1.Visible = true;
                frm.cmbRol.SelectedValue = tblUsuario.CurrentRow.Cells["rol_Codigo"].Value.ToString();
                frm.txtApellido.Text = tblUsuario.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                frm.txtUsuario.Text = tblUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                frm.txtPass.Text = tblUsuario.CurrentRow.Cells["Contraseña"].Value.ToString();
                frm.txtId.Text = tblUsuario.CurrentRow.Cells["ID"].Value.ToString();
                frm.ShowDialog();
                Cargar_Usuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != " ")
            {
                tblUsuario.DataSource = UsuarioABM.buscarUsuario(txtBuscar.Text);
                txtBuscar.Text = "";
            }else {
                Cargar_Usuarios();
            }
        }

        private void tblUsuario_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(tblUsuario.CurrentRow.Cells["Estado"].Value.ToString() == "INACTIVO"){
                btnEliminar.Text = "Activar";
                btnEditar.Enabled = false;
            }
            else {
                btnEliminar.Text = "Eliminar";
                btnEditar.Enabled = true;
            }
        }
    }
}
