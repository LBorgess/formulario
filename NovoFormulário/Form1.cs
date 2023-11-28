﻿using System;
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
            MessageBox.Show("Deseja enviar os dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void inicializaCampos()
        {
            cbxEstado.DisplayMember = "Nome";
            cbxEstado.ValueMember = "Sigla";
            cbxEstado.DataSource = estados;
        }

        public void populaEstados()
        {
            estados.Add(new Estado("", ""));
            estados.Add(new Estado("ES", "Espirito Santo"));
            estados.Add(new Estado("BA", "Bahia"));
            estados.Add(new Estado("SP", "São Paulo"));
            estados.Add(new Estado("BH", "Belo Horizonte"));
            estados.Add(new Estado("RJ", "Rio de Janeiro"));
            estados.Add(new Estado("MA", "Maranhão"));
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
