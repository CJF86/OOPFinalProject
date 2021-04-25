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
    public partial class firstAge : Form
    {
        
        public firstAge()
        {
            InitializeComponent();
        }

        

        private void searchButton_Click(object sender, EventArgs e)
        {
            int j; //creates variable used within for loops

            bool FirstAge_Switch = false;

            bool Iteration_Switch = false;

            //Creates string array with first age events
            string[] FirstAge_Array = new string[] { "1", "Sun first sets sail;awakening of men in Hildorien", "20", "Turgon and Finrod establish Gondolin", "60", "battle of Dagor Aglareb is fought;men cease worship of Illuvatar", "116", "Gondolin is completed", "260", "Glaurung is driven to Angband;the long peace begins", "305", "Men discovered by Finrod", "455", "Morgoth breaks siege of Angband;Fingolfin killed", "457", "Minas Tirith falls to Sauron", "472", "Nirnaeth Arnoediad is fought", "495", "Battle of Tumhalad and sack of Nargothrond;Tuor comes to Gondolin", "505", "Doriath destroyed in second kinslaying", "510", "Gondolin betrayed by Maeglin and sacked", "538", "Third kinslaying occurs", "545", "War of Wrath begins", "587", "Morgoth is cast into the void;remaining silmarils are stolen and lost;elves are summoned to Valinor" };

            string First_AgeInput;//creates string First_AgeInput

            First_AgeInput = firstAgeYear.Text;//sets First_AgeInput to use input value

            while (FirstAge_Switch == false)
            {
                for (j = 0; j < FirstAge_Array.Length; j++)//iterates through the array
                {
                    if (j == FirstAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (First_AgeInput == FirstAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(FirstAge_Array[j + 1]);
                        FirstAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch==true&&First_AgeInput!=FirstAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        FirstAge_Switch = true;
                        break;
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)//provides return button that takes user back to lotrtimeline form
        {
            lotrTimeline L1 = new lotrTimeline();
            this.Hide();
            L1.ShowDialog();
        }
    }
}
