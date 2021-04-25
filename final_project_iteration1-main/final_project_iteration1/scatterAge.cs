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
    public partial class scatterAge : Form
    {
        public scatterAge()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int j; //creates variable used within for loops

            bool ScatterAge_Switch = false;

            bool Iteration_Switch = false;

            //Creates string array with age events
            string[] ScatterAge_Array = new string[] { "10193", "Battle of Arrakeen. House Harkonnen is annihilated. Glossu Rabban, Vladimir Harkonnen and Feyd-Rautha died. Paul Atreides officially becomes Padishah Emperor.", "10194", "Paul and Jessica travel back to Caladan. Jessica is installed as Duchess. Alia proclaims that those who are not Muad'Dib's allies, are his enemies.", "10198", "First failed attempt on Paul's life by Swordmaster Whitmore Bludd.", "10199", "Second failed attempt on Paul's life by Marie Fenring and her adopted parents, Hasimir Fenring and Margot Fenring, with him using the Emperor's Blade.", "10209", "Chani dies after giving birth to Leto Atreides II and Ghanima Atreides. Paul goes into the deep desert. Alia assumes regency of the throne for the twins.", "10219", "After a confrontation against her nephew Leto Atreides II, Alia Atreides dies, and he ascends to the throne, becoming the God Emperor/Tyrant, and sets the Universe on his The Golden Path.", "10256", "Jessica Atreides dies." };

            string Scatter_AgeInput;//creates string AgeInput

            Scatter_AgeInput = scatterAgeYear.Text;//sets AgeInput to use input value

            while (ScatterAge_Switch == false)
            {
                for (j = 0; j < ScatterAge_Array.Length; j++)//iterates through the array
                {
                    if (j == ScatterAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Scatter_AgeInput == ScatterAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(ScatterAge_Array[j + 1]);
                        ScatterAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Scatter_AgeInput != ScatterAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        ScatterAge_Switch = true;
                        break;
                    }
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DuneTimeline T1 = new DuneTimeline();
            this.Hide();
            T1.ShowDialog();
        }
    }
}
