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
    public partial class CSunflower : UserControl
    {
        private int k = 0;
        private int _hp;
        public int hp
        {
            get => _hp;
            set
            {
                _hp = value; 
                label1.Width = 100 * value / 100;
                label1.Text = value.ToString();
                if (value <= 0)
                {
                    pictureBox1.Dispose();
                    label1.Dispose();
                }
            }
        }

        public CSunflower()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
