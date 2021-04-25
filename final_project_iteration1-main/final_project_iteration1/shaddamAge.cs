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
    public partial class shaddamAge : Form
    {
        public shaddamAge()
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

            bool ShaddamAge_Switch = false;

            bool Iteration_Switch = false;

            //Creates string array with age events
            string[] ShaddamAge_Array = new string[] { "10156", "Death of Elrood IX. Vladimir Harkonnen’s unsuccessful effort to cause warfare between House Atreides and the Bene Tleilax.", "10171", "Leto Atreides gains popularity in the Landsraad by trying to solve the Moritani-Ecaz conflict. The Bene Gesserit 'presents' Jessica to Leto with the secret aim that she would conceive a girl child from him – this girl should give birth to the Kwisatz Haderach.", "10173", "Gurney Halleck escapes from slavery.", "10174", "Birth of Abulurd Harkonnen's second son, Feyd-Rautha.Duncan Idaho is declared swordmaster. Gurney Halleck joins House Atreides. Birth of Chani Kynes, daughter of Liet-Kynes and Faroula.", "10175", "Birth of Paul Atreides.", "10182", "Death of Wensicia Corrino, daughter of Elrood IX.", "10192", "Birth of Marie Fenring, biological daughter of Feyd-Rautha Harkonnen and Lady Margot Fenring, on Caladan.", "10190", "Birth of Alia Atreides." };

            string Shaddam_AgeInput;//creates string AgeInput

            Shaddam_AgeInput = shaddamAgeYear.Text;//sets AgeInput to use input value

            while (ShaddamAge_Switch == false)
            {
                for (j = 0; j < ShaddamAge_Array.Length; j++)//iterates through the array
                {
                    if (j == ShaddamAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Shaddam_AgeInput == ShaddamAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(ShaddamAge_Array[j + 1]);
                        ShaddamAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Shaddam_AgeInput != ShaddamAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        ShaddamAge_Switch = true;
                        break;
                    }
                }
            }
        }
    }
}
