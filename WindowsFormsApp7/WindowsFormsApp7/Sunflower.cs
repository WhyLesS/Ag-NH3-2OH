using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Sunflower : Plant , ISunflower
    {

        public int heal { get; set; }

        public Sunflower(bool life, int hp, bool photo, int heal)
            : base(life, hp, photo)
        {
            this.heal = heal;
        }

        public string HealSundew(Sundew sundew, Sun sun)
        {
            if (sun.light)
            {
                sundew.hp += 20;
                sundew.damage += 4;
                hp += 5;
                s = sundew.AreLife();
                s += AreLife();
                s += "То чувство, когда подсолнух умеет лечить, а ты - нет...\n";
                return s;
            }
            else
            {
                sundew.hp += 5;
                sundew.damage ++;
                hp -= 5;
                s = sundew.AreLife();
                s += AreLife();
                s += "Жертва ночи спасает друзей, это так мило:3\n";
                return s;
            }
        }
        //их можно объеденить, но пока что сделаем так)
        public string HealNut(Nut nut, Sun sun)
        {
            if (sun.light)
            {
                nut.defend += 11;
                nut.hp += 6;
                hp += 5;
                s += AreLife();
                s += "Подлечить толстого всегла приятно (нет)((Help!))\n";
                return s;
            }
            else
            {
                nut.defend += 4;
                nut.hp += 4;
                hp -= 5;
                s += AreLife();
                s += "Все ради тостенького!\n";
                return s;
            }
        }
    }
}
