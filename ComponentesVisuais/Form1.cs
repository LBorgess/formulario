using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentesVisuais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save file...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
