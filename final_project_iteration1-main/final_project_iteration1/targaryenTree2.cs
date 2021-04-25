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
    public partial class targaryenTree2 : Form
    {
        
        public targaryenTree2()
        {
            InitializeComponent();
        }

        private void targaryenTree2_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            targaryenTree f1 = new targaryenTree();
            this.Hide();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            House_Targaryen3 f3 = new House_Targaryen3();
            this.Hide();
            f3.ShowDialog();
        }

        private void jaeherysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jaehaerys the Conciliator, the Old King, and Jaehaerys the Wise. Fourth Lord of the Seven Kingdoms, as King Jaehaerys I Targaryen. He rode Vermithor.");
        }

        private void alysanneButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Good Queen Alysanne, was the queen consort of her brother, King Jaehaerys I Targaryen. Alysanne was a dragonrider whose mount was Silverwing.");
        }

        private void variousButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jaeherys and Alysanne had many other children, too many to fit onto a tree. Their names are as follows: Aegon, Daenerys, Aemon, Daella, Gaemon, Valerion, Vaegon, Maegelle, Viserra, Saera, and Gael.");
        }

        private void baelonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as the Spring Prince, for the season of his birth, and the Brave, was a member of House Targaryen and was the fourth born child of King Jaehaerys I Targaryen and Queen Alysanne Targaryen. He had three sons himself, Princes Viserys, Daemon and Aegon. Baelon was a dragonrider whose mount was Vhagar.");
        }

        private void alyssaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Princess Alyssa Targaryen was the fifth born child of King Jaehaerys I Targaryen and Queen Alysanne Targaryen. Alyssa was a dragonrider whose dragon was Meleys, the Red Queen.");
        }

        private void viserysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The fifth Targaryen king to sit the Iron Throne, ruling from 103 AC to 129 AC. He succeeded his grandfather, the Old King Jaehaerys I. Viserys continued the prosperous peace and legacy of his grandsire, but the seeds for the civil war known as the Dance of the Dragons that would much later engulf the realm were inadvertently sown in his reign. Viserys was a dragonrider who rode Balerion until the dragon died of old age during the reign of Jaehaerys I. Viserys never bonded with another dragon after Balerion's death.");
        }

        private void alicentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A member of House Hightower who became the second wife to King Viserys I Targaryen. She was the daughter of Ser Otto Hightower, who had been Hand of the King to Jaehaerys I, Viserys I, and later his grandson Aegon II. She was the mother of King Aegon II, Queen Helaena, Prince Aemond and Prince Daeron.");
        }

        private void aemmaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The queen consort and first wife of King Viserys I Targaryen, and a granddaughter of King Jaehaerys I Targaryen and his sister-wife, Queen Alysanne Targaryen.");
        }

        private void rhaenyraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cheered as the Realm's Delight when she was young and later called the Half-Year Queen, Rhaenyra was the first-born child of King Viserys I Targaryen. Rhaenyra was King Viserys I's only living child by his first wife, Queen Aemma of House Arryn. At the age of eight she was made her father's heir and grew up expecting to become the first ruling Queen of Westeros. Rhaenyra was a dragonrider whose mount was Syrax.");
        }

        private void daemonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uncle and husband of Princess Rhaenyra Targaryen, whose claim he supported in the Dance of the Dragons. He was Rhaenyra's second husband, following Ser Laenor Velaryon. He was a younger son of Prince Baelon Targaryen, and brother to King Viserys I Targaryen.");
        }

        private void aegonButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Aegon the Elder, Aegon was the sixth Targaryen king to sit the Iron Throne, succeeding his father, Viserys I Targaryen, as Lord of the Seven Kingdoms. His ascent was disputed by his older half-sister, Princess Rhaenyra Targaryen, who had been their father's designated heir. Aegon and Rhaenyra fought for the throne in the civil war the singers called the Dance of the Dragons, in which both siblings perished.");
        }

        private void halaenaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the sister-wife to King Aegon II Targaryen. She was the only daughter of King Viserys I Targaryen by his second wife, Queen Alicent Hightower, and his second daughter overall. Helaena and Aegon had three children: the twins Jaehaerys and Jaehaera, and Maelor. Like her siblings, Helaena was a dragonrider, who rode the dragon Dreamfyre.");
        }

        private void viserysButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The tenth Targaryen king to sit the Iron Throne as Lord of the Seven Kingdoms. He was the son of Rhaenyra Targaryen and Daemon Targaryen, the brother and Hand of King Aegon III Targaryen, and the father of King Aegon IV Targaryen, Queen Naerys Targaryen, and Prince Aemon 'the Dragonknight'.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A member of House Rogare of Lys. She married Prince Viserys Targaryen, the younger brother of King Aegon III Targaryen. With Viserys, Larra had three children: King Aegon IV, Prince Aemon, and Queen Naerys Targaryen. She eventually abandoned Viserys and returned to Lys.");
        }

        private void aegonButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Known as Aegon the Unworthy, was the eleventh Targaryen to sit the Iron Throne, and is considered to be one of the worst Targaryen kings. He sired numerous bastards, legitimizing them on his deathbed, an act that led to five Blackfyre Rebellions.");
        }

        private void aegonButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Aegon the Younger, and later as Aegon the Unlucky, Aegon the Unhappy, the Broken King, and most famously as Aegon the Dragonbane, was the seventh Targaryen king to sit the Iron Throne. He succeeded his uncle, Aegon II Targaryen, at the conclusion of the Dance of the Dragons, which saw the victorious supporters of his late mother Rhaenyra Targaryen install him on the throne. When he was a child, his dragon was Stormcloud.");
        }

        private void jaehaeraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("She was the first wife and queen of her cousin King Aegon III Targaryen. Jaehaera had a twin brother, Jaehaerys, and a younger brother, Maelor.[3] The dragon Morghul was bound to Jaehaera. Two years after her marriage, Jaehaera died when she reportedly threw herself from Maegor's Holdfast and was impaled on the spikes of the dry moat below. She lived for a half hour in agony before her death. With her ended the line of the marriage of King Viserys I Targaryen and his second wife, Queen Alicent Hightower.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The queen consort and second wife of King Aegon III Targaryen, and a member of House Velaryon. Daenaera was the daughter of Daeron Velaryon, a cousin of Lord Alyn Velaryon, and his wife, Hazel Harte.");
        }

        private void daeronButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Known as the Young Dragon and the Boy King, was the eldest son of King Aegon III Targaryen and Queen Daenaera Velaryon, and the eighth Targaryen king to sit the Iron Throne. He ascended to the throne at the age of fourteen and is famous for invading Dorne, which he wrote about in his The Conquest of Dorne.");
        }

        private void baelorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Known as Baelor the Beloved and Baelor the Blessed, was the ninth Targaryen king to reign on the Iron Throne as Lord of the Seven Kingdoms. Known for his piety, Baelor was a septon as well as a king. He was the second son of King Aegon III Targaryen and Queen Daenaera Velaryon, and ruled after the death of his older brother, King Daeron I Targaryen.");
        }

        private void daenaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Daena the Defiant, was the eldest daughter of King Aegon III Targaryen and Queen Daenaera Velaryon. She was the sister-wife of King Baelor I Targaryen, and was the mother of Daemon Blackfyre, her bastard son by the future King Aegon IV Targaryen.");
        }

        private void naerysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A member of House Targaryen and the sister-wife to King Aegon IV, who was known as the Unworthy. Naerys was the sister of Prince Aemon the Dragonknight, and the mother of King Daeron II Targaryen and Princess Daenerys Targaryen.");
        }

        private void aemonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as the Dragonknight, was the second son of King Viserys II Targaryen and his wife, Lady Larra Rogare. Aemon joined the Kingsguard during the reign of his uncle, King Aegon III Targaryen, at the age of seventeen, and eventually rose to become Lord Commander. After Aegon III, Aemon served four other kings. He died saving the life of his brother, King Aegon IV Targaryen.");
        }

        private void daemonbButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daemon I Blackfyre, born Daemon Waters, was the bastard son of Princess Daena Targaryen and King Aegon IV Targaryen.[4] Daemon founded House Blackfyre, named after the Targaryen Valyrian steel sword. He fought against his trueborn half-brother, King Daeron II Targaryen, for the Iron Throne in the First Blackfyre Rebellion.");
        }

        private void daeronButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daeron II, also known as Daeron the Good, was the twelfth Targaryen to sit the Iron Throne. Daeron brought Dorne peacefully into the realm, uniting all the lands of Westeros south of the wall. His bastard half-brother, Daemon Blackfyre, challenged his rule and the result was a terrible civil war, the First Blackfyre Rebellion. Daeron died during the Great Spring Sickness in 209 AC.");
        }

        private void myriahButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Princess Myriah Nymeros Martell was the wife and queen consort of King Daeron II Targaryen.");
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            House_Targaryen3 f3 = new House_Targaryen3();
            this.Hide();
            f3.ShowDialog();
        }
    }
}
