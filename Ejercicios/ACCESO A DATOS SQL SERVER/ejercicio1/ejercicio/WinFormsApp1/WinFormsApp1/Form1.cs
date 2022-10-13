using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGestionPersonas_Click(object sender, EventArgs e)
        {
            GestionPersonas ventanaPersonas = new GestionPersonas();
            //creo objeto de GestionCliente y lo almacenamos en ventanaClientes

            ventanaPersonas.ShowDialog();//para poder la ventana
        }
    }
}
