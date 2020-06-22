namespace Vistas
{
    partial class FrmTipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelarT = new System.Windows.Forms.Button();
            this.btnNuevoTipo = new System.Windows.Forms.Button();
            this.btnEditGT = new System.Windows.Forms.Button();
            this.txtTipoClase = new System.Windows.Forms.TextBox();
            this.txtTipoID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditTipo = new System.Windows.Forms.Button();
            this.btnEliminarTipo = new System.Windows.Forms.Button();
            this.tblTipoVeh = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoVeh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnEditTipo);
            this.groupBox1.Controls.Add(this.btnEliminarTipo);
            this.groupBox1.Controls.Add(this.tblTipoVeh);
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 274);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(696, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCancelarT);
            this.groupBox2.Controls.Add(this.btnNuevoTipo);
            this.groupBox2.Controls.Add(this.btnEditGT);
            this.groupBox2.Controls.Add(this.txtTipoClase);
            this.groupBox2.Controls.Add(this.txtTipoID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(426, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 205);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(84, -6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de Vehiculo";
            // 
            // btnCancelarT
            // 
            this.btnCancelarT.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelarT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarT.Location = new System.Drawing.Point(173, 159);
            this.btnCancelarT.Name = "btnCancelarT";
            this.btnCancelarT.Size = new System.Drawing.Size(91, 29);
            this.btnCancelarT.TabIndex = 13;
            this.btnCancelarT.Text = "Cancelar";
            this.btnCancelarT.UseVisualStyleBackColor = false;
            this.btnCancelarT.Visible = false;
            this.btnCancelarT.Click += new System.EventHandler(this.btnCancelarT_Click);
            // 
            // btnNuevoTipo
            // 
            this.btnNuevoTipo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTipo.Location = new System.Drawing.Point(121, 158);
            this.btnNuevoTipo.Name = "btnNuevoTipo";
            this.btnNuevoTipo.Size = new System.Drawing.Size(91, 29);
            this.btnNuevoTipo.TabIndex = 6;
            this.btnNuevoTipo.Text = "Agregar";
            this.btnNuevoTipo.UseVisualStyleBackColor = false;
            this.btnNuevoTipo.Click += new System.EventHandler(this.btnNuevoTipo_Click_1);
            // 
            // btnEditGT
            // 
            this.btnEditGT.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditGT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGT.Location = new System.Drawing.Point(69, 159);
            this.btnEditGT.Name = "btnEditGT";
            this.btnEditGT.Size = new System.Drawing.Size(91, 29);
            this.btnEditGT.TabIndex = 12;
            this.btnEditGT.Text = "Guardar";
            this.btnEditGT.UseVisualStyleBackColor = false;
            this.btnEditGT.Visible = false;
            this.btnEditGT.Click += new System.EventHandler(this.btnEditGT_Click_1);
            // 
            // txtTipoClase
            // 
            this.txtTipoClase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoClase.Location = new System.Drawing.Point(121, 89);
            this.txtTipoClase.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoClase.Name = "txtTipoClase";
            this.txtTipoClase.Size = new System.Drawing.Size(194, 27);
            this.txtTipoClase.TabIndex = 5;
            this.txtTipoClase.TextChanged += new System.EventHandler(this.txtTipoClase_TextChanged);
            // 
            // txtTipoID
            // 
            this.txtTipoID.Enabled = false;
            this.txtTipoID.Location = new System.Drawing.Point(109, 47);
            this.txtTipoID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoID.Name = "txtTipoID";
            this.txtTipoID.Size = new System.Drawing.Size(70, 20);
            this.txtTipoID.TabIndex = 3;
            this.txtTipoID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // btnEditTipo
            // 
            this.btnEditTipo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTipo.Location = new System.Drawing.Point(301, 172);
            this.btnEditTipo.Name = "btnEditTipo";
            this.btnEditTipo.Size = new System.Drawing.Size(75, 30);
            this.btnEditTipo.TabIndex = 15;
            this.btnEditTipo.Text = "Editar";
            this.btnEditTipo.UseVisualStyleBackColor = false;
            this.btnEditTipo.Click += new System.EventHandler(this.btnEditTipo_Click_1);
            // 
            // btnEliminarTipo
            // 
            this.btnEliminarTipo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipo.Location = new System.Drawing.Point(301, 100);
            this.btnEliminarTipo.Name = "btnEliminarTipo";
            this.btnEliminarTipo.Size = new System.Drawing.Size(75, 30);
            this.btnEliminarTipo.TabIndex = 14;
            this.btnEliminarTipo.Text = "Eliminar";
            this.btnEliminarTipo.UseVisualStyleBackColor = false;
            this.btnEliminarTipo.Click += new System.EventHandler(this.btnEliminarTipo_Click_1);
            // 
            // tblTipoVeh
            // 
            this.tblTipoVeh.AllowUserToAddRows = false;
            this.tblTipoVeh.AllowUserToDeleteRows = false;
            this.tblTipoVeh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tblTipoVeh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.tblTipoVeh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblTipoVeh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTipoVeh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblTipoVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTipoVeh.Location = new System.Drawing.Point(17, 34);
            this.tblTipoVeh.Name = "tblTipoVeh";
            this.tblTipoVeh.ReadOnly = true;
            this.tblTipoVeh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTipoVeh.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tblTipoVeh.Size = new System.Drawing.Size(254, 205);
            this.tblTipoVeh.TabIndex = 17;
            // 
            // FrmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(815, 306);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Tipo";
            this.Load += new System.EventHandler(this.FrmTipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoVeh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarT;
        private System.Windows.Forms.Button btnNuevoTipo;
        private System.Windows.Forms.Button btnEditGT;
        private System.Windows.Forms.TextBox txtTipoClase;
        private System.Windows.Forms.TextBox txtTipoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditTipo;
        private System.Windows.Forms.Button btnEliminarTipo;
        private System.Windows.Forms.DataGridView tblTipoVeh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}