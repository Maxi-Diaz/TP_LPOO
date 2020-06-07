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
    public partial class FrmNuevaVenta : Form
    {
        public FrmNuevaVenta(string user, string pwd)
        {
            InitializeComponent();
            load_combo_clientes();
            load_combo_vehiculos();
            load_combo_formaPago();
            cargar_Vendedor(user, pwd);
        }

        private void load_combo_clientes()
        {
            cmbCliente.DisplayMember = "Cliente";
            cmbCliente.ValueMember = "cli_id";
            cmbCliente.DataSource = VentasABM.list_cliente();
        }


        private void load_combo_vehiculos()
        {
            cmbVehiculo.DisplayMember = "veh_datos";
            cmbVehiculo.ValueMember = "veh_id";
            cmbVehiculo.DataSource = VentasABM.list_vehiculos();

        }

        private void load_combo_formaPago()
        {
            cmbPago.DisplayMember = "pag_Forma";
            cmbPago.ValueMember = "pag_id";
            cmbPago.DataSource = VentasABM.list_forma_pago();
        }

        private void cargar_Vendedor(string user, string pwd)
        {
            cmbVendedor.DisplayMember = "usu_apellidoNombre";
            cmbVendedor.ValueMember = "usu_id";
            cmbVendedor.DataSource = VentasABM.set_vendedor(user, pwd);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Registrar la venta?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                agregar();
                limpiarCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregar()
        {
            try
            {
                Venta oVenta = new Venta();

                oVenta.Cli_Id = (int)cmbCliente.SelectedValue;
                oVenta.Veh_Id = (int)cmbVehiculo.SelectedValue;
                oVenta.Usr_Id = (int)cmbCliente.SelectedValue;
                oVenta.Vta_Fecha = dtmFecha.Value;
                oVenta.Pag_Id = cmbPago.SelectedValue.ToString();
                oVenta.Vta_PrecioFinal = Convert.ToDecimal(txtPrecio.Text);
                oVenta.Vta_Estado = "VALIDADA";



                VentasABM.insertVenta(oVenta);
                MessageBox.Show("Venta Registrada!");
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a);
                MessageBox.Show("Venta no Registrada!");
            }
        }

        private void limpiarCampos()
        {
            cmbCliente.Text = "";
            cmbVehiculo.Text = "";
            cmbPago.Text = "";
            dtmFecha.Text = "";
            txtPrecio.Text = "";
        }

        private void cmbVehiculo_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.Text = VentasABM.precio_vehiculo(Convert.ToInt32(cmbVehiculo.SelectedValue.ToString()));
        }

        private void txtPrecio_KeyPress( object sender, KeyPressEventArgs e ) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }
    }
}
