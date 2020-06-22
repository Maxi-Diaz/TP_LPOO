using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;
using ClaseBase.BD;

namespace Vistas
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "")
            {
                try {
                Marca marca = new Marca();
                marca.Mar_descripcion = txtDesc.Text;
                MarcaABM.agregarMarca(marca);
                CargarMarca();
                txtID.Text = "";
                txtDesc.Text = "";
                    MessageBox.Show("Marca Agregada!");

                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("Marca no Registrada!");
                }
              
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            CargarMarca();
        }

        private void CargarMarca()
        {
            tblMarca.DataSource = MarcaABM.list_Marca();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblMarca.CurrentRow != null)
            {
                try {
                    Marca marca = new Marca();
                marca.Mar_id = Convert.ToInt32(tblMarca.CurrentRow.Cells["mar_ID"].Value.ToString());
                if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MarcaABM.eliminarMarca(marca);
                    MessageBox.Show("Se elimino el Marca correctamente", "Importante!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMarca();
                }
                  
                    
                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("Marca no eliminada!");
                }
               
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = true;
            btnEditarG.Visible = true;
            btnNuevaMarca.Visible = false;
            if (tblMarca.CurrentRow != null)
            {
                txtID.Text = tblMarca.CurrentRow.Cells["mar_ID"].Value.ToString();
                txtDesc.Text = tblMarca.CurrentRow.Cells["mar_Nombre"].Value.ToString();

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
                    Marca marca = new Marca();
                    marca.Mar_id = int.Parse(txtID.Text);
                    marca.Mar_descripcion = txtDesc.Text;
                    MarcaABM.editarMarca(marca);
                    CargarMarca();
                    txtID.Text = "";
                    txtDesc.Text = "";
                MessageBox.Show("Marca Editada!");
                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("error al editar");
                }

                
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDesc.Text = "";
            btnCancelar.Visible = false;
            btnEditarG.Visible = false;
            btnNuevaMarca.Visible = true;
        }
    }
}
