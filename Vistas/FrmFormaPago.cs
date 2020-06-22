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
    public partial class FrmFormaPago : Form
    {
        public FrmFormaPago()
        {
            InitializeComponent();
        }

        private void CargarPago()
        {
            tblFormaPago.DataSource = PagoABM.list_forma_pago();
        }

        private void FrmFormaPago_Load(object sender, EventArgs e)
        {
            CargarPago();
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "")
            {
                try {
                FormaPago pago = new FormaPago();
                pago.Pag_descripcion = txtDesc.Text;
                PagoABM.agregarPago(pago);
                CargarPago();
                pago = new FormaPago();
                    MessageBox.Show("Forma de pago Agregado!");

                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("Forma de pago no Registrado!");
                }
                
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblFormaPago.CurrentRow != null)
            {
                try {
                 FormaPago pago = new FormaPago();
                pago.Pag_id = Convert.ToInt32(tblFormaPago.CurrentRow.Cells["ID"].Value.ToString());
                if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    PagoABM.eliminarPago(pago);
                    MessageBox.Show("Se elimino la Clase correctamente", "Importante!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPago();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            btnGuardarNuevo.Visible = false;
            if (tblFormaPago.CurrentRow != null)
            {

                txtIdPago.Text = tblFormaPago.CurrentRow.Cells["ID"].Value.ToString();
                txtDesc.Text = tblFormaPago.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "")
            {
                try {
                FormaPago pago = new FormaPago();
                pago.Pag_id = int.Parse(txtIdPago.Text);
                pago.Pag_descripcion = txtDesc.Text;
                PagoABM.editarPago(pago);
                CargarPago();
                    MessageBox.Show("Pago Editado!");

                }
                catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("Pago no editado!");
                }
              
            }
            else
            {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdPago.Text = "";
            txtDesc.Text = "";
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            btnGuardarNuevo.Visible = true;
        }

    }
}
