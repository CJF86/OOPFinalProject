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
    public partial class conquestAge : Form
    {
        public conquestAge()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int j; //creates variable used within for loops

            bool ConquestAge_Switch = false;

            bool Iteration_Switch = false;

            string[] ConquestAge_Array = new string[] { "1", "Despite pleas to intervene in the Free Cities, Aegon the Conqueror, the ruler of House Targaryen, decides to invade Westeros, along with his sister-wives Rhaenys and Visenya.", "4", "After Aegon conquers most of Westeros, he begins a war with the final unconquered kingdom, Dorne.", "7", "Aegon's son Aenys I is born from Rhaenys.", "10", "Rhaenys dies after a Dornish scorpion bolt strikes her dragon and she falls to her death.", "12", "Aegon's second son Maegor I is born from Visenya.", "13", "The Dornish War ends; Dorne falls under Aegon's rule, but its monarch is allowed to keep the title of 'Prince' or 'Princess'.", "37", "Aegon the Conqueror dies from a stroke at the age of 64. His first son Aenys becomes king.", "42", "Aenys dies under questionable circumstances. His brother Maegor assumes the Iron Throne, skipping over Aenys' children.", "48", "Maegor is defeated. His nephew Jaeherys becomes King.", "103", "Jaeherys dies after a long rule. His grandson Viserys I takes the throne.", "129", "Viserys I dies. Despite choosing his daughter Rhaenyra as his sucessor, his son Aegon II takes the throne, beginning a Targaryen Civil War that ends with many dead dragons and a new monarch.", "131", "After the war, Aegon III takes the throne. The last dragon in the world dies during his reign, branding him 'Aegon Dragonsbane'.", "157", "Aegon Dragonsbane dies. His son Daeron the Young Dragon takes the throne at the age of 14. Starts the Conquest of Dorne, resulting in a short-lasting conquest of Dorne, followed by a Dornish rebellion.", "161", "Daeron the Young Dragon dies. His brother Baelor I takes the throne.", "171", "Baelor I accidentally fasts to death. His uncle Viserys II, brother to Aegon III, takes the throne.", "172", "Viserys II dies. His son, Aegon IV, assumes the throne.", "184", "Aegon IV, deemed Aegon the Unworthy, dies after fathering countless bastard children. He legitimizes all of them upon his death. His trueborn son Daeron II assumes the throne.", "196", "Daemon Blackfyre, one of Aegon the Unworthy's legitimized bastards, starts an unsucessful rebellion against his brother. It ends in the same year with his death and defeat.", "209", "Daeron II dies of an illness. His son Aerys I takes the throne.", "221", "Aerys I dies. His brother Maekar I takes the throne.", "233", "Maeker I dies. His fifth son Aegon takes the throne, becoming Aegon V, the 'Unlikely'.", "259", "Aegon V, among many other Kinsgaurd and Servants, dies in the mysterious Tragedy of Summerhall. His son Jaeherys II takes the throne.", "262", "Jaeherys II dies. His son Aerys II, dubbed 'The Mad King', assumes the throne." };

            string Conquest_AgeInput;//creates string for year

            Conquest_AgeInput = conquestYear.Text;// makes user input

            while (ConquestAge_Switch == false)
            {
                for (j = 0; j < ConquestAge_Array.Length; j++)//iterates through the array
                {
                    if (j == ConquestAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Conquest_AgeInput == ConquestAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(ConquestAge_Array[j + 1]);
                        ConquestAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Conquest_AgeInput != ConquestAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        ConquestAge_Switch = true;
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
