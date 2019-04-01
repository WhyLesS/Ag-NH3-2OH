using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Nut : Plant , INut
    {
        private int _defend { get; set; }
        public int defend
        {
            get => _defend;
            set
            {
                _defend = value;
                if (futGraphics != null)
                    futGraphics.defend = defend;
            }
        }
        public Nut(bool life, int hp, bool photo, int defend)
            : base(life, hp, photo)
        {
            this.defend = defend;
        }
        public string Strengthen()
        {
            if (defend != 0)
                defend += defend;
            else
                defend += 2;
            hp += (int)(execution * 0.1);
            AreLife();
            s = "Ну, ты стал немного лучше, чем был";
            return s;
        }

        public string Defender(Sundew sundew)
        {
            sundew.defend += 5;

            return s;
        }
    }
}
