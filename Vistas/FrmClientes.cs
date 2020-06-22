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
using Vistas.Listados;


namespace Vistas
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            tblCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            tblCliente.DataSource = ClienteABM.listarClientes();
            tblCliente.Columns[5].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frm = new FrmAltaCliente();
            frm.lbl_title.Text = "Agregar";
            frm.ShowDialog();
            CargarClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblCliente.CurrentRow != null)
            {
                //FrmModiCliente frm = new FrmModiCliente();
                FrmAltaCliente frm = new FrmAltaCliente();
                frm.lbl_title.Text = "Modificar";
                frm.txtID.Text = tblCliente.CurrentRow.Cells["cli_ID"].Value.ToString();////////////////
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
                MessageBox.Show("Debe seleccionar una fila", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblCliente.CurrentRow != null)
            {
                Cliente cliente = new Cliente();
                cliente.Cli_Dni = tblCliente.CurrentRow.Cells["DNI"].Value.ToString();
                cliente.Cli_Id = Convert.ToInt32( tblCliente.CurrentRow.Cells["cli_ID"].Value.ToString());
                if(ClienteABM.cliente_compras(cliente.Cli_Id) != 0){
                    MessageBox.Show("El cliente posee compras, no se puede eliminar");
                }else{
                     if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                      {
                           ClienteABM.eliminarCliente(cliente);
                           MessageBox.Show("Se elimino el usuario correctamente");
                           CargarClientes();
                      }
                }

               
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != " ")
            {
                tblCliente.DataSource = ClienteABM.BuscarClientes(txtBuscar.Text);
                txtBuscar.Text = "";
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

        private void btnporApellido_Click(object sender, EventArgs e)
        {
            //FrmListadoSimple oFrm = new FrmListadoSimple("Cliente");
            //oFrm.Show();
            tblCliente.DataSource = ClienteABM.ordenarPorApellido();
            tblCliente.Columns[5].Visible = false;
        }
    }
}
