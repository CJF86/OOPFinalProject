using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace final_project_iteration1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)//writes textbox information to text file when button is clicked
        {
            string UserNameEntry;
            string PasswordEntry;

            UserNameEntry = CreateUserTxtBox.Text;
            PasswordEntry = CreatePassTxtBox.Text;
            //These files may only work on my computer so the path might need changed to transfer properly
            System.IO.File.AppendAllText(@"C:\\Users\Craig\\Downloads\\final_project_iteration3-main\\final_project_iteration2-main\\final_project_iteration1-main\\final_project_iteration1-main\\final_project_iteration1\Credential.txt",UserNameEntry + Environment.NewLine);
            System.IO.File.AppendAllText(@"C:\\Users\Craig\\Downloads\\final_project_iteration3-main\\final_project_iteration2-main\\final_project_iteration1-main\\final_project_iteration1-main\\final_project_iteration1\Credential.txt", PasswordEntry + Environment.NewLine);

            Creation C1 = new Creation();
            this.Hide();
            C1.ShowDialog();


        }
    }
}
