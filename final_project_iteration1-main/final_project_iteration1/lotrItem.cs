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
    public partial class lotrItem : Form
    {
        public lotrItem()
        {
            InitializeComponent();
        }

        private void RaceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RaceBox.SelectedIndex == 0)
            {
                RacePicBox.Load("https://static.wikia.nocookie.net/lotr/images/8/84/AragornCrown.jpg/revision/latest/scale-to-width-down/175?cb=20070623125402");
                RaceInfo.Text = "The race of Men was the second significant race of beings created by the supreme God, Ilúvatar, since they awoke at the start of the First Age, at the first rising of the Sun";
            }
            else if (RaceBox.SelectedIndex == 1)
            {
                RacePicBox.Load("https://static.wikia.nocookie.net/cate-blanchett/images/d/d6/GaladrielROTK.png/revision/latest/scale-to-width-down/340?cb=20141217141153");
                RaceInfo.Text = "The Elves, who called themselves the Quendi, and who in lore are commonly referred to as the Eldar (adj. Eldarin), were the first and eldest of the Children of Ilúvatar, and are considered to be the fairest and wisest of any race of Arda given sapience";
            }
            else if (RaceBox.SelectedIndex == 2)
            {
                RacePicBox.Load("https://i.guim.co.uk/img/media/863d2a87325a2cbc523389336def51a166e0ee6b/0_186_4700_2820/master/4700.jpg?width=1200&height=1200&quality=85&auto=format&fit=crop&s=d3d985dbd897e3f34277bfc1aace15a4");
                RaceInfo.Text = "Hobbits, also known as Halflings, were an ancient mortal race that lived in Middle-earth. Although their exact origins are unknown, they were initially found in the northern regions of Middle-earth and below the Vales of Anduin.";
            }
            else if (RaceBox.SelectedIndex == 3)
            {
                RacePicBox.Load("https://img1.looper.com/img/gallery/the-backstory-of-the-lord-of-the-rings-dwarves-explained/intro-1591296229.jpg");
                RaceInfo.Text = "Dwarves were a short, stocky race, a little taller than hobbits but much broader and heavier. Most Dwarves had thick, luxuriant beards in which they took great pride, and often forked or braided them and tucked them into their belts.";
            }
        }

        private void RealmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RealmBox.SelectedIndex == 0)
            {
                RealmPicBox.Load("https://i.etsystatic.com/5503964/r/il/67bdc6/1311752137/il_570xN.1311752137_1bvg.jpg");
                RealmInfo.Text = "Gondor was the most prominent kingdom of Men in Middle-earth, bordered by Rohan to the north, Harad to the south, the cape of Andrast and the Sea to the west, and Mordor to the east. Its first capital was Osgiliath, moved to Minas Tirith in TA 1640.";
            }
            else if (RealmBox.SelectedIndex == 1)
            {
                RealmPicBox.Load("https://static.wikia.nocookie.net/lotr/images/b/b8/193a6bdec38ffa000c2819d33d397cbf.jpg/revision/latest/scale-to-width-down/281?cb=20180410215546");
                RealmInfo.Text = "Rohan, or the Riddermark (Rohirric), was a great kingdom of Men, located in the land once known as Calenardhon, situated in the great vale between the Misty Mountains to the north and the White Mountains to the south. The land of Rohan extended from the fords of the river Isen in the west, up to the shores of the river Anduin in the east.";
            }
            else if (RealmBox.SelectedIndex == 2)
            {
                RealmPicBox.Load("https://i.pinimg.com/originals/81/81/9e/81819e4c3daa011328ccec33b9adcb72.jpg");
                RealmInfo.Text = "The Woodland Realm was a kingdom of Silvan Elves located deep in Mirkwood, the Forest of the Wilderland, beginning in the Second Age.";
            }
            else if (RealmBox.SelectedIndex == 3)
            {
                RealmPicBox.Load("https://static.wikia.nocookie.net/lotr/images/e/e1/Tara_Rueping_-_Lothlorien.jpg/revision/latest/scale-to-width-down/278?cb=20160108151538");
                RealmInfo.Text = "Lothlórien, also known as Lorien, was a forest and Elven realm near the lower Misty Mountains. It was first settled by Nandorin Elves, but later populated by Ñoldor and Sindar under Celeborn of Doriath and Galadriel, daughter of Finarfin. It was located on the River Celebrant, southeast of Khazad-dûm, and was the only place where the golden Mallorn trees grew.";
            }
            else if (RealmBox.SelectedIndex == 4)
            {
                RealmPicBox.Load("https://economictimes.indiatimes.com/photo/58768239.cms?from=mdr");
                RealmInfo.Text = "The Shire was the homeland of the majority of the hobbits in Middle-earth. It was located in the northwestern portion of Middle-earth, in the northern region of Eriador, within the remains of the Kingdom of Arnor. ";
            }
        }

        private void lotrItem_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Creation C3 = new Creation();
            this.Hide();
            C3.ShowDialog();
        }
    }
}
