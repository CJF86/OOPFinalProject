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
    public partial class Creation : Form
    {
        public Creation()
        {
            InitializeComponent();
        }

        private void BeginBtn_Click(object sender, EventArgs e)//sends user to appropriate creation form based off of selected series on button click
        {
            if (GOTRdBtn.Checked == true)
            {
                gotItem G1 = new gotItem();
                this.Hide();
                G1.ShowDialog();
            }
            else if (LOTRRdBtn.Checked == true)
            {
                lotrItem G2 = new lotrItem();
                this.Hide();
                G2.ShowDialog();
            }
            else if (DuneRdBtn.Checked == true)
            {
                DuneItems G3 = new DuneItems();
                this.Hide();
                G3.ShowDialog();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Form1 F4 = new Form1();
            this.Hide();
            F4.ShowDialog();
        }
    }
}
