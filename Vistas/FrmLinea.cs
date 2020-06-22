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
    public partial class FrmLinea : Form
    {
        public FrmLinea()
        {
            InitializeComponent();
            load_combo_marca();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarLinea()
        {
            try {
                tblLineas.DataSource = LineaABM.listarLinea(int.Parse(cmbMarca.SelectedValue.ToString()));
            } catch (Exception a){
                MessageBox.Show(""+a);
            }
            
        }

        private void load_combo_marca() {
            cmbMarca.DisplayMember = "mar_Nombre";
            cmbMarca.ValueMember = "mar_ID";
            cmbMarca.DataSource = MarcaABM.list_Marca();

        }

        private void FrmLinea_Load(object sender, EventArgs e)
        {
            CargarLinea();
        }

        private void btnNuevaLinea_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "" || cmbMarca.SelectedIndex != -1)
            {
                try {
                Linea linea = new Linea();
                linea.Mar_id = int.Parse(cmbMarca.SelectedValue.ToString());
                linea.Lin_descripcion = txtDesc.Text;
                LineaABM.agregarLinea(linea);
                CargarLinea();
                limpiarCampos();
                    MessageBox.Show("Linea Agregada!");

                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("Linea no Registrada!");
                }
               
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = true;
            btnEditarG.Visible = true;
            btnNuevaLinea.Visible = false;
            if (tblLineas.CurrentRow != null)
            {
                txtID.Text = tblLineas.CurrentRow.Cells["ID"].Value.ToString();
                txtDesc.Text = tblLineas.CurrentRow.Cells["Descripcion"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarG_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "")
            {
                try {
                Linea linea = new Linea();
                linea.Lin_id = int.Parse(txtID.Text);
                
                linea.Lin_descripcion = txtDesc.Text;
                LineaABM.editarLinea(linea);
                CargarLinea();
                txtID.Text = "";
                txtDesc.Text = "";
                    MessageBox.Show("Linea Modificada!");

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

        private void limpiarCampos() {
            txtDesc.Text = "";
            cmbMarca.SelectedIndex = 0;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDesc.Text = "";
            btnCancelar.Visible = false;
            btnEditarG.Visible = false;
            btnNuevaLinea.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblLineas.CurrentRow != null)
            {
                try {
                Linea linea = new Linea();
                linea.Lin_id = Convert.ToInt32(tblLineas.CurrentRow.Cells["ID"].Value.ToString());
                if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LineaABM.eliminarLinea(linea);
                    MessageBox.Show("Se elimino Linea correctamente", "Importante!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLinea();
                }
                   

                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("Usuario no Registrado!");
                }
               
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbMarca_SelectedIndexChanged( object sender, EventArgs e ) {
            CargarLinea();
        }
    }
}
