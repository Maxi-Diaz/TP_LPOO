using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;

namespace Vistas
{
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro quiere cancelar", "Titulo, Alerta!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (tbx_matricula.Text != "" && tbx_marca.Text != "" && tbx_linea.Text != "" && tbx_modelo.Text != ""
                && tbx_color.Text != "" && tbx_puertas.Text != "" && cbx_gps != null && tbx_tipo.Text != ""
                && tbx_clase.Text != "" && tbx_precio.Text != "")
            {
                Vehiculo vehiculo = new Vehiculo(tbx_matricula.Text, tbx_marca.Text, tbx_linea.Text, int.Parse(tbx_modelo.Text),
                    tbx_color.Text, int.Parse(tbx_puertas.Text), cbx_gps.Checked, tbx_tipo.Text, tbx_clase.Text,
                    int.Parse(tbx_precio.Text));
                MessageBox.Show("Matricula: " + vehiculo.Veh_Matricula + "\n" +
                    "Marca: " + vehiculo.Veh_Marca + "\n" +
                    "Modelo: " + vehiculo.Veh_Modelo + "\n" +
                    "Puertas: " + vehiculo.Veh_Puerta + "\n" +
                    "GPS: " + cbx_gps.Checked + "\n");
            }
            else {
                MessageBox.Show("Campos Vacios");
            }
        }

        private void btn_aceptar_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
