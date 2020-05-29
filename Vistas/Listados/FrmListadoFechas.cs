using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase.BD;


namespace Vistas.Listados {
    public partial class FrmListadoFechas : Form {
        public FrmListadoFechas(DateTime inicio, DateTime final) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar(inicio, final);
        }

        private void cargar(DateTime inicio, DateTime final) {
            lblTitulo.Text = "Compras";
            dgvListado.DataSource = VentasABM.list_Fecha(inicio, final);
        }
        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
