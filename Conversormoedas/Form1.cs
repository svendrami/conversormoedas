using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversormoedas
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_realdolar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(tbvalor.Text);

            resultado = num1 * 5.62;
            label3.Text = Convert.ToString(resultado);
            resultado = 0;
            num1 = 0;
        }

        private void Dolarparareal_Click(object sender, EventArgs e)
        {
            // double num1, resultado;
            num1 = Convert.ToDouble(tbvalor.Text);

            resultado = num1 / 5.62;
            label3.Text = Convert.ToString(resultado);
            resultado = 0;
            num1 = 0;
        }

        private void Btn_realparaeuro_Click(object sender, EventArgs e)
        {
            // double num1, resultado;
            num1 = Convert.ToDouble(tbvalor.Text);

            resultado = num1 * 6.63;
            label3.Text = Convert.ToString(resultado);
            resultado = 0;
            num1 = 0;
        }

        private void Btn_euroreal_Click(object sender, EventArgs e)
        {
            // double num1, resultado;
            num1 = Convert.ToDouble(tbvalor.Text);

            resultado = num1 / 6.63;
            label3.Text = Convert.ToString(resultado);
            resultado = 0;
            num1 = 0;
        }

        private void btneuroparadolar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(tbvalor.Text);

            resultado = num1 * 1.18;
            label3.Text = Convert.ToString(resultado);
            resultado = 0;
            num1 = 0;
        }

        private void btndolarparaeuro_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(tbvalor.Text);

            resultado = num1 / 1.18;
            label3.Text = Convert.ToString(resultado);
            resultado = 0;
            num1 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
