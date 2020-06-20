namespace Vistas
{
    partial class FrmGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoID = new System.Windows.Forms.TextBox();
            this.txtTipoClase = new System.Windows.Forms.TextBox();
            this.txtClaseID = new System.Windows.Forms.TextBox();
            this.txtClaseDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarT = new System.Windows.Forms.Button();
            this.btnNuevoTipo = new System.Windows.Forms.Button();
            this.btnEditGT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnEditarG = new System.Windows.Forms.Button();
            this.btnNuevoClase = new System.Windows.Forms.Button();
            this.tblClaseVeh = new System.Windows.Forms.DataGridView();
            this.tblTipoVeh = new System.Windows.Forms.DataGridView();
            this.btnEliminarClase = new System.Windows.Forms.Button();
            this.btnEditClase = new System.Windows.Forms.Button();
            this.btnEliminarTipo = new System.Windows.Forms.Button();
            this.btnEditTipo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClaseVeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoVeh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // txtTipoID
            // 
            this.txtTipoID.Enabled = false;
            this.txtTipoID.Location = new System.Drawing.Point(113, 66);
            this.txtTipoID.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoID.Name = "txtTipoID";
            this.txtTipoID.Size = new System.Drawing.Size(70, 23);
            this.txtTipoID.TabIndex = 3;
            // 
            // txtTipoClase
            // 
            this.txtTipoClase.Location = new System.Drawing.Point(113, 121);
            this.txtTipoClase.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoClase.Name = "txtTipoClase";
            this.txtTipoClase.Size = new System.Drawing.Size(194, 23);
            this.txtTipoClase.TabIndex = 5;
            // 
            // txtClaseID
            // 
            this.txtClaseID.Enabled = false;
            this.txtClaseID.Location = new System.Drawing.Point(116, 58);
            this.txtClaseID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaseID.Name = "txtClaseID";
            this.txtClaseID.Size = new System.Drawing.Size(70, 23);
            this.txtClaseID.TabIndex = 1;
            // 
            // txtClaseDesc
            // 
            this.txtClaseDesc.Location = new System.Drawing.Point(116, 110);
            this.txtClaseDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaseDesc.Name = "txtClaseDesc";
            this.txtClaseDesc.Size = new System.Drawing.Size(194, 23);
            this.txtClaseDesc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Vehiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Clases de Vehiculo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancelarT);
            this.groupBox1.Controls.Add(this.btnNuevoTipo);
            this.groupBox1.Controls.Add(this.btnEditGT);
            this.groupBox1.Controls.Add(this.txtTipoClase);
            this.groupBox1.Controls.Add(this.txtTipoID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(517, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 211);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelarT
            // 
            this.btnCancelarT.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelarT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarT.Location = new System.Drawing.Point(182, 164);
            this.btnCancelarT.Name = "btnCancelarT";
            this.btnCancelarT.Size = new System.Drawing.Size(83, 29);
            this.btnCancelarT.TabIndex = 13;
            this.btnCancelarT.Text = "Cancelar";
            this.btnCancelarT.UseVisualStyleBackColor = false;
            this.btnCancelarT.Visible = false;
            this.btnCancelarT.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevoTipo
            // 
            this.btnNuevoTipo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTipo.Location = new System.Drawing.Point(125, 162);
            this.btnNuevoTipo.Name = "btnNuevoTipo";
            this.btnNuevoTipo.Size = new System.Drawing.Size(83, 33);
            this.btnNuevoTipo.TabIndex = 6;
            this.btnNuevoTipo.Text = "Guardar";
            this.btnNuevoTipo.UseVisualStyleBackColor = false;
            this.btnNuevoTipo.Click += new System.EventHandler(this.btnNuevoTipo_Click);
            // 
            // btnEditGT
            // 
            this.btnEditGT.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditGT.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGT.Location = new System.Drawing.Point(78, 164);
            this.btnEditGT.Name = "btnEditGT";
            this.btnEditGT.Size = new System.Drawing.Size(83, 29);
            this.btnEditGT.TabIndex = 12;
            this.btnEditGT.Text = "Guardar";
            this.btnEditGT.UseVisualStyleBackColor = false;
            this.btnEditGT.Visible = false;
            this.btnEditGT.Click += new System.EventHandler(this.btnEditGT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnCancelarC);
            this.groupBox2.Controls.Add(this.btnEditarG);
            this.groupBox2.Controls.Add(this.btnNuevoClase);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtClaseDesc);
            this.groupBox2.Controls.Add(this.txtClaseID);
            this.groupBox2.Location = new System.Drawing.Point(517, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 199);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelarC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarC.Location = new System.Drawing.Point(178, 155);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(83, 29);
            this.btnCancelarC.TabIndex = 11;
            this.btnCancelarC.Text = "Cancelar";
            this.btnCancelarC.UseVisualStyleBackColor = false;
            this.btnCancelarC.Visible = false;
            this.btnCancelarC.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarG
            // 
            this.btnEditarG.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditarG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarG.Location = new System.Drawing.Point(74, 155);
            this.btnEditarG.Name = "btnEditarG";
            this.btnEditarG.Size = new System.Drawing.Size(83, 29);
            this.btnEditarG.TabIndex = 10;
            this.btnEditarG.Text = "Guardar";
            this.btnEditarG.UseVisualStyleBackColor = false;
            this.btnEditarG.Visible = false;
            this.btnEditarG.Click += new System.EventHandler(this.btnEditarG_Click);
            // 
            // btnNuevoClase
            // 
            this.btnNuevoClase.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoClase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoClase.Location = new System.Drawing.Point(126, 155);
            this.btnNuevoClase.Name = "btnNuevoClase";
            this.btnNuevoClase.Size = new System.Drawing.Size(83, 29);
            this.btnNuevoClase.TabIndex = 2;
            this.btnNuevoClase.Text = "Guardar";
            this.btnNuevoClase.UseVisualStyleBackColor = false;
            this.btnNuevoClase.Click += new System.EventHandler(this.btnNuevoClase_Click);
            // 
            // tblClaseVeh
            // 
            this.tblClaseVeh.AllowUserToAddRows = false;
            this.tblClaseVeh.AllowUserToDeleteRows = false;
            this.tblClaseVeh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tblClaseVeh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.tblClaseVeh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblClaseVeh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblClaseVeh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tblClaseVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClaseVeh.Location = new System.Drawing.Point(59, 41);
            this.tblClaseVeh.Name = "tblClaseVeh";
            this.tblClaseVeh.ReadOnly = true;
            this.tblClaseVeh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblClaseVeh.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tblClaseVeh.Size = new System.Drawing.Size(269, 179);
            this.tblClaseVeh.TabIndex = 12;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTipoVeh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tblTipoVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTipoVeh.Location = new System.Drawing.Point(59, 283);
            this.tblTipoVeh.Name = "tblTipoVeh";
            this.tblTipoVeh.ReadOnly = true;
            this.tblTipoVeh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTipoVeh.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.tblTipoVeh.Size = new System.Drawing.Size(269, 197);
            this.tblTipoVeh.TabIndex = 13;
            // 
            // btnEliminarClase
            // 
            this.btnEliminarClase.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClase.Location = new System.Drawing.Point(379, 73);
            this.btnEliminarClase.Name = "btnEliminarClase";
            this.btnEliminarClase.Size = new System.Drawing.Size(75, 29);
            this.btnEliminarClase.TabIndex = 3;
            this.btnEliminarClase.Text = "Eliminar";
            this.btnEliminarClase.UseVisualStyleBackColor = false;
            this.btnEliminarClase.Click += new System.EventHandler(this.btnEliminarClase_Click);
            // 
            // btnEditClase
            // 
            this.btnEditClase.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClase.Location = new System.Drawing.Point(379, 134);
            this.btnEditClase.Name = "btnEditClase";
            this.btnEditClase.Size = new System.Drawing.Size(75, 29);
            this.btnEditClase.TabIndex = 4;
            this.btnEditClase.Text = "Editar";
            this.btnEditClase.UseVisualStyleBackColor = false;
            this.btnEditClase.Click += new System.EventHandler(this.btnEditClase_Click);
            // 
            // btnEliminarTipo
            // 
            this.btnEliminarTipo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipo.Location = new System.Drawing.Point(379, 335);
            this.btnEliminarTipo.Name = "btnEliminarTipo";
            this.btnEliminarTipo.Size = new System.Drawing.Size(75, 30);
            this.btnEliminarTipo.TabIndex = 7;
            this.btnEliminarTipo.Text = "Eliminar";
            this.btnEliminarTipo.UseVisualStyleBackColor = false;
            this.btnEliminarTipo.Click += new System.EventHandler(this.btnEliminarTipo_Click);
            // 
            // btnEditTipo
            // 
            this.btnEditTipo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTipo.Location = new System.Drawing.Point(379, 406);
            this.btnEditTipo.Name = "btnEditTipo";
            this.btnEditTipo.Size = new System.Drawing.Size(75, 30);
            this.btnEditTipo.TabIndex = 8;
            this.btnEditTipo.Text = "Editar";
            this.btnEditTipo.UseVisualStyleBackColor = false;
            this.btnEditTipo.Click += new System.EventHandler(this.btnEditTipo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditTipo);
            this.groupBox3.Controls.Add(this.btnEliminarTipo);
            this.groupBox3.Controls.Add(this.btnEditClase);
            this.groupBox3.Controls.Add(this.btnEliminarClase);
            this.groupBox3.Controls.Add(this.tblTipoVeh);
            this.groupBox3.Controls.Add(this.tblClaseVeh);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(15, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(871, 506);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(934, 549);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIONES";
            this.Load += new System.EventHandler(this.FrmGestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClaseVeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoVeh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoID;
        private System.Windows.Forms.TextBox txtTipoClase;
        private System.Windows.Forms.TextBox txtClaseID;
        private System.Windows.Forms.TextBox txtClaseDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblClaseVeh;
        private System.Windows.Forms.DataGridView tblTipoVeh;
        private System.Windows.Forms.Button btnNuevoTipo;
        private System.Windows.Forms.Button btnNuevoClase;
        private System.Windows.Forms.Button btnEliminarClase;
        private System.Windows.Forms.Button btnEditClase;
        private System.Windows.Forms.Button btnEliminarTipo;
        private System.Windows.Forms.Button btnEditTipo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditarG;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnCancelarT;
        private System.Windows.Forms.Button btnEditGT;
    }
}