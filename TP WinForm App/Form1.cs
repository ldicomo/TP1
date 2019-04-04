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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listadoDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoPersonas ventana1 = new ListadoPersonas();
            ventana1.Show();
        }

        private void listadoDeObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoObjetos ventana2 = new ListadoObjetos();
            ventana2.Show();
        }
    }
}
