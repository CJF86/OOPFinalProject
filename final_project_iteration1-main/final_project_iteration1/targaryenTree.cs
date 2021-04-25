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
    public partial class targaryenTree : Form
    {
        targaryenTree2 f2 = new targaryenTree2();
        public targaryenTree()
        {
            InitializeComponent();
        }

        private void targaryenTree_Load(object sender, EventArgs e) //DON'T DELETE THIS!!! IF YOU ACCIDENTALLY MAKE IT IT'S OKAY, BUT IF YOU DELETE IT IT'LL DESTROY THE WHOLE FORM
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            gotTree G1 = new gotTree();
            G1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
        }

        private void aenarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aenar the Exile. First Lord of Dragonstone.");
        }

        private void aerionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daemion's son. Married to Lady Valaena Velaryon.");
        }

        private void valaenaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a noblewoman from House Velaryon living at the end of the Century of Blood. She was the wife of Aerion Targaryen, Lord of Dragonstone, and the mother of the three conquerors of Westeros: Visenya, Aegon, and Rhaenys Targaryen.");
        }

        private void rheanysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rhaenys Targaryen was the youngest sister of King Aegon I Targaryen, the first Lord of the Seven Kingdoms. She was a dragonrider who rode the dragon Meraxes.");
        }

        private void aegonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The first Lord of the Seven Kingdoms and king on the Iron Throne, having conquered six of the Seven Kingdoms during the Conquest. The dragonlord was the founder of the ruling Targaryen dynasty of Westeros. He was a dragonrider who rode the dragon Balerion, the black dread.");
        }

        private void visenyaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Queen Visenya Targaryen was the older sister and wife of King Aegon I Targaryen, the first Lord of the Seven Kingdoms. Her younger sister, Rhaenys, was married to Aegon as well. Visenya was a dragonrider, and rode the dragon Vhagar.");
        }

        private void aenysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The elder son of Aegon I by his younger sister-wife Rhaenys. Married to Lady Alyssa Velaryon. Second Lord of the Seven Kingdoms, as King Aenys I Targaryen.");
        }

        private void maegorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Maegor the Cruel. The younger son of Aegon I by his elder sister-wife Visenya. Third Lord of the Seven Kingdoms, as King Maegor I Targaryen. Married to Ceryse Hightower, Alys Harroway, Tyanna of the Tower, and the 'Black Brides', Elinor Costayne, Rhaena Targaryen, and Jeyne Westerling.");
        }

        private void alyssaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A member of House Velaryon during the first century after Aegon's Conquest. She was married to King Aenys I Targaryen, and gave birth to his six children. Some years after Aenys's death Alyssa served as Queen Regent to her youngest son, King Jaehaerys I Targaryen. She remarried to Lord Rogar Baratheon, and gave birth to two more children during the marriage");
        }

        private void viserysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The second son of King Aenys I Targaryen and Queen Alyssa Velaryon.");
        }

        private void jaeherysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jaehaerys the Conciliator, the Old King, and Jaehaerys the Wise. Fourth Lord of the Seven Kingdoms, as King Jaehaerys I Targaryen. He rode Vermithor.");
        }

        private void alysanneButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Good Queen Alysanne, was the queen consort of her brother, King Jaehaerys I Targaryen. Alysanne was a dragonrider whose mount was Silverwing.");
        }

        private void othAegonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The second child, and eldest son and heir, of King Aenys I Targaryen and Queen Alyssa Velaryon. After his father's death, he became a dragonrider and rode his late father's dragon, Quicksilver. He became known to history as Aegon the Uncrowned after his uncle usurped the Throne.");
        }

        private void rhaenaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The eldest of the six children of King Aenys I Targaryen and Queen Alyssa Velaryon. She was a dragonrider and rode the dragon Dreamfyre. Following her marriage to King Maegor I Targaryen, Rhaena became known as one of his Black Brides. During the reign of her brother, Jaehaerys I Targaryen, Rhaena became known as the Queen in the West during her time on Fair Isle, and as the Queen in the East during the years she held Dragonstone.");
        }

        private void aereaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The eldest daughter of Prince Aegon and Princess Rhaena Targaryen. She had a younger twin sister, Rhaella. Aerea disappeared from Dragonstone towards the end of 54 AC, claiming and flying away on the dragon Balerion, who had made his lair on the island after the death of his previous rider, King Maegor I Targaryen.");
        }

        private void rhaellaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Septa Rhaella, born Rhaella Targaryen, was a daughter of Prince Aegon and Princess Rhaena Targaryen. She had an older twin sister, Aerea.");
        }
    }
}
