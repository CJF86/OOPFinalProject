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
    
    public partial class lotrTimeline : Form
    {
        //different forms for different arrays
        firstAge f1 = new firstAge(); 
        secondAge f2 = new secondAge();
        thirdAge f3 = new thirdAge();
        public lotrTimeline()
        {
            InitializeComponent();
        }


        private void flyButton_Click(object sender, EventArgs e)
        {
            if (firstAgeButton.Checked)
            {
                this.Hide();
                f1.ShowDialog();
            }
            else if (secondAgeButton.Checked)
            {
                this.Hide();
                f2.ShowDialog();
            }
            else if (thirdAgeButton.Checked)
            {
                this.Hide();
                f3.ShowDialog();
            }
        }
    }
}
