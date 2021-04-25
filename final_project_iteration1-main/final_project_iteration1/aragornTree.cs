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
    public partial class aragornTree : Form
    {
        string[] arnor = new string[8] {"Here are the kings in the Realm of Arnor in order: ", "Eldacar, ", "Arantar, ",  "Tarcil, ", "Tarondor, ", "Valandur, ", "Elendur, ", "and Earendur."};
        string[] arthedain = new string[16] { "Here are the kings in the Realm of Arthedain in order: ", "Amlaith, ", "Beleg, ", "Mallor, ", "Celepharn, ", "Celebrindor, ", "Malvegil, ", "Argeleb I, ", "Arveleg I, ", "Araphor, ", "Argeleb II, ", "Arvegil, ", "Arveleg II, ", "Araval, ", "Araphant, ", "and Arvedui." };
        string[] dunedain = new string[15] { "Here are the Chieftains of the Dunedain in order: ", "Aranarth,", "Arahael,", "Aranuir,", "Aravir,", "Aragorn I,", "Araglas,", "Arahad I,", "Aragost,", "Aravorn, ", "Arahad II", "Arassuil,", "Arathorn I,", "Argonui, ", "and Arador."};


        public aragornTree()
        {
            InitializeComponent();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lotrTree T1 = new lotrTree();
            T1.ShowDialog();
        }

        private void arnorButton_Click(object sender, EventArgs e)
        {
            string msg = string.Join(Environment.NewLine, arnor);
            MessageBox.Show(msg);
        }

        private void arthedainButton_Click(object sender, EventArgs e)
        {
            string msg = string.Join(Environment.NewLine, arthedain);
            MessageBox.Show(msg);
        }

        private void dunedainButton_Click(object sender, EventArgs e)
        {
            string msg = string.Join(Environment.NewLine, dunedain);
            MessageBox.Show(msg);
        }

        private void elendilButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elendil was the father of Isildur and Anárion, a survivor of the Downfall of Númenor, and the founder and first High King of the Dúnedain in Middle-earth. Gil-galad and Elendil fought Sauron and cast him down, but were both slain, and Elendil's sword Narsil was broken when he fell. His son used the broken sword to cut the One Ring from Sauron's hand.");
        }

        private void isildurButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Isildur was the eldest son and heir of Elendil, the first High King of the Realms in Exile. Elendil and Gil-galad threw down Sauron, thus winning the battle though both were slain and Elendil's sword Narsil broke under him as he fell. Isildur took the hilt shard of his father's sword and cut the One Ring from Sauron's finger. Ignoring the advice of Elrond and Círdan, lieutenant of Gil-galad, Isildur did not destroy the Ring; instead he claimed it as a weregild for the deaths of his father and brother, and an heirloom for his House. This led to his death.");
        }

        private void elendurButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elendur was the eldest son and Heir of Isildur, slain with his father in the Disaster of the Gladden Fields.");
        }

        private void aratanButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the War of the Last Alliance of Elves and Men, Aratan and his brother Ciryon did not participate in the Siege of Barad-dûr. Isildur had sent these two brothers to man Minas Ithil so as to guard Cirith Dúath and prevent a possible breakout of Sauron should he escape the siege.");
        }

        private void ciriyonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the Disaster of the Gladden Fields, Ciryon was the first brother to die; Aratan was mortally wounded while trying to save him. After the fall of these two brothers, Elendur advised his father to put on the One Ring and escape.");
        }

        private void valandilButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The third King of Arnor, succeeding his father, High King Isildur, after he and Valandil's older brothers were killed in the Disaster of the Gladden Fields in T.A. 2.");
        }

        private void arathornButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The fifteenth Chieftain of the Dúnedain and succeeded his father, Arador, when he was killed in 2930. He was the father of Aragorn II, King of the Reunited Kingdom.");
        }

        private void gilraenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gilraen the Fair was a Dúnadan of the North, the daughter of Dírhael and Ivorwen, and a descendant of the first chieftain, Aranarth.");
        }

        private void aragornButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aragorn II was the son of Arathorn II and Gilraen. He was the last Chieftain of the Dúnedain and a direct descendant through many generations of Isildur, the last High King of both Arnor and Gondor. Aragorn would become the greatest Man of his time, leading the Men of the West against Sauron's forces, helping to destroy the One Ring, and reuniting the Kingdoms of Arnor and Gondor.");
        }

        private void arwenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arwen Undómiel, also known as Arwen Evenstar, was one of the half-elven, married to Aragorn II. She was the daughter of Elrond and Celebrían.");
        }

        private void eldarionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eldarion became the second King of the Reunited Kingdom after the death of his father Elessar in Fo.A. 120. At the time of his ascending to the throne, Eldarion was 'full ripe and ready for kingship'.It is known that Eldarion was given the tokens of kingship(Andúril, etc.) by his father, who died soon after the crowning of his son. He was also recorded to have several sisters.");
        }
    }
}
