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

namespace Vistas {
    public partial class FrmAnularVenta: Form {
        public FrmAnularVenta() {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro quiere Anular la venta?", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //try
                //{
                //    Venta Oventa = new Venta();
                //    Oventa.Vta_Id = Convert.ToInt32(txt_id.Text);
                //    VentasABM.set_estado_venta(int.Parse(txt_id.Text.ToString()));
                //    Vehiculo oVehiculo = new Vehiculo();
                //    oVehiculo.Veh_ID = Convert.ToInt32(txtVehID.Text.ToString());
                //    oVehiculo.Veh_Estado = true;
                //    VehiculoABM.venderVehiculo(oVehiculo);
                //    MessageBox.Show("Venta Anulada!");
                //    this.Close();
                //}
                //catch (Exception a)
                //{
                //    MessageBox.Show("" + a);
                //    MessageBox.Show("No se pudo Anular!");
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
