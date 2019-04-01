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
    public partial class Ssundew : UserControl
    {
        Human human = new Human(true, 110, 100, 100);
        Sundew sundew = new Sundew(true, 110, true, 10, 0);
        public string s;

        public Ssundew()
        {
            InitializeComponent();
            label2.Text = sundew.HP.ToString();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SOS(human,sundew);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        void SOS(Human human, Sundew sundew)
        {
            s = human.KillSundew(sundew);
            label2.Text = sundew.HP.ToString();
            label2.Width = 153 * sundew.HP / 100;
            if (sundew.HP <= 0 || !sundew.Life)
            {
                pictureBox1.Dispose();
                label2.Dispose();
                sundew.Life = false;
            }
        }
       
    }
}
