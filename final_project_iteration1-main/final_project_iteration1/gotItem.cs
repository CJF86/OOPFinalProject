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
    public partial class gotItem : Form
    {
        public gotItem()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Changes sigil picture based on combo box input
        {
            if (HouseBox.SelectedIndex == 0)
            {
                SigilPicBox.Load("https://hips.hearstapps.com/digitalspyuk.cdnds.net/16/25/1466688518-sigil-of-house-targaryen.jpg?resize=480:*");
                InfoTxtBox.Text = "classic Valyrian features of pale skin, blonde hair of shades of gold and/or silver, and purple eyes. Incest is common, and madness is in the veins.";
            }
            else if (HouseBox.SelectedIndex == 1)
            {
                SigilPicBox.Load("https://img2.cgtrader.com/items/2437775/28fdaca804/game-of-thrones-stark-house-3d-print-ready-got-3d-model-obj-stl-3dm-ztl.jpg");
                InfoTxtBox.Text = ("Black hair and grey or light blue eyes. Value honour highly.");
            }
            else if (HouseBox.SelectedIndex == 2)
            {
                SigilPicBox.Load("https://i.pinimg.com/originals/91/dd/27/91dd273b8d019c4b30c6a621330e3554.jpg");
                InfoTxtBox.Text = ("Black hair, blue eyes, large. Bullheaded and stubborn. Good warriors.");
            }
            else if (HouseBox.SelectedIndex == 3)
            {
                SigilPicBox.Load("https://images-na.ssl-images-amazon.com/images/I/71LEHVDQ5YL._AC_SX466_.jpg");
                InfoTxtBox.Text = ("Richest House in all Seven Kingdoms. Blonde hair, green eyes. Ambitious and highly concerned with their legacy.");
            }
            else if (HouseBox.SelectedIndex == 4)
            {
                SigilPicBox.Load("https://qtoptens-com.exactdn.com/wp-content/uploads/2017/09/Greyjoy.jpg?strip=all&lossy=1&ssl=1&fit=977,507");
                InfoTxtBox.Text = ("House Greyjoy of Pyke is one of the Great Houses of Westeros. It rules over the Iron Islands, a harsh and bleak collection of islands off the west coast of Westeros, from the castle at Pyke.");
            }
            else if (HouseBox.SelectedIndex == 5)
            {
                SigilPicBox.Load("https://i.pinimg.com/originals/cd/cc/e5/cdcce52fe4f0e117154001a30b87dd54.jpg");
                InfoTxtBox.Text = ("Tan skiny, black hair, brown eyes. Often very loyal.");
            }
            else if (HouseBox.SelectedIndex == 6)
            {
                SigilPicBox.Load("http://4.bp.blogspot.com/-UYW8ibzloOM/Voe8AIMJbFI/AAAAAAAAHTk/_fDjWKb4XLI/s1600/house-Tyrell-house-tyrell-34178705-1600-1200.jpg");
                InfoTxtBox.Text = ("Curly brown hair, brown eyes. Ambitous.");
            }
        }

        private void AnimalBox_SelectedIndexChanged(object sender, EventArgs e)//changes animal picture based on combo box input
        {
            if (AnimalBox.SelectedIndex == 0)
            {
                AnimalPicBox.Load("https://static.wikia.nocookie.net/gameofthrones/images/8/8f/DrogonWinterfell8x01.PNG/revision/latest?cb=20190515233534");
                AnimalInfo.Text = "Drogon is one of the three dragons born in the wastelands beyond Lhazar, along with his brothers Rhaegal and Viserion. He is named after Daenerys's late husband Khal Drogo. He can be distinguished by his black and red colored scales, and red-black wings. He was also Daenerys's personal mount.";
            }
            else if (AnimalBox.SelectedIndex == 1)
            {
                AnimalPicBox.Load("https://i.pinimg.com/originals/a0/99/6b/a0996bcd2d5b96a9ce0a0b830c8744ef.jpg");
                AnimalInfo.Text = ("Viserion was one of the three dragons born in the wastelands beyond Lhazar, along with Drogon and Rhaegal. He was named after Daenerys Targaryen's elder brother, Viserys. He could be distinguished by his cream and gold colored scales, and red-orange wings. Eventually, he became an ice dragon");
            }
            else if (AnimalBox.SelectedIndex == 2)
            {
                AnimalPicBox.Load("https://static.wikia.nocookie.net/gameofthrones/images/5/54/RhaegalPostFlight.PNG/revision/latest?cb=20190415050236");
                AnimalInfo.Text = ("Rhaegal was one of the three dragons born in the wastelands beyond Lhazar, along with Drogon and Viserion. He was named after Daenerys Targaryen's eldest brother Rhaegar. He could be distinguished by his green and bronze colored scales, and his yellow-orange colored wings.");
            }
            else if (AnimalBox.SelectedIndex == 3)
            {
                AnimalPicBox.Load("http://pm1.narvii.com/6071/1bcfa11eceb830c422646a75148e960ead3d4cb1_00.jpg");
                AnimalInfo.Text = ("Grey Wind was one of six direwolf pups found by the children of House Stark. Grey Wind is adopted and raised by Robb Stark.");
            }
            else if (AnimalBox.SelectedIndex == 4)
            {
                AnimalPicBox.Load("https://cdn.images.express.co.uk/img/dynamic/20/590x/secondary/Game-of-thrones-season-7-direwolf-names-stark-ghost-nymeria-lady-summer-shaggydog-grey-wind-1005866.jpg");
                AnimalInfo.Text = (" Lady is a direwolf bonded to Sansa Stark. She is the litter-mate of Grey Wind, Nymeria, Summer, Shaggydog, and Ghost.");
            }
            else if (AnimalBox.SelectedIndex == 5)
            {
                AnimalPicBox.Load("https://static.wikia.nocookie.net/gameofthrones/images/5/54/Nymeria-S7.png/revision/latest/scale-to-width-down/350?cb=20170724060059");
                AnimalInfo.Text = ("Nymeria is one of six direwolf pups found by the children of House Stark. Nymeria is adopted and raised by Arya Stark. After Nymeria leaves Arya, she becomes the leader of a huge wolf pack in the Riverlands.");
            }
            else if (AnimalBox.SelectedIndex == 6)
            {
                AnimalPicBox.Load("https://static.wikia.nocookie.net/gameofthrones/images/8/87/SummerS3.jpg/revision/latest/scale-to-width-down/350?cb=20150404133818");
                AnimalInfo.Text = ("Summer was one of six direwolf pups found by the children of House Stark. Summer is adopted and raised by Bran Stark. ");
            }
            else if (AnimalBox.SelectedIndex == 7)
            {
                AnimalPicBox.Load("https://static.wikia.nocookie.net/gameofthrones/images/0/05/Shaggydog.png/revision/latest/scale-to-width-down/337?cb=20160717054717");
                AnimalInfo.Text = ("Shaggydog was one of six direwolf pups found by the children of House Stark. Shaggydog is adopted and raised by Rickon Stark, the youngest of the five Stark children. Shaggydog is distinguished from the rest of his siblings by his black fur.");
            }
            else if (AnimalBox.SelectedIndex == 8)
            {
                AnimalPicBox.Load("https://static.wikia.nocookie.net/gameofthrones/images/9/94/804_Ghost_Profile.png/revision/latest/scale-to-width-down/338?cb=20190506030424");
                AnimalInfo.Text = ("Ghost is one of six direwolf pups that are found by the children of House Stark. He is adopted and raised by Jon Snow. Ghost is an albino with white fur and red eyes. Though he was the runt of the litter when he was born, he quickly grew to be as big as the rest of his siblings.");
            }
            
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Creation C2 = new Creation();
            this.Hide();
            C2.ShowDialog();
        }
    }
}
