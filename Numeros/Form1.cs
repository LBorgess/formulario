using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNum1.Text);
            double n2 = Convert.ToDouble(txtNum2.Text);
            double n3 = Convert.ToDouble(txtNum3.Text);
            double resultado = 0;

            // Compara
            if(n1 >= n2 || n2 >= n3)
            {
                resultado = n1;
            }

            if (n2 >= n1 || n2 >= n3)
            {
                resultado = n2;
            }

            if (n3 >= n1 || n3 >= n1)
            {
                resultado = n3;
            }

            lblResultado.Text = resultado.ToString();

        }
    }
}
