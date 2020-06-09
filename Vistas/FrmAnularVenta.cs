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

        private void btn_aceptar_Click( object sender, EventArgs e ) {
            if (MessageBox.Show("Seguro quiere eliminarlo", "Importante!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Venta Oventa = new Venta();
                Oventa.Vta_Id = Convert.ToInt32(txt_id.Text);
                VentasABM.anular_venta(int.Parse(txt_id.Text.ToString()));
                //this.Close();
            }
        }
    }
}
