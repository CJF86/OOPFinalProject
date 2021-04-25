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
    public partial class Account : Form
    {
        SignIn S1 = new SignIn();
        SignUp S2 = new SignUp();
        public Account()
        {
            InitializeComponent();
        }

        private void SignInbtn_Click(object sender, EventArgs e)//Opens the sign in form when button is clicked
        {
            this.Hide();
            S1.ShowDialog();

        }

        private void SignUpBtn_Click(object sender, EventArgs e)//Opens the sign up form when the button is clicked
        {
            this.Hide();
            S2.ShowDialog();
        }
    }
}
