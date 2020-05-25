namespace Vistas
{
    partial class FrmAltaCliente
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.tbx_telefono = new System.Windows.Forms.TextBox();
            this.tbx_direccion = new System.Windows.Forms.TextBox();
            this.tbx_apellido = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.tbx_dni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.Location = new System.Drawing.Point(233, 228);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 23;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aceptar.Location = new System.Drawing.Point(125, 228);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 22;
            this.btn_aceptar.Text = "Agregar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // tbx_telefono
            // 
            this.tbx_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_telefono.Location = new System.Drawing.Point(219, 176);
            this.tbx_telefono.Name = "tbx_telefono";
            this.tbx_telefono.Size = new System.Drawing.Size(100, 20);
            this.tbx_telefono.TabIndex = 21;
            // 
            // tbx_direccion
            // 
            this.tbx_direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_direccion.Location = new System.Drawing.Point(219, 133);
            this.tbx_direccion.Name = "tbx_direccion";
            this.tbx_direccion.Size = new System.Drawing.Size(100, 20);
            this.tbx_direccion.TabIndex = 20;
            // 
            // tbx_apellido
            // 
            this.tbx_apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_apellido.Location = new System.Drawing.Point(219, 93);
            this.tbx_apellido.Name = "tbx_apellido";
            this.tbx_apellido.Size = new System.Drawing.Size(100, 20);
            this.tbx_apellido.TabIndex = 19;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_nombre.Location = new System.Drawing.Point(219, 54);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(100, 20);
            this.tbx_nombre.TabIndex = 18;
            // 
            // tbx_dni
            // 
            this.tbx_dni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_dni.Location = new System.Drawing.Point(219, 21);
            this.tbx_dni.Name = "tbx_dni";
            this.tbx_dni.Size = new System.Drawing.Size(100, 20);
            this.tbx_dni.TabIndex = 17;
            this.tbx_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_dni_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "DNI:";
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 272);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.tbx_telefono);
            this.Controls.Add(this.tbx_direccion);
            this.Controls.Add(this.tbx_apellido);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.tbx_dni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox tbx_telefono;
        private System.Windows.Forms.TextBox tbx_direccion;
        private System.Windows.Forms.TextBox tbx_apellido;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.TextBox tbx_dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}