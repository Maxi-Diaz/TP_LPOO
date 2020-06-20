namespace Vistas
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barTitulo = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lbfecha = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.subMenu = new System.Windows.Forms.Panel();
            this.btnNuevoGestion = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogueado = new System.Windows.Forms.Label();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbarBtn = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbHora = new System.Windows.Forms.Label();
            this.fecha_t = new System.Windows.Forms.Timer(this.components);
            this.barTitulo.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pMenu.SuspendLayout();
            this.subMenu.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pbarBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // barTitulo
            // 
            this.barTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.barTitulo.Controls.Add(this.lbTitulo);
            this.barTitulo.Controls.Add(this.btnCerrarSesion);
            this.barTitulo.Location = new System.Drawing.Point(0, 0);
            this.barTitulo.Name = "barTitulo";
            this.barTitulo.Size = new System.Drawing.Size(950, 64);
            this.barTitulo.TabIndex = 1;
            this.barTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(424, 14);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(105, 36);
            this.lbTitulo.TabIndex = 9;
            this.lbTitulo.Text = "HOME";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(13, 14);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(119, 36);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lbfecha
            // 
            this.lbfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.White;
            this.lbfecha.Location = new System.Drawing.Point(111, 15);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(55, 18);
            this.lbfecha.TabIndex = 6;
            this.lbfecha.Text = "Fecha";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 67);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(950, 538);
            this.panelPrincipal.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.logo_Agencia;
            this.pictureBox1.Location = new System.Drawing.Point(332, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pMenu
            // 
            this.pMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMenu.AutoScroll = true;
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pMenu.Controls.Add(this.btnReportes);
            this.pMenu.Controls.Add(this.btnSistema);
            this.pMenu.Controls.Add(this.btnCliente);
            this.pMenu.Controls.Add(this.btnVehiculo);
            this.pMenu.Controls.Add(this.subMenu);
            this.pMenu.Controls.Add(this.btnVentas);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Location = new System.Drawing.Point(950, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(200, 650);
            this.pMenu.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.Enabled = false;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Image = global::Vistas.Properties.Resources.reportes;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 509);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(15);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 55);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSistema.Enabled = false;
            this.btnSistema.FlatAppearance.BorderSize = 0;
            this.btnSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSistema.Image = global::Vistas.Properties.Resources.empleados;
            this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.Location = new System.Drawing.Point(0, 454);
            this.btnSistema.Margin = new System.Windows.Forms.Padding(15);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(200, 55);
            this.btnSistema.TabIndex = 6;
            this.btnSistema.Text = "Usuarios";
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.Enabled = false;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCliente.Image = global::Vistas.Properties.Resources.clientes;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 399);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(15);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(200, 55);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculo.Enabled = false;
            this.btnVehiculo.FlatAppearance.BorderSize = 0;
            this.btnVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVehiculo.Image = global::Vistas.Properties.Resources.compras;
            this.btnVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculo.Location = new System.Drawing.Point(0, 344);
            this.btnVehiculo.Margin = new System.Windows.Forms.Padding(15);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(200, 55);
            this.btnVehiculo.TabIndex = 4;
            this.btnVehiculo.Text = "Vehiculos";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // subMenu
            // 
            this.subMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.subMenu.Controls.Add(this.btnNuevoGestion);
            this.subMenu.Controls.Add(this.btnNuevo);
            this.subMenu.Controls.Add(this.btnListado);
            this.subMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenu.Location = new System.Drawing.Point(0, 235);
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(200, 109);
            this.subMenu.TabIndex = 8;
            this.subMenu.Visible = false;
            // 
            // btnNuevoGestion
            // 
            this.btnNuevoGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnNuevoGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoGestion.FlatAppearance.BorderSize = 0;
            this.btnNuevoGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnNuevoGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoGestion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoGestion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoGestion.Location = new System.Drawing.Point(0, 73);
            this.btnNuevoGestion.Margin = new System.Windows.Forms.Padding(15);
            this.btnNuevoGestion.Name = "btnNuevoGestion";
            this.btnNuevoGestion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNuevoGestion.Size = new System.Drawing.Size(200, 37);
            this.btnNuevoGestion.TabIndex = 4;
            this.btnNuevoGestion.Text = "Nueva Forma de Pago";
            this.btnNuevoGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoGestion.UseVisualStyleBackColor = false;
            this.btnNuevoGestion.Click += new System.EventHandler(this.btnNuevoGestion_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.Location = new System.Drawing.Point(0, 36);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(15);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(200, 37);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nueva Venta";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnListado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListado.FlatAppearance.BorderSize = 0;
            this.btnListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListado.Location = new System.Drawing.Point(0, 0);
            this.btnListado.Margin = new System.Windows.Forms.Padding(15);
            this.btnListado.Name = "btnListado";
            this.btnListado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListado.Size = new System.Drawing.Size(200, 36);
            this.btnListado.TabIndex = 2;
            this.btnListado.Text = "Listado de Ventas";
            this.btnListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.Enabled = false;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.Image = global::Vistas.Properties.Resources.venta;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 180);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(15);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 55);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pLogo.Controls.Add(this.lblRol);
            this.pLogo.Controls.Add(this.label2);
            this.pLogo.Controls.Add(this.label1);
            this.pLogo.Controls.Add(this.lblLogueado);
            this.pLogo.Controls.Add(this.iconMaximizar);
            this.pLogo.Controls.Add(this.iconRestaurar);
            this.pLogo.Controls.Add(this.iconMinimizar);
            this.pLogo.Controls.Add(this.iconCerrar);
            this.pLogo.Controls.Add(this.pictureBox2);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(200, 180);
            this.pLogo.TabIndex = 0;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(42, 132);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(64, 18);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rol: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "BIENVENIDO:";
            // 
            // lblLogueado
            // 
            this.lblLogueado.AutoSize = true;
            this.lblLogueado.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogueado.ForeColor = System.Drawing.Color.White;
            this.lblLogueado.Location = new System.Drawing.Point(6, 98);
            this.lblLogueado.Name = "lblLogueado";
            this.lblLogueado.Size = new System.Drawing.Size(64, 18);
            this.lblLogueado.TabIndex = 4;
            this.lblLogueado.Text = "Usuario";
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.Image = global::Vistas.Properties.Resources.maxi;
            this.iconMaximizar.Location = new System.Drawing.Point(111, 3);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMaximizar.TabIndex = 1;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Visible = false;
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestaurar.Image = global::Vistas.Properties.Resources.res;
            this.iconRestaurar.Location = new System.Drawing.Point(111, 3);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconRestaurar.TabIndex = 3;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Vistas.Properties.Resources.minimazar;
            this.iconMinimizar.Location = new System.Drawing.Point(142, 3);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMinimizar.TabIndex = 2;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = global::Vistas.Properties.Resources.cerrar;
            this.iconCerrar.Location = new System.Drawing.Point(168, 3);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(20, 20);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconCerrar.TabIndex = 0;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vistas.Properties.Resources.persona;
            this.pictureBox2.Location = new System.Drawing.Point(135, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pbarBtn
            // 
            this.pbarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.pbarBtn.Controls.Add(this.btnCerrar);
            this.pbarBtn.Controls.Add(this.lbHora);
            this.pbarBtn.Controls.Add(this.lbfecha);
            this.pbarBtn.Location = new System.Drawing.Point(0, 602);
            this.pbarBtn.Name = "pbarBtn";
            this.pbarBtn.Size = new System.Drawing.Size(950, 48);
            this.pbarBtn.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(833, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(95, 34);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Atras";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(29, 15);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(48, 18);
            this.lbHora.TabIndex = 3;
            this.lbHora.Text = "Hora";
            // 
            // fecha_t
            // 
            this.fecha_t.Enabled = true;
            this.fecha_t.Tick += new System.EventHandler(this.fecha_t_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pbarBtn);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.barTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.barTitulo.ResumeLayout(false);
            this.barTitulo.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pMenu.ResumeLayout(false);
            this.subMenu.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pbarBtn.ResumeLayout(false);
            this.pbarBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Panel subMenu;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pbarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogueado;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Timer fecha_t;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNuevoGestion;
        private System.Windows.Forms.Label lbHora;
        public System.Windows.Forms.Label lbTitulo;
        public System.Windows.Forms.Panel barTitulo;
        public System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label label2;
    }
}

