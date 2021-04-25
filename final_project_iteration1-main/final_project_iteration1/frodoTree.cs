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
    public partial class frodoTree : Form
    {
        public frodoTree()
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

        private void frodoTree_Load(object sender, EventArgs e)
        {

        }

        private void balboButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Balbo was born when the Shire was recovering from both the Days of Dearth where Gandalf came to the aid of the Hobbits. albo was the original patriarch of the Baggins Family, being the first recorded member of the respected family of Hobbits.");
        }

        private void melianButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berylla's brother was Basso, who is said to have 'gone to sea' in S.R. 1195 at the age of 26.");
        }

        private void mungoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mungo was the eldest child of Balbo Baggins and Berylla Boffin. He married Laura Grubb, and they had five children together: Bungo, Belba, Longo, Linda and Bingo.");
        }

        private void lauraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laura was a sister of Lavender Grubb. She married Mungo Baggins and among their children was Bilbo Baggins' father Bungo.From T.A. 2900 to 2916 Laura Grubb was the official matriarch of the Baggins Family.");
        }

        private void pansyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pansy was the daughter of Balbo Baggins and Berylla Boffin. She married Fastolph Bolger, and had various descendants.");
        }

        private void fastolphBolger_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fastolp was the son of Rudolph Bolger and Cora Goodbody. He married Pansy Baggins and had various descendants.");
        }

        private void mimosaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mimosa married Ponto Baggins. They had two children; Rosa was born in S.R. 1256, and Polo Baggins shortly thereafter.");
        }

        private void pontoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ponto was the middle child of Balbo and Berylla Baggins. He married Mimosa Bunce, with whom he had two children: Rosa and Polo. Ponto died in S.R. 1311, the year when the Shire suffered from the Fell Winter.");
        }

        private void lilyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lily was a daughter of Balbo Baggins and Berylla Boffin. She married Togo Goodbody and had many descendants. During the last years of her life, the Shire suffered from the Fell Winter, and around that time she lost her elder brother Ponto. Lily died the next year, as did her other brother, Largo.");
        }

        private void tantButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tanta married Largo Baggins, and was the mother of Fosco Baggins.");
        }

        private void largoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Largo was a son of Balbo Baggins. He married Tanta Hornblower, and had one child, Fosco. The last years of his life the Shire suffered from the Fell Winter and around that time he lost his elder brother Ponto. Largo died the next year, as did his younger sister Lily.");
        }

        private void bungoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bungo Baggins was a well-to-do Hobbit, and the father of Bilbo Baggins. Father and son were so much alike, in looks and behaviour, that Bilbo seemed like a 'second edition' of his 'solid and comfortable' father. Apart from fathering Bilbo, Bungo's other achievements were that he built and excavated the rather luxurious Bag End in the Hill in Hobbiton and that he laid down several bottles of Old Winyards wine that would be enjoyed by Rorimac Brandybuck after Bilbo's Farewell Party and by the small party on 21 September T.A. 3018 that Frodo Baggins gave before leaving Bag End.");
        }

        private void belladonnaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Belladonna was one of the three remarkable daughters of the Old Took. She had eight older brothers (and one younger), and was the eldest of the three daughters.[2] Belladonna married Bungo Baggins, who built a spacious hole for her (partly with her money). It became the residence of the Baggins Family, and in 2890, her son and only child Bilbo was born. She died in 2934, eight years after her husband.");
        }

        private void otherButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mungo and Laura had several other children. Their names are as follows: Belba, Longo, Linda, and Bingo.");
        }

        private void hildigrimButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hildigrim was the third son of the Old Took. He married Rosa Baggins, with whom he had one son, Adalgrim.");
        }

        private void rosaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rosa was the daughter of Ponto Baggins and Mimosa Bunce. She married Hildigrim Took, son of the Old Took. They had only one child, Adalgrim, born in 1280.");
        }

        private void poloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Polo was the second child, and only son, of Ponto Baggins and Mimosa Bunce. In his turn, Polo also had a son and a daughter, Posco and Prisca.");
        }

        private void rubyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The daughter of Adalgar Bolger, Ruby married Fosco Baggins. They had three children: Dora, Drogo and Dudo.");
        }

        private void fosco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fosco was the son of Largo Baggins and Tanta Hornblower. He married Ruby Bolger, and had three children: Dora, Drogo and Dudo.");
        }

        private void bilboButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilbo Baggins was a Hobbit who lived in The Shire during the final years of the Third Age. His adventure with the dwarves Thorin and company earned him a fortune, and brought the One Ring of Sauron back into knowledge. He lived a very pleasant life of retirement in Rivendell: eating, sleeping, writing poetry, and working on his memoir, There and Back Again and wrote a book called Translations from the Elvish. Two years later, however, Bilbo as a former ringbearer accompanied Frodo Baggins, Gandalf, and certain Elves to the Grey Havens, there to take ship for the West, on 29 September, T.A. 3021. He had already celebrated his 131st birthday, becoming the oldest Hobbit in the history of Middle-earth. As a mortal, he died in the West.");
        }

        private void adalgrimButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adalgrim was the only child of Hildigrim Took and Rosa Baggins. He had five children, four of them daughters. His youngest children were Paladin and Esmeralda, born in S.R. 1333 and S.R. 1336.");
        }

        private void priscaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prisca was the second child and daughter of Polo Baggins. She married Wilibald Bolger, and had several children: Wilimar, Heribald and Nora. Her husband passed away before S.R. 1401, but she attended Bilbo's Farewell Party with her children.");
        }

        private void poscoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Posco was the son of Polo Baggins and a cousin of Bilbo Baggins. He married Gilly Brownlock, and together they had several children: Ponto, Porto, Peony. While his family and descendants attended his cousin's Bilbo's Farewell Party in S.R. 1401, he did not.");
        }

        private void primulaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Primula was the youngest daughter[1] of Gorbadoc Brandybuck and Mirabella Took. She married Drogo Baggins, with whom she had one child, Frodo. In late S.R. 1380, she and her husband drowned when they went boating on the Brandywine River.");
        }

        private void drogoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drogo Baggins was the second child, and oldest son, of Fosco Baggins and Ruby Bolger, born in S.R. 1308. He married Primula Brandybuck, and had one child, Frodo. A regular and respectable Shire-hobbit, fond of good food, he often visited his generous father-in-law Gorbadoc Brandybuck in Brandy Hall, and seemed to adopt the curious customs of the Bucklanders, like boating. This was the cause of his irregular death, as during one of his visits to his in-laws in Buckland, he drowned in a boating accident with his wife Primula. Frodo was still very young and he was taken under the custody of his uncle, Rorimac Brandybuck.");
        }

        private void doraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Her parents were Fosco Baggins and Ruby Bolger. She had two younger brothers, Dudo Baggins and Drogo Baggins, the father of Frodo. Dora enjoyed writing letters filled with advice to her relations, and in memory of this correspondence Bilbo Baggins gave her a waste-paper basket when he left the Shire in S.R. 1401. She attended his Farewell Party at the age of 99. Dora Baggins died five years later in 1406.");
        }

        private void dudoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dudo was the son of Fosco Baggins and Ruby Bolger. He was the brother of Drogo Baggins and had a daughter, Daisy. Dudo, his sister, daughter and son-in-law were guests at Bilbo's Farewell Party.");
        }

        private void eglantineButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eglantine Banks was born sometime in the late Third Age, and at some point married Paladin Took, who later became Thain Paladin II. Eglantine was the mother four children: Pearl in TA 2975, Pimpernel in TA 2979, Pervinca in TA 2985, and Peregrin (called Pippin) in TA 2990. She and her family attended Bilbo's Farewell Birthday Party on September 22, 3001. Eglantine's date of death is not known.");
        }

        private void paladinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paladin Took II was the thirty-first Thain of the Shire, and the father of the famous hobbit Peregrin Took. Paladin was the only son of Adalgrim Took and his unnamed wife and the brother of Esmeralda (Took) Brandybuck. Paladin married Eglantine Banks, and had four children: Pearl Took, Pimpernel Took, Pervinca Took, and Peregrin Took. Paladin lived near Whitwell, near Tuckborough, where he owned a farm.");
        }

        private void esmereldaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esmeralda was born to Adalgrim Took and his unnamed wife. She was the youngest of their five children. She was a descendant of Gerontius Took, and younger sister to Thain Paladin Took II. She married Saradoc Brandybuck, the Master of Buckland, and removed to Brandy Hall. Being a Took and marrying into the Brandybuck family, she was both Peregrin Took's aunt and Merry Brandybuck's mother.");
        }

        private void saraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saradoc Brandybuck, also known as 'Scattergold, ' was a hobbit of the Shire and the seventh Master of Buckland. Saradoc was married to Esmeralda Took and was the father of Meriadoc. He lived from 1340-1432 Shire Reckoning, and attended Bilbo Baggins's birthday party in 1401 Shire Reckoning. He was the son of Old Rory Brandybuck, who also attended the party and was the only one to realize that Bilbo was truly leaving. Saradoc was Frodo Baggins's cousin.");
        }

        private void frodoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Frodo Baggins was a hobbit of the Third Age, the most famous of all Hobbits in the histories for his leading role in the Quest of the Ring. During this epic quest, he bore the One Ring to Mount Doom and there destroyed it, giving him renown like no other Halfling throughout Middle-earth. He is also peculiar for being, as a Ring-bearer, one of the three Hobbits who sailed from Middle-earth to Aman, there to die in peace.");
        }

        private void griffoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Griffo was the son of Gruffo Boffin. He married Daisy Baggins, and was present at Bilbo's Farewell Party.");
        }

        private void daisyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daisy was the daughter of Dudo Baggins, born in S.R. 1350. She married Griffo Boffin and had a child, Tosto Boffin in S.R. 1388. They were all guests at Bilbo's Farewell Party.");
        }

        private void pippinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Peregrin 'Pippin' Took was one of the Hobbits in the Fellowship of the Ring. He was the youngest of the Company, being in his tweens, but grew up quickly and eventually became a Knight of Gondor. Elrond, at least, seemed to doubt his capability for the quest, but Pippin proved to be a loyal and courageous friend.");
        }

        private void meriadocButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meriadoc 'Merry' Brandybuck, called The Magnificent, was a Hobbit, the son of Saradoc Brandybuck. Merry was the heir of the Brandybucks to Brandy Hall, and, after his participation to the War of the Ring, eventually became the Master there. While Pippin and Gandalf headed away to Minas Tirith, Merry stayed with Aragorn and the Rohirrim, developing a close friendship with King Théoden. Out of love for him, Merry offered the King his service, which Théoden warmly accepted. 'As a father you shall be to me', Merry said at that time, and Théoden responded 'For a little while'.");
        }
    }
}
