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

namespace Vistas
{
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro quiere cancelar", "Alerta!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(lbl_title.Text=="Agregar"){
                if (tbx_dni.Text != "" && tbx_nombre.Text != "" && tbx_apellido.Text != ""
                && tbx_direccion.Text != "" && tbx_telefono.Text != "") {
                    Cliente cliente = new Cliente();
                    cliente.Cli_Dni = tbx_dni.Text;
                    cliente.Cli_Nombre = tbx_nombre.Text;
                    cliente.Cli_Apellido = tbx_apellido.Text;
                    cliente.Cli_Direccion = tbx_direccion.Text;
                    cliente.Cli_Telefono = tbx_telefono.Text;
                    if (ClienteABM.cliente_existente(cliente.Cli_Dni) == 0)
                    {
                        ClienteABM.agregarCliente(cliente);
                        //MessageBox.Show(ClienteABM.cliente_existente(cliente.Cli_Dni).ToString());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Dni Existente");
                        //MessageBox.Show(ClienteABM.cliente_existente(cliente.Cli_Dni).ToString());
                    }
                } else {
                    MessageBox.Show("Complete todos los campos");
                }
            } else {
                if (tbx_dni.Text != "" && tbx_nombre.Text != "" && tbx_apellido.Text != ""
                && tbx_direccion.Text != "" && tbx_telefono.Text != "") {
                    Cliente cliente = new Cliente();
                    cliente.Cli_Dni = tbx_dni.Text;
                    cliente.Cli_Nombre = tbx_nombre.Text;
                    cliente.Cli_Apellido = tbx_apellido.Text;
                    cliente.Cli_Direccion = tbx_direccion.Text;
                    cliente.Cli_Telefono = tbx_telefono.Text;
                    if (ClienteABM.cliente_existente(cliente.Cli_Dni) <= 1)
                    {
                        ClienteABM.editarCliente(cliente);
                        //MessageBox.Show(ClienteABM.cliente_existente(cliente.Cli_Dni).ToString());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Dni Existente");
                        MessageBox.Show(ClienteABM.cliente_existente(cliente.Cli_Dni).ToString());
                    }
                    
                } else {
                    MessageBox.Show("Campos Vacios");
                }
            }
            
        }

        private void tbx_dni_KeyPress( object sender, KeyPressEventArgs e ) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
