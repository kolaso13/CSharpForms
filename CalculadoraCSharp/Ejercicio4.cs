using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(textBox1.Text == "Informática" || textBox1.Text == "Informatica" && textBox2.Text == "1234")
            {
                label3.Text = "Bienvenido al Sistema, Informática";
            }
            else
            {
                label3.Text = "Usuario no identificado";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
