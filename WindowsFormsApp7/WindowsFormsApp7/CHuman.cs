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
    public partial class CHuman : UserControl
    {
        int k, l, m;

        private int _hp;

        [DisplayName("ВСЕ РАВНО ХРЕНЬ"), DefaultValue(90)]
        public int hp
        {
            get => _hp;
            set
            {
                _hp = value;
                label6.Text = value.ToString();
                label6.Width = 100 * value / 100;
                if (value <= 0)
                {
                    AllDispose();
                }
            }
        }

        public void AllDispose()
        {
            label6.Dispose();
            pictureBox1.Dispose();
            label1.Dispose();
            label2.Dispose();
        }

        private int _iq;
        public int IQ
        {
            get => _iq;
            set
            {
                _iq = value;
                label1.Text = value.ToString();
                label1.Width = 110 * value / 100;
                if (value <= 0)
                {
                    label1.Dispose();
                }
            }
        }

        private int _food;

        public int food
        {
            get => _food;
            set
            {
                _food = value;
                label2.Text = value.ToString();
                label2.Width = 100 * value / 100;
                if (value <= 0)
                {
                    label2.Dispose();
                }
            }
        }

        public CHuman()
        {
            InitializeComponent();
            k = label6.Width;
            l = label1.Width;
            m = label2.Width;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
