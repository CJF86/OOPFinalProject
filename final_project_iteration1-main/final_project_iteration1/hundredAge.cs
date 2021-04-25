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
    public partial class hundredAge : Form
    {
        public hundredAge()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int j; //creates variable used within for loops

            bool HundredAge_Switch = false;

            bool Iteration_Switch = false;

            string[] HundredAge_Array = new string[] { "8000", "On the eastern continent of Essos, the ancient Ghiscari Empire flourishes on the eastern coast of Slaver's Bay, one of the oldest - if not the oldest - great civilizations in the world. The Ghiscari Empire is built on large-scale slavery of conquered peoples, who toil away to build the great pyramids of Old Ghis and its colonies.", "6000", "On the western side of Slaver's Bay, a race of peaceful shepherds find Dragons lairing in the Fourteen Fires, an immense chain of volcanoes extending across the neck of the Valyrian Peninsula. The Valyrians tame the dragons with magic and begin expanding their influence into the rest of Essos.", "7000", "The Ghiscari Wars begin, span for 1000 years. Inevitably, the expanding Valyrian Freehold comes into conflict with the Ghiscari Empire over which superpower will dominate the continent. They fight a series of five great wars, ending with the Valyrians throwing down the Ghiscari in defeat.", "6001", "A race of men from Essos, the Andals, crossed the Narrow Sea in numerous ships and made landfall in the Vale of Arryn. Under the banner of the Faith of the Seven, riding horses and wielding weapons made of iron, they overran and conquered all of Westeros south of the Neck.", "5500", "Their overland migration waves only reached the western side of the continent generations later, and by that point they were clearly inevitable. Therefore, the rulers of the Westerlands and the Reach peacefully intermarried with chosen Andal groups, inviting them in and uniting with them to fight off the other Andal kingdoms in eastern Westeros.", "4000", "The Andals finally conquer the Iron Islands, much later than the mainland of Westeros due to their isolated location. However, the few Andals who invaded the Iron Islands essentially 'went native' and acculturated to the distinct ironborn culture, even abandoning the Faith of the Seven to convert to worship of the Drowned God.", "700", "The Rhoynish Wars begin. The Valyrian Freehold begins settling the region of the modern Free Cities. Their expansion brings them into conflict with the native inhabitants of the region surrounding the River Rhoyne. Nymeria, the warrior-queen of the Rhoynar, realizes that they cannot stand against dragons and they flee to Dorne, in southern Westeros.", "500", "Revolting slaves take over the Valyrian fleet they were being transported in, and use the ships to flee from the Valyrian-controlled areas of central Essos to the northwestern corner of the continent. There they find a secretive lagoon protected by mountains and narrow access channels, where they found the Secret City of Braavos.", "200", "The Valyrians annex Dragonstone, an island in the Narrow Sea just off the eastern coast of Westeros. The Targaryen family takes control of the island, which is used as a trading post with the Seven Kingdoms. According to legend, Aenar Targaryen had a vision of impending catastrophe and arranged to have his family removed from the Freehold.", "100", "Doom of Valyria: The Fourteen Fires erupt in a titanic explosion that obliterates the heartland of the Valyrian Freehold. Most of the Valyrian dragons, who lair in the volcanoes when not needed, are killed outright. The City of Valyria is partially buried under vast amounts of ash. The Valyrian Peninsula fractures and breaks apart. A large part of it is torn away from the mainland, low-lying areas are flooded and many offshore islands are formed. The waters around Valyria remain poisonous until the present day.", "2", "The Century of Blood. In the aftermath of the Doom, Valyria's outlying colony-cities began breaking away and asserting their independence, becoming the nine Free Cities." };

            string Hundred_AgeInput;//creates string for year

            Hundred_AgeInput = hundredYear.Text;// makes user input

            while (HundredAge_Switch == false)
            {
                for (j = 0; j < HundredAge_Array.Length; j++)//iterates through the array
                {
                    if (j == HundredAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Hundred_AgeInput == HundredAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(HundredAge_Array[j + 1]);
                        HundredAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Hundred_AgeInput != HundredAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        HundredAge_Switch = true;
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
