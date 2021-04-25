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
    public partial class starkTree : Form
    {
        public starkTree()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            gotTree f1 = new gotTree();
            this.Hide();
            f1.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void builderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brandon Stark, also known as Brandon the Builder and Bran the Builder, was the legendary founder of House Stark who is said to have lived during the Age of Heroes. Scholars believe an ancient king's actions have been exaggerated into legend, or the reigns of multiple kings have been remembered as one through the passage of time.");
        }

        private void torrhenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Known as the King Who Knelt, he was a head of House Stark who reigned as King in the North until Aegon I Targaryen invaded Westeros with his dragons. He was named Lord of Winterfell and Warden of the North after submitting to Aegon during the War of Conquest.");
        }

        private void cregButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Known as the Old Man of the North, was the Lord of Winterfell and head of House Stark during the reigns of kings Viserys I, Aegon II, Aegon III and Daeron I Targaryen. Briefly served as Hand of the King for Aegon III.");
        }

        private void lynaraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A noblewoman of House Stark during the second century after Aegon's Conquest.[2] She was a descendant of a younger son of Lord Brandon 'the Boisterous' Stark.");
        }

        private void vButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No <3");
        }

        private void brandonButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brandon Stark was the Lord of Winterfell and head of House Stark during the reign of King Daeron II Targaryen. He was the youngest son of Lord Cregan Stark and Lady Lynara Stark.");

        }

        private void alysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lady Alys Karstark was a member of House Karstark, she married Lord Brandon Stark, youngest son Lord Cregan Stark, together they had three children; Rodwell, Beron and Arsa Stark.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Several Generations were lost in the Old North. Only those past this point survived.");
        }

        private void rickardButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rickard Stark was Lord of Winterfell, Warden of the North, and head of House Stark during the reign of King Aerys II Targaryen. He was the only child of Lord Edwyle Stark and Lady Marna Locke.");
        }

        private void lyarraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lyarra Stark was a noblewoman from House Stark during the reign of kings Aegon V, Jaehaerys II and Aerys II Targaryen. She was a daughter of Rodrik Stark and Arya Flint, and the younger sister of Branda Stark.");
        }

        private void wildButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brandon Stark, called the Wild Wolf, was the oldest son of Lord Rickard Stark and Lady Lyarra Stark and the heir to Winterfell prior to Robert's Rebellion. He was on his way back to Riverrun for a wedding when word reached Brandon of Lyanna's supposed abduction by Prince Rhaegar Targaryen. Upon entering the Red Keep, Brandon shouted for Rhaegar to 'come out and die'. Rhaegar was not present, however, and Brandon and his companions were arrested by King Aerys II Targaryen and charged with plotting Rhaegar's murder. Brandon was placed in a strangle device from Tyrosh, with a longsword placed just out of reach. He was forced to watch as his father was burned alive in his own armor and strangled himself while attempting to get to the sword so he could save his father.");
        }

        private void eddardButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Head of House Stark, Lord of Winterfell, and Warden of the North. He is a close friend to King Robert I Baratheon, with whom he was raised. Known as the Quiet Wolf. As a second son, Eddard had never expected to become the Lord of Winterfell, and as such did not always feel equal to the task, determined it had all been meant for his elder brother Brandon. After discovering that the king's children were actually not his, Eddard is arrested for attempting a coup. Ser Ilyn Payne beheads Eddard with his own greatsword, Ice.");
        }

        private void shaeraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The wife of Eddard Stark, Lord of Winterfell and Warden of the North. Catelyn attends her brother Edmure's wedding at the Twins, sitting between Ser Ryman Frey and Lord Roose Bolton during the feast. However, the Freys and Boltons betray the Starks in an act of treachery that becomes known as the Red Wedding. In a desperate attempt to save her son's life, Catelyn seizes Lord Walder Frey's lackwit grandson, Aegon, and tries to trade his life for Robb's. When Robb is killed by Roose, Catelyn saws through Aegon's throat with a knife. Walder had planned to take Catelyn hostage, but the maddened woman claws her own face and Ser Raymund Frey is allowed to slit her throat.");
        }

        private void benjenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The First Ranger of the Night's Watch and the younger brother of Lord Eddard Stark of Winterfell. Also known as the Pup.");
        }

        private void lyannaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lyanna Stark was the only daughter of Lord Rickard Stark and his wife, Lady Lyarra Stark. She had two older brothers, Brandon and Eddard, and one younger brother, Benjen. Her abduction by Prince Rhaegar Targaryen was the event that ultimately triggered Robert's Rebellion and led to the downfall of the Targaryen dynasty.");

        }

        private void rhaegarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prince Rhaegar Targaryen was the firstborn son of King Aerys II Targaryen and his sister-wife, Queen Rhaella. As heir-apparent, he was the Prince of Dragonstone and crown prince for the Iron Throne. Rhaegar was popular with the smallfolk during his lifetime, but he died in Robert's Rebellion which was triggered in part by his abduction of Lyanna Stark. He was slain in single combat by Robert Baratheon at the ruby ford during the Battle of the Trident.");

        }

        private void jonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the eyes of the Seven Kingdoms, Jon Snow was born to Eddard Stark, Warden of the North, and an unknown woman, in the year 280. He is, in actuality, the son of Rhaegar Targaryen and Lyanna Stark, making him a strong contender for the Iron Throne. His wolf is a silent albino named Ghost.");

        }

        private void tyrionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The third and youngest child of Lord Tywin Lannister and the late Lady Joanna Lannister. His older siblings are Cersei Lannister, the queen of King Robert I Baratheon, and Ser Jaime Lannister, a knight of Robert's Kingsguard.");

        }

        private void talisaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The daughter of a Volanteen noble. She worked as a healer on the battlefields of the Westerlands, where she met the King in the North, Robb Stark, fell in love with him, eventually married him, and became pregnant with their child. Murdered at the Red Wedding alongside her husband, King Robb.");
        }

        private void robbButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Robb Stark is the eldest son of Eddard Stark and Catelyn Tully and is the heir of House Stark to Winterfell and the north. He is called the Young Wolf by friend and foe alike. Named King in the North after his father is murderd in King's Landing. Murdered at the Red Wedding beside his mother, wife, his wolf Grey Wind, and his bannermen.");
        }

        private void sansaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A member of House Stark and is the elder daughter of Lady Catelyn and Lord Eddard Stark. She has three brothers: Robb, Bran and Rickon; a younger sister: Arya; and a half-brother: Jon Snow. Her wolf, Lady, is murdered on the Kingsroad after her sister's wolf Nymeria attacks Prince Joffrey.");

        }

        private void aryaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arya Stark is the third child and second daughter of Lord Eddard Stark and Lady Catelyn Tully. Arya is a spirited girl interested in fighting and exploration, unlike her older sister, Sansa. Arya wants to learn how to fight with a sword, to the horror of Sansa, who enjoys the more traditional pursuits of a noblewoman. Arya is particularly close to her half brother, Jon Snow, who encourages her martial pursuits. She is said to take after the fiery Lyanna in temperament. She named her wolf after the warrior queen Nymeria.");
        }

        private void branButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The second son of Eddard Stark and Catelyn Tully. Called the Winged Wolf due to his warging and greensight abilities. His wolf's name is Summer.");
        }

        private void rickonButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rickon is a naturally aggressive and strong-willed child, but his youth makes it difficult for him to cope with the terrible changes that come to his family and life. He is usually accompanied by his direwolf, Shaggydog.");
        }
    }
}
