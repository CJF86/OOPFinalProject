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
    public partial class elroodAge : Form
    {
        public elroodAge()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DuneTimeline T1 = new DuneTimeline();
            this.Hide();
            T1.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int j; //creates variable used within for loops

            bool ElroodAge_Switch = false;

            bool Iteration_Switch = false;

            //Creates string array with age events
            string[] ElroodAge_Array = new string[] { "10018", "Death of Emperor Fondil III. Elrood Corrino IX ascends the throne. During the reign of Elrood IX, Richese is overpowered by Ix in an economic warfare. This leads to the political and economic decline of House Richese.", "10071", "Birth of Habla.", "10092", "Birth of Fafnir Corrino, son of Elrood IX and Alexandra Ecaz. Birth of Wanna Marcus.", "10112", "Wellington Yueh graduates at the Suk School.", "10119", "Habla gives birth to Shaddam, son of Elrood IX and Barbara Mutelli.", "10130", "The Ecazi Revolt. Dominic Vernius and Paulus Atreides fight on Elrood IX’s side against the rebels. The rebellion is suppressed. Birth of the bastard son of Elrood and his concubine Shando Balut. The child is named Tyros Reffa and is adopted by House Taligari.", "10138", "Marriage of Dominic Vernius and Shando Balut. Hasimir and Shaddam kill Fafnir Corrino, the crown prince.", "10140", "Birth of Leto Atreides, son of Paulus Atreides and Helena Richese.", "10146", "Birth of Duncan Idaho.", "10154", "Bene Tleilax takes over control of Ix. The Fremen begin terraforming Arrakis with Pardot Kynes’s guidance. Duncan Idaho becomes a servant of House Atreides. Birth of Liet-Kynes, son of Pardot Kynes. Birth of Jessica, daughter of Gaius Helen Mohiam and Vladimir Harkonnen as a subject of the Kwisatz Haderach project." };

            string Elrood_AgeInput;//creates string AgeInput

            Elrood_AgeInput = elroodAgeYear.Text;//sets AgeInput to use input value

            while (ElroodAge_Switch == false)
            {
                for (j = 0; j < ElroodAge_Array.Length; j++)//iterates through the array
                {
                    if (j == ElroodAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Elrood_AgeInput == ElroodAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(ElroodAge_Array[j + 1]);
                        ElroodAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Elrood_AgeInput != ElroodAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        ElroodAge_Switch = true;
                        break;
                    }
                }
            }
        }
    }
}
