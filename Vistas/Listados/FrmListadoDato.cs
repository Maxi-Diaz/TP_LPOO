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
using Vistas.Listados;

namespace Vistas.Listados {
    public partial class FrmListadoDato : Form {
        public FrmListadoDato(string titulo, int dato) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargar(titulo, dato);
        }

         
           

        private void cargar(string titulo, int dato) {

            switch (titulo) {
                case "Compras":
                    lblTitulo.Text = "Compras Realizadas";
                    dgvListado.DataSource = VentasABM.list_Compras(dato);
                    break;

                case "Venta Marcas":
                    lblTitulo.Text = "Compras Realizadas";
                    dgvListado.DataSource = MarcaABM.list_Marca(dato);

                    break;

                case "Linea":

                    break;

                case "TodoVentas":

                    break;

                case "":
                    break;

            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }









    }
}
