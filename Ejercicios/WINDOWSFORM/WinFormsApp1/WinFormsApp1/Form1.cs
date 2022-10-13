using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void btn_Click(object sender, EventArgs e)
        {
            var hasNumber = new Regex(@"[0-9]+");

            if (textBox1.Text =="" && textBox2.Text=="")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }else if(!textBox1.Text.Equals(textBox2.Text))
            {
                MessageBox.Show("Las claves deben ser iguales!");
            }
            else if(textBox1.Text.Length<=5 || textBox1.Text.Length>=11)
            {
                MessageBox.Show("La clave debe ser mayor o igual a 6 y menor o igual de 10 caracteres");
            }else if(!hasNumber.IsMatch(textBox1.ToString()))
            {
                MessageBox.Show("La clave debe contener al menos un valor numerico");
            }
            else
            {
                MessageBox.Show("Clave aceptada");
            }
             
        }
    }
}
