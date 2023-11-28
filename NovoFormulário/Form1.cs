using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoFormulário
{
    public partial class Form1 : Form
    {
        List<Estado> estados = new List<Estado>();
        public Form1()
        {
            InitializeComponent();
            populaEstados();
            inicializaCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void inicializaCampos()
        {
            cbxEstado.DisplayMember = "Nome";
            cbxEstado.ValueMember = "Sigla";
            cbxEstado.DataSource = estados;
        }

        public void populaEstados()
        {
            estados.Add(new Estado("ES", "Espirito Santo"));
            estados.Add(new Estado("ES", "Espirito Santo"));
            estados.Add(new Estado("SP", "São Paulo"));
            estados.Add(new Estado("ES", "Espirito Santo"));
            estados.Add(new Estado("RJ", "Rio de Janeiro"));
            estados.Add(new Estado("ES", "Espirito Santo"));
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
