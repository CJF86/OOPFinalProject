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
    public partial class DuneItems : Form
    {
        public DuneItems()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                FamilyPicBox.Load("https://i.pinimg.com/originals/f0/48/eb/f048eba873f351e5de03f988a3167dee.jpg");
                FamilyInfo.Text = "House Atreides was one of the Houses Major within the infrastructure of the Galactic Padishah Empire. They were ruled by the patriarch of the Atreides family, who took the title of Duke.";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                FamilyPicBox.Load("https://static.wikia.nocookie.net/dune/images/1/19/Dune-ccg-judge-of-the-change-fakhir-zirut-56s_519rFydJQTL-1.jpg/revision/latest/scale-to-width-down/180?cb=20190228092717");
                FamilyInfo.Text = "The Fremen were humans, who consider the planet Arrakis their home. They formed an integral part in the establishment of the Atreides Empire and Muad'Dib's Jihad launched by Paul Atreides, their adopted leader.";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                FamilyPicBox.Load("https://static.wikia.nocookie.net/dune/images/2/2a/Screenshot_2019-03-13-16-53-26-1.png/revision/latest/scale-to-width-down/239?cb=20190313155408");
                FamilyInfo.Text = "The Imperial House Corrino was once the deadliest and grandest House Major found within the Known universe, and for many thousands of years the imperial family of the Imperium. The official residence of the Imperial House Corrino was the planet Kaitain while their personal fief was the ancestral exile planet Salusa Secundus. ";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                FamilyPicBox.Load("https://static.wikia.nocookie.net/dune/images/3/3a/Bg.png/revision/latest/scale-to-width-down/80?cb=20190311232834");
                FamilyInfo.Text = "The Bene Gesserit are a pseudo-religious organization of all-women spies, nuns, scientists, and theologians who use genetic experimentation, galactic political interference, and religious engineering to further their own agenda of ascending the human race with the advent of their chosen one, the Kwisatz Haderach. ";
            }
        }

        private void TransportBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransportBox.SelectedIndex == 0)
            {
                TransportPicBox.Load("https://static.wikia.nocookie.net/dune/images/c/cd/Sandworm_heretics.jpg/revision/latest/scale-to-width-down/127?cb=20050829035720");
                TransportInfo.Text = "The sandworm was a native life-form of the planet Arrakis. It lived in the vast deserts and sand dunes that stretched across the surface of the planet. Most importantly, sandworms are an essential factor in the creation of the Spice Melange.";
            }
            else if (TransportBox.SelectedIndex == 1)
            {
                TransportPicBox.Load("https://static.wikia.nocookie.net/dune/images/c/c4/Ornithopter-RoadtoDune.jpg/revision/latest/scale-to-width-down/180?cb=20091030075710");
                TransportInfo.Text = "Ornithopters, also commonly referred to as 'thopters, were the most common small transport vessels in the Imperium. These ships were capable of carrying 6 passengers, 9 if the back seats were removed. ";
            }
            else if (TransportBox.SelectedIndex == 2)
            {
                TransportPicBox.Load("https://static.wikia.nocookie.net/dune/images/7/79/Guild-Heighliner.jpg/revision/latest/scale-to-width-down/250?cb=20071006063410");
                TransportInfo.Text = "A starship was a space-faring vessel capable of travelling between star systems. They typically travelled close to light speed, or used the Holtzman Effect to realize faster-than-light travel.";
            }
        }
    }
}
