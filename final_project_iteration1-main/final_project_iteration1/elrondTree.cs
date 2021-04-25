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
    public partial class elrondTree : Form
    {
        string[] dunedain = new string[15] { "Here are the Chieftains of the Dunedain in order: ", "Aranarth,", "Arahael,", "Aranuir,", "Aravir,", "Aragorn I,", "Araglas,", "Arahad I,", "Aragost,", "Aravorn, ", "Arahad II", "Arassuil,", "Arathorn I,", "Argonui, ", "and Arador." };

        public elrondTree()
        {
            InitializeComponent();
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

        private void finweButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finwë was the first High King of the Ñoldor who led his people on the journey from Middle-earth to Valinor in the blessed realm of Aman. He was a great friend of Elu Thingol, the King of Doriath.");
        }

        private void indisButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("She was the niece of Ingwë, the King of the Vanyar and High King of the Elves, for her mother was Ingwë's sister. Indis was known for her great beauty and was thus referred to as Indis the Fair.");
        }

        private void thingolButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elu Thingol was an Elf of the Teleri during the First Age. His brother was Olwë, who became the Lord of Alqualondë, Lord of Tol Eressëa, and High King of the Teleri of Aman, both of whom may have had a second brother called Elmo. He was a good friend of Finwë, the first High King of the Ñoldor during the times before the elves reached Aman.");
        }

        private void melianButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Melian was an Ainu of the race of the Maiar of Yavanna, wife of King Elu Thingol, Queen of Doriath and mother of Lúthien Tinúviel. Melian was the fourth greatest and most powerful of all the Maiar. In Middle-earth, she surpassed everyone in both wisdom and beauty.");
        }

        private void fingolfinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fingolfin was the second High King of the Ñoldor in Beleriand; the Ñoldor being one of the three branches of Elves. He was the eldest son of Finwë and Indis, younger brother of Findis, older brother of Irimë and Finarfin, and the younger half-brother of Fëanor. He founded the House of Fingolfin, which ruled the Ñoldor in Middle-earth.");
        }

        private void anaireButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Little is known of Anairë's life; only that she chose not to follow her husband to Middle-earth during their departure from Aman. They had four children during the Noontide of Valinor, namely Fingon, Turgon, Aredhel, and Argon. Anairë was known to be friends with Eärwen, Finarfin's wife. It is assumed that she continued to reside in Aman along with the other Elves of Valinor.");
        }

        private void berenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beren, also called Beren Erchamion, was a man of the First House of the Edain, and a hero whose romance with an Elf-maiden Lúthien was one of the great stories of the Elder Days that were told for many ages after he lived.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lúthien, also known as Tinúviel, was an Elf-maiden of Doriath, the wife of Beren Erchamion, and the most beautiful of all the Children of Ilúvatar to ever live. Her love of the mortal Adan Beren, for whom she was prepared to risk everything, including her life, was legendary and lamented forever in song and story. She and Beren braved Morgoth's horrors, eventually winning the Silmaril from his crown and the approval of their marriage by King Thingol.");
        }

        private void turgonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turgon was a Ñoldorin Elf of Gondolin, second son of Fingolfin, brother of Fingon, Aredhel, Argon, and father of Idril. In Middle-earth, Turgon was the King of Gondolin and the High King of the Ñoldor. For centuries of the First Age, Turgon remained successfully hidden from Morgoth until a betrayal from within Gondolin brought its downfall.");
        }

        private void elenweButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elenwë was probably born in Valinor sometime during the Noontide of Valinor. Elenwë followed her husband to Middle-earth when his brethren resolved to join the House of Fëanor in pursuit of Melkor and regain the Silmarils. Unfortunately, she along with many others died during the crossing of Helcaraxë, while Turgon almost perished himself trying to save her. It was said that her body was covered in ice and was therefore unable to be saved.");
        }

        private void nimlothButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nimloth later married Dior the Fair, her second cousin, making her an heir of Melian, Queen of Doriath. In the few years before the death of Thingol, she lived near the land of Lanthir Lamath at the base of the Blue Mountains in the Northeast. There her children Eluréd, Elurín and Elwing were born.");
        }

        private void diorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dior, also called Dior Eluchîl, was the son of Beren the One-handed of the House of Bëor (First House of the Edain) and the Elven-princess Lúthien of Doriath. He later became the King of Doriath as the heir of King Thingol, and thus became the High King of the Sindar. Dior the Fair was one of the Half-elven for his father was of the race of Men, and his mother was Elven.");
        }

        private void idrilButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Idril, also called Celebrindal, was a Ñoldorin Elf of Gondolin. She was the daughter of Turgon and Elenwë, wife of the Man Tuor, and mother of Eärendil the Mariner, a Half-elven.");
        }

        private void tuorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tuor was an Adan of the House of Hador and a great hero of Men; the only son of Huor and Rían. He was the cousin of Túrin Turambar.");
        }

        private void elwingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elwing also known as Elwing the White, was the daughter of Dior the Fair and his wife Nimloth. She was the younger sister of the twin brothers Eluréd and Elurín. She became the wife of Eärendil the Mariner, and was the mother of Elrond and Elros.");
        }

        private void eluredButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eluréd and Elurín were both born in the short-lived renewed Kingdom of Doriath under their father Dior. They were named after their great-grandfather Elu Thingol, the King of Doriath. They had a younger sister named Elwing. The boys lived peacefully with their father and mother in Menegroth until the dreaded Oath of Fëanor descended on Doriath due to Dior's failure to turn over the Silmaril, under the threat of war. When the Sons of Fëanor attacked, the twins were seized by the cruel servants of Celegorm and abandoned in the forest to die. However, Maedhros, the eldest of the Sons of Fëanor, bitterly regretted this deed and sought in vain for them in the surrounding forest.");
        }

        private void elurinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eluréd and Elurín were both born in the short-lived renewed Kingdom of Doriath under their father Dior. They were named after their great-grandfather Elu Thingol, the King of Doriath. They had a younger sister named Elwing. The boys lived peacefully with their father and mother in Menegroth until the dreaded Oath of Fëanor descended on Doriath due to Dior's failure to turn over the Silmaril, under the threat of war. When the Sons of Fëanor attacked, the twins were seized by the cruel servants of Celegorm and abandoned in the forest to die. However, Maedhros, the eldest of the Sons of Fëanor, bitterly regretted this deed and sought in vain for them in the surrounding forest.");
        }

        private void earendilButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eärendil was a great Half-elven mariner who voyaged to Valinor, entreated before the Valar on behalf of the Children of Iluvatar, and carried a star across the sky at the end of the First Age. His acts had been prophesied of among the Elves centuries beforehand.");
        }

        private void elrosButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elros, also known as Elros Tar-Minyatur, the Half-elven, was the son of Eärendil and Elwing, brother of Elrond, uncle of Elladan and Elrohir and Arwen Undómiel, and the first King of Númenor; ancestor to a line of kings especially to his descendant Aragorn II Elessar. He had a strong friendship with the Elves, who were half his kin.");
        }

        private void elrondButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elrond Half-elven, Lord of Rivendell, was one of the mighty Elf-rulers of old who lived in Middle-earth from the First Age to the beginning of the Fourth Age. He was the father of Arwen Undomiel, the eventual lover of Aragorn II Elessar. Elrond and Elros were given the choice at the end of the First Age to be counted among Men or Elves. Elros chose the Fate of Men and became Elros Tar-Minyatur, the first King of Númenor. Elrond chose to be counted among the Elves, and remained in Lindon as captain and herald of Gil-Galad, the High King of the Ñoldor. After the combined forces of the elves under Gil-galad, Cirdan, Elrond and the Men of Númenor defeated Sauron in SA 1701 Elrond remained in Rivendell and hosted the first White Council, attended by Galadriel, at which it was decided that Elrond's home, the Last Homely House, would remain the last stronghold west of the Misty Mountains, and that the Three Rings then held by Gil-galad and Galadriel would remain hidden. According to one account Gil-galad at this time gave Elrond Vilya the Blue Ring.");
        }

        private void galadrielButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("She was one of the greatest of the Elves in Middle-earth, surpassing nearly all others in beauty, knowledge, and power. She bore Nenya, one of the three Elven rings of power. J.R.R. Tolkien thought of her, along with Gil-galad the Elven-king, as one of the mightiest and fairest of all the Elves left in Middle-earth in the Third Age. She brought the strap.");
        }

        private void celebornButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Celeborn was the Lord of Lothlórien, and the husband of Galadriel, Lady of the Golden Wood. He was said to be one of the wisest Elves in Middle-earth at the end of the Third Age. During the War of the Ring, Celeborn defended Lothlórien and led the assault on the Enemy castle of Dol Guldur.He remained in Middle - earth for a time at the beginning of the Fourth Age, but eventually he joined his wife in the Undying Lands.");
        }

        private void celebrianButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Celebrían's birth date is unspecified, though she may have been born near Lake Evendim between SA 350 and SA 400. She lived with her mother Galadriel in Eregion, and later fled to Lórinand sometime between SA 1350 and SA 1400. After a time, Galadriel and Celebrían passed through Moria and dwelt in Rivendell. There, she met Elrond, who, though he loved her, said nothing about it. In TA 2509, Celebrían was on her way to visit her parents in Lothlórien when she was waylaid by Orcs in the Redhorn Pass of the Misty Mountains. She was then tormented by the orcs and received a poisoned wound. Her sons arrived much later to rescue her, and Elrond healed her wounds, but Celebrían was never fully-healed in mind and spirit. Horrified and haunted by the memories of her torture, she no longer desired to remain in Middle-earth, and sailed west the next year.");
        }

        private void dunedainButton_Click(object sender, EventArgs e)
        {
            string msg = string.Join(Environment.NewLine, dunedain);
            MessageBox.Show(msg);
        }

        private void aragornButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aragorn II was the son of Arathorn II and Gilraen. He was the last Chieftain of the Dúnedain and a direct descendant through many generations of Isildur, the last High King of both Arnor and Gondor. Aragorn would become the greatest Man of his time, leading the Men of the West against Sauron's forces, helping to destroy the One Ring, and reuniting the Kingdoms of Arnor and Gondor.");
        }

        private void arwenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arwen Undómiel, also known as Arwen Evenstar, was one of the half-elven, married to Aragorn II. She was the daughter of Elrond and Celebrían.");
        }

        private void elladanButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elladan and Elrohir were the twin sons of Elrond the Half-elven and Celebrían of Rivendell, and were noted for their close friendship and cooperation with the Dúnedain of the North, Rangers of the North and Men in general, and for their deeds during the War of the Ring.");
        }

        private void elrohirButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elladan and Elrohir were the twin sons of Elrond the Half-elven and Celebrían of Rivendell, and were noted for their close friendship and cooperation with the Dúnedain of the North, Rangers of the North and Men in general, and for their deeds during the War of the Ring.");
        }

        private void eldarionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eldarion became the second King of the Reunited Kingdom after the death of his father Elessar in Fo.A. 120. At the time of his ascending to the throne, Eldarion was 'full ripe and ready for kingship'.It is known that Eldarion was given the tokens of kingship(Andúril, etc.) by his father, who died soon after the crowning of his son. He was also recorded to have several sisters.");
        }

        private void daughterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aragorn Elessar and Arwen Evenstar are said to have had several daughters, though there names are never stated cause J.R.R. Tolkien's sexist or whatever.");
        }
    }
}
