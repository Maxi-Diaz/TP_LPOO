using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ClaseBase.BD;
using ClaseBase;

namespace Vistas
{
    public partial class FrmMenu : Form
    {
        string usu = "";
        string con = "";
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmMenu(String user, string pwd)
        {
            InitializeComponent();
            cargar_nombre(user, pwd);
            usu = user;
            con = pwd;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            iniciarBotones();
        }

        private void cargar_nombre(String user, string pwd)
        {
            lblLogueado.Text = Validaciones.nombre_usuario(user, pwd);
        }

        private void iniciarBotones()
        {
            if (FrmLogin.idRolNumber == 1)
            {
                
                btnSistema.Enabled = true;
                btnVehiculo.Enabled = true;
                btnReporte.Enabled = true;
            }
            else if (FrmLogin.idRolNumber == 2)
            {
                btnVentas.Enabled = true;
                btnCliente.Enabled = true;
            }
            else
            {
                btnCliente.Enabled = true;
                btnReporte.Enabled = true;
                btnSistema.Enabled = true;
                btnVehiculo.Enabled = true;
                btnVentas.Enabled = true;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        { 
            if(MessageBox.Show("Seguro quiere cerrar?", "Importante!!", MessageBoxButtons.YesNo)== DialogResult.Yes){
                Application.Exit();
            }
        }

        int LX, LY;
        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1150, 650);
            this.Location = new Point(LX, LY);
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*CODIGO ABRIR FORMULARIO DENTRO DE PANEL*/
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void hideSubMenu() {
            if (subMenu.Visible == true)
            {
                subMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenus)
        {
            if (subMenus.Visible == false)
            {
                hideSubMenu();
                subMenus.Visible = true;
            }
            else {
                subMenus.Visible = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesion?", "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        /*LLama al form hijo */
        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenu);
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmVehiculo());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmClientes());
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmUsuario());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmListadoVentas());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmNuevaVenta(usu,con));
        }
    }
}
