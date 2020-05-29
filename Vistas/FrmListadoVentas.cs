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
        public FrmListadoVentas()
        {
            InitializeComponent();
            cargar();
            load_combo_clientes();
            load_combo_marcas();
        }

        private void load_combo_clientes() {
            cmbClientes.DisplayMember = "cli_Datos";
            cmbClientes.ValueMember = "cli_ID";
            cmbClientes.DataSource = VentasABM.list_cliente();
        }

        private void cargar()
        {
            tbListaVentas.DataSource = VentasABM.list_venta();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbListaVentas.DataSource = VentasABM.buscarMarcaVenta(textBox1.Text);
        }
        */
        private void btnCompras_Click(object sender, EventArgs e) {
            FrmListadoDato oFrm = new FrmListadoDato("Compras", (int)cmbClientes.SelectedValue);
            oFrm.Show();
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e) {

        }

        private void btnFecha_Click(object sender, EventArgs e) {
            FrmListadoFechas oFrm = new FrmListadoFechas(dtpInicio.Value, dtpFinal.Value);
            oFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            FrmListadoDato oFrm = new FrmListadoDato("Venta Marcas", (int)cmbMarca.SelectedValue);
            oFrm.Show();
        }

        private void load_combo_marcas() {
            cmbMarca.DisplayMember = "mar_Nombre";
            cmbMarca.ValueMember = "mar_ID";
            cmbMarca.DataSource = MarcaABM.list_Marca();
        }
    }
}
