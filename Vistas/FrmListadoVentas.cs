using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase.BD;
using Vistas.Listados;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using SDFont = System.Drawing;
using ClaseBase;

namespace Vistas
{
    public partial class FrmListadoVentas : Form
    {
        VentasABM ventas = new VentasABM();
        //string nomfile = "";
        public FrmListadoVentas()
        {

            VentasABM ventas = new VentasABM();
            InitializeComponent();
            cargar();
            load_combo_clientes();
            load_combo_marcas();
            tbListaVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void load_combo_clientes() {
            cmbClientes.DisplayMember = "Cliente";
            cmbClientes.ValueMember = "Cliente";
            cmbClientes.DataSource = ClienteABM.list_cliente();
            //cmbClientes.DataSource = VentasABM.list_cliente();
            cmbClientes.Text = "Seleccione Cliente";
        }

        public void cargar()
        {
            //VentasABM ventas = new VentasABM();
            this.ventas.list_venta();
            cargar_lblInforme(ventas.Total_ventas, ventas.Total_anulada, ventas.Importe_total);
            tbListaVentas.DataSource = ventas.Tabla;
            tbListaVentas.Columns[9].Visible = false;
            tbListaVentas.Columns[10].Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompras_Click(object sender, EventArgs e) {
            ventas.list_Compras(cmbClientes.SelectedValue.ToString());
            cargar_lblInforme(ventas.Total_ventas, ventas.Total_anulada, ventas.Importe_total);
            tbListaVentas.DataSource = ventas.Tabla;

        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e) {

        }

        private void btnFecha_Click(object sender, EventArgs e) {
            DateTime dtpi = new DateTime(dtpInicio.Value.Year, dtpInicio.Value.Month, dtpInicio.Value.Day, 0, 0, 0);
            DateTime dtpf = new DateTime(dtpFinal.Value.Year, dtpFinal.Value.Month, dtpFinal.Value.Day, 23, 59, 59);
            VentasABM ventas = new VentasABM();
            ventas.list_Fecha(dtpi,dtpf);
            cargar_lblInforme(ventas.Total_ventas, ventas.Total_anulada, ventas.Importe_total);
            tbListaVentas.DataSource = ventas.Tabla;
        }

        private void button1_Click(object sender, EventArgs e) {
            ventas.buscarMarcaVenta(cmbMarca.SelectedValue.ToString());
            cargar_lblInforme(ventas.Total_ventas, ventas.Total_anulada, ventas.Importe_total);
            tbListaVentas.DataSource = ventas.Tabla;
        }

        private void load_combo_marcas() {
            cmbMarca.DisplayMember = "mar_Nombre";
            cmbMarca.ValueMember = "mar_Nombre";
            cmbMarca.DataSource = MarcaABM.list_Marca();
            cmbMarca.Text = "Seleccione Marca";
        }

        private void btn_anuluar_Click( object sender, EventArgs e ) {

            DialogResult dialogResult = MessageBox.Show("¿Seguro quieres ANULAR la venta N°"+
                tbListaVentas.CurrentRow.Cells["Numero de Venta"].Value.ToString() + "?", "Anular", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                //do something
                try {
                    Venta Oventa = new Venta();
                    Oventa.Vta_Id = Convert.ToInt32(tbListaVentas.CurrentRow.Cells["Numero de Venta"].Value.ToString());
                    VentasABM.set_estado_venta(int.Parse(tbListaVentas.CurrentRow.Cells["Numero de Venta"].Value.ToString()), "ANULADA");
                    Vehiculo oVehiculo = new Vehiculo();
                    oVehiculo.Veh_ID = Convert.ToInt32(tbListaVentas.CurrentRow.Cells["veh_ID"].Value.ToString());
                    oVehiculo.Veh_Estado = true;
                    VehiculoABM.venderVehiculo(oVehiculo);
                    MessageBox.Show("Venta Anulada!");
                    cargar();
                } catch (Exception a) {
                    MessageBox.Show("" + a);
                    MessageBox.Show("No se pudo Anular!");
                }
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }

        private void cargar_lblInforme(string total, string anulada, string importe) {
            lbl_registro.Text = "Total de Ventas:" + total + "  |  ";
            lbl_registro.Text = lbl_registro.Text + " " + "Total Anuladas: " + anulada + "  |  ";
            lbl_registro.Text = lbl_registro.Text + " " + "Importe Total(Confirmados): $" + importe;
        }

        private void btn_imprimir_Click( object sender, EventArgs e ) {
            try {
                Document documento = new Document(PageSize.A4.Rotate(),10,10,10,10);
                string nombre = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+ "\\Reporte.pdf";
                FileStream archivo = new FileStream(nombre, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                PdfWriter.GetInstance(documento,archivo);
                documento.Open();
                ExportarPDF(documento);
                documento.Close();
                Process.Start(nombre);
                cargar();
            }catch(Exception a){
                MessageBox.Show(""+a);
            }
        }

        public void ExportarPDF(Document documento) {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            Font arial = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);
            PdfPTable pdf = new PdfPTable(tbListaVentas.ColumnCount);
            pdf.DefaultCell.Padding = 3;
            pdf.WidthPercentage = 100;
            pdf.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdf.DefaultCell.BorderWidth = 1;
            float[] columwidth = { 3, 15, 8, 10, 10, 10, 10, 10, 10, 0 ,0};
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            pdf.SetWidths(columwidth);

            Paragraph encabezado = new Paragraph("Reporte Ventas",arial);
            encabezado.Alignment = Element.ALIGN_CENTER;
            Paragraph texto = new Paragraph("Fecha:"+ DateTime.Now +"\n ",text);
            
            foreach(DataGridViewColumn column in tbListaVentas.Columns){
                PdfPCell celldt = new PdfPCell(new Phrase(column.HeaderText, text));
                celldt.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdf.AddCell(celldt);
            }

            foreach (DataGridViewRow row in tbListaVentas.Rows) {
                foreach (DataGridViewCell cell in row.Cells) {

                    pdf.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            
            documento.Add(encabezado);
            documento.Add(texto);
            documento.Add(pdf);
        }

        private void btn_confirmar_Click( object sender, EventArgs e ) {
            if (tbListaVentas.CurrentRow.Cells["Estado"].Value.ToString() == "PENDIENTE") {
                DialogResult dialogResult = MessageBox.Show("¿Quieres CONFIRMAR la venta e Imprimir la Factura?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    //do something
                    //MessageBox.Show(tbListaVentas.CurrentRow.Cells["ID"].Value.ToString());
                    try {
                        imprimirFactura();
                        VentasABM.set_estado_venta(int.Parse(tbListaVentas.CurrentRow.Cells["Numero de Venta"].Value.ToString()), "VALIDADA");
                        cargar();
                    } catch (Exception a) {
                        MessageBox.Show("" + a);
                    }

                } else if (dialogResult == DialogResult.No) {
                    //do something else
                }
            } else if (tbListaVentas.CurrentRow.Cells["Estado"].Value.ToString() == "VALIDADA") {
                DialogResult dialogResult = MessageBox.Show("¿Quieres Imprimir la Factura?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    //do something
                    //MessageBox.Show(tbListaVentas.CurrentRow.Cells["ID"].Value.ToString());
                    try {
                        imprimirFactura();
                        
                    } catch (Exception a) {
                        MessageBox.Show("" + a);
                    }

                } else if (dialogResult == DialogResult.No) {
                    //do something else
                }
            }
            
        }

        private void imprimirFactura() {

            try {
                Document documento = new Document(PageSize.A5, 10, 10, 10, 10);
                string nombre = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Factura N°" + tbListaVentas.CurrentRow.Cells["Numero de Venta"].Value.ToString() + ".pdf";
                FileStream archivo = new FileStream(nombre, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                
                PdfWriter.GetInstance(documento, archivo);
                documento.Open();
                ExportarFacturaPDF(documento);
                documento.Close();
                Process.Start(nombre);
            } catch (Exception e) {
                MessageBox.Show("" + e);
            }
        }

        private void ExportarFacturaPDF(Document documento) {
            DataTable dtv = new DataTable();

            dtv = VehiculoABM.buscarID(int.Parse(tbListaVentas.CurrentRow.Cells["veh_ID"].Value.ToString()));
            string gps = "";
            if (dtv.Rows[0][9].ToString() == "False") {
                gps = "No";
            } else {
                gps = "Si";
            }

            DataTable dtc = new DataTable();
            dtc = ClienteABM.BuscarCliNyPD(tbListaVentas.CurrentRow.Cells["Cliente"].Value.ToString());

            DataTable dtu = new DataTable();
            dtu = UsuarioABM.buscarIDUsuario(int.Parse(tbListaVentas.CurrentRow.Cells["usu_ID"].Value.ToString()));

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            Font arial = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance("logo-Agencia.png");

            //png.ScaleToFit(80f,50f);
            png.ScaleAbsoluteWidth(100f);
            png.ScaleAbsoluteHeight(80f);

            //-----------------TITULO---------------------------
            Paragraph encabezado = new Paragraph("Factura\n\n", arial);
            encabezado.Alignment = Element.ALIGN_CENTER;

            //---------------Espacio----------------------------
            Paragraph texto = new Paragraph("\n");

            //--------------Informacion Venta-------------------
            PdfPTable info = new PdfPTable(2);
            float[] cwinfo = { 6, 14 };
            info.DefaultCell.Padding = 3;
            info.WidthPercentage = 100;
            info.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            info.DefaultCell.BorderWidth = 0;
            info.SetWidths(cwinfo);
            //info.AddCell(new Phrase(" N° De Factura: " + nventa.ToString() + "\n " +
            //    "Fecha de Factura: " + DateTime.Now + "\n ", text));
            PdfPCell cellpng = new PdfPCell(png);
            cellpng.HorizontalAlignment = Element.ALIGN_CENTER;
            cellpng.BorderWidth = 0;
            info.AddCell(cellpng);

            PdfPCell cellinfo = new PdfPCell(new Phrase(" N° De Factura: " + tbListaVentas.CurrentRow.Cells["Numero de Venta"].Value.ToString() + "\n " +
                "Fecha de Factura: " + DateTime.Now + "\n\n " +
                "--------------------------------------------------- \n\n" +
                " Empresa: " + "Company Car" + "\n " +
                "Vendedor: "+ dtu.Rows[0][4].ToString()
                 , text));
            info.AddCell(cellinfo);

            //-------------Datos Cliente------------------
            PdfPTable tablaCliente = new PdfPTable(1);
            tablaCliente.DefaultCell.Padding = 3;
            tablaCliente.WidthPercentage = 100;
            tablaCliente.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaCliente.DefaultCell.BorderWidth = 1;

            PdfPCell cellcli = new PdfPCell(new Phrase("Cliente", text));
            cellcli.BackgroundColor = new iTextSharp.text.BaseColor(192, 192, 192);
            cellcli.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaCliente.AddCell(cellcli);

            tablaCliente.AddCell(new Phrase("Nombre: " + dtc.Rows[0][1].ToString()+"\n" +
                "Apellido: " + dtc.Rows[0][2].ToString() + "\n" +
                "DNI: " + dtc.Rows[0][0].ToString() + "\n" +
                "Direccion: " + dtc.Rows[0][3].ToString() + "\n" +
                "Telefono: " + dtc.Rows[0][4].ToString(), text));
            //------------Datos Veh------------------
            PdfPTable tablaVeh = new PdfPTable(1);
            tablaVeh.DefaultCell.Padding = 3;
            tablaVeh.WidthPercentage = 100;
            tablaVeh.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            tablaVeh.DefaultCell.BorderWidth = 1;

            PdfPCell cellveh = new PdfPCell(new Phrase("Vehiculo", text));
            cellveh.BackgroundColor = new iTextSharp.text.BaseColor(192, 192, 192);
            cellveh.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaVeh.AddCell(cellveh);
            
            tablaVeh.AddCell(new Phrase("Matricula: " +dtv.Rows[0][1].ToString()+ "             " +
                "Modelo: " + dtv.Rows[0][2].ToString() + "\n" +
                "Marca: " + dtv.Rows[0][3].ToString() + "                       " +
                "Linea: " + dtv.Rows[0][4].ToString() + "\n" +
                "Puertas: " + dtv.Rows[0][8].ToString() + "        " +
                "Color: " + dtv.Rows[0][7].ToString() + "        " +
                "Gps: " + gps, text));
            //-------------Importe----------------
            float[] columwidth = { 16, 4 };
            PdfPTable tablaImp = new PdfPTable(2);
            tablaImp.DefaultCell.Padding = 3;
            tablaImp.WidthPercentage = 100;
            tablaImp.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaImp.DefaultCell.BorderWidth = 1;
            tablaImp.SetWidths(columwidth);

            PdfPCell cellimp = new PdfPCell(new Phrase("Importe: ", text));
            cellimp.BackgroundColor = new iTextSharp.text.BaseColor(133, 185, 241);
            cellimp.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaImp.AddCell(cellimp);
            tablaImp.AddCell(new Phrase("$" +tbListaVentas.CurrentRow.Cells["Precio Final"].Value.ToString(), text));

            documento.Add(encabezado);
            documento.Add(info);
            documento.Add(texto);
            documento.Add(tablaCliente);
            documento.Add(texto);
            documento.Add(tablaVeh);
            documento.Add(tablaImp);
        }

        private void tbListaVentas_CellMouseClick( object sender, DataGridViewCellMouseEventArgs e ) {
            if (tbListaVentas.CurrentRow.Cells["Estado"].Value.ToString() == "PENDIENTE" || tbListaVentas.CurrentRow.Cells["Estado"].Value.ToString() == "VALIDADA") {
                btn_confirmar.Enabled = true;
            } else if (tbListaVentas.CurrentRow.Cells["Estado"].Value.ToString() == "ANULADA") {
                btn_confirmar.Enabled = false;
            } else {
                btn_confirmar.Enabled = false;
            }

            if (tbListaVentas.CurrentRow.Cells["Estado"].Value.ToString() == "PENDIENTE") {
                btn_anuluar.Enabled = true;
            } else if (tbListaVentas.CurrentRow.Cells["Estado"].Value.ToString() == "VALIDADA") {
                btn_anuluar.Enabled = false;
            } else {
                btn_anuluar.Enabled = false;
            }
        }



    }
}
