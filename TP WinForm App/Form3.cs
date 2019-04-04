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
    public partial class ListadoObjetos : Form
    {
        public ListadoObjetos()
        {
            InitializeComponent();
        }

        private void ListadoObjetos_Load(object sender, EventArgs e)
        {

        }

        private void txtNomObj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomObj_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida solo letras, backspace y espacio.
            if (!(e.KeyChar > 64 && e.KeyChar < 91) && !(e.KeyChar > 96 && e.KeyChar < 123) 
                && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNomObj.Text == "")
                MessageBox.Show("Ingrese el objeto.");
            listaUno.Items.Add(txtNomObj.Text);
            
        }

        private void btnDerTodos_Click(object sender, EventArgs e)
        {
            //Comprueba que en listaDos, no haya 
            //un objeto igual al de listaUna,
            //sino es así, procede a sumarlo.
            bool sihay;
            if (listaUno.Items.Count > 0)
            {
                foreach (String item1 in listaUno.Items)
                {
                    sihay = false;
                    foreach (String item2 in listaDos.Items)
                    {
                        if (item2.ToString().Contains(item1))
                            sihay = true;
                    }
                    if (!sihay)
                    {
                        listaDos.Items.Add(item1.ToString());
                    }
                }
            }
        }

        private void btnDerUno_Click(object sender, EventArgs e)
        {
            //Comprueba que el objeto seleccionado
            //en listaUno, no este ya, en listaDos,
            //sino es así, procede a sumarlo.
            bool sihay = false;
            foreach (String item2 in listaDos.Items)
            {
                if (item2.Equals(listaUno.SelectedItem))
                {
                    MessageBox.Show("El objeto ya existe en listaDos.");
                    sihay = true;
                }            
            }
            if (!sihay) listaDos.Items.Add(listaUno.SelectedItem);
        }

        private void btnIzqUno_Click(object sender, EventArgs e)
        {
            //Suma en listaUno, un objeto 
            //seleccionado en listaDos.
            listaUno.Items.Add(listaDos.SelectedItem);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Borra un objeto seleccionado en listaUno.
            listaDos.Items.Remove(listaDos.SelectedItem);
        }

        private void TextBox(object sender, EventArgs e)
        {
         
        }
    }
}
