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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                textBox2.Text = textBox1.Text;
                textBox1.Text = "";
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                textBox3.Text = textBox2.Text;
                textBox2.Text = "";
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                textBox1.Text = textBox3.Text;
                textBox3.Text = "";
                textBox1.Focus();
            }
        }

        private void btn_SalirOnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_LimpiarOnClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }
    }
}
