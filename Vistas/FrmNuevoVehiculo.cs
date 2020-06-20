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
    public partial class FrmNuevoVehiculo : Form
    {
        private int opcion;
        public FrmNuevoVehiculo(int op)
        {
            InitializeComponent();
            llenar_datos(op);
            load_combo_marca();
            load_combo_clase();
            load_combo_tipo();
            opcion = op;
        }

        private void llenar_datos(int op)
        {
            if (op == 0)
            {
                limpiarCampos();
            }
            else
            {

            }
        }

        private void load_combo_marca()
        {
            cmbMarca.DisplayMember = "mar_Nombre";
            cmbMarca.ValueMember = "mar_ID";
            cmbMarca.DataSource = MarcaABM.list_Marca();
        }

        private void cmbMarca_TextChanged(object sender, EventArgs e)
        {
            load_combo_linea((int)cmbMarca.SelectedValue);
        }

        private void load_combo_tipo()
        {
            cmb_tipo.DisplayMember = "tip_Tipo";
            cmb_tipo.ValueMember = "tip_ID";
            cmb_tipo.DataSource = VehiculoABM.list_tipo();
        }

        private void load_combo_clase()
        {
            cmb_clase.DisplayMember = "cla_Descripcion";
            cmb_clase.ValueMember = "cla_ID";
            cmb_clase.DataSource = VehiculoABM.list_clase();
        }
        private void load_combo_linea(int id)
        {
            cmbLinea.DisplayMember = "lin_Nombre";
            cmbLinea.ValueMember = "lin_ID";
            cmbLinea.DataSource = LineaABM.list_Linea(id);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case 0:

                    if (txtMatricula.Text != "" && txtModelo.Text != "" && txtColor.Text != "" && txtPuertas.Text != ""
                        && txtPrecio.Text != "")
                    {
                        agregar();
                        limpiarCampos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Por favor complete todos los datos!");
                    }
                    break;
                case 1:
                    if (txtMatricula.Text != "" && txtModelo.Text != "" && txtColor.Text != "" && txtPuertas.Text != "" &&
                        txtPrecio.Text != "")
                    {
                        editar();
                        limpiarCampos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Por favor complete todos los datos!");
                    }
                    break;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void limpiarCampos()
        {
            txtMatricula.Text = "";
            cmbLinea.Text = "";
            cmbMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtPuertas.Text = "";
            chbGPS.Checked = false;
            txtPrecio.Text = "";
        }

        private void agregar()
        {
            try
            {
                Vehiculo oVehiculo = new Vehiculo();

                oVehiculo.Veh_Matricula = txtMatricula.Text;
                oVehiculo.Lin_Id = (int)cmbLinea.SelectedValue;
                oVehiculo.Veh_Modelo = Convert.ToInt32(txtModelo.Text);
                oVehiculo.Veh_Color = txtColor.Text;
                oVehiculo.Veh_Puerta = Convert.ToInt32(txtPuertas.Text);
                if (chbGPS.Checked == true)
                {
                    oVehiculo.Veh_GPS = true;
                }
                else
                {
                    oVehiculo.Veh_GPS = false;
                }
                oVehiculo.Tip_ID = int.Parse(cmb_tipo.SelectedValue.ToString());
                oVehiculo.Cls_ID = int.Parse(cmb_clase.SelectedValue.ToString());
                oVehiculo.Veh_Precio = Convert.ToDecimal(txtPrecio.Text);
                oVehiculo.Veh_Estado = true;





                VehiculoABM.insertVehiculo(oVehiculo);
                MessageBox.Show("Vehiculo Registrado!");
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
                MessageBox.Show("Vehiculo no Registrado!");
            }
        }


        private void editar()
        {
            try
            {
                Vehiculo oVehiculo = new Vehiculo();
                oVehiculo.Veh_ID = Convert.ToInt32(txtID.Text);
                oVehiculo.Veh_Matricula = txtMatricula.Text;
                oVehiculo.Lin_Id = (int)cmbLinea.SelectedValue;
                oVehiculo.Veh_Modelo = Convert.ToInt32(txtModelo.Text);
                oVehiculo.Veh_Color = txtColor.Text;
                oVehiculo.Veh_Puerta = Convert.ToInt32(txtPuertas.Text);
                if (chbGPS.Checked == true)
                {
                    oVehiculo.Veh_GPS = true;
                }
                else
                {
                    oVehiculo.Veh_GPS = false;
                }
                oVehiculo.Tip_ID = int.Parse(cmb_tipo.SelectedValue.ToString());
                oVehiculo.Cls_ID = int.Parse(cmb_clase.SelectedValue.ToString());
                oVehiculo.Veh_Precio = Convert.ToDecimal(txtPrecio.Text);
                oVehiculo.Veh_Estado = true;

                VehiculoABM.editarVehiculo(oVehiculo);
                MessageBox.Show("Vehiculo Modificado!");
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
                MessageBox.Show("Vehiculo no Modificado!");
            }
        }

        private void txtPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnNuevoTipo_Click(object sender, EventArgs e)
        {
            FrmTipo frm = new FrmTipo();
            frm.ShowDialog();
        }

        private void btnNuevoClase_Click(object sender, EventArgs e)
        {
            FrmClase frm = new FrmClase();
            frm.ShowDialog();
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frm = new FrmMarca();
            frm.ShowDialog();
        }

        private void btnNuevaLinea_Click(object sender, EventArgs e)
        {
            FrmLinea frm = new FrmLinea();
            frm.ShowDialog();
        }
    }
}
