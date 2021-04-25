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
    public partial class gotTree : Form
    {
        lannisterTree f1 = new lannisterTree();
        starkTree f2 = new starkTree();
        targaryenTree f6 = new targaryenTree();
        public gotTree()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lannisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.ShowDialog();
        }

        private void starkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
        }

        private void targaryenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            f6.ShowDialog();
        }
    }
}
