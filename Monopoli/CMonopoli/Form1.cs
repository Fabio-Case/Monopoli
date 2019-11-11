using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMonopoli
{
    public partial class Form1 : Form
    {
        CImmobile imm;
        public Form1()
        {
            InitializeComponent();
            imm = new CImmobile();
            textBox1.Text = imm.visualizzaListaContratti();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
