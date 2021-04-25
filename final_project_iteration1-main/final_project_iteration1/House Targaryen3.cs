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
    public partial class House_Targaryen3 : Form
    {
        public House_Targaryen3()
        {
            InitializeComponent();
        }

        private void House_Targaryen3_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            targaryenTree2 f2 = new targaryenTree2();
            f2.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myriahButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Princess Myriah Nymeros Martell was the wife and queen consort of King Daeron II Targaryen.");
        }

        private void daeronButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daeron II, also known as Daeron the Good, was the twelfth Targaryen to sit the Iron Throne. Daeron brought Dorne peacefully into the realm, uniting all the lands of Westeros south of the wall. His bastard half-brother, Daemon Blackfyre, challenged his rule and the result was a terrible civil war, the First Blackfyre Rebellion. Daeron died during the Great Spring Sickness in 209 AC.");

        }

        private void variousButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daeron II and Myriah had two other children, too many to fit onto a tree. Their names are as follows: Baelor and Rhaegel");
        }

        private void aerysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aerys I Targaryen was Lord of the Seven Kingdoms and the thirteenth Targaryen king to sit the Iron Throne. He succeeded his father, King Daeron II Targaryen.");
        }

        private void penroseButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A noblewoman of House Penrose and the queen consort of King Aerys I Targaryen.");
        }

        private void maekarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lord of the Seven Kingdoms and the fourteenth Targaryen king to sit the Iron Throne. He was the fourth son of King Daeron II Targaryen, and was given the Targaryen seat of Summerhall, and was thus known as the Prince of Summerhall. Maekar was a capable army commander who served in two of the Blackfyre Rebellions. After a number of unexpected deaths in the royal family, he came to the throne in 221 AC.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("She married Daeron's fourth son, Prince Maekar, and together they had six children: Daeron, Aerion, Aemon, Aegon, Daella and Rhae Targaryen");
        }

        private void aegonButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lord of the Seven Kingdoms and the fifteenth Targaryen to sit the Iron Throne as King of the Andals, the Rhoynar, and the First Men. Dubbed Aegon the Unlikely. In his youth, he went by the nickname Egg and squired for Ser Duncan the Tall.");
        }

        private void vButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maekar I and Dyanna Dayne had five children before Aegon the Unlikely. Their names were as follows: Aerion, Daeron, Aemon, Daella, and Rhae.");
        }

        private void blackwoodButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Queen Betha Blackwood, known as Black Betha, was a member of House Blackwood who became queen consort to King Aegon V Targaryen. She married Aegon V out of love rather than political gain.");
        }

        private void duncanButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prince Duncan Targaryen, also known as Prince Duncan the Small and the Prince of Dragonflies, was a member of House Targaryen. He was the first son of King Aegon V Targaryen and his Queen Betha Blackwood, but gave up the throne for love.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jenny of Oldstones was the wife of Duncan Targaryen, the Prince of Dragonflies. There are many songs written about her, including Jenny's song, which the ghost of High Heart always wants to hear.");
        }

        private void jaeherysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jaehaerys's father, King Aegon V Targaryen, had developed a deep distaste for the Targaryen practice of incestuous marriages and was determined to end the custom. Thus, in 237 AC, Jaehaerys was betrothed to Celia Tully, the daughter of the Lord of Riverrun. However, from a young age, Jaehaerys had been of a more traditional frame of mind, as he was in love with his sister, Princess Shaera.");
        }

        private void shaeraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shaera was betrothed to Luthor Tyrell by her mother, Queen Betha Blackwood, in 237 AC, while her older brother, Prince Jaehaerys, was betrothed to Celia Tully. After their brother, Prince Duncan, defied King Aegon V Targaryen and married following his heart, Shaera and Jaehaerys eluded their guards and were secretly married in 240 AC. By the time this became known to their royal parents, Jaehaerys and Shaera had already consummated the marriage, forcing Aegon to accept it.");
        }

        private void daeronButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When both were nine years old, Prince Daeron was betrothed to Lady Olenna Redwyne in 237 AC, a betrothal arranged by his mother, Betha. After his three older siblings had broken their own betrothals—Duncan to marry Jenny of Oldstones, Jaehaerys and Shaera to marry each other—Daeron broke his betrothal to Olenna as well when he was eighteen years old, in 246 AC. While his brothers had broken their betrothals for other women, this was not the case for Daeron. He preferred the companionship of Ser Jeremy Norridge, a young knight whom he had befriended when they were squires together at Highgarden.");
        }

        private void rhaelleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It was Rhaelle's eldest brother, Duncan, who broke his betrothal first, by marrying Jenny of Oldstones in 239 AC. This greatly angered Lord Lyonel, who rebelled against his king. A trial by combat, and the word of King Aegon V ended Lord Lyonel's rebellion, with an end result a betrothal, of Rhaelle to Lord Lyonel's son and heir, Ormund Baratheon. Her grandson, Robert, would later become king.");
        }

        private void ormundButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ormund Baratheon was the Lord of Storm's End and head of House Baratheon during the second half of the reign of Aegon V Targaryen and during the reign of Jaehaerys II Targaryen. He served the latter as Hand of the King, until his death whilst commanding the royal army in the invasion of the Stepstones in the War of the Ninepenny Kings.");
        }

        private void aerysButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Also called the Mad King and King Scab, Aerys was the seventeenth and last member of the Targaryen dynasty to sit the Iron Throne, ruling from 262 AC to 283 AC. While still a teenager, Aerys was married to his sister Rhaella, in accordance with the family tradition of dynastic incest. While Aerys's grandfather, King Aegon V Targaryen was against this incestuous marriage (as he had been against incestuous marriages for his own children), Jaehaerys was allowed to arrange it. Jaehaerys's motivation for the marriage was a prophecy made by a woods witch, which had been interpreted to mean that the prince that was promised would be born of the line of Aerys and Rhaella.");
        }

        private void rhaellaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Queen Rhaella Targaryen was the sister, wife, and queen of King Aerys II Targaryen and the only daughter of King Jaehaerys II Targaryen and his sister-wife, Queen Shaera Targaryen. Her grandfather was King Aegon V Targaryen. Rhaella was the mother of Prince Rhaegar, Prince Viserys, and Princess Daenerys. She died shortly after Daenerys's birth.");
        }

        private void rhaegarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prince Rhaegar Targaryen was the firstborn son of King Aerys II Targaryen and his sister-wife, Queen Rhaella. As heir-apparent, he was the Prince of Dragonstone and crown prince for the Iron Throne. Rhaegar was popular with the smallfolk during his lifetime, but he died in Robert's Rebellion which was triggered in part by his abduction of Lyanna Stark. He was slain in single combat by Robert Baratheon at the ruby ford during the Battle of the Trident.");
        }

        private void eliaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Princess Elia Nymeros Martell, also known simply as Elia Martell or Elia of Dorne was a Dornish princess from House Martell. She was married to the crown prince, Rhaegar Targaryen, and by him birthed Rhaenys and Aegon. Elia was murdered by Ser Gregor Clegane in the Sack of King's Landing during Robert's Rebellion.");
        }

        private void viserysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prince Viserys Targaryen is the heir of his father, King Aerys II Targaryen, following the death of his older brother, Prince Rhaegar, during Robert's Rebellion. The war turned Viserys and his younger sister, Daenerys, Princess of Dragonstone, into exiles from the Seven Kingdoms who can only plot to regain control of the Iron Throne.[1] He styles himself as 'Viserys of the House Targaryen, the Third of his Name, King of the Andals, the Rhoynar, and the First Men, Lord of the Seven Kingdoms and Protector of the Realm', as he had been declared king on Dragonstone after his father's death. In the Free Cities Viserys was mockingly dubbed 'the Beggar King', a name which spread towards the Seven Kingdoms.");
        }

        private void daenerysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Princess Daenerys Targaryen, also known as Daenerys Stormborn, is one of the last confirmed members of House Targaryen, along with her older brother Viserys, who refers to her as Dany. She is the youngest child of King Aerys II Targaryen and his sister-wife, Queen Rhaella. She hatches the first three dragons seen in the world since the reign of Aegon III.");
        }

        private void drogoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drogo is a powerful khal or warlord of the fearsome Dothraki nomads. Daenerys Targaryen is promised to him at the beginning of A Song of Ice and Fire.");
        }

        private void rheanysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In 280 AC, Rhaenys was born on Dragonstone. After her birth, her mother was bedridden for half a year. Rhaenys was presented at court by her father, Prince Rhaegar Targaryen. Whilst her grandmother, Queen Rhaella Targaryen, embraced her warmly, her grandfather, King Aerys II Targaryen, refused to touch or hold her, claiming she smelled 'Dornish'.");
        }

        private void aegonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A comet was seen above King's Landing on the night Aegon was conceived, which led his father Rhaegar, Prince of Dragonstone, to believe that Aegon was the 'prince that was promised'. The comet was seen as 'the bleeding star' of the prophecy. Maester Aemon was aware of Rhaegar's beliefs, though it is unclear if he shared them. According to Lord Eddard Stark, Lord Tywin Lannister's soldiers tore Aegon from his mother's breast and dashed his head against a wall.");
        }

        private void jonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the eyes of the Seven Kingdoms, Jon Snow was born to Eddard Stark, Warden of the North, and an unknown woman, in the year 280. He is, in actuality, the son of Rhaegar Targaryen and Lyanna Stark, making him a strong contender for the Iron Throne.");
        }

        private void lyannaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lyanna Stark was the only daughter of Lord Rickard Stark and his wife, Lady Lyarra Stark. She had two older brothers, Brandon and Eddard, and one younger brother, Benjen. Her abduction by Prince Rhaegar Targaryen was the event that ultimately triggered Robert's Rebellion and led to the downfall of the Targaryen dynasty.");
        }
    }
}
