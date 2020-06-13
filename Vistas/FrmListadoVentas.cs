using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase.BD;
using Vistas.Listados;

namespace Vistas
{
    public partial class FrmListadoVentas : Form
    {
        VentasABM ventas = new VentasABM();
        public FrmListadoVentas()
        {

            VentasABM ventas = new VentasABM();
            InitializeComponent();
            cargar();
            load_combo_clientes();
            load_combo_marcas();
        }

        private void load_combo_clientes() {
            cmbClientes.DisplayMember = "Cliente";
            cmbClientes.ValueMember = "Cliente";
            cmbClientes.DataSource = ClienteABM.list_cliente();
            //cmbClientes.DataSource = VentasABM.list_cliente();
            cmbClientes.Text = "Seleccione Cliente";
        }

        public void cargar()
        {
            //VentasABM ventas = new VentasABM();
            this.ventas.list_venta();
            cargar_lblInforme(ventas.Total_ventas, ventas.Total_anulada, ventas.Importe_total);
            tbListaVentas.DataSource = ventas.Tabla;
            tbListaVentas.Columns[9].Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e) {
            ventas.list_Compras(cmbClientes.SelectedValue.ToString());
            cargar_lblInforme(ventas.Total_ventas, ventas.Total_anulada, ventas.Importe_total);
            tbListaVentas.DataSource = ventas.Tabla;
            
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e) {

        }

        private void btnFecha_Click(object sender, EventArgs e) {
            DateTime dtpi = new DateTime(dtpInicio.Value.Year, dtpInicio.Value.Month, dtpInicio.Value.Day, 0, 0, 0);
            DateTime dtpf = new DateTime(dtpFinal.Value.Year, dtpFinal.Value.Month, dtpFinal.Value.Day, 23, 59, 59);
            VentasABM ventas = new VentasABM();
            ventas.list_Fecha(dtpi,dtpf);
            cargar_lblInforme(ventas.Total_ventas, ventas.Total_anulada, ventas.Importe_total);
            tbListaVentas.DataSource = ventas.Tabla;
        }

        private void button1_Click(object sender, EventArgs e) {
            ventas.buscarMarcaVenta(cmbMarca.SelectedValue.ToString());
            cargar_lblInforme(ventas.Total_ventas, ventas.Total_anulada, ventas.Importe_total);
            tbListaVentas.DataSource = ventas.Tabla;
        }

        private void load_combo_marcas() {
            cmbMarca.DisplayMember = "mar_Nombre";
            cmbMarca.ValueMember = "mar_Nombre";
            cmbMarca.DataSource = MarcaABM.list_Marca();
            cmbMarca.Text = "Seleccione Marca";
        }

        private void btn_anuluar_Click( object sender, EventArgs e ) {
            FrmAnularVenta frm = new FrmAnularVenta();
            if (tbListaVentas.SelectedRows.Count > 0)
            {
                frm.txt_id.Text = tbListaVentas.CurrentRow.Cells["ID"].Value.ToString();
                frm.txtVehID.Text = tbListaVentas.CurrentRow.Cells["veh_ID"].Value.ToString();
                frm.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cargar_lblInforme(string total, string anulada, string importe) {
            lbl_registro.Text = "Total de Ventas:" + total + "  |  ";
            lbl_registro.Text = lbl_registro.Text + " " + "Total Anuladas: " + anulada + "  |  ";
            lbl_registro.Text = lbl_registro.Text + " " + "Importe Total(Confirmados): $" + importe;
        }
    }
}
