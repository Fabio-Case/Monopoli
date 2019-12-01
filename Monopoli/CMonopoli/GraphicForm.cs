using Giocatore;
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
    public partial class GraphicForm : Form
    {
        CGiocatori player; 
        public GraphicForm()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri("https://it.wikipedia.org/wiki/Monopoly");
        }

        private void GraphicForm_Load(object sender, EventArgs e)
        {
            //for(int r=0;r< tableLayoutPanel1.RowCount;r++)
            //    for (int c = 0; c< tableLayoutPanel1.ColumnCount; c++)
            //    {
            //        Label lab = new Label();
            //        lab.Text = "ciao";
            //        tableLayoutPanel1.Controls.Add(lab, r, c);
            //    }


        }

        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBoxGioc2.SelectedItem)
            {
                case "G1":
                    label1.Text = textBoxNome.Text;
                    break;
                case "G2":
                    label2.Text = textBoxNome.Text;
                    break;
                case "G3":
                    label3.Text = textBoxNome.Text;
                    break;
                case "G4":
                    label4.Text = textBoxNome.Text;
                    break;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGioc_SelectedIndexChanged(object sender, EventArgs e)
        {
            player = new CGiocatori(comboBoxGioc.SelectedIndex + 2);
        }
    }
}
