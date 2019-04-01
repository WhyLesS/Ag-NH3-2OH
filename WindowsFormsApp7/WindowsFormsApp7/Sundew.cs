using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Sundew : Plant, ISundew
    {
        public int damage { get; set; }
        public int defend { get; set; }

        public Sundew(bool life, int hp, bool photo, int damage, int defend)
            : base(life, hp, photo)
        {
            this.damage = damage;
            this.defend = defend;
        }

        public string GetPlotFromHuman(Human human)
        {
            human.hp -= (int)(execution * 0.3);
            s = "этот человек...\n" + human.MeLife();
            damage++;
            hp += (int)(execution * 0.34);
            s += AreLife();
            return s;
        }
    }
}
