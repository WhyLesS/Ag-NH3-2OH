using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class SunFlowerr : UserControl
    {
        Human human = new Human(true, 110, 100, 100);
        Sunflower sunflower = new Sunflower(true, 90, true, 10);
        public string s;
        public SunFlowerr()
        {
            InitializeComponent();
        }

        private void SunFlowerr_Load(object sender, EventArgs e)
        {

        }

        void SOSO(Human human, Sunflower sunflower)
        {
            s = human.KillSunflower(sunflower);
            label4.Text = sunflower.HP.ToString();
            label4.Width = 153 * sunflower.HP / 100;
            if (sunflower.HP <= 0 || !sunflower.Life)
            {
                pictureBox3.Dispose();
                label4.Dispose();
                sunflower.Life = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SOSO(human, sunflower);
        }
    }
}
