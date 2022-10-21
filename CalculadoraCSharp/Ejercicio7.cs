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
using Button = System.Windows.Forms.Button;

namespace CalculadoraCSharp
{
    public partial class Ejercicio7 : Form
    {
        private Boolean operationOn = true;
        public Ejercicio7()
        {
            InitializeComponent();
        }
        private void btn_numberOnClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+(sender as Button).Text;
            operationOn = true;
        }
        private void btn_operadorOnClick(object sender, EventArgs e)
        {
            if (operationOn)
            {
                textBox1.Text = textBox1.Text + (sender as Button).Text;
                operationOn = false;
    	    }
        }
        private void btn_LimpiarOnClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operationOn = true;
        }
        private void btn_LimpiarUltimoOnClick(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void btn_ResultadoOnClick(object sender, EventArgs e)
        {
            if(textBox1.Text.Substring(textBox1.Text.Length-1) != "+" && 
                textBox1.Text.Substring(textBox1.Text.Length - 1) != "-" && 
                textBox1.Text.Substring(textBox1.Text.Length - 1) != "/" &&
                textBox1.Text.Substring(textBox1.Text.Length - 1) != "*") { 

            DataTable dataTable = new DataTable();
            DataColumn column = new DataColumn("Ecua", typeof(double), textBox1.Text);
            dataTable.Columns.Add(column);
            dataTable.Rows.Add(0);
            double operation = (double)dataTable.Rows[0][0];
            textBox1.Text = Convert.ToString(operation);
            }
        }
    }
}
