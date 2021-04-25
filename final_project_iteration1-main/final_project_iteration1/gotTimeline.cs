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
    public partial class gotTimeline : Form
    {
        dawnAge f1 = new dawnAge();
        andalAge f2 = new andalAge();
        hundredAge f3 = new hundredAge();
        conquestAge f4 = new conquestAge();
        postAge f5 = new postAge();
        public gotTimeline()
        {
            InitializeComponent();
        }

        private void lotrTimeButton_Click(object sender, EventArgs e)
        {
            if (dawnButton.Checked)
            {
                this.Hide();
                f1.ShowDialog();
            }
            else if (andalButton.Checked)
            {
                this.Hide();
                f2.ShowDialog();
            }
            else if (hundredButton.Checked)
            {
                this.Hide();
                f3.ShowDialog();
            }
            else if (conquestButton.Checked)
            {
                this.Hide();
                f4.ShowDialog();
            }
            else if (postButton.Checked)
            {
                this.Hide();
                f5.ShowDialog();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
