namespace Vistas
{
    partial class FrmClase
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditClase = new System.Windows.Forms.Button();
            this.btnEliminarClase = new System.Windows.Forms.Button();
            this.tblClaseVeh = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnEditarG = new System.Windows.Forms.Button();
            this.btnNuevoClase = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaseDesc = new System.Windows.Forms.TextBox();
            this.txtClaseID = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblClaseVeh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnEditClase);
            this.groupBox3.Controls.Add(this.btnEliminarClase);
            this.groupBox3.Controls.Add(this.tblClaseVeh);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(18, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 277);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(698, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEditClase
            // 
            this.btnEditClase.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClase.Location = new System.Drawing.Point(318, 145);
            this.btnEditClase.Name = "btnEditClase";
            this.btnEditClase.Size = new System.Drawing.Size(75, 29);
            this.btnEditClase.TabIndex = 14;
            this.btnEditClase.Text = "Editar";
            this.btnEditClase.UseVisualStyleBackColor = false;
            this.btnEditClase.Click += new System.EventHandler(this.btnEditClase_Click_1);
            // 
            // btnEliminarClase
            // 
            this.btnEliminarClase.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEliminarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClase.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClase.Location = new System.Drawing.Point(318, 87);
            this.btnEliminarClase.Name = "btnEliminarClase";
            this.btnEliminarClase.Size = new System.Drawing.Size(75, 29);
            this.btnEliminarClase.TabIndex = 13;
            this.btnEliminarClase.Text = "Eliminar";
            this.btnEliminarClase.UseVisualStyleBackColor = false;
            this.btnEliminarClase.Click += new System.EventHandler(this.btnEliminarClase_Click_1);
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
            this.tblClaseVeh.Location = new System.Drawing.Point(34, 55);
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
            this.tblClaseVeh.Size = new System.Drawing.Size(269, 186);
            this.tblClaseVeh.TabIndex = 16;
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
            this.groupBox2.Location = new System.Drawing.Point(417, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 206);
            this.groupBox2.TabIndex = 15;
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
            this.btnCancelarC.Click += new System.EventHandler(this.btnCancelarC_Click);
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
            this.btnEditarG.Click += new System.EventHandler(this.btnEditarG_Click_1);
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
            this.btnNuevoClase.Click += new System.EventHandler(this.btnNuevoClase_Click_1);
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
            // txtClaseDesc
            // 
            this.txtClaseDesc.Location = new System.Drawing.Point(116, 110);
            this.txtClaseDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaseDesc.Name = "txtClaseDesc";
            this.txtClaseDesc.Size = new System.Drawing.Size(194, 23);
            this.txtClaseDesc.TabIndex = 1;
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
            // FrmClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(815, 306);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIONES";
            this.Load += new System.EventHandler(this.FrmGestion_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblClaseVeh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditClase;
        private System.Windows.Forms.Button btnEliminarClase;
        private System.Windows.Forms.DataGridView tblClaseVeh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnEditarG;
        private System.Windows.Forms.Button btnNuevoClase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaseDesc;
        private System.Windows.Forms.TextBox txtClaseID;
        private System.Windows.Forms.Button button1;
    }
}