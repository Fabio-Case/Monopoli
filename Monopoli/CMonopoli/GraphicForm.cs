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
        
        public GraphicForm()
        {
            InitializeComponent();
        }

        private void GraphicForm_Load(object sender, EventArgs e)
        {
            for(int r=0;r< tableLayoutPanel1.RowCount;r++)
                for (int c = 0; c< tableLayoutPanel1.ColumnCount; c++)
                {
                    Label lab = new Label();
                    lab.Text = "ciao";
                    tableLayoutPanel1.Controls.Add(lab, r, c);
                }
                    

        }
    }
}
