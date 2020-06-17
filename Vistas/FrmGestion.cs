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
    public partial class FrmGestion : Form
    {
        public FrmGestion()
        {
            InitializeComponent();
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            CargarClase();
            CargarTipo();
        }

        private void CargarClase()
        {
            tblClaseVeh.DataSource = ClaseABM.listarClases();
        }

        private void CargarTipo()
        {
            tblTipoVeh.DataSource = TipoABM.listarTipos();
        }

        private void btnNuevoClase_Click(object sender, EventArgs e)
        {
            if (txtClaseDesc.Text != "")
            {
                ClaseVehiculo clase = new ClaseVehiculo();
                clase.Cls_descripcion = txtClaseDesc.Text;
                ClaseABM.agregarClase(clase);
                CargarClase();
                clase = new ClaseVehiculo();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnNuevoTipo_Click(object sender, EventArgs e)
        {
            if (txtTipoClase.Text != "")
            {
                TipoVehiculo tipo = new TipoVehiculo();
                tipo.Tip_descripcion = txtTipoClase.Text;
                TipoABM.agregarTipo(tipo);
                CargarTipo();
                tipo = new TipoVehiculo();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnEliminarTipo_Click(object sender, EventArgs e)
        {
            if (tblTipoVeh.CurrentRow != null)
            {
                TipoVehiculo tipo = new TipoVehiculo();
                tipo.Tip_id = Convert.ToInt32(tblTipoVeh.CurrentRow.Cells["ID"].Value.ToString());
                if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    TipoABM.eliminarTipo(tipo);
                    MessageBox.Show("Se elimino el Tipo correctamente", "Importante!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTipo();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditTipo_Click(object sender, EventArgs e)
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

        private void btnEliminarClase_Click(object sender, EventArgs e)
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

        private void btnEditClase_Click(object sender, EventArgs e)
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

        private void btnEditarG_Click(object sender, EventArgs e)
        {
            if (txtClaseDesc.Text != "")
            {
                ClaseVehiculo clase = new ClaseVehiculo();
                clase.Cls_descripcion = txtTipoClase.Text;
                ClaseABM.editarClase(clase);
                CargarClase();
                clase = new ClaseVehiculo();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtClaseID.Text = "";
            txtClaseDesc.Text = "";
            btnEditarG.Visible = false;
            btnCancelarC.Visible = false;
            btnNuevoClase.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTipoID.Text = "";
            txtTipoClase.Text = "";
            btnCancelarT.Visible = false;
            btnEditGT.Visible = false;
            btnNuevoTipo.Visible = true;
        }

        private void btnEditGT_Click(object sender, EventArgs e)
        {
            if (txtTipoClase.Text != "")
            {
                TipoVehiculo tipo = new TipoVehiculo();
                tipo.Tip_descripcion = txtTipoClase.Text;
                TipoABM.editarTipo(tipo);
                CargarTipo();
                tipo = new TipoVehiculo();
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }
    }
}
