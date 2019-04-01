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
    public partial class CNut : UserControl
    {
        int k, l;

        private int _hp;
        [DisplayName("ПОНЯЛ, ЧТО ЭТО ЗА ХРЕНЬ))))"), DefaultValue(90)]
        public int hp
        {
            get => _hp;
            set
            {
                _hp = value;
                label1.Text = value.ToString();
                label1.Width = 160 * value / 100;
                if (value <= 0)
                {
                    label1.Dispose();
                    pictureBox1.Dispose();
                    label2.Dispose();
                }
            }
        }

        private int _defend { get; set; }
        [DisplayName("(Defend)А ЕЕ ИМЕННО В ЭТОМ МЕСТЕ УСТАНАВЛИВАТЬ?"), DefaultValue(90)]
        public int defend
        {
            get => _defend;
            set
            {
                _defend = value;
                label2.Text = value.ToString();
                label2.Width = value * 160 / 100;//e vtyz e;t ujhbn jn 'nj [thyb pft,fkj у меня уже горит от это херни заебало - перевод
                
                if (value <= 0)
                {
                    label2.Dispose();
                }
            }
        }

        public CNut()
        {
            InitializeComponent();
            k = label2.Width;
            l = label1.Width;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
