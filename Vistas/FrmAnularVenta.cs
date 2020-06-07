using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase.BD;

namespace Vistas {
    public partial class FrmAnularVenta: Form {
        public FrmAnularVenta() {
            InitializeComponent();
        }

        private void FrmAnularVenta_Load( object sender, EventArgs e ) {

        }

        private void btn_aceptar_Click( object sender, EventArgs e ) {
            VentasABM.anular_venta(int.Parse(txt_id.Text.ToString()));
            this.Close();
        }
    }
}
