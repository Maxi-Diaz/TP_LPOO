using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ClaseBase.BD;
using ClaseBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public static int idRolNumber;
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TituloBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            FrmMenu FrmMenu = new FrmMenu(txtUser.Text, txtPass.Text);
            Validaciones login = new Validaciones();

            if (login.validar(txtUser.Text, txtPass.Text) == 1)
            {
                idRolNumber = 1;
                FrmMenu.Show();
                FrmMenu.FormClosed += Logout;
                this.Hide();
            }
            else if (login.validar(txtUser.Text, txtPass.Text) == 2)
            {
                idRolNumber = 2;
                FrmMenu.Show();
                FrmMenu.FormClosed += Logout;
                this.Hide();
            }
            else if (login.validar(txtUser.Text, txtPass.Text) == 3)
            {
                idRolNumber = 3;
                txtUser.Clear();
                txtPass.Clear();
                FrmMenu.Show();
                FrmMenu.FormClosed += Logout;
                this.Hide();
            }
            else
            {
                msgError("Usuario y/o contraseña incorrectos");
                txtUser.Clear();
                txtPass.Clear();
            }
                    
        }

        private void msgError(String msg)
        {
            lblErrorMsj.Text = "      " + msg;
            lblErrorMsj.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtPass.UseSystemPasswordChar = false;
            lblErrorMsj.Visible = false;
            this.Show();
            txtUser.Focus();
        }
    }
}
