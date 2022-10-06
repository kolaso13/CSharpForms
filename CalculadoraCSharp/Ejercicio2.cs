using System;
using System.Collections;
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
    public partial class Ejercicio2 : Form
    {
        String concatenar = "";
        private List<Button> botones;
        int index = 0;

        public Ejercicio2()
        {
            InitializeComponent();
            botones = new List<Button>();
            botones.Add(button1);
            botones.Add(button2);
            botones.Add(button3);
            botones.Add(button4);
            botones.Add(button5);
            botones.Add(button6);
        }

        private void btn_salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpiar(object sender, EventArgs e)
        {
            textBox1.Text = "";
            concatenar = "";
            if (index <= botones.Count - 1)
            {
                botones[index].Enabled = false;
            } 
            botones[0].Enabled = true;
            index = 0;
        }

        private void btn_unir(object sender, EventArgs e)
        {
            textBox1.Text = concatenar;
        }

        private void btn_frase(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            botones[index + 1].Enabled = true;
            concatenar += " " + textBox1.Text;
            index++;
            textBox1.Text = "";
        }
    }
}
