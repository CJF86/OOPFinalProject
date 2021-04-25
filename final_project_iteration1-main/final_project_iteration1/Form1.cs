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
    public partial class Form1 : Form
    {
        lotrTimeline f2 = new lotrTimeline();
        lotrTree f3 = new lotrTree();
        lotrItem f4 = new lotrItem();

        gotTimeline f5 = new gotTimeline();
        gotTree f6 = new gotTree();
        gotItem f7 = new gotItem();

        DuneTimeline f8 = new DuneTimeline();
        DuneTree f9 = new DuneTree();
        DuneItems f10 = new DuneItems();

        Account f11 = new Account();
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (LOTRbutton.Checked)
            {
                if (timelineCheckBox.Checked) //done
                {
                    this.Hide();
                    f2.ShowDialog();
                }
                if (treeCheckBox.Checked)
                {
                    this.Hide();
                    f3.ShowDialog();
                }
                if (itemCheckBox.Checked)
                {
                    this.Hide();
                    f11.ShowDialog();
                }
                
            }
            else if (GOTbutton.Checked)
            {
                if (timelineCheckBox.Checked) //done
                {
                    this.Hide();
                    f5.ShowDialog();
                }
                if (treeCheckBox.Checked)
                {
                    this.Hide();
                    f6.ShowDialog();
                }
                if (itemCheckBox.Checked)
                {
                    this.Hide();
                    f11.ShowDialog();
                }
            }
            else if (Dunebutton.Checked)
            {
                if (timelineCheckBox.Checked) //done
                {
                    this.Hide();
                    f8.ShowDialog();
                }
                if (treeCheckBox.Checked)
                {
                    this.Hide();
                    f9.ShowDialog();
                }
                if (itemCheckBox.Checked)
                {
                    this.Hide();
                    f11.ShowDialog();
                }
            }
            
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
