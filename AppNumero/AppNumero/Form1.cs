using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Instanciar objetos
            Numero numero1 = new Numero(int.Parse(txtNumeroMenor.Text),
                int.Parse(txtNumeroMayor.Text));

            List<int> rangonumero = new List<int>();
            rangonumero = numero1.MostrarRango();
            foreach (int contador2 in rangonumero)
            {
                rbtMostrarRango.Text = rbtMostrarRango.Text + " " + contador2.ToString();
            }
        }
    }
}
