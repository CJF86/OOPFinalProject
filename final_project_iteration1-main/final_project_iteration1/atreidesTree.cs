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
    public partial class atreidesTree : Form
    {
        public atreidesTree()
        {
            InitializeComponent();
        }
        
        private void skourosButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Later known as Agememnon Cymek, the ruthless leader of the Cymek Titans, the biological father of Vorian Atreides, and a key figure in history leading up to the Butlerian Jihad.");
        }

        private void agamemnonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("King Agamemnon was a military ruler from ancient Greece, a member of the House of Atreus who fought in the Trojan War.");
        }

        private void vorianButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vorian's main role in the thinking machine empire was to accompany the robot Seurat on one of Omnius' update ships, the Dream Voyager, travelling around through the Synchronized Worlds and delivering various updates of the computer evermind. He was entirely loyal to his father, General Agamemnon, and absolutely believed everything that he said, because he wished to become a cymek and a Titan like him.");
        }

        private void miklosButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Miklos Atreides, was the father of Kean Atreides, grandfather of Paulus Atreides, great-grandfather of Leto Atreides I, and great-great grandfather of Paul Atreides. Thus, Miklos was the 23rd Duke Atreides.");
        }

        private void keanButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("According to Reverend Mother Cienna, Kean, much like Paulus and Leto I, had been 'a man of impeccable credentials, a man of honor.'");
        }

        private void paulusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as the Old Duke, was the son of Kean Atreides, grandson of Miklos Atreides, and the 25th Duke Atreides. Paulus married Helena Richese, and fathered a single son, Leto Atreides I. Paulus posthumously became the grandfather to Paul Atreides (who was named in his honor), and great-grandfather to Leto Atreides II (the God-Emperor) and Ghanima Atreides. Duke Paulus regularly engaged in bullfights, until he lost his life to a drugged Salusan bull.");
        }

        private void helenaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Her marriage to Paulus was political in nature, and the couple had little in common and limited love for one another. Partly as a result of this and partly because of Helena's continued allegiance to House Richese, they gradually drifted apart until they were on acrimonious terms. She did, however, maintain a perfect front during important meetings and public events and fussed about her own appearance. During her spare time, she preferred to study the Orange Catholic Bible and other religious texts.");
        }

        private void letoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Leto the Just, born in planet Caladan, only son of the Old Duke Paulus Atreides and Lady Helena (born Richese). Therefore, he claimed Atreides heritage from his father, and Richese and Corrino through his mother. With his first concubine, Kailea Vernius, he was father of Victor Atreides, deceased at 6 years old. With his Bene Gesserit concubine, Lady Jessica, he was father of Emperor Paul Atreides and Regent Alia. Grandfather of Leto Atreides II, the God - Emperor, and Ghanima.");

        }

        private void jessicaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lady Jessica of the Atreides was the official concubine of Duke Leto Atreides I, and the mother of his son Emperor Paul Atreides, and of the Regent Alia Atreides. She was also a Reverend Mother of the Bene Gesserit Sisterhood.");
        }

        private void paulButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Muad'Dib, Usul, and The Preacher (10175 AG - 10220 AG), born on the planet Kaitain, son of Duke Leto Atreides I and Bene Gesserit concubine Lady Jessica. Oldest brother of Alia Atreides. He married Bene Gesserit - trained Irulan Corrino, but without offspring.With his Fremen concubine Chani Kynes, was father of the twins Ghanima and Leto Atreides II, the God - Emperor. Twenty - first and last Duke of House Atreides, leader of the Fremen, and first ruler of the Atreides Empire.He was considered the Kwisatz Haderach, the powerful prescient being, long sought by the Bene Gesserit and product of their lengthy breeding program.");
        }

        private void aliaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also known as Saint Alia of the Knife (10191 AG - 10219 AG), born in planet Arrakis. Posthumous daughter of Duke Leto Atreides I and his Bene Gesserit concubine Lady Jessica, was the younger sister of Paul Atreides. Regent of the Atreides Empire, she established an autocratic government based on the cult of her personality.She was killed by her nephew Leto Atreides II, the God - Emperor.");
        }

        private void chaniButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paul's prescience begins manifesting itself through dreams while he is still living in his ancestral home on the planet Caladan; he sees Chani in these visions, though they have not yet met. Paul and the Atreides come to the desert planet Arrakis, but Paul's father Duke Leto is soon killed by the Harkonnens and Paul and his mother Lady Jessica are forced to flee into the desert. They are reluctantly taken in by a tribe of the planet's native Fremen, and Chani is the Fremen woman put in charge of protecting and guiding Paul. They soon become lovers, and Paul rises as a religious leader among the Fremen, and is called Muad'Dib. Her death shatters Paul.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leto is the son of Paul Atreides and his Fremen concubine Chani, and the twin brother of Ghanima. Leto is named for his paternal grandfather Duke Leto Atreides I, who is killed in the Harkonnen/Imperial invasion of the desert planet Arrakis. Rises to God Emperor.");
        }

        private void ghanimaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("She is the daughter of Paul Atreides and his Fremen concubine Chani, and the twin sister to Leto Atreides II. Like her aunt Alia and her brother Leto, Ghanima is pre-born; Chani had consumed so much melange during her pregnancy that Leto and Ghanima had awakened to full, adult consciousness before birth, receiving the genetic memories of both their male and female ancestors.");
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DuneTree D1 = new DuneTree();
            D1.ShowDialog();
        }
    }
}
