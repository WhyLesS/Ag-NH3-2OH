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
	public partial class CSundew : UserControl
	{
        int k = 0;
		private IHaveHP _obj;//эта фигня for привязкu логики к графике!
		[Browsable(false)] //Атрибут, блокирующий появление свойства в конструкторе
		public IHaveHP obj {
			get => _obj;
			set
			{
				_obj = value;
				OnLoad();
			}
		}

		private int _hp;

		[DisplayName("ХЭПЭШЕЧКА"), DefaultValue(100)]
		public int HP
		{
			get => _hp;
			set
			{
				_hp = value;
				label4.Text = value.ToString();
                label4.Width = k * value / 100;//
                if (value <= 0)
                {
                    label4.Dispose();
                    pictureBox3.Dispose();
                    label4.Dispose();
                }
            }
		}

		[DisplayName("КАРТИНОЧКА"), DefaultValue(100)]
		public Image Picture {
			get => pictureBox3.Image;
			set => pictureBox3.Image = value;
		}

		public CSundew()
        {
            InitializeComponent();
            k = label4.Width;
        }

        private void OnLoad()
        {
			//Динамическая подмена картинок. Условия можно продолжить. Аналог заданию картинок ручками через свойства в конструкторе
			//if (obj is Human)
			//{
			//	pictureBox3.Image = Properties.Resources.Human1;
			//}
			//else if (obj is Sundew)
			//{
			//	pictureBox3.Image = Properties.Resources.sundew111;
			//}
        }

        public int Test { get; set; }
		private void propertyGrid1_Click(object sender, EventArgs e)
		{

		}

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
