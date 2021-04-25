using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project_iteration1
{
    public partial class lotrTree : Form
    {
        elrondTree f1 = new elrondTree();
        aragornTree f2 = new aragornTree();
        frodoTree f3 = new frodoTree();
        gimliTree f4 = new gimliTree();

        
        public lotrTree()
        {
            InitializeComponent();
        }
        private void viewButton_Click(object sender, EventArgs e)
        {
            if (elrondButton.Checked)
            {
                this.Hide();
                f1.ShowDialog();
            }
            else if (aragornButton.Checked)
            {
                this.Hide();
                f2.ShowDialog();
            }
            else if (frodoButton.Checked)
            {
                this.Hide();
                f3.ShowDialog();
            }
            else if (gimliButton.Checked)
            {
                this.Hide();
                f4.ShowDialog();
            }
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
