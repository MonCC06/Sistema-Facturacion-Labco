using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using ET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        #region Variables Globales
        int EstadoGuarda = 0;
        int IDDetalle = 0;
        int IDCliente = 0;
        int IDTrabajador = 0;
        int IDFactura = 0;
        int IDVehiculo = 0;
        int IDProducto = 0;
        int IDMarca = 0;

        int IDServicio = 0;




        #endregion

        #region Metodo vehiculo
        private void FormatoVe()
        {
            dataGridViewVehiculo.Columns[0].Width = 100;
            dataGridViewVehiculo.Columns[0].HeaderText = "ID Vehiculo";
            dataGridViewVehiculo.Columns[1].Width = 100;
            dataGridViewVehiculo.Columns[1].HeaderText = "Vehiculo";

        }



        private void ListadoVe(string cTexto)
        {

            try
            {
                dataGridViewVehiculo.DataSource = BLVehiculo.ListadoVE(cTexto);
                this.FormatoVe();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }


        private void SeleccionaItem()
        {
            //Validasmos que el DATAGEIP tenga datos para que no nos de error

            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewVehiculo.CurrentRow.Cells["IDVehiculo"].Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.IDVehiculo = Convert.ToInt32(dataGridViewVehiculo.CurrentRow.Cells["IDVehiculo"].Value);
                TxTPlacaVehiculo.Text = Convert.ToString(dataGridViewVehiculo.CurrentRow.Cells["Placa"].Value);

            }

        }


        #endregion

        #region Metodo Marca

        private void FormatoMa()
        {
            dataGridViewMarca.Columns[0].Width = 100;
            dataGridViewMarca.Columns[0].HeaderText = "ID Marca";
            dataGridViewMarca.Columns[1].Width = 100;
            dataGridViewMarca.Columns[1].HeaderText = "Marca";

        }

        private void ListadoMarca(string cTexto)
        {

            try
            {
                dataGridViewMarca.DataSource = BLMarca.ListadoMA(cTexto);
                this.FormatoMa();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }



        }

        private void SeleccionaItemMarca()
        {
            //Validasmos que el DATAGEIP tenga datos para que no nos de error

            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewVehiculo.CurrentRow.Cells["IDMarca"].Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                this.IDMarca = Convert.ToInt32(dataGridViewVehiculo.CurrentRow.Cells["IDMarca"].Value);
                TxTNombreMarca.Text = Convert.ToString(dataGridViewVehiculo.CurrentRow.Cells["Nombre"].Value);

            }

        }



        private void GuardarMarca()
        {

            if (TxTNombreMarca.Text == String.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {

                ETMarca etmarca = new ETMarca();
                string Rpta = "";
                etmarca.IDMarca = this.IDMarca;
                etmarca.Nombre = TxTNombreMarca.Text.Trim();
                Rpta = BLMarca.GuardarMA(EstadoGuarda, etmarca);


                if (Rpta == "OK")
                {
                    this.ListadoVe("%");
                    MessageBox.Show("Los datos se han registrado", "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    EstadoGuarda = 0; // si no guardo nada
                    TxTNombreMarca.Text = "";
                    TxTNombreMarca.ReadOnly = true;
                    this.IDMarca = 0;

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

                }

            }



        }



        #endregion

        #region Metodos Cliente
        private void FormatoCL()
        {
            DgvCliente.Columns[0].Width = 100;
            DgvCliente.Columns[0].HeaderText = "ID_Cliente";
            DgvCliente.Columns[1].Width = 100;
            DgvCliente.Columns[1].HeaderText = "Nombre";
            DgvCliente.Columns[2].Width = 100;
            DgvCliente.Columns[2].HeaderText = "Cedula";
            DgvCliente.Columns[3].Width = 100;
            DgvCliente.Columns[3].HeaderText = "Telefono";
            DgvCliente.Columns[4].Width = 100;
            DgvCliente.Columns[4].HeaderText = "Correo";
            DgvCliente.Columns[5].Width = 100;
            DgvCliente.Columns[5].HeaderText = "Estado";
        }

        private void ListadoCL(string tTexto)
        {
            try
            {
                DgvCliente.DataSource = BLCliente.ListadoCL(tTexto);
                this.FormatoCL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            //datasource nos dice de donde vamos a consumir los datos
        }

        private void BotonesCliente(bool LEstado)
        {
            this.btnGuardarNuevoCliente.Enabled = LEstado;
            this.btnBuscarCliente.Enabled = LEstado;
            this.btnModficarCliente.Enabled = LEstado;
            this.btnCancelarNuevoCliente.Enabled = LEstado;
            this.btnEliminarCliente.Enabled = LEstado;
        }

        private void SeleccionaCliente()
        {
            //convertir dato de string a un valor 
            if (string.IsNullOrEmpty(Convert.ToString(DgvCliente.CurrentRow.Cells["IDCliente"].Value)))
            {
                MessageBox.Show("No hay datos que mostar", "Aviso del Sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                //convertir el id del cliente de la celda seleccionada de string a entero
                this.IDCliente = Convert.ToInt32(DgvCliente.CurrentRow.Cells["IDCliente"].Value);
                txtNuevoNombreCliente.Text = Convert.ToString(DgvCliente.CurrentRow.Cells["Nombre"].Value);
                txtNuevoCedulaCliente.Text = Convert.ToString(DgvCliente.CurrentRow.Cells["Cedula"].Value);
                txtNuevoCorreoCliente.Text = Convert.ToString(DgvCliente.CurrentRow.Cells["Correo"].Value);
                txtNuevoTelefonoCliente.Text = Convert.ToString(DgvCliente.CurrentRow.Cells["Telefono"].Value);
            }
        }
        #endregion

        #region Metodos Factura
        private void FormatoListaCL()
        {
            DgvListaCL.Columns[0].Width = 100;
            DgvListaCL.Columns[0].HeaderText = "Nombre";
        }

        private void ListadoLCL(string cTexto)
        {
            try
            {
                DgvCliente.DataSource = BLCliente.ListadoCL(cTexto);
                this.FormatoCL();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {

            }
        }

        private void SeleccionaListaCL()
        {
            if (string.IsNullOrEmpty(Convert.ToString(DgvListaCL.CurrentRow.Cells["Nombre"].Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                TxtListaCL.Text = Convert.ToString(DgvListaCL.CurrentRow.Cells["Nombre"].Value);
            }
        }
        



        private void FormatoFA()
        {
            DgvFacturaProducto.Columns[0].Width = 100;
            DgvFacturaProducto.Columns[0].HeaderText = "Precio";
            DgvFacturaProducto.Columns[1].Width = 100;
            DgvFacturaProducto.Columns[1].HeaderText = "Descripcion";
            DgvFacturaProducto.Columns[1].Width = 100;
            DgvFacturaProducto.Columns[1].HeaderText = "Cantidad";
        }

        private void ListadoFA(string cTexto)
        {
            try
            {
                DgvTrabajador.DataSource = BLProducto.ListadoPR(cTexto);
                this.FormatoFA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Seleccionacl(string cTexto)
        {
            //Validasmos que el DATAGEIP tenga datos para que no nos de error

            if (string.IsNullOrEmpty(Convert.ToString(TxtNombreCliente)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Calcular_Totales()
        {

            decimal nCantidad = 0;
            decimal nSubtotal = 0;
            decimal nIva = 0;
            decimal nPrecio = 0;
            decimal nTotal = 0;

            if (DgvFacturaProducto.Rows.Count == 0)
            {
                nSubtotal = 0;
                nIva = 0;
                nTotal = 0;
            }
            else
            {

                foreach (DataRow FilaTemp in DgvFacturaProducto.Rows)
                {

                    nPrecio = nPrecio + Convert.ToDecimal(FilaTemp["Precio"]); // Suma de precios
                    nCantidad = nCantidad + Convert.ToDecimal(FilaTemp["Cantidad"]);

                    nSubtotal = nPrecio * nCantidad;
                    nIva = nIva / (1 + Convert.ToDecimal("0.13")); // Subtotal sin el IVA
                    nIva = nSubtotal * nIva;
                    nTotal = (nSubtotal + nIva);

                    TxtSubtotal.Text = decimal.Round(nSubtotal, 2).ToString("#0.00");
                    TxtIVA.Text = ("#13.00%");
                    TxtTotal.Text = decimal.Round(nTotal, 2).ToString("#0.00");
                }
            }
        }
        #endregion

        #region Metodos Trabajador
        private void FormatoTR()
        {
            DgvTrabajador.Columns[0].Width = 100;
            DgvTrabajador.Columns[0].HeaderText = "ID_Trabajador";
            DgvTrabajador.Columns[1].Width = 100;
            DgvTrabajador.Columns[1].HeaderText = "Nombre";
            DgvTrabajador.Columns[2].Width = 100;
            DgvTrabajador.Columns[2].HeaderText = "Cedula";
            DgvTrabajador.Columns[3].Width = 100;
            DgvTrabajador.Columns[3].HeaderText = "Telefono";
            DgvTrabajador.Columns[4].Width = 100;
            DgvTrabajador.Columns[4].HeaderText = "Correo";
            DgvTrabajador.Columns[5].Width = 100;
            DgvTrabajador.Columns[5].HeaderText = "Estado";
        }

        //solicitud a bl para validar solicitud y la bl retorne el dato que esta solicitando

        private void ListadoTR(string tTexto)
        {
            try
            {
                // Asigna a "DgvTrabajador" los datos provenientes del método "ListadoTR" de la capa de lógica de negocios, basado en el texto de búsqueda "tTexto".
                DgvTrabajador.DataSource = BLTrabajador.ListadoTR(tTexto);

                // Llama al método "FormatoTR" para aplicar un formato personalizado a la tabla o DataGridView.
                this.FormatoTR();
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, muestra un mensaje con la descripción del error y la pila de llamadas.
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            // "DataSource" define la fuente de datos para el DataGridView, indicando de dónde se obtendrán los datos que se mostrarán.
            
        }

        private void BotonesTrabajador(bool LEstado)
        {
            // Habilita o deshabilita el botón "Guardar Nuevo Trabajador" según el estado de "LEstado".
this.btnGuardarNuevoTrabajador.Enabled = LEstado;

// Habilita o deshabilita el botón "Buscar Trabajador" según el estado de "LEstado".
this.btnBuscarTrabajador.Enabled = LEstado;

// Habilita o deshabilita el botón "Modificar Trabajador" según el estado de "LEstado".
this.btnModficarTrabajador.Enabled = LEstado;

// Habilita o deshabilita el botón "Cancelar Nuevo Trabajador" según el estado de "LEstado".
this.btnCancelarNuevoTrabajador.Enabled = LEstado;

// Habilita o deshabilita el botón "Eliminar Trabajador" según el estado de "LEstado".
this.btnEliminarTrabajador.Enabled = LEstado;

        }

        private void SeleccionaTrabajador()
        {
            //convertir dato de string a un valor 
            if (string.IsNullOrEmpty(Convert.ToString(DgvTrabajador.CurrentRow.Cells["IDTrabajador"].Value)))
            {
                MessageBox.Show("No hay datos que mostar", "Aviso del Sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                //convertir el id del trabajador de la celda seleccionada de string a entero
                this.IDTrabajador = Convert.ToInt32(DgvTrabajador.CurrentRow.Cells["IDTrabajador"].Value);
                txtNuevoNombreTrabajador.Text = Convert.ToString(DgvTrabajador.CurrentRow.Cells["Nombre"].Value);
                txtNuevoCedulaTrabajador.Text = Convert.ToString(DgvTrabajador.CurrentRow.Cells["Cedula"].Value);
                txtNuevoCorreoTrabajador.Text = Convert.ToString(DgvTrabajador.CurrentRow.Cells["Correo"].Value);
                txtNuevoTelefonoTrabajador.Text = Convert.ToString(DgvTrabajador.CurrentRow.Cells["Telefono"].Value);
            }



        }
        private void GuardarTrabajador()
        {
            if (string.IsNullOrEmpty(txtNuevoNombreTrabajador.Text.Trim()))
            {
                MessageBox.Show("Nombre del trabajador requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNuevoCedulaTrabajador.Text.Trim()))
            {
                MessageBox.Show("Cédula del trabajador requerida(*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNuevoCorreoTrabajador.Text.Trim()))
            {
                MessageBox.Show("Correo del trabajador requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNuevoTelefonoTrabajador.Text.Trim()))
            {
                MessageBox.Show("Teléfono del trabajador requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ETTrabajador eTTrabajador = new ETTrabajador
            {
                IDTrabajador = this.IDTrabajador,
                Nombre = txtNuevoNombreTrabajador.Text.Trim(),
                Cedula = txtNuevoCedulaTrabajador.Text.Trim(),
                Correo = txtNuevoCorreoTrabajador.Text.Trim(),
                Telefono = txtNuevoTelefonoTrabajador.Text.Trim()
            };

            string Rpta = BLTrabajador.GuardarTR(EstadoGuarda, eTTrabajador);

            if (Rpta == "OK")
            {
                this.ListadoTR("%");
                MessageBox.Show("Los datos se han registrado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EstadoGuarda = 0;
                this.BotonesTrabajador(true);
                txtNuevoNombreTrabajador.Text = "";
                txtNuevoCedulaTrabajador.Text = "";
                txtNuevoCorreoTrabajador.Text = "";
                txtNuevoTelefonoTrabajador.Text = "";
                this.IDTrabajador = 0;
            }
            else
            {
                MessageBox.Show(Rpta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ModificarTrabajador()
        {
            EstadoGuarda = 2; // Indica que se trata de una actualización

            // Verificar si hay una fila seleccionada en el DataGridView
            if (DgvTrabajador.CurrentRow != null)
            {
                // Obtener el IDCliente de la fila seleccionada
                this.IDTrabajador = Convert.ToInt32(DgvTrabajador.CurrentRow.Cells["IDTrabajador"].Value);

                // Poblar los campos con los datos actuales del cliente
                txtNuevoNombreTrabajador.Text = Convert.ToString(DgvTrabajador.CurrentRow.Cells["Nombre"].Value);
                txtNuevoCedulaTrabajador.Text = Convert.ToString(DgvTrabajador.CurrentRow.Cells["Cedula"].Value);
                txtNuevoCorreoTrabajador.Text = Convert.ToString(DgvTrabajador.CurrentRow.Cells["Correo"].Value);
                txtNuevoTelefonoTrabajador.Text = Convert.ToString(DgvTrabajador.CurrentRow.Cells["Telefono"].Value);


                // Establecer el enfoque en el primer campo editable
                txtNuevoNombreTrabajador.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un trabajador para modificar.", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region Metodos producto
        int iDProducto = 0;
        string descripcion = "";
        float precio = 0;
        int stockActual = 0;




        private void FormatoPR()
        {
            DGVProducto.Columns[0].Width = 90;
            DGVProducto.Columns[0].HeaderText = "ID Producto";
            DGVProducto.Columns[1].Width = 240;
            DGVProducto.Columns[1].HeaderText = "Producto";
            DGVProducto.Columns[2].Width = 150;
            DGVProducto.Columns[2].HeaderText = "Precio";
            DGVProducto.Columns[3].Width = 80;
            DGVProducto.Columns[3].HeaderText = "Stock";

        }
        private void ListadoPR(string cTexto)
        {
            try
            {
                DGVProducto.DataSource = BLProducto.ListadoPR(cTexto);
                this.FormatoPR();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {

            }
        }
        private void EstadoBotonesPrincipales(bool LEstado)
        {
            this.BTGuardarProducto.Enabled = LEstado;
            this.BTEliminararProducto.Enabled = LEstado;
            this.BTModificarProducto.Enabled = LEstado;
            this.BTBusarProducto.Enabled = LEstado;
            this.BTCancelarProducto.Enabled = LEstado;


        }

        private void EstadoBotonesProcesos(bool LEstado)
        {
            this.BTCancelarProducto.Enabled = LEstado;
            this.BTGuardarProducto.Enabled = LEstado;



        }
        private void SeleccionaItemProducto()
        {
            // Validamos que el DataGridView tenga datos para que no nos dé error
            if (string.IsNullOrEmpty(Convert.ToString(DGVProducto.CurrentRow.Cells["IdProducto"].Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                // Asignamos los valores del DataGridView a las variables correspondientes
                this.iDProducto = Convert.ToInt32(DGVProducto.CurrentRow.Cells["IdProducto"].Value);
                this.precio = Convert.ToInt32(DGVProducto.CurrentRow.Cells["precio"].Value);
                this.stockActual = Convert.ToInt32(DGVProducto.CurrentRow.Cells["StockActual"].Value);


                // Asignamos los valores del DataGridView a los TextBoxes correspondientes
                TBDescripcionProducto.Text = Convert.ToString(DGVProducto.CurrentRow.Cells["DescripcionPr"].Value);
                TBPrecioProducto.Text = Convert.ToString(DGVProducto.CurrentRow.Cells["precio"].Value);
                TBStockProducto.Text = Convert.ToString(DGVProducto.CurrentRow.Cells["StockProducto"].Value);
            }
        }
        private void GuardarProducto()
        {
            if (TBDescripcionProducto.Text == String.Empty ||
        TBPrecioProducto.Text == String.Empty ||
        TBStockProducto.Text == String.Empty)

            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else//Sino Se procede a registrar los datos
            {
                ETProducto eTProducto = new ETProducto();
                string Rpta = "";
                eTProducto.IDProducto = this.iDProducto;
                eTProducto.Descripcion = TBDescripcionProducto.Text.Trim();
                eTProducto.StockActual = Convert.ToInt32(TBStockProducto.Text);
                eTProducto.Precio = float.Parse(TBPrecioProducto.Text);
                Rpta = BLProducto.GuardarPR(EstadoGuarda, eTProducto);


                if (Rpta == "OK")
                {
                    this.ListadoPR("%");//LLAMAMOS EL METODO PARA ACTUALIZAR LA LISTA
                    MessageBox.Show("Los datos se han registrado", "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    EstadoGuarda = 0;//sIN NINGUNA ACCION
                    this.EstadoBotonesPrincipales(true);
                    this.EstadoBotonesProcesos(false);
                    TBDescripcionProducto.Text = "";
                    TBStockProducto.Text = "0";
                    TBPrecioProducto.Text = "0";
                    TBDescripcionProducto.ReadOnly = true;
                    TBStockProducto.ReadOnly = true;
                    TBPrecioProducto.ReadOnly = true;



                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

                }
            }
        }
        #endregion

        #region Metodos Servicio
        private void FormatoSE()
        {
            DGVServicio.Columns[0].Width = 100;
            DGVServicio.Columns[0].HeaderText = "ID_Servicio";
            DGVServicio.Columns[1].Width = 100;
            DGVServicio.Columns[1].HeaderText = "Descripcion_servicio";
            DGVServicio.Columns[2].Width = 100;
            DGVServicio.Columns[2].HeaderText = "Precio";
        }

        private void ListadoSE(string tTexto)
        {
            try
            {
                DGVServicio.DataSource = BLServicio.ListadoSE(tTexto);
                this.FormatoSE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            //datasource nos dice de donde vamos a consumir los datos
        }

        private void BotonesServicio(bool LEstado)
        {
            this.BTGuardarServicio.Enabled = LEstado;
            this.BTGuardarServicio.Enabled = LEstado;
            this.BTModificarServicio.Enabled = LEstado;
            this.BTCancelarServicio.Enabled = LEstado;
            this.BTEliminarServicio.Enabled = LEstado;
        }

        private void SeleccionaServicio()
        {
            //convertir dato de string a un valor 
            if (string.IsNullOrEmpty(Convert.ToString(DGVServicio.CurrentRow.Cells["Descripcion"].Value)))
            {
                MessageBox.Show("No hay datos que mostar", "Aviso del Sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {


                TBDescripcionServicio.Text = Convert.ToString(DGVServicio.CurrentRow.Cells["Descripcion"].Value);

                //convertir el precio del servicio de la celda seleccionada de string a entero

                TBPrecioServicio.Text = Convert.ToString(DGVServicio.CurrentRow.Cells["Precio"].Value);


            }
        }
        #endregion
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabFactura_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox17_Enter(object sender, EventArgs e)
        {


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            this.ListadoTR("%");
            this.ListadoFA("%");
        }

        #region Eventos Clientes
        private void btnGuardarNuevoCliente_Click(object sender, EventArgs e)
        {
            if (txtNuevoNombreCliente.Text == String.Empty)
            {
                MessageBox.Show("Nombre del Cliente requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            if (txtNuevoCedulaCliente.Text == String.Empty)
            {
                MessageBox.Show("Cedula del Cliente requerida(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            if (txtNuevoCorreoCliente.Text == String.Empty)
            {
                MessageBox.Show("Correo del Cliente requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            if (txtNuevoTelefonoCliente.Text == String.Empty)
            {
                MessageBox.Show("Telefono del  requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                ETCliente eTCliente = new ETCliente();
                //Respuesta de la bl y la que recibe de dal cuando se hace el insert (cuando guardamos)
                //para saber si el proceso fue exitoso o no
                String Rpta = "";
                eTCliente.IDCliente = this.IDCliente;
                //lo que el usuario digite en ese campo se va a capturar y se va a enviar a la bd como propiedad
                eTCliente.Nombre = txtNuevoNombreCliente.Text.Trim();
                eTCliente.Cedula = txtNuevoCedulaCliente.Text.Trim();
                eTCliente.Correo = txtNuevoCorreoCliente.Text.Trim();
                eTCliente.Telefono = txtNuevoTelefonoCliente.Text.Trim();
                //respuesta igual a los que nos retorne, enviar parametros para saber si es nuevo o no
                Rpta = BLCliente.GuardarCL(EstadoGuarda, eTCliente);


                //
                if (Rpta == "OK")
                {
                    //volver a actualizar para que apareza el cambio
                    this.ListadoTR("%");
                    MessageBox.Show("Los dato se han registrado", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    EstadoGuarda = 0;
                    //activar botones
                    this.BotonesTrabajador(true);
                    //volver todo a su estado original
                    txtNuevoNombreCliente.Text = "";
                    txtNuevoCedulaCliente.Text = "";
                    txtNuevoCorreoCliente.Text = "";
                    txtNuevoTelefonoCliente.Text = "";
                    this.IDCliente = 0;

                }
                else
                {
                    MessageBox.Show("No se logro registrar el dato", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                }
            }

        }
        private void btnModficarCliente_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;
            this.IDCliente = 0;
            this.BotonesTrabajador(true);
            //txtNuevoNombreTrabajador.Text = "";
            this.Select();
            //Poner el cursor en donde se empiezan a cambiar datos
            txtNuevoNombreCliente.Focus();

        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(DgvCliente.CurrentRow.Cells["IDCliente"].Value)))
            {
                MessageBox.Show("No hay datos que mostar", "Aviso del Sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion;
                //preguntar si se quiere realizar procedimiento y a opcion se le asignael valor de la respuesta
                opcion = MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    String Rpta = "";
                    //convertir a int
                    this.IDTrabajador = Convert.ToInt32(DgvCliente.CurrentRow.Cells["IDCliente"].Value);
                    Rpta = BLCliente.EliminaCL(this.IDCliente);

                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoTR("%");
                        this.IDCliente = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Exclamation);

                    }
                }

            }
        }
        private void btnCancelarNuevoCliente_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0;
            this.IDCliente = 0;
            txtNuevoNombreCliente.Text = "";
            txtNuevoCedulaCliente.Text = "";
            txtNuevoCorreoCliente.Text = "";
            txtNuevoTelefonoCliente.Text = "";
            this.BotonesTrabajador(true);
            this.Select();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (ckbNombreCliente.Checked == true)
            {
                this.ListadoCL(TxtBuscarCliente.Text.Trim());
            }

            if (ckbCedulaCliente.Checked == true)
            {
                this.ListadoCL(TxtBuscarCliente.Text.Trim());
            }

        }

        #endregion

        #region Eventos Servicio
        private void BTGuardarServicio_Click(object sender, EventArgs e)
        {

            if (TBDescripcionServicio.Text == String.Empty)
            {
                MessageBox.Show("Se requiere descripción del servicio(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            if (TBPrecioServicio.Text == String.Empty)
            {
                MessageBox.Show("Precio del servicio requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

            else
            {
                ETServicio eTServicio = new ETServicio();
                //Respuesta de la bl y la que recibe de dal cuando se hace el insert (cuando guardamos)
                //para saber si el proceso fue exitoso o no
                String Rpta = "";
                eTServicio.Descripcion = this.descripcion;
                //lo que el usuario digite en ese campo se va a capturar y se va a enviar a la bd como propiedad
                eTServicio.Descripcion = TBDescripcionServicio.Text.Trim();
                eTServicio.Monto = float.Parse(TBPrecioProducto.Text);

                //respuesta igual a los que nos retorne, enviar parametros para saber si es nuevo o no
                Rpta = BLServicio.GuardarSE(EstadoGuarda, eTServicio);


                //
                if (Rpta == "OK")
                {
                    //volver a actualizar para que apareza el cambio
                    this.ListadoSE("%");
                    MessageBox.Show("Los dato se han registrado", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    EstadoGuarda = 0;
                    //activar botones
                    this.BotonesServicio(true);
                    //volver todo a su estado original
                    TBPrecioServicio.Text = "";
                    TBDescripcionServicio.Text = "";


                }
                else
                {
                    MessageBox.Show("No se logro registrar el dato", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                }
            }



        }

        private void BTModificarServicio_Click(object sender, EventArgs e)
        {


            EstadoGuarda = 2;
            this.descripcion = "";
            this.BotonesServicio(true);
            this.SeleccionaServicio();
            //Poner el cursor en donde se empiezan a cambiar datos
            TBDescripcionServicio.Focus();
        }

        #endregion


        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void groupBox18_Enter(object sender, EventArgs e)
        {

        }
        #region Metodo Marca
        private void buttonGuardarMarca_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            GuardarMarca();

        }

        private void buttonBuscarMarca_Click(object sender, EventArgs e)
        {
            this.ListadoMarca(TxTBuscarMarca.Text.Trim());

        }

        private void buttonCancelarMarca_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0;//Sin ninguna accion
            this.IDMarca = 0;
            TxTNombreMarca.Text = "";
            TxTNombreMarca.ReadOnly = true;

        }

        private void buttonEliminarMarca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewMarca.CurrentRow.Cells["IDMarca"].Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de eliminar el registro seleccionado ?", "Aviso del sistema", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.IDMarca = Convert.ToInt32(dataGridViewMarca.CurrentRow.Cells["IDMarca"].Value);
                    Rpta = BLMarca.EliminarMA(this.IDMarca);

                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoMarca("%");//LLAMAMOS EL METODO PARA ACTUALIZAR LA LISTA
                        this.IDMarca = 0;
                        MessageBox.Show("Registro eliminado", "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
                    }

                }


            }

        }

        private void buttonModificarMarca_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0;//Sin ninguna accion
            this.IDMarca = 0;
            TxTBuscarMarca.Text = "";
            TxTBuscarMarca.ReadOnly = true;
        }

        #endregion


        #region Vehiculo



        private void buttonGuardarVehiculo_Click(object sender, EventArgs e)
        {

            if (TxTModeloVehiculo.Text == String.Empty ||
                   TxTPlacaVehiculo.Text == String.Empty ||
                   TxTVINVehiculo.Text == String.Empty ||
                   DistanciaTxTVehiculo.Text == String.Empty)


            {
                MessageBox.Show("Falta ingresar datos requeridos(*)", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {

                ETVehiculo etvehiculo = new ETVehiculo();
                string Rpta = "";
                etvehiculo.IDVehiculo = this.IDVehiculo;
                etvehiculo.Modelo = TxTModeloVehiculo.Text.Trim();
                etvehiculo.Placa = TxTPlacaVehiculo.Text.Trim();
                etvehiculo.VIN = TxTVINVehiculo.Text.Trim();
                etvehiculo.DistanciaRecorrida = DistanciaTxTVehiculo.Text.Trim();
                Rpta = BLVehiculo.GuardarVE(EstadoGuarda, etvehiculo);


                if (Rpta == "OK")
                {
                    this.ListadoVe("%");
                    MessageBox.Show("Los datos se han registrado", "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    EstadoGuarda = 0; // si no guardo nada

                    TxTPlacaVehiculo.Text = "";
                    TxTVINVehiculo.Text = "";
                    TxTModeloVehiculo.Text = "";

                    if (chkM.Checked == true)
                    {
                        DistanciaTxTVehiculo.Text = "";
                    }
                    if (chkK.Checked == true)
                    {
                        DistanciaTxTVehiculo.Text = "";
                    }


                    TxTVINVehiculo.ReadOnly = true;
                    TxTPlacaVehiculo.ReadOnly = true;
                    TxTModeloVehiculo.ReadOnly = true;
                    DistanciaTxTVehiculo.ReadOnly = true;
                    this.IDVehiculo = 0;

                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

                }
            }

        }
        private void buttonCancelarVehiculo_Click(object sender, EventArgs e)
        {

            EstadoGuarda = 0;//Sin ninguna accion
            this.IDVehiculo = 0;
            TxTPlacaVehiculo.Text = "";
            TxTVINVehiculo.Text = "";
            TxTModeloVehiculo.Text = "";
            DistanciaTxTVehiculo.Text = "0";
            TxTPlacaVehiculo.ReadOnly = true;
            TxTVINVehiculo.ReadOnly = true;
            TxTModeloVehiculo.ReadOnly = true;
            DistanciaTxTVehiculo.ReadOnly = true;






        }






        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void TxtCedulaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarVehiculo_Click(object sender, EventArgs e)
        {

            if (chkceduvehi.Checked == true)
            {
                this.ListadoVe(TxTBuscarVehiculo.Text.Trim());
            }
            if (chkplacavehiculo.Checked == true)
            {
                this.ListadoVe(TxTBuscarVehiculo.Text.Trim());
            }





        }

        private void buttonModificarVehiculo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0;//Sin ninguna accion
            this.IDMarca = 0;
            TxTBuscarMarca.Text = "";
            TxTBuscarMarca.ReadOnly = true;



        }

        private void buttonEliminarVehiculo_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewVehiculo.CurrentRow.Cells["IdVehiculo"].Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de eliminar el registro seleccionado ?", "Aviso del sistema", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.IDVehiculo = Convert.ToInt32(dataGridViewVehiculo.CurrentRow.Cells["IDVehiculo"].Value);
                    Rpta = BLVehiculo.EliminaVE(this.IDVehiculo);

                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoVe("%");//LLAMAMOS EL METODO PARA ACTUALIZAR LA LISTA
                        this.IDVehiculo = 0;
                        MessageBox.Show("Registro eliminado", "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
                    }

                }


            }









        }
        #endregion

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {

        }
        #region Eventos Trabajador
        private void btnGuardarNuevoTrabajador_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            GuardarTrabajador();

        }

        private void btnModficarTrabajador_Click(object sender, EventArgs e)
        {
            //2= actualizar
            EstadoGuarda = 2;
            this.IDTrabajador = 0;
            this.BotonesTrabajador(true);
            //txtNuevoNombreTrabajador.Text = "";
            this.SeleccionaTrabajador();
            //Poner el cursor en donde se empiezan a cambiar datos
            txtNuevoNombreTrabajador.Focus();

        }

        private void btnEliminarTrabajador_Click(object sender, EventArgs e)
        {
            // Verifica si la celda "IDTrabajador" de la fila actual en "DgvTrabajador" está vacía o es nula
            if (String.IsNullOrEmpty(Convert.ToString(DgvTrabajador.CurrentRow.Cells["IDTrabajador"].Value)))
            {
                // Muestra un mensaje de error si no hay datos que mostrar
                MessageBox.Show("No hay datos que mostrar", "Aviso del Sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion;
                // Pregunta al usuario si está seguro de eliminar el registro seleccionado
                // y almacena la respuesta en la variable "opcion"
                opcion = MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Aviso del Sistema", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question);

                // Si el usuario confirma que desea eliminar el registro
                if (opcion == DialogResult.Yes)
                {
                    String Rpta = "";
                    // Convierte el valor de la celda "IDTrabajador" a un entero y lo asigna a "IDTrabajador"
                    this.IDTrabajador = Convert.ToInt32(DgvTrabajador.CurrentRow.Cells["IDTrabajador"].Value);

                    // Llama al método "EliminaTR" del negocio lógico "BLTrabajador" para eliminar el trabajador
                    Rpta = BLTrabajador.EliminaTR(this.IDTrabajador);

                    // Si la respuesta es "OK", significa que el registro fue eliminado con éxito
                    if (Rpta.Equals("OK"))
                    {
                        // Actualiza la lista de trabajadores y resetea el "IDTrabajador"
                        this.ListadoTR("%");
                        this.IDTrabajador = 0;

                        // Muestra un mensaje informando que el registro fue eliminado
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation);
                    }
                }
            }

        }

        private void btnCancelarNuevoTrabajador_Click(object sender, EventArgs e)
        {
            // Inicializa el estado de guardado en 0, lo que probablemente indica que no hay cambios pendientes o que se está en modo de inserción
            EstadoGuarda = 0;

            // Resetea el ID del trabajador a 0, lo que podría significar que no hay ningún trabajador seleccionado o se está preparando para un nuevo registro
            this.IDTrabajador = 0;

            // Limpia los campos de texto asociados con los datos del trabajador, estableciendo su valor a una cadena vacía
            txtNuevoNombreTrabajador.Text = "";
            txtNuevoCedulaTrabajador.Text = "";
            txtNuevoCorreoTrabajador.Text = "";
            txtNuevoTelefonoTrabajador.Text = "";

            // Habilita o deshabilita botones relacionados con la gestión de trabajadores, posiblemente habilitando los botones para añadir un nuevo trabajador
            this.BotonesTrabajador(true);

            // Llama a un método que selecciona un trabajador, lo que podría ser para refrescar la vista o preparar la interfaz para la selección de un nuevo trabajador
            this.SeleccionaTrabajador();

        }

        private void btnBuscarTrabajador_Click(object sender, EventArgs e)
        {
            // Verifica si el checkbox "ckbNombreTrabajador" está marcado
            if (ckbNombreTrabajador.Checked == true)
            {
                // Si está marcado, llama al método "ListadoTR" pasando el texto ingresado en "txtBuscarTrabajador", eliminando espacios en blanco adicionales
                this.ListadoTR(txtBuscarTrabajador.Text.Trim());
            }

            // Verifica si el checkbox "ckbCedulaTrabajador" está marcado
            if (ckbCedulaTrabajador.Checked == true)
            {
                // Si está marcado, llama al método "ListadoTR" pasando el texto ingresado en "txtBuscarTrabajador", eliminando espacios en blanco adicionales
                this.ListadoTR(txtBuscarTrabajador.Text.Trim());
            }

        }

        #endregion

        private void BTGuardarProducto_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            GuardarProducto();
        }

        private void BTCancelarProducto_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0;//Sin ninguna accion

            this.iDProducto = 0;
            TBDescripcionProducto.Text = "";
            TBStockProducto.Text = "0";
            TBPrecioProducto.Text = "0";
            TBStockProducto.ReadOnly = true;
            TBPrecioProducto.ReadOnly = true;
            TBDescripcionProducto.ReadOnly = true;
            this.EstadoBotonesPrincipales(true);
            this.EstadoBotonesProcesos(false);
        }

        private void BTModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarTrabajador();
        }

        private void BTEliminararProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(DGVProducto.CurrentRow.Cells["IdProducto"].Value)))
            {
                MessageBox.Show("No hay datos que mostrar", "Aviso del sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de eliminar el registro seleccionado ?", "Aviso del sistema", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    string Rpta = "";
                    this.iDProducto = Convert.ToInt32(DGVProducto.CurrentRow.Cells["Idproducto"].Value);
                    Rpta = BLProducto.EliminaPR(this.iDProducto);

                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoPR("%");//LLAMAMOS EL METODO PARA ACTUALIZAR LA LISTA
                        this.iDProducto = 0;
                        MessageBox.Show("Registro eliminado", "Aviso del sistema", MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void BTBusarProducto_Click(object sender, EventArgs e)
        {
            this.ListadoPR(TBBuscarProducto.Text.Trim());
        }

        #region Eventos Factura
        private void BtnAnularFA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarFA_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimirFA_Click(object sender, EventArgs e)
        {
            TxtCedulaCliente.ReadOnly = true;
            TxtNombreCliente.ReadOnly = true;
            TxtTelefonoCliente.ReadOnly = true;
            TxtEmailCliente.ReadOnly = true;
            TxtEstadoFactura.ReadOnly = true;
            TxtTrabajador.ReadOnly = true;
            TxtPlacaVehiculoFactura.ReadOnly = true;
            TxtMarcaVehiculoFactura.ReadOnly = true;
            TxtAnnoVehiculoFactura.ReadOnly = true;
            TxtDistanciaVehiculoFactura.ReadOnly = true;


        }
        #endregion

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvListaCL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvListaCL_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionaListaCL();
            PnlListaCL.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void BtnLupa1_Click(object sender, EventArgs e)
        {
            this.PnlListaCL.Location = TxtEmailCliente.Location;
            this.PnlListaCL.Visible = true;
        }

        private void BtnBuscar2_Click_1(object sender, EventArgs e)
        {
            this.ListadoLCL(TxtListaCL.Text);
        }

        private void BtnRetornar2_Click(object sender, EventArgs e)
        {
            PnlListaCL.Visible = false;
        }
    }
}