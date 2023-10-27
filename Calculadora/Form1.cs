using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double resultado = n1 + n2;
            lblresultado.Text = resultado.ToString("F2");
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double resultado = n1 - n2;
            lblresultado.Text = resultado.ToString("F2");
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);
            double resultado = n1 * n2;
            lblresultado.Text = resultado.ToString("F2");
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtn1.Text);
            double n2 = Convert.ToDouble(txtn2.Text);

            if (n1 == 0 || n2 == 0)
            {
                lblresultado.Text = "Impossível calcular";
            }
            else
            {
                double resultado = n1 / n2;
                lblresultado.Text = resultado.ToString("F2");
            }
        }
    }
}
