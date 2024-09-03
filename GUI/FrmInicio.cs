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
                DgvTrabajador.DataSource = BLTrabajador.ListadoTR(tTexto);
                this.FormatoTR();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            //datasource nos dice de donde vamos a consumir los datos
        }

        private void BotonesTrabajador(bool LEstado)
        {
            this.btnGuardarNuevoTrabajador.Enabled = LEstado;
            this.btnBuscarTrabajador.Enabled = LEstado;
            this.btnModficarTrabajador.Enabled = LEstado;
            this.btnCancelarNuevoTrabajador.Enabled = LEstado;
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
<<<<<<< HEAD

        }
=======
            this.ListadoTR("%");
        }

        #region Eventos Trabajador
        private void btnGuardarNuevoTrabajador_Click(object sender, EventArgs e)
        {
            if (txtNuevoNombreTrabajador.Text == String.Empty)
            {
                MessageBox.Show("Nombre del trabajador requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            if (txtNuevoCedulaTrabajador.Text == String.Empty)
            {
                MessageBox.Show("Cedula del trabajador requerida(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            if (txtNuevoCorreoTrabajador.Text == String.Empty)
            {
                MessageBox.Show("Correo del trabajador requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            if (txtNuevoTelefonoTrabajador.Text == String.Empty)
            {
                MessageBox.Show("Telefono del trabajador requerido(*)", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                ETTrabajador eTTrabajador = new ETTrabajador();
                //Respuesta de la bl y la que recibe de dal cuando se hace el insert (cuando guardamos)
                //para saber si el proceso fue exitoso o no
                String Rpta = "";
                eTTrabajador.IDTrabajador = this.IDTrabajador;
                //lo que el usuario digite en ese campo se va a capturar y se va a enviar a la bd como propiedad
                eTTrabajador.Nombre = txtNuevoNombreTrabajador.Text.Trim();
                eTTrabajador.Cedula = txtNuevoCedulaTrabajador.Text.Trim();
                eTTrabajador.Correo = txtNuevoCorreoTrabajador.Text.Trim();
                eTTrabajador.Telefono = txtNuevoTelefonoTrabajador.Text.Trim();
                //respuesta igual a los que nos retorne, enviar parametros para saber si es nuevo o no
                Rpta = BLTrabajador.GuardarSE(EstadoGuarda, eTTrabajador);


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
                    txtNuevoNombreTrabajador.Text = "";
                    txtNuevoCedulaTrabajador.Text = "";
                    txtNuevoCorreoTrabajador.Text = "";
                    txtNuevoTelefonoTrabajador.Text = "";
                    this.IDTrabajador = 0;

                }
                else
                {
                    MessageBox.Show("No se logro registrar el dato", "Aviso del Sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                }
            }

        }

        private void btnModficarTrabajador_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 2;
            this.IDTrabajador = 0;
            this.BotonesTrabajador(true);
            //txtNuevoNombreTrabajador.Text = "";
            DgvTrabajador.SelectedIndex = 1;
            this.SeleccionaItems();
            //Poner el cursor en donde se empiezan a cambiar datos
            txtNuevoNombreTrabajador.Focus();



        }

        private void btnEliminarTrabajador_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(DgvTrabajador.CurrentRow.Cells["IDTrabajador"].Value)))
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
                    this.IDTrabajador = Convert.ToInt32(DgvTrabajador.CurrentRow.Cells["IDTrabajador"].Value);
                    Rpta = BLTrabajador.EliminaSE(this.IDTrabajador);

                    if (Rpta.Equals("OK"))
                    {
                        this.ListadoTR("%");
                        this.IDTrabajador = 0;
                        MessageBox.Show("Registro Eliminado", "Aviso del Sistema", MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Exclamation);

                    }
                }

            }
        }

        private void btnCancelarNuevoTrabajador_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0;
            this.IDTrabajador = 0;
            txtNuevoNombreTrabajador.Text = "";
            txtNuevoCedulaTrabajador.Text = "";
            txtNuevoCorreoTrabajador.Text = "";
            txtNuevoTelefonoTrabajador.Text = "";
            this.BotonesTrabajador(true);
            this.SeleccionaItems();
        }

        private void btnBuscarTrabajador_Click(object sender, EventArgs e)
        {
            if (ckb.Checked == true)
            {
                this.ListadoTR(Textbox29.Text.Trim());
            }

            if (ckb.Checked == true)
            {
                this.ListadoTR(Textbox29.Text.Trim());
            }

        }
    }
}
