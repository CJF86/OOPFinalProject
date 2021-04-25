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
    public partial class dawnAge : Form
    {
        public dawnAge()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int j; //creates variable used within for loops

            bool DawnAge_Switch = false;

            bool Iteration_Switch = false;

            string[] DawnAge_Array = new string[] { "12000", "A human ethnic group, the First Men, invades Westeros across the Arm of Dorne from Essos. The Wars of the First Men and the Children of the Forest last for generations. The Children destroy the Arm of Dorne.", "10000", "After years of warfare, the two sides agree to a truce: the Children could not win, but the First Men feared the massive cost in lives if they continued to fight the Children to extinction.", "8000", "The Long Night: A great winter that lasts a generation descends on the world, followed by a night that goes for years. Under the cover of darkness, the White Walkers invade Westeros from the uttermost north, causing immense suffering and destruction. In the War for the Dawn, the Children and the First Men unite to defeat the Walkers, eventually throwing them back into the north.", "7500", "Bran the Builder may have ruled the North from Winterfell as some sort of high-king, but this unity falls apart after the threat of the Long Night ends, and the North fragments into various petty kingdoms, like the rest of Westeros.", "7000", "Garth Gardener builds Highgarden and settles the fertile fields of the Reach. His dynasty continues as House Gardener, though Garth's numerous descendants also found many other vassal houses throughout the Reach.", "6500", "Lann the Clever swindles House Casterly out of Casterly Rock and its rich gold mines using nothing but his wits, and becomes the founder of House Lannister.", "6000", "Durran Godsgrief builds the impregnable fortress Storm's End, founding House Durrandon (ancestors of House Baratheon).", "5500", "The Grey King unites the Iron Islands, and according to legend kills Nagga the sea-dragon. His sons begin the tradition of the Kingsmoot, raising up non-hereditary high kings of the isles by holding an election among their own lords." };
            
            string Dawn_AgeInput;//creates string Dawn_AgeInput

            Dawn_AgeInput = dawnYear.Text;//sets to use input value

            while (DawnAge_Switch == false)
            {
                for (j = 0; j < DawnAge_Array.Length; j++)//iterates through the array
                {
                    if (j == DawnAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Dawn_AgeInput == DawnAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(DawnAge_Array[j + 1]);
                        DawnAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Dawn_AgeInput != DawnAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        DawnAge_Switch = true;
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
