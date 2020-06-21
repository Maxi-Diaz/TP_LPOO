using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ClaseBase.BD;
using ClaseBase;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using SDFont = System.Drawing;

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
            cmbCliente.DataSource = ClienteABM.list_cliente();
        }


        private void load_combo_vehiculos()
        {
            cmbVehiculo.DisplayMember = "veh_datos";
            cmbVehiculo.ValueMember = "veh_id";
            cmbVehiculo.DataSource = VehiculoABM.list_Vehiculos_disponible();

        }
     

        private void load_combo_formaPago()
        {
            cmbPago.DisplayMember = "Descripcion";
            cmbPago.ValueMember = "ID";
            cmbPago.DataSource = PagoABM.list_forma_pago();
        }

        private void cargar_Vendedor(string user, string pwd)
        {
            cmbVendedor.DisplayMember = "usu_apellidoNombre";
            cmbVendedor.ValueMember = "usu_id";
            cmbVendedor.DataSource = UsuarioABM.set_vendedor(user, pwd);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaActal = DateTime.Today;
            if (dtmFecha.Value > fechaActal)
            {
                if (MessageBox.Show("Desea Registrar la venta?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    agregar();
                    limpiarCampos();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tiene que ser una fecha actualizada","Importante",MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

        private void agregar()
        {
            try {
                Venta oVenta = new Venta();
                oVenta.Cli_Id = (int) cmbCliente.SelectedValue;
                oVenta.Veh_Id = (int) cmbVehiculo.SelectedValue;
                oVenta.Usr_Id = (int) cmbVendedor.SelectedValue;
                oVenta.Vta_Fecha = dtmFecha.Value;
                oVenta.Pag_Id = cmbPago.SelectedValue.ToString();
                oVenta.Vta_PrecioFinal = Convert.ToDecimal(txtPrecio.Text);
                oVenta.Vta_Estado = "PENDIENTE";
                VentasABM.insertVenta(oVenta);
                MessageBox.Show("Venta Registrada!");
                Vehiculo oVehiculo = new Vehiculo();
                oVehiculo.Veh_ID = oVenta.Veh_Id;
                oVehiculo.Veh_Estado = false;
                VehiculoABM.venderVehiculo(oVehiculo);
                load_combo_vehiculos();
            } catch (Exception a) {
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
            try {
                txtPrecio.Text = VehiculoABM.precio_vehiculo(Convert.ToInt32(cmbVehiculo.SelectedValue.ToString()));
            } catch{

            }
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFormaPago frm = new FrmFormaPago();
            frm.ShowDialog();
        }

        private void sinVehiculo() {
            if(cmbVehiculo.SelectedIndex == -1){
                DialogResult result = MessageBox.Show("Sin Vehiculos Disponibles","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    
                } 
            }
        }

        private void FrmNuevaVenta_Load( object sender, EventArgs e ) {
            sinVehiculo();
        }
    }
}
