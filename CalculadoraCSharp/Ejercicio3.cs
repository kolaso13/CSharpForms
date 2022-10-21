using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculadoraCSharp
{
    public partial class Ejercicio3 : Form
    {

        public double num1, num2, num3, num4;
        private void btn_Siguiente(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox1.Text == null){
                textBox1.Text = "0";
            }
            switch (label1.Text)
            {
                case "Numero 1":
                    num1 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                    label1.Text = "Numero 2";
                    break;
                case "Numero 2":
                    num2 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                    label1.Text = "Numero 3";
                    break;
                case "Numero 3":
                    num3 = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                    label1.Text = "Numero 4";
                    break;
                case "Numero 4":
                    num4 = double.Parse(textBox1.Text);
                    Hide();
              
                    new Ejercicio3B(Calculate()).Show();
                    break;
            }
        }
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btn_salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private double Calculate()
        {
           return (num1 + (num1 * num2) + (num2 * num3) + (num3 * num4)) / 4;
        }
    }
}
