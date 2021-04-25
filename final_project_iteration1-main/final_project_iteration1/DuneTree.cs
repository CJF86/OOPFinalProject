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
    public partial class DuneTree : Form
    {
        atreidesTree f2 = new atreidesTree();
        harkonnenTree f3 = new harkonnenTree();
        public DuneTree()
        {
            InitializeComponent();
        }

        private void atreidesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
        }

        private void harkonnenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
