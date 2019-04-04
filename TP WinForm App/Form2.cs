using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm_App
{
    public partial class ListadoPersonas : Form
    {
        int pos; string a, b;

        private List<Persona> listadoPersonas = new List<Persona>();
        private BindingList<Persona> listaBindeable;

        public ListadoPersonas()
        {
            InitializeComponent();
        }

        private void ListadoPersonas_Load(object sender, EventArgs e)
        {
            listaBindeable = new BindingList<Persona>(listadoPersonas);
            dgvPersonas.DataSource = listaBindeable;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida solo letras, backspace y espacio.
            if (!(e.KeyChar > 64 && e.KeyChar < 91) && !(e.KeyChar > 96 && e.KeyChar < 123)
                && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida solo letras, backspace y espacio.
            if (!(e.KeyChar > 64 && e.KeyChar < 91) && !(e.KeyChar > 96 && e.KeyChar < 123)
                && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void labEdad_Click(object sender, EventArgs e)
        {
            //Calcula la edad y la muestra en el Label.
            TimeSpan tS = new TimeSpan();
            tS = DateTime.Now.Subtract(dtpFechaNac.Value);
            labEdad.Text = "Edad:" + Convert.ToInt32(tS.TotalDays / 365).ToString();
        }

        private void rbMujer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbPop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbHardRock_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbMetal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbSalsa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbTango_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbClasica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cobColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Calcula la edad y la muestra en el Label.
            TimeSpan tS = new TimeSpan();
            tS = DateTime.Now.Subtract(dtpFechaNac.Value);
            labEdad.Text = "Edad:" + Convert.ToInt32(tS.TotalDays / 365).ToString();

            //Valida si estan los campos nombre, apellido, y si el color fue seleccionado,
            //sino avisa con un mensaje.
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || cobColores.SelectedIndex < 0)
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }

            //Saca la palabra "Edad", para poder insertarla en el metodo constructor.
            labEdad.Text = Convert.ToInt32(tS.TotalDays / 365).ToString();

            //Busca el RadioButtom que fue seleccionado.
            a = "";
            if (rbHombre.Checked) a = rbHombre.Text.ToString();
            else if (rbMujer.Checked) a = rbMujer.Text.ToString();
            else a = rbOtro.Text.ToString();

            //Suma las selecciones musicales.
            b = "";
            if (chbPop.Checked) b += chbPop.Text.ToString() + " ";
            if (chbHardRock.Checked) b += chbHardRock.Text.ToString() + " ";
            if (chbMetal.Checked) b += chbMetal.Text.ToString() + " ";
            if (chbSalsa.Checked) b += chbSalsa.Text.ToString() + " ";
            if (chbTango.Checked) b += chbTango.Text.ToString() + " ";
            if (chbClasica.Checked) b += chbClasica.Text.ToString();

            Persona nuevo = new Persona(txtNombre.Text.Trim(), txtApellido.Text.Trim(), labEdad.Text.Trim(), 
            a, b, cobColores.SelectedItem.ToString());
            listadoPersonas.Add(nuevo);
            refrescarGrilla();
        }

        private void refrescarGrilla()
        {
            listaBindeable.ResetBindings();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //pos representa la posición de la fila,
            //y los valores de 0 a 5, son los campos a modificar.
            dgvPersonas[0, pos].Value = txtNombre.Text;
            dgvPersonas[1, pos].Value = txtApellido.Text;
            dgvPersonas[2, pos].Value = labEdad.Text;
            dgvPersonas[3, pos].Value = a;
            dgvPersonas[4, pos].Value = b;
            dgvPersonas[5, pos].Value = cobColores.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Si no está null, elimina la fila seleccionada.
            if (dgvPersonas.CurrentRow == null)
                return;

            dgvPersonas.Rows.Remove(dgvPersonas.CurrentRow);
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se posiciona en la fila actual.
            pos = dgvPersonas.CurrentRow.Index;
            txtNombre.Text = dgvPersonas[0, pos].Value.ToString();
            txtApellido.Text = dgvPersonas[1, pos].Value.ToString();
            labEdad.Text = dgvPersonas[2, pos].Value.ToString();
            a = dgvPersonas[3, pos].Value.ToString();
            b = dgvPersonas[4, pos].Value.ToString();
            cobColores.Text = dgvPersonas[5, pos].Value.ToString();
        }
    }
}
