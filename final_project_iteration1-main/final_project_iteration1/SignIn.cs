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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)//allows for sign in based on entered credentials. Same functionality as timeline array loop
        {
            //Dependent on file paths. not sure how to fix that exactly
            int M;
            bool UserNameSwitch = false;
            bool PasswordSwitch = false;
            bool AccountCheckSwitch = false;
            string User_Entry = UsrNameTxtBox.Text;
            string Pass_Entry = PassWrdTxtBox.Text;
            string[] Credential_Array = System.IO.File.ReadAllLines(@"C:\\Users\Craig\\Downloads\\final_project_iteration3-main\\final_project_iteration2-main\\final_project_iteration1-main\\final_project_iteration1-main\\final_project_iteration1\Credential.txt");

            while (AccountCheckSwitch == false)//same functionality as timeline loops
            {
                for (M = 0; M < Credential_Array.Length; M++)
                {
                    if (User_Entry == Credential_Array[M])
                    {
                        UserNameSwitch = true;
                        //PasswordSwitch = true;
                        //AccountCheckSwitch = true;
                        //break;

                    }
                    if (Pass_Entry == Credential_Array[M+1])//could probably be combined.Separated for debugging
                    {
                        PasswordSwitch = true;
                        //AccountCheckSwitch = true;
                    }
                    if (UserNameSwitch == true && PasswordSwitch == true)
                    {
                        AccountCheckSwitch = true;
                        break;

                    }

                }
                if (UserNameSwitch == false && PasswordSwitch == false)
                {
                    MessageBox.Show("That account does not exist");
                    AccountCheckSwitch = true;
                    break;
                }


            }
            if (UserNameSwitch == true && PasswordSwitch == true)
            {
                Creation C2 = new Creation();
                this.Hide();
                C2.ShowDialog();

            }



        }
    }
}
