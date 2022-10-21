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
    public partial class Ejercicio3B : Form
    {
        
        public Ejercicio3B(double res)
        {
            InitializeComponent();
            textBox1.Text = res.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar(object sender, EventArgs e)
        {
            textBox1.Text="";
            Hide();
            new Ejercicio3().Show();
        }

        private void btn_Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
