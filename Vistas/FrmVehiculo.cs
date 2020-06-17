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
using Vistas.Listados;

namespace Vistas
{
    public partial class FrmVehiculo : Form
    {

        public FrmVehiculo()
        {
            InitializeComponent();
            Cargar();
        }


        private void Cargar()
        {
            dgvVehiculos.DataSource = VehiculoABM.list_Vehiculos();
            dgvVehiculos.Columns[12].Visible = false;
            dgvVehiculos.Columns[13].Visible = false;
            dgvVehiculos.Columns[14].Visible = false;
            dgvVehiculos.Columns[15].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoVehiculo oFrm = new FrmNuevoVehiculo(0);
            oFrm.ShowDialog();
            Cargar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            if (dgvVehiculos.CurrentRow != null)
            {
                FrmNuevoVehiculo oFrm = new FrmNuevoVehiculo(1);
                oFrm.txtID.Text = dgvVehiculos.CurrentRow.Cells["ID"].Value.ToString();
                oFrm.txtMatricula.Text = dgvVehiculos.CurrentRow.Cells["Matricula"].Value.ToString();
                oFrm.cmbMarca.SelectedValue = dgvVehiculos.CurrentRow.Cells["mar_ID"].Value.ToString();
                oFrm.cmbLinea.SelectedValue = dgvVehiculos.CurrentRow.Cells["lin_ID"].Value.ToString();
                oFrm.txtModelo.Text = dgvVehiculos.CurrentRow.Cells["Modelo"].Value.ToString();
                oFrm.txtColor.Text = dgvVehiculos.CurrentRow.Cells["Color"].Value.ToString();
                oFrm.txtPuertas.Text = dgvVehiculos.CurrentRow.Cells["Puertas"].Value.ToString();

                if (dgvVehiculos.CurrentRow.Cells["GPS"].Value.ToString() == "True")
                {
                    oFrm.chbGPS.Checked = true;
                }
                else
                {
                    oFrm.chbGPS.Checked = false;
                }
                oFrm.cmb_tipo.SelectedValue = dgvVehiculos.CurrentRow.Cells["tip_ID"].Value.ToString();
                oFrm.cmb_clase.SelectedValue = dgvVehiculos.CurrentRow.Cells["cls_ID"].Value.ToString();
                oFrm.txtPrecio.Text = dgvVehiculos.CurrentRow.Cells["Precio"].Value.ToString();

                oFrm.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.CurrentRow != null)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Veh_ID = Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["ID"].Value.ToString());
                vehiculo.Veh_Matricula = dgvVehiculos.CurrentRow.Cells["Matricula"].Value.ToString();
                vehiculo.Lin_Id = Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["lin_ID"].Value.ToString());
                vehiculo.Veh_Modelo = Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["Modelo"].Value.ToString());
                vehiculo.Veh_Color = dgvVehiculos.CurrentRow.Cells["Color"].Value.ToString();
                vehiculo.Veh_Puerta = Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["Puertas"].Value.ToString());

                if (dgvVehiculos.CurrentRow.Cells["GPS"].Value.ToString() == "True")
                {
                    vehiculo.Veh_GPS = true;
                }
                else
                {
                    vehiculo.Veh_GPS = false;
                }
                vehiculo.Tip_ID = int.Parse(dgvVehiculos.CurrentRow.Cells["tip_ID"].Value.ToString());
                vehiculo.Cls_ID = int.Parse(dgvVehiculos.CurrentRow.Cells["cls_ID"].Value.ToString());
                vehiculo.Veh_Precio = Convert.ToDecimal(dgvVehiculos.CurrentRow.Cells["Precio"].Value.ToString());
                if (dgvVehiculos.CurrentRow.Cells["Estado"].Value.ToString() == "DISPONIBLE")
                {
                    vehiculo.Veh_Estado = true;
                }
                else
                {
                    vehiculo.Veh_Estado = false;
                }
                if (vehiculo.Veh_Estado == true)
                {
                    if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        eliminar(vehiculo);
                    }
                }
                else
                {
                    MessageBox.Show("El Vehiculo esta Vendido no se puede eliminar!");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void eliminar(Vehiculo oVehiculo)
        {
            try
            {
                VehiculoABM.eliminarVehiculo(oVehiculo);
                MessageBox.Show("Vehiculo Eliminado!");
                Cargar();
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
                MessageBox.Show("Vehiculo no Eliminado!");
            }
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {

            if (rbtnLinea.Checked)
            {
                dgvVehiculos.DataSource = VehiculoABM.list_Vehiculos_lm(1);
            }
            else
            {
                if (rbtnMarca.Checked)
                {
                    dgvVehiculos.DataSource = VehiculoABM.list_Vehiculos_lm(0);
                }
            }
        }
    }
}
