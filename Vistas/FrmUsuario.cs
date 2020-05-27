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
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Cargar_Usuarios();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frm = new FrmAltaUsuario();
            frm.ShowDialog();
            Cargar_Usuarios();
        }

        private void Cargar_Usuarios() {
            tblUsuario.DataSource = UsuarioABM.cargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblUsuario.SelectedRows.Count > 0)
            {
                Usuario user = new Usuario();
                user.Usr_Id = int.Parse(tblUsuario.CurrentRow.Cells["ID"].Value.ToString());
                if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    UsuarioABM.borrarUsuario(user);
                    MessageBox.Show("Se elimino el usuario correctamente");
                    Cargar_Usuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        
        //Falla en llamado del combobox
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblUsuario.SelectedRows.Count > 0)
            {
                FrmModiUsuario frm = new FrmModiUsuario();
                frm.cmbRol.Text = tblUsuario.CurrentRow.Cells["Descripcion"].Value.ToString();
                frm.txtApellido.Text = tblUsuario.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                frm.txtUsuario.Text = tblUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                frm.txtPass.Text = tblUsuario.CurrentRow.Cells["Contraseña"].Value.ToString();
                frm.txtId.Text = tblUsuario.CurrentRow.Cells["ID"].Value.ToString();
                frm.ShowDialog();
                Cargar_Usuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
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
    }
}
