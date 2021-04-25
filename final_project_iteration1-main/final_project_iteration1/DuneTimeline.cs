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
    public partial class DuneTimeline : Form
    {
        titanAge f1 = new titanAge();
        omniusAge f2 = new omniusAge();
        elroodAge f3 = new elroodAge();
        shaddamAge f4 = new shaddamAge();
        paulAge f5 = new paulAge();
        scatterAge f6 = new scatterAge();
        public DuneTimeline()
        {
            InitializeComponent();
        }

        private void surfButton_Click(object sender, EventArgs e)
        {
            if (titanButton.Checked)
            {
                this.Hide();
                f1.ShowDialog();
            }
            else if (omniusButton.Checked)
            {
                this.Hide();
                f2.ShowDialog();
            }
            else if (elroodButton.Checked)
            {
                this.Hide();
                f3.ShowDialog();
            }
            else if (shaddamButton.Checked)
            {
                this.Hide();
                f4.ShowDialog();
            }
            else if (paulButton.Checked)
            {
                this.Hide();
                f5.ShowDialog();
            }
            else if (scatterButton.Checked)
            {
                this.Hide();
                f6.ShowDialog();
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
