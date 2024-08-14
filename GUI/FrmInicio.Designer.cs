namespace GUI
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabFactura = new System.Windows.Forms.TabPage();
            this.tabClientes = new System.Windows.Forms.TabPage();
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
            this.tabTrabajador = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.buttonEliminarVehiculo = new System.Windows.Forms.Button();
            this.buttonModificarVehiculo = new System.Windows.Forms.Button();
            this.textBoxBusacarVehiculo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBuscarVehiculo = new System.Windows.Forms.Button();
            this.checkBoxBuscarPorPlaca = new System.Windows.Forms.CheckBox();
            this.checkBoxBuscarPorCedulaDueno = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxDistanciaMillas = new System.Windows.Forms.CheckBox();
            this.checkBoxDistanciaKilometros = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxDistanciaRecorrida = new System.Windows.Forms.TextBox();
            this.textBoxVINVehiculo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonCancelarVehiculo = new System.Windows.Forms.Button();
            this.buttonGuardarVehiculo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxModeloVehiculo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.buttonEliminarMarca = new System.Windows.Forms.Button();
            this.buttonModificarMarca = new System.Windows.Forms.Button();
            this.textBoxBuscarMarca = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonBuscarMarca = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonCancelarMarca = new System.Windows.Forms.Button();
            this.buttonGuardarMarca = new System.Windows.Forms.Button();
            this.textBoxNombreMarca = new System.Windows.Forms.TextBox();
            this.Tab.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabTrabajador.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabFactura);
            this.Tab.Controls.Add(this.tabClientes);
            this.Tab.Controls.Add(this.tabTrabajador);
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Location = new System.Drawing.Point(13, 13);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1021, 473);
            this.Tab.TabIndex = 0;
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
            // tabTrabajador
            // 
            this.tabTrabajador.Controls.Add(this.groupBox4);
            this.tabTrabajador.Controls.Add(this.groupBox3);
            this.tabTrabajador.Location = new System.Drawing.Point(4, 22);
            this.tabTrabajador.Name = "tabTrabajador";
            this.tabTrabajador.Size = new System.Drawing.Size(1013, 447);
            this.tabTrabajador.TabIndex = 2;
            this.tabTrabajador.Text = "Trabajador";
            this.tabTrabajador.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.groupBox4.Location = new System.Drawing.Point(25, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(969, 286);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.btnAceptar);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.txtCorreo);
            this.groupBox3.Controls.Add(this.txtCedula);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(25, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(969, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(705, 59);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(705, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(450, 59);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(209, 20);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(450, 25);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(209, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(132, 59);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(200, 20);
            this.txtCedula.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cedula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1013, 447);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Vehiculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1013, 447);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Marca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Controls.Add(this.dataGridViewVehiculo);
            this.groupBox5.Controls.Add(this.buttonEliminarVehiculo);
            this.groupBox5.Controls.Add(this.buttonModificarVehiculo);
            this.groupBox5.Controls.Add(this.textBoxBusacarVehiculo);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.buttonBuscarVehiculo);
            this.groupBox5.Controls.Add(this.checkBoxBuscarPorPlaca);
            this.groupBox5.Controls.Add(this.checkBoxBuscarPorCedulaDueno);
            this.groupBox5.Location = new System.Drawing.Point(22, 207);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(968, 228);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar";
            // 
            // dataGridViewVehiculo
            // 
            this.dataGridViewVehiculo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculo.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewVehiculo.Location = new System.Drawing.Point(22, 89);
            this.dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            this.dataGridViewVehiculo.Size = new System.Drawing.Size(929, 122);
            this.dataGridViewVehiculo.TabIndex = 8;
            // 
            // buttonEliminarVehiculo
            // 
            this.buttonEliminarVehiculo.Location = new System.Drawing.Point(723, 40);
            this.buttonEliminarVehiculo.Name = "buttonEliminarVehiculo";
            this.buttonEliminarVehiculo.Size = new System.Drawing.Size(67, 23);
            this.buttonEliminarVehiculo.TabIndex = 7;
            this.buttonEliminarVehiculo.Text = "Eliminar";
            this.buttonEliminarVehiculo.UseVisualStyleBackColor = true;
            // 
            // buttonModificarVehiculo
            // 
            this.buttonModificarVehiculo.Location = new System.Drawing.Point(606, 40);
            this.buttonModificarVehiculo.Name = "buttonModificarVehiculo";
            this.buttonModificarVehiculo.Size = new System.Drawing.Size(67, 23);
            this.buttonModificarVehiculo.TabIndex = 6;
            this.buttonModificarVehiculo.Text = "Modificar";
            this.buttonModificarVehiculo.UseVisualStyleBackColor = true;
            // 
            // textBoxBusacarVehiculo
            // 
            this.textBoxBusacarVehiculo.Location = new System.Drawing.Point(297, 22);
            this.textBoxBusacarVehiculo.Name = "textBoxBusacarVehiculo";
            this.textBoxBusacarVehiculo.Size = new System.Drawing.Size(188, 20);
            this.textBoxBusacarVehiculo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Buscar";
            // 
            // buttonBuscarVehiculo
            // 
            this.buttonBuscarVehiculo.Location = new System.Drawing.Point(480, 22);
            this.buttonBuscarVehiculo.Name = "buttonBuscarVehiculo";
            this.buttonBuscarVehiculo.Size = new System.Drawing.Size(67, 23);
            this.buttonBuscarVehiculo.TabIndex = 3;
            this.buttonBuscarVehiculo.Text = "Buscar";
            this.buttonBuscarVehiculo.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuscarPorPlaca
            // 
            this.checkBoxBuscarPorPlaca.AutoSize = true;
            this.checkBoxBuscarPorPlaca.Location = new System.Drawing.Point(98, 64);
            this.checkBoxBuscarPorPlaca.Name = "checkBoxBuscarPorPlaca";
            this.checkBoxBuscarPorPlaca.Size = new System.Drawing.Size(53, 17);
            this.checkBoxBuscarPorPlaca.TabIndex = 2;
            this.checkBoxBuscarPorPlaca.Text = "Placa";
            this.checkBoxBuscarPorPlaca.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuscarPorCedulaDueno
            // 
            this.checkBoxBuscarPorCedulaDueno.AutoSize = true;
            this.checkBoxBuscarPorCedulaDueno.Location = new System.Drawing.Point(98, 24);
            this.checkBoxBuscarPorCedulaDueno.Name = "checkBoxBuscarPorCedulaDueno";
            this.checkBoxBuscarPorCedulaDueno.Size = new System.Drawing.Size(109, 17);
            this.checkBoxBuscarPorCedulaDueno.TabIndex = 1;
            this.checkBoxBuscarPorCedulaDueno.Text = "Cedula del dueno";
            this.checkBoxBuscarPorCedulaDueno.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox6.Controls.Add(this.checkBoxDistanciaMillas);
            this.groupBox6.Controls.Add(this.checkBoxDistanciaKilometros);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.textBoxDistanciaRecorrida);
            this.groupBox6.Controls.Add(this.textBoxVINVehiculo);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBoxPlacaVehiculo);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.buttonCancelarVehiculo);
            this.groupBox6.Controls.Add(this.buttonGuardarVehiculo);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.textBoxModeloVehiculo);
            this.groupBox6.Location = new System.Drawing.Point(22, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(968, 156);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nuevo";
            // 
            // checkBoxDistanciaMillas
            // 
            this.checkBoxDistanciaMillas.AutoSize = true;
            this.checkBoxDistanciaMillas.Location = new System.Drawing.Point(110, 94);
            this.checkBoxDistanciaMillas.Name = "checkBoxDistanciaMillas";
            this.checkBoxDistanciaMillas.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDistanciaMillas.TabIndex = 10;
            this.checkBoxDistanciaMillas.Text = "Millas";
            this.checkBoxDistanciaMillas.UseVisualStyleBackColor = true;
            // 
            // checkBoxDistanciaKilometros
            // 
            this.checkBoxDistanciaKilometros.AutoSize = true;
            this.checkBoxDistanciaKilometros.Location = new System.Drawing.Point(110, 129);
            this.checkBoxDistanciaKilometros.Name = "checkBoxDistanciaKilometros";
            this.checkBoxDistanciaKilometros.Size = new System.Drawing.Size(74, 17);
            this.checkBoxDistanciaKilometros.TabIndex = 9;
            this.checkBoxDistanciaKilometros.Text = "Kilometros";
            this.checkBoxDistanciaKilometros.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(36, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Distancia en";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(274, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Distancia de recorrido";
            // 
            // textBoxDistanciaRecorrida
            // 
            this.textBoxDistanciaRecorrida.Location = new System.Drawing.Point(416, 102);
            this.textBoxDistanciaRecorrida.Name = "textBoxDistanciaRecorrida";
            this.textBoxDistanciaRecorrida.Size = new System.Drawing.Size(131, 20);
            this.textBoxDistanciaRecorrida.TabIndex = 21;
            // 
            // textBoxVINVehiculo
            // 
            this.textBoxVINVehiculo.Location = new System.Drawing.Point(684, 48);
            this.textBoxVINVehiculo.Name = "textBoxVINVehiculo";
            this.textBoxVINVehiculo.Size = new System.Drawing.Size(131, 20);
            this.textBoxVINVehiculo.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(623, 55);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "VIN";
            // 
            // textBoxPlacaVehiculo
            // 
            this.textBoxPlacaVehiculo.Location = new System.Drawing.Point(416, 38);
            this.textBoxPlacaVehiculo.Name = "textBoxPlacaVehiculo";
            this.textBoxPlacaVehiculo.Size = new System.Drawing.Size(131, 20);
            this.textBoxPlacaVehiculo.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(317, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Placa";
            // 
            // buttonCancelarVehiculo
            // 
            this.buttonCancelarVehiculo.Location = new System.Drawing.Point(761, 125);
            this.buttonCancelarVehiculo.Name = "buttonCancelarVehiculo";
            this.buttonCancelarVehiculo.Size = new System.Drawing.Size(67, 23);
            this.buttonCancelarVehiculo.TabIndex = 18;
            this.buttonCancelarVehiculo.Text = "Cancelar";
            this.buttonCancelarVehiculo.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarVehiculo
            // 
            this.buttonGuardarVehiculo.Location = new System.Drawing.Point(651, 125);
            this.buttonGuardarVehiculo.Name = "buttonGuardarVehiculo";
            this.buttonGuardarVehiculo.Size = new System.Drawing.Size(67, 23);
            this.buttonGuardarVehiculo.TabIndex = 17;
            this.buttonGuardarVehiculo.Text = "Guardar";
            this.buttonGuardarVehiculo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Modelo";
            // 
            // textBoxModeloVehiculo
            // 
            this.textBoxModeloVehiculo.Location = new System.Drawing.Point(110, 35);
            this.textBoxModeloVehiculo.Name = "textBoxModeloVehiculo";
            this.textBoxModeloVehiculo.Size = new System.Drawing.Size(131, 20);
            this.textBoxModeloVehiculo.TabIndex = 12;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox7.Controls.Add(this.dataGridViewMarca);
            this.groupBox7.Controls.Add(this.buttonEliminarMarca);
            this.groupBox7.Controls.Add(this.buttonModificarMarca);
            this.groupBox7.Controls.Add(this.textBoxBuscarMarca);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.buttonBuscarMarca);
            this.groupBox7.Location = new System.Drawing.Point(22, 140);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(968, 294);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Buscar";
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewMarca.Location = new System.Drawing.Point(22, 89);
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.Size = new System.Drawing.Size(919, 193);
            this.dataGridViewMarca.TabIndex = 8;
            // 
            // buttonEliminarMarca
            // 
            this.buttonEliminarMarca.Location = new System.Drawing.Point(278, 47);
            this.buttonEliminarMarca.Name = "buttonEliminarMarca";
            this.buttonEliminarMarca.Size = new System.Drawing.Size(67, 23);
            this.buttonEliminarMarca.TabIndex = 7;
            this.buttonEliminarMarca.Text = "Eliminar";
            this.buttonEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // buttonModificarMarca
            // 
            this.buttonModificarMarca.Location = new System.Drawing.Point(202, 47);
            this.buttonModificarMarca.Name = "buttonModificarMarca";
            this.buttonModificarMarca.Size = new System.Drawing.Size(67, 23);
            this.buttonModificarMarca.TabIndex = 6;
            this.buttonModificarMarca.Text = "Modificar";
            this.buttonModificarMarca.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarMarca
            // 
            this.textBoxBuscarMarca.Location = new System.Drawing.Point(268, 19);
            this.textBoxBuscarMarca.Name = "textBoxBuscarMarca";
            this.textBoxBuscarMarca.Size = new System.Drawing.Size(188, 20);
            this.textBoxBuscarMarca.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(157, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Buscar por nombre";
            // 
            // buttonBuscarMarca
            // 
            this.buttonBuscarMarca.Location = new System.Drawing.Point(472, 19);
            this.buttonBuscarMarca.Name = "buttonBuscarMarca";
            this.buttonBuscarMarca.Size = new System.Drawing.Size(67, 23);
            this.buttonBuscarMarca.TabIndex = 3;
            this.buttonBuscarMarca.Text = "Buscar";
            this.buttonBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.buttonCancelarMarca);
            this.groupBox8.Controls.Add(this.buttonGuardarMarca);
            this.groupBox8.Controls.Add(this.textBoxNombreMarca);
            this.groupBox8.Location = new System.Drawing.Point(22, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(968, 106);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nueva marca";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(139, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Nombre";
            // 
            // buttonCancelarMarca
            // 
            this.buttonCancelarMarca.Location = new System.Drawing.Point(472, 19);
            this.buttonCancelarMarca.Name = "buttonCancelarMarca";
            this.buttonCancelarMarca.Size = new System.Drawing.Size(67, 23);
            this.buttonCancelarMarca.TabIndex = 18;
            this.buttonCancelarMarca.Text = "Cancelar";
            this.buttonCancelarMarca.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarMarca
            // 
            this.buttonGuardarMarca.Location = new System.Drawing.Point(472, 66);
            this.buttonGuardarMarca.Name = "buttonGuardarMarca";
            this.buttonGuardarMarca.Size = new System.Drawing.Size(67, 23);
            this.buttonGuardarMarca.TabIndex = 17;
            this.buttonGuardarMarca.Text = "Guardar";
            this.buttonGuardarMarca.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreMarca
            // 
            this.textBoxNombreMarca.Location = new System.Drawing.Point(220, 24);
            this.textBoxNombreMarca.Name = "textBoxNombreMarca";
            this.textBoxNombreMarca.Size = new System.Drawing.Size(188, 20);
            this.textBoxNombreMarca.TabIndex = 9;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 491);
            this.Controls.Add(this.Tab);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.Tab.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTrabajador.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewVehiculo;
        private System.Windows.Forms.Button buttonEliminarVehiculo;
        private System.Windows.Forms.Button buttonModificarVehiculo;
        private System.Windows.Forms.TextBox textBoxBusacarVehiculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonBuscarVehiculo;
        private System.Windows.Forms.CheckBox checkBoxBuscarPorPlaca;
        private System.Windows.Forms.CheckBox checkBoxBuscarPorCedulaDueno;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxDistanciaMillas;
        private System.Windows.Forms.CheckBox checkBoxDistanciaKilometros;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxDistanciaRecorrida;
        private System.Windows.Forms.TextBox textBoxVINVehiculo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxPlacaVehiculo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonCancelarVehiculo;
        private System.Windows.Forms.Button buttonGuardarVehiculo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxModeloVehiculo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridViewMarca;
        private System.Windows.Forms.Button buttonEliminarMarca;
        private System.Windows.Forms.Button buttonModificarMarca;
        private System.Windows.Forms.TextBox textBoxBuscarMarca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonBuscarMarca;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonCancelarMarca;
        private System.Windows.Forms.Button buttonGuardarMarca;
        private System.Windows.Forms.TextBox textBoxNombreMarca;
    }
}