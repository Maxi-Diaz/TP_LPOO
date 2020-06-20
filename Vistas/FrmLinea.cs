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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarLinea()
        {
            tblLineas.DataSource = LineaABM.listarLinea();
        }

        private void FrmLinea_Load(object sender, EventArgs e)
        {
            CargarLinea();
        }

        private void btnNuevaLinea_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "")
            {
                Linea linea = new Linea();
                linea.Lin_descripcion = txtDesc.Text;
                LineaABM.agregarLinea(linea);
                CargarLinea();
                linea = new Linea();
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
                Linea linea = new Linea();
                linea.Lin_id = int.Parse(txtID.Text);
                linea.Lin_descripcion = txtDesc.Text;
                LineaABM.editarLinea(linea);
                CargarLinea();
                txtID.Text = "";
                txtDesc.Text = "";
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
            btnNuevaLinea.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblLineas.CurrentRow != null)
            {
                Linea linea = new Linea();
                linea.Lin_id = Convert.ToInt32(tblLineas.CurrentRow.Cells["ID"].Value.ToString());
                if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LineaABM.eliminarLinea(linea);
                    MessageBox.Show("Se elimino Linea correctamente", "Importante!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLinea();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
