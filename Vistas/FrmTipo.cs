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
    public partial class FrmTipo : Form
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void FrmTipo_Load(object sender, EventArgs e)
        {
            CargarTipo();
        }

        private void CargarTipo()
        {
            tblTipoVeh.DataSource = TipoABM.listarTipos();
        }

        private void btnEliminarTipo_Click_1(object sender, EventArgs e)
        {
            if (tblTipoVeh.CurrentRow != null)
            {
                try {
                TipoVehiculo tipo = new TipoVehiculo();
                tipo.Tip_id = Convert.ToInt32(tblTipoVeh.CurrentRow.Cells["ID"].Value.ToString());
                if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TipoABM.eliminarTipo(tipo);
                    MessageBox.Show("Se elimino el Tipo correctamente", "Importante!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTipo();
                }

                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("No se pudo eliminar!");
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditTipo_Click_1(object sender, EventArgs e)
        {
            btnCancelarT.Visible = true;
            btnEditGT.Visible = true;
            btnNuevoTipo.Visible = false;
            if (tblTipoVeh.CurrentRow != null)
            {
                txtTipoID.Text = tblTipoVeh.CurrentRow.Cells["ID"].Value.ToString();
                txtTipoClase.Text = tblTipoVeh.CurrentRow.Cells["Descripcion"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditGT_Click_1(object sender, EventArgs e)
        {
            if (txtTipoClase.Text != "")
            {
                try {
                TipoVehiculo tipo = new TipoVehiculo();
                tipo.Tip_id = int.Parse(txtTipoID.Text);
                tipo.Tip_descripcion = txtTipoClase.Text;
                TipoABM.editarTipo(tipo);
                CargarTipo();
                txtTipoID.Text = "";
                txtTipoClase.Text = "";
                    MessageBox.Show("Tipo de vehiculo Modificado!");

                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("No se pudo editar!");
                }
               
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnCancelarT_Click(object sender, EventArgs e)
        {
            txtTipoID.Text = "";
            txtTipoClase.Text = "";
            btnCancelarT.Visible = false;
            btnEditGT.Visible = false;
            btnNuevoTipo.Visible = true;
        }

        private void btnNuevoTipo_Click_1(object sender, EventArgs e)
        {
            if (txtTipoClase.Text != "")
            {
                try {
                TipoVehiculo tipo = new TipoVehiculo();
                tipo.Tip_descripcion = txtTipoClase.Text;
                TipoABM.agregarTipo(tipo);
                CargarTipo();
                txtTipoID.Text = "";
                txtTipoClase.Text = "";
                    MessageBox.Show("Tipo de vehiculo Agregado!");

                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("tipo de vehiculo no Registrado!");
                }
                
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTipoClase_TextChanged(object sender, EventArgs e) {

        }
    }
}
