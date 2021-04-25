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
    public partial class omniusAge : Form
    {
        public omniusAge()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int j; //creates variable used within for loops

            bool OmniusAge_Switch = false;

            bool Iteration_Switch = false;

            //Creates string array with age events
            string[] OmniusAge_Array = new string[] { "1182", "Xerxes' network seizes control over Ix. Omnius, the AI, establishes the Synchronized Worlds over the Titan-worlds. The Titans are made his servants.", "1082", "Barbarossa creates Beowulf.", "603", "Omnius launches an unsuccessful attack against Chusuk.", "400", "The Sorceresses of Rossak begin to keep detailed breeding records, starting the future Kwisatz Haderach program.", "377", "Discovery of a Muadru runestone on an empty planet.", "358", "Birth of Abdel.", "303", "Last massive assault of the machines for the next 100 years.", "277", "Ginaz soldiers find Chirox in a shipwreck. They reprogram it and begin using it for combat practices.", "225", "Hecate secretly returns to human space and begins to watch the war between Omnius and the League of Nobles.", "224", "Marriage of Manion Butler and Livia. Birth of Camie Boro, descendant of the last Emperor of the Old Empire.", "223", "Birth of Vorian Atreides and Xavier Harkonnen.", "221", "Birth of Serena, Octa, and Fredo Butler.", "210", "Death of Conquee Cenva. Selim is lost in the desert for two days.", "206", "Death of Fredo Butler. Xavier receives the legal entitlement to the original Harkonnen holdings.", "203", "Tio Holtzman invents the Scrambler web which fails to protect the attack of the thinking machines against Salusa Secundus. Selim is exiled from his village by Naib Dhartha, but he discovers how to ride the sandworms of Arrakis. Erasmus is transferred from Corrin to Earth. Omnius conquers Giedi Prime and then he dispatches thousands of deepspace probes into the galaxy to establish machine bases.", "201", "Birth of Roella Harkonnen. Erasmus kills the baby Manion. Revolt breaks out on Earth were Ajax is killed. The First slave revolt of Poritrin is suppressed and Bel Moulay executed.", "200", "The League of Nobles starts the Butlerian Jihad against the thinking machines. Using atomics, the League wipes out the thinking machines of Earth. The nuclear attack renders Earth uninhabitable for centuries.", "199", "Birth of Omilia Harkonnen.", "197", "Corrin-Omnius sends a heavy fleet to Salusa Secundus, but the Army of the Jihad rebuffs them. Vorian Atreides returns to Bela Tegeuse and discovers that the thinking machines have rebuilt it. Jafar joins the exiled Selim. Later many follow his example, making Selim’s outlaw band grow.", "195", "The Army of the Jihad attempts to free the population from the Synchronized World Honru but Omnius uses suicide robot ships that wipe out the whole Jihad fleet. Over 500000 free humans are killed.", "193", "Jihad Police is officially established, lead by Yorek Thurr. In a political marriage, Iblis Ginjo marries Camie Boro.", "164", "Aurelius Venport gives the space-folding technology and the Kolhar shipyards to the Jihad’s disposal. Vidad and his colleagues broker peace between Omnius and the League. The war-weary humans want peace in spite of Serena Butler’s and Iblis Ginjo’s protest.", "108", "Vorian Atreides reveals to Abulurd Butler the true role of Xavier Harkonnen in the Tlulaxa organ scandal. Liberation of Honru. Omnius infects the League Planets with the Omnius Scourge causing the death of billions." };

            string Omnius_AgeInput;//creates string Omnius_AgeInput

            Omnius_AgeInput = omniusAgeYear.Text;//sets Omnius_AgeInput to use input value

            while (OmniusAge_Switch == false)
            {
                for (j = 0; j < OmniusAge_Array.Length; j++)//iterates through the array
                {
                    if (j == OmniusAge_Array.Length - 1)//sets iteration switch when iteration reaches the end of the array
                    {
                        Iteration_Switch = true;
                    }

                    if (Omnius_AgeInput == OmniusAge_Array[j])//outputs information if user input is found within the array
                    {
                        MessageBox.Show(OmniusAge_Array[j + 1]);
                        OmniusAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && Omnius_AgeInput != OmniusAge_Array[j])//handles user input if it is not found within the array
                    {
                        MessageBox.Show("That date is unknown");
                        OmniusAge_Switch = true;
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
