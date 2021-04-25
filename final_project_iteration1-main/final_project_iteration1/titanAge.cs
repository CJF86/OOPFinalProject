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
    public partial class titanAge : Form
    {
        public titanAge()
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

            bool TitanAge_Switch = false;

            bool Iteration_Switch = false;

            //Creates string array with age events
            string[] TitanAge_Array = new string[] { "2200", "Arn Eklo, Kwyna, Vidad and others become Cogitors. Some follow Vidad to Hessra to contemplate the universe or become hermit philosophers on inhabited worlds.", "1381", "The Zensunni break away from the religion of Maometh.", "1287", "Tlaloc fails to bring the Old Empire out of her slumber. 20 people (Titans) set out to conquer the Empire with him. Barbarossa reprograms computers giving them human aggression and hunger for power. With his aid the Old Empire falls. Arrakis is abandoned.", "1280", "Tlaloc dies. Agamemnon and other Titans have themselves transformed to cymeks.", "1192", "The First Hrethgir Rebellion on Walgis. Xerxes trusts keeping the order on his planets completely to the local computer network.", "1183", "Ajax, lord of Walgis crushes the rebellion and exterminates the populace. Outraged by the massacre, his mate Hecate transfers her brain into a deepspace vessel and disappears." };

            string Titan_AgeInput;//creates string AgeInput

            Titan_AgeInput = titanAgeYear.Text;//sets AgeInput to use input value

            while (TitanAge_Switch == false)
            {
                for (j = 0; j < TitanAge_Array.Length; j++)//iterates through the array
                {
                    if (j == TitanAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Titan_AgeInput == TitanAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(TitanAge_Array[j + 1]);
                        TitanAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Titan_AgeInput != TitanAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        TitanAge_Switch = true;
                        break;
                    }
                }
            }
        }
    }
}
