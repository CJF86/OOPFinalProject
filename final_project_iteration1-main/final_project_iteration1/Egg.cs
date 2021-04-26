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
    public partial class Egg : Form
    {
        public Egg()
        {
            InitializeComponent();
        }

        private void Egg_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("https://steamuserimages-a.akamaihd.net/ugc/1662354662424130854/716B4C07357CA8C06BAB2E2C29F768511548F24D/?imw=512&&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=false");
        }
    }
}
