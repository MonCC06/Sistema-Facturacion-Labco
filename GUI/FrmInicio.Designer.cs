﻿namespace GUI
{
    partial class FrmInicio
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFactura = new System.Windows.Forms.TabPage();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.tabTrabajador = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnModificar1 = new System.Windows.Forms.Button();
            this.txtBuscar1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLupa1 = new System.Windows.Forms.Button();
            this.chkCedula1 = new System.Windows.Forms.CheckBox();
            this.chkNombre1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.txtCorreo1 = new System.Windows.Forms.TextBox();
            this.txtCedula1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFactura);
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabTrabajador);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFactura
            // 
            this.tabFactura.Location = new System.Drawing.Point(4, 22);
            this.tabFactura.Name = "tabFactura";
            this.tabFactura.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactura.Size = new System.Drawing.Size(1013, 447);
            this.tabFactura.TabIndex = 0;
            this.tabFactura.Text = "Factura";
            this.tabFactura.UseVisualStyleBackColor = true;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.groupBox2);
            this.tabClientes.Controls.Add(this.groupBox1);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(1013, 447);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // tabTrabajador
            // 
            this.tabTrabajador.Location = new System.Drawing.Point(4, 22);
            this.tabTrabajador.Name = "tabTrabajador";
            this.tabTrabajador.Size = new System.Drawing.Size(1013, 447);
            this.tabTrabajador.TabIndex = 2;
            this.tabTrabajador.Text = "Trabajador";
            this.tabTrabajador.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnEliminar1);
            this.groupBox2.Controls.Add(this.btnModificar1);
            this.groupBox2.Controls.Add(this.txtBuscar1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnLupa1);
            this.groupBox2.Controls.Add(this.chkCedula1);
            this.groupBox2.Controls.Add(this.chkNombre1);
            this.groupBox2.Location = new System.Drawing.Point(25, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 294);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(22, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 193);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Location = new System.Drawing.Point(278, 47);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(67, 23);
            this.btnEliminar1.TabIndex = 7;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            // 
            // btnModificar1
            // 
            this.btnModificar1.Location = new System.Drawing.Point(202, 47);
            this.btnModificar1.Name = "btnModificar1";
            this.btnModificar1.Size = new System.Drawing.Size(67, 23);
            this.btnModificar1.TabIndex = 6;
            this.btnModificar1.Text = "Modificar";
            this.btnModificar1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar1
            // 
            this.txtBuscar1.Location = new System.Drawing.Point(268, 19);
            this.txtBuscar1.Name = "txtBuscar1";
            this.txtBuscar1.Size = new System.Drawing.Size(188, 20);
            this.txtBuscar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // btnLupa1
            // 
            this.btnLupa1.Location = new System.Drawing.Point(472, 19);
            this.btnLupa1.Name = "btnLupa1";
            this.btnLupa1.Size = new System.Drawing.Size(67, 23);
            this.btnLupa1.TabIndex = 3;
            this.btnLupa1.Text = "Buscar";
            this.btnLupa1.UseVisualStyleBackColor = true;
            // 
            // chkCedula1
            // 
            this.chkCedula1.AutoSize = true;
            this.chkCedula1.Location = new System.Drawing.Point(75, 53);
            this.chkCedula1.Name = "chkCedula1";
            this.chkCedula1.Size = new System.Drawing.Size(59, 17);
            this.chkCedula1.TabIndex = 2;
            this.chkCedula1.Text = "Cedula";
            this.chkCedula1.UseVisualStyleBackColor = true;
            // 
            // chkNombre1
            // 
            this.chkNombre1.AutoSize = true;
            this.chkNombre1.Location = new System.Drawing.Point(75, 23);
            this.chkNombre1.Name = "chkNombre1";
            this.chkNombre1.Size = new System.Drawing.Size(63, 17);
            this.chkNombre1.TabIndex = 1;
            this.chkNombre1.Text = "Nombre";
            this.chkNombre1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancelar1);
            this.groupBox1.Controls.Add(this.btnGuardar1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefono1);
            this.groupBox1.Controls.Add(this.txtCorreo1);
            this.groupBox1.Controls.Add(this.txtCedula1);
            this.groupBox1.Controls.Add(this.txtNombre1);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 106);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Location = new System.Drawing.Point(713, 18);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(67, 23);
            this.btnCancelar1.TabIndex = 18;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(713, 57);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(67, 23);
            this.btnGuardar1.TabIndex = 17;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(397, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Correo";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(487, 59);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(188, 20);
            this.txtTelefono1.TabIndex = 12;
            // 
            // txtCorreo1
            // 
            this.txtCorreo1.Location = new System.Drawing.Point(487, 20);
            this.txtCorreo1.Name = "txtCorreo1";
            this.txtCorreo1.Size = new System.Drawing.Size(188, 20);
            this.txtCorreo1.TabIndex = 11;
            // 
            // txtCedula1
            // 
            this.txtCedula1.Location = new System.Drawing.Point(155, 59);
            this.txtCedula1.Name = "txtCedula1";
            this.txtCedula1.Size = new System.Drawing.Size(188, 20);
            this.txtCedula1.TabIndex = 10;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(155, 20);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(188, 20);
            this.txtNombre1.TabIndex = 9;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 491);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.tabControl1.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFactura;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabTrabajador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnModificar1;
        private System.Windows.Forms.TextBox txtBuscar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLupa1;
        private System.Windows.Forms.CheckBox chkCedula1;
        private System.Windows.Forms.CheckBox chkNombre1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.TextBox txtCorreo1;
        private System.Windows.Forms.TextBox txtCedula1;
        private System.Windows.Forms.TextBox txtNombre1;
    }
}