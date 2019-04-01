using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Plant : IPlant
    {
        private CSunflower _flowerGraphics;
        public CSunflower flowerGraphics
        {
            get => _flowerGraphics;
            set
            {
                _flowerGraphics = value;
                _flowerGraphics.hp = hp;
            }
        }
        private CNut _futGraphics;
        public CNut futGraphics
        {
            get => _futGraphics;
            set
            {
                _futGraphics = value;
                _futGraphics.hp = hp;
            }
        }
        private CSundew _dewGraphics;
		public CSundew dewGraphics
		{
			get => _dewGraphics;
			set
            {
				_dewGraphics = value;
				_dewGraphics.HP = hp;
			}
		}

		private int _hp;
        public int hp
		{
			get => _hp;
			set
			{
				_hp = value;
				if (dewGraphics != null)
					dewGraphics.HP = value;
                if (futGraphics != null)
                    futGraphics.hp = value;
                if (flowerGraphics != null)
                    flowerGraphics.hp = value;
            }
		}

        public int execution = 100;
        public bool life = true;
        public bool photo { get; set; }
        public string s;

        //___________________________________________________________

        public Plant (bool life, int hp, bool photo)
        {
            this.life = life;
            this.hp = hp;
            this.photo = photo;
        }

        public string AreLife()
        {
            if (life && hp > 0)
            {
                s = "БРАТЦЫ, ОНО ОЧЕНЬ ЖИВОЕ, ЙОШКИН КОТ\n";
                return s;
            }
            else
            {
                s = "ОНО МЕРТВО\n";
                return s;
            }
        }

        public string GetPhotoEating(Sun sun)
        {
            if (sun.light && photo)
            {
                hp += (int)(execution * 0.1);
                s = "наслаждаемся солнышком (*_*)\n";
                return s;
            }
            else
            {
                s = "а ты не можешь это сделать!\n";
                return s;
            }
        }
    }
}
