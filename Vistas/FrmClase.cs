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
    public partial class FrmClase : Form
    {
        public FrmClase()
        {
            InitializeComponent();
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            CargarClase();
            
        }

        private void CargarClase()
        {
            tblClaseVeh.DataSource = ClaseABM.listarClases();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoClase_Click_1(object sender, EventArgs e)
        {
            if (txtClaseDesc.Text != "")
            {
                ClaseVehiculo clase = new ClaseVehiculo();
                clase.Cls_descripcion = txtClaseDesc.Text;
                ClaseABM.agregarClase(clase);
                CargarClase();
                txtClaseID.Text = "";
                txtClaseDesc.Text = "";
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnEliminarClase_Click_1(object sender, EventArgs e)
        {
            if (tblClaseVeh.CurrentRow != null)
            {
                ClaseVehiculo clase = new ClaseVehiculo();
                clase.Cls_ID = Convert.ToInt32(tblClaseVeh.CurrentRow.Cells["ID"].Value.ToString());
                if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ClaseABM.eliminarClase(clase);
                    MessageBox.Show("Se elimino la Clase correctamente", "Importante!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClase();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditClase_Click_1(object sender, EventArgs e)
        {
            btnEditarG.Visible = true;
            btnCancelarC.Visible = true;
            btnNuevoClase.Visible = false;
            if (tblClaseVeh.CurrentRow != null)
            {
                txtClaseID.Text = tblClaseVeh.CurrentRow.Cells["ID"].Value.ToString();
                txtClaseDesc.Text = tblClaseVeh.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarG_Click_1(object sender, EventArgs e)
        {
            if (txtClaseDesc.Text != "")
            {
                ClaseVehiculo clase = new ClaseVehiculo();
                clase.Cls_ID = int.Parse(txtClaseID.Text);
                clase.Cls_descripcion = txtClaseDesc.Text;
                ClaseABM.editarClase(clase);
                CargarClase();
                txtClaseID.Text = "";
                txtClaseDesc.Text = "";
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnCancelarC_Click(object sender, EventArgs e)
        {
            txtClaseID.Text = "";
            txtClaseDesc.Text = "";
            btnEditarG.Visible = false;
            btnCancelarC.Visible = false;
            btnNuevoClase.Visible = true;
        }
    }
}
