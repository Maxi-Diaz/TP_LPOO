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
        private Button currentButton;
        private Random random;
        private int tempndex;
        public Form activarForm;
        string usu = "";
        string con = "";
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmMenu(String user, string pwd)
        {
            
            InitializeComponent();
            random = new Random();
            btnCerrar.Visible = false;
            cargar_nombre(user, pwd);
            usu = user;
            con = pwd;
        }

        public FrmMenu(){}

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            iniciarBotones();
        }

        /*Metodo para Seleccionar color aleatorio*/
        private Color SelectTemaColores()
        {
            int index = random.Next(TemasColores.ColorLista.Count);
            while (tempndex == index)
            {
                index = random.Next(TemasColores.ColorLista.Count);
            }
            tempndex = index;
            string color = TemasColores.ColorLista[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivarBoton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DesactivarBoton();
                    Color color = SelectTemaColores();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    barTitulo.BackColor = color;
                    pbarBtn.BackColor = color;
                    btnCerrarSesion.BackColor = TemasColores.ChangeColorBrightness(color, -0.3);
                    btnCerrar.BackColor = TemasColores.ChangeColorBrightness(color, -0.3);
                    pLogo.BackColor = TemasColores.ChangeColorBrightness(color, -0.3);
                    btnCerrar.Visible = true;
                }
            }
        }

        public void DesactivarBoton()
        {
            foreach (Control previousBtn in pMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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
            }
            else if (FrmLogin.idRolNumber == 2)
            {
                btnVentas.Enabled = true;
                btnCliente.Enabled = true;
            }
            else
            {
                btnCliente.Enabled = true;
                btnSistema.Enabled = true;
                btnVehiculo.Enabled = true;
                btnVentas.Enabled = true;
            }
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        { 
            if(MessageBox.Show("Seguro quiere cerrar?", "PELIGRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes){
                Application.Exit();
            }
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
        private void AbrirFormInPanel(Form formHijo, object btnSender)
        {
            if (activarForm != null)
            {
                activarForm.Close();
            }
            ActivarBoton(btnSender);
            activarForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formHijo);
            this.panelPrincipal.Tag = formHijo;
            btnCerrarSesion.BringToFront();
            formHijo.BringToFront();
            formHijo.Show();
            lbTitulo.Text = formHijo.Text;
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

        private void hideSubMenu2()
        {
            if (subMenu2.Visible == true)
            {
                subMenu2.Visible = false;
            }
        }

        private void showSubMenu2(Panel subMenus)
        {
            if (subMenus.Visible == false)
            {
                hideSubMenu2();
                subMenus.Visible = true;
            }
            else
            {
                subMenus.Visible = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesion?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        /*LLama al form hijo */
        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenu);
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            showSubMenu2(subMenu2);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmClientes(), sender);
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmUsuario(), sender);
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmListadoVentas(), sender);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmNuevaVenta(usu, con), sender);
        }

        private void fecha_t_Tick(object sender, EventArgs e)
        {
            lbfecha.Text = DateTime.Now.ToLongDateString();
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnNuevoVeh_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmVehiculo(), sender);
        }

        private void btnNuevoGestion_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmGestion(), sender);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(activarForm != null){
                activarForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DesactivarBoton();
            lbTitulo.Text = "HOME";
            pbarBtn.BackColor = Color.FromArgb(249, 155, 0);
            barTitulo.BackColor = Color.FromArgb(249, 155, 0);
            pLogo.BackColor = Color.FromArgb(39, 39, 58);
            btnCerrarSesion.BackColor = Color.FromArgb(255, 192, 128);
            currentButton = null;
            btnCerrar.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
    }
}
