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
    public partial class gimliTree : Form
    {
        public gimliTree()
        {
            InitializeComponent();
        }

        private void nainButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Náin II was the King of Durin's Folk for 97 years, succeeding his father Óin upon his death in T.A. 2488, being the heir of Durin the Deathless.");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lotrTree T1 = new lotrTree();
            T1.ShowDialog();
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dainButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dáin was the son of King Náin II, and he had a younger brother Borin. He had three children, Thrór, Frór, and Grór. Dáin flourished during the period when the House of Durin was seated in the Grey Mountains. He succeeded his father when the Dragons of the north had declared war against the Dwarves of the Grey Mountains. Dáin ruled for only four years his people, who were troubled by increasing attacks from his halls until he met his premature end when both he and his second son, Frór, were killed by a Cold-drake at his gates.");
        }

        private void borinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borin was the younger son of King Náin II. During his youth, the House of Durin lived in the dragon-plagued Grey Mountains that were ruled by his brother Dáin I. Through his son, Farin, Borin was the ancestor of four of the thirteen Dwarves of Thorin and Company (Balin, Dwalin, Óin, and Glóin) and Gimli Elf-friend of the Company of the Ring.");
        }

        private void throrButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thrór was King of Durin's Folk for 201 years, from 2589 to 2790. He was the eldest son of Dáin I and brother of Grór and Frór. After a great Cold-drake killed both his father and brother Frór, the remaining brothers Thrór and Grór led their people away from the Grey Mountains. As Dáin's heir Thrór led many Dwarves back to Lonely Mountain in T.A. 2590, where he became King under the Mountain, a title held earlier by his ancestor, Thorin I. Grór continued east with a great following of Durin's folk to the Iron Hills, where he founded his own realm.");
        }

        private void farinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Farin was one of the Dwarves of the Grey Mountains. When his uncle King Dáin I and cousin Frór had been slain by a Cold-drake, his people were forced to flee the dragon-plagued Grey Mountains while he was just 29 years old. Farin's father, Borin, joined Thrór when he rebuilt the Kingdom under the Mountain in 2590.");
        }

        private void thrainButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thráin II was King of Durin's Folk for 60 years, from T.A. 2790 to 2850, during their exile from Lonely Mountain. He was the son of Thrór and father of Thorin II, Frerin, and Dís. In T.A. 2790 Nár returned to tell Thráin that his father had been captured and butchered by the Orc-chieftain Azog when they had journeyed to the mines of Moria. Even worse, Azog had beheaded Thrór and carved his own name on Thrór's forehead to show the Dwarves that an Orc now ruled their ancestral home.");
        }

        private void fundinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fundin was a dwarf of the royal line of Durin's folk, the great-grandson of King Náin II. He was the son of Farin and the older brother of Gróin.");
        }

        private void groinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gróin was an important figure in the royal genealogies of the Dwarves, Gróin was the grandson of Borin, the younger son of King Náin II, and so could claim direct descent from Durin the Deathless himself. In his turn, Gróin was the younger brother of Fundin, father to Óin and Glóin, and uncle to Balin and Dwalin, all four of whom travelled on the Quest of Erebor.");
        }

        private void balinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Balin was a Dwarven leader, the son of Fundin and elder brother of Dwalin and a member of Durin's Folk. He was one of the Dwarves that travelled with Bilbo Baggins and Gandalf to reclaim Erebor. Though the riches of Erebor made the Dwarves prosperous again, there were many who longed to return to Moria. Dáin Ironfoot counseled against it, but Balin mounted an expedition in T.A. 2989. They hoped to regain the treasures, and Balin had also hoped to find the Ring of Thrór, which was assumed to be lost when Thrór entered the Gates years before. For five years the colony thrived. They managed to find many old treasures, mithril, and armouries. But on 10 November T.A. 2994, as Balin went to look in Mirrormere, an orc archer fatally shot him. Balin's body was placed in a tomb in the Chamber of Mazarbul.");
        }

        private void dwalinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Dwarf of the House of Durin. He was, along with his brother Balin, a member of Thorin's company which took part in the Quest of Erebor to reclaim the Lonely Mountain from the dragon Smaug. Dwalin survived the adventure and lived well into the Fourth Age.");
        }

        private void priscaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("He was one of the Dwarves of Thorin's company who set out to reclaim Erebor from Smaug. Later, he followed Balin in an ill-fated attempt to retake Moria.");
        }

        private void gloinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Glóin was a dwarf of Durin's Folk, the son of Gróin, the brother of Óin, and the father of Gimli of the Fellowship of the Ring. He is most famous as one of Thorin's companions on the quest to Erebor. He later attended the Council of Elrond with his son Gimli, years after the Quest of Erebor.");
        }

        private void gimliButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gimli, also known as Gimli Elf-Friend, was a dwarf of the House of Durin who became famous as the only Dwarven member of the Fellowship of the Ring. In Aglarond, it is assumed, he lived on until he was old, and in Fo.A. 120 he sailed with Legolas his 'friend' across Belegaer to Valinor, becoming the first and only Dwarf to do so.");
        }

        private void thorinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thorin II 'Oakenshield', eventually called King under the Mountain or Mountain King, was the son of Thráin II, the older brother of Frerin and Dís, the grandson of King Thrór and the uncle of Fíli and Kíli. Thorin was best known for his deeds as leader of a company that infiltrated the lost Kingdom under the Mountain to take it back from Smaug and for leading an alliance of Men, Dwarves, and Elves in the Battle of Five Armies.");
        }
    }
}
