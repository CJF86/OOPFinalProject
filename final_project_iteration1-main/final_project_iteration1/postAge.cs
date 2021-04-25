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
    public partial class postAge : Form
    {
        public postAge()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int j; //creates variable used within for loops

            bool PostAge_Switch = false;

            bool Iteration_Switch = false;

            string[] PostAge_Array = new string[] { "279", "Robert's Rebellion against the Mad King begins after his bride, Lyanna Stark, is kidnapped by Prince Rhaegar. Ends in victory two years later. Robert I Baratheon takes the throne.", "280", "Robb Stark, Eddard Stark's first trueborn son, is born. Jon Snow, Eddard Stark's bastard son, is born.", "281", "Having fled after the defeat of her husband, the Mad King, Queen Rhaella dies giving birth to her daughter, Daenerys Targaryen.", "298", "Daenerys Targaryen marries Khal Drogo. Robert Baratheon dies. His son, Joffrey I Baratheon, executes Robert's friend and Hand, Eddard Stark. This starts the War of the Five Kings. Daenerys hatches three dragons, the first dragons seen since Aegon Dragonsbane's Reign.", "300", "The War of the Five Kings ends with Robb I Stark is murdered at his uncles wedding. Jon Snow is murdered at the Wall." };

            string Post_AgeInput;//creates string for year

            Post_AgeInput = postYear.Text;// makes user input

            while (PostAge_Switch == false)
            {
                for (j = 0; j < PostAge_Array.Length; j++)//iterates through the array
                {
                    if (j == PostAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Post_AgeInput == PostAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(PostAge_Array[j + 1]);
                        PostAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Post_AgeInput != PostAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        PostAge_Switch = true;
                        break;
                    }
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            gotTimeline G1 = new gotTimeline();
            this.Hide();
            G1.ShowDialog();
        }
    }
}
