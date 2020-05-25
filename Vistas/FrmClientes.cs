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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            tblCliente.DataSource = ClienteABM.listarClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frm = new FrmAltaCliente();
            frm.ShowDialog();
            CargarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblCliente.SelectedRows.Count > 0)
            {
                FrmModiCliente frm = new FrmModiCliente();
                frm.tbx_dni.Text = tblCliente.CurrentRow.Cells["DNI"].Value.ToString();
                frm.tbx_nombre.Text = tblCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                frm.tbx_apellido.Text = tblCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                frm.tbx_direccion.Text = tblCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                frm.tbx_telefono.Text = tblCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                frm.ShowDialog();
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblCliente.SelectedRows.Count > 0)
            {
                Cliente cliente = new Cliente();
                cliente.Cli_Dni = tblCliente.CurrentRow.Cells["DNI"].Value.ToString();
                ClienteABM.eliminarCliente(cliente);
                MessageBox.Show("Se elimino el usuario correctamente");
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != " ")
            {
                tblCliente.DataSource = ClienteABM.BuscarClientes(txtBuscar.Text);
            }
            else
            {
                CargarClientes();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
