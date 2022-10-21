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
    public partial class Ejercicio5 : Form
    {
        
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btn_ComicSansOnClick(object sender, EventArgs e)
        {
            label1.Font = new Font("Comic Sans MS", label1.Font.Size);
        }  

        private void btn_CourierOnClick(object sender, EventArgs e)
        {
            label1.Font = new Font("Courier", label1.Font.Size);
        }

        private void btn_NegritaOnClick(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void btn_CursivaOnClick(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Italic);
        }

        private void btn_TachadoOnClick(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Strikeout);
        }

        private void btn_SubrayadoOnClick(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Underline);
        }

        private void btn_TamanyoMasOnClick(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size+1);
        }

        private void btn_TamanyoMenosOnClick(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size - 1);
        }

        private void btn_SalirOnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SeleccionarOnClick(object sender, EventArgs e)
        {
            
            label2.Text = "El texto tiene " + textBox1.Text.Length +" caracteres, y el texto seleccionado es: "+textBox1.SelectedText;
        }
    }
}
