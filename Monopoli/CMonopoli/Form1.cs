using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMonopoli
{
    public partial class Form1 : Form
    {
        SerialPort COM;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            COM = new SerialPort("COM9", 9600); //creo l'oggetto SerialPort che serve per comunicare con arduino

            COM.Open(); //apro la comunicazione con arduino
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = COM.ReadLine();
        }
    }
}
