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

namespace Vistas.Listados {
    public partial class FrmListadoSimple : Form {
        public FrmListadoSimple( string titulo) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar(titulo);
        }


        private void cargar(string titulo) {

            //switch (titulo) {
            //    case "Cliente":
            //        lblTitulo.Text = titulo;
            //        dgvListado.DataSource = ClienteABM.cliente_apellido();
            //        break;

            //    case "Marca":
            //        lblTitulo.Text = "Vehiculos ordenados por marca";
            //        dgvListado.DataSource = VehiculoABM.list_Vehiculos_lm(0);
            //        break;

            //    case "Linea":
            //        lblTitulo.Text = titulo;
            //        dgvListado.DataSource = VehiculoABM.list_Vehiculos_lm(1);
            //        break;

            //    case "TodoVentas":
            //        lblTitulo.Text = "Ventas";
            //        //dgvListado.DataSource = VentasABM.list_venta();
            //        break;

            //    case "":
            //        break;

            //}





        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

       


    }
}
