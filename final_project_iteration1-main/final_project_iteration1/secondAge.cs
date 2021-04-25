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
    public partial class secondAge : Form
    {
        public secondAge()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int k;
            bool SecondAge_Switch = false;
            bool Iteration_Switch = false;
            string[] SecondAge_Array = new string[] { "1", "Foundation of the Grey Havens", "500", "Sauron rises again in middle earth", "600", "Numenorean ships sail to middle earth", "750", "Noldor found the realm of Eregion", "1000", "Sauron begins building Barad-dur", "1200", "Numenoreans build permanent havens in Middle Earth", "1350", "Galadriel comes to Lorien", "1600", "The one ring is forged;Barad dur is completed", "1693", "war of elves and Sauron begins;Elvish rings are hidden", "1697", "Elrond establishes Rivendell", "1700", "Sauron's forces retreat to Mordor", "1800", "Numenor establishes permanent settlements in Middle Earth", "2221", "Ringwraiths first appear", "3209", "Birth of Isildur", "3262", "Sauron taken prisoner", "3280", "Isildur steals from Nimloth;the White Tree is burned", "3300", "Sauron becomes high priest of Melkor", "3320", "Realms of Gondor and Arnor are founded", "3428", "Sauron beseiges Minis Ithil;War of the Last Alliance begins", "3430", "The last alliance of elves and men is formed", "3434", "Siege of Barad-dur begins", "3441", "Isildur slays Sauron by cutting the one ring from his finger, destroying his physical form and ending the war" };

            string SecondAge_Input;
            SecondAge_Input = secondAgeYear.Text;

            while (SecondAge_Switch == false)
            {
                for (k = 0; k < SecondAge_Array.Length; k++)
                {
                    if (k == SecondAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (SecondAge_Input == SecondAge_Array[k])
                    {
                        MessageBox.Show(SecondAge_Array[k + 1]);
                        SecondAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && SecondAge_Input != SecondAge_Array[k])
                    {
                        MessageBox.Show("That date is unknown");
                        SecondAge_Switch = true;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lotrTimeline L2 = new lotrTimeline();
            this.Hide();
            L2.ShowDialog();
        }
    }
}
