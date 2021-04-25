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
    public partial class thirdAge : Form
    {
        public thirdAge()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int i;
            bool ThirdAge_Switch = false;
            bool Iteration_Switch = false;

            string[] ThirdAge_Array = new string[] { "2", "Isildur is killed by orcs;The one ring is lost in the Anduin", "3", "The shards of Narsil are brought to Imladris", "1000", "The Istari arrive in Middle Earth", "1050", "Gondor reaches the height of its power;Sauron inhabits Dol Goldur", "1300", "The shadow over Middle earth grows;The realm of Angmar is formed;The Nazgul reappear", "1601", "Hobbits settle the Shire", "1975", "Gondor destroys Angmar", "1980", "Durin's Bane awoken in Moria;The Witch king returns to Mordor", "2002", "Minis Ithil falls", "2050", "The line of kings fails", "2063", "The watchful peace begins", "2430", "Gollum is born", "2463", "Gollum claims the ring", "2746", "Thorin Oakenshield is born", "2770", "Smaug claims Erebor", "2890", "Bilbo Baggins is born", "2941", "Bilbo Baggins claims the one ring;Sauron is driven to Mordor from Dol Goldur", "2951", "Sauron declares his presence in Mordor", "2953", "Last meeting of the white council", "2968", "Frodo Baggins is born", "3002", "Bilbo settles in Rivendell", "3018", "Council of Elrond is held, the fellowship sets out", "3019", "Gandalf dies fighting a balrog;The fellowship dissolves;The battles of the war of the ring occur;The one ring is destroyed", "3021", "Elrond,Galadriel,Gandalf,Frodo,and Bilbo depart for the Grey Havens" };

            string ThirdAge_Input;

            ThirdAge_Input = thirdAgeYear.Text;

            while (ThirdAge_Switch == false)
            {
                for (i = 0; i < ThirdAge_Array.Length; i++)
                {
                    if (i == ThirdAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (ThirdAge_Input == ThirdAge_Array[i])
                    {
                        MessageBox.Show(ThirdAge_Array[i + 1]);
                        ThirdAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && ThirdAge_Input != ThirdAge_Array[i])
                    {
                        MessageBox.Show("That date is not known");
                        ThirdAge_Switch = true;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lotrTimeline L3 = new lotrTimeline();
            this.Hide();
            L3.ShowDialog();
        }
    }
}
