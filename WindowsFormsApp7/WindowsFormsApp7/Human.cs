using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Human : IHuman , IHaveHP
    {
        public int uran235 = 100;//HP
        public int tennesin = 10;//IQ
        public int nihony = 10;//Food
        public bool life;
        public string s;

        private CHuman _humanGraphics;
        public CHuman humanGraphics
        {
            get => _humanGraphics;
            set
            {
                _humanGraphics = value;
                _humanGraphics.hp = hp;
                _humanGraphics.IQ = iq;
                _humanGraphics.food = food;
            }
        }

        private int _iq;

        public int iq
        {
            get => _iq;
            set
            {
                _iq = value;
                if (humanGraphics != null)
                    humanGraphics.IQ = value;
            }
        }

        private int _hp;

        public int hp
        {
            get => _hp;
            set
            {
                _hp = value;
                if (humanGraphics != null)
                    humanGraphics.hp = value;
            }
        }

        private int _food;

        public int food
        {
            get => _food;
            set
            {
                _food = value;
                if (humanGraphics != null)
                    humanGraphics.food = value;
            }
        }

        //_____________________________________________________
        public Human (bool life, int iq, int hp, int food)
        {
            this.life = life;
            this.iq = iq;
            this.hp = hp;
            this.food = food;
        }

        public string EatFood()
        {
            if (food > 0)
            {
                hp += (int)(uran235 * 0.1);
                food -= (int)(nihony * 0.4) ;
                s = "Наша еда!\n";
                return s;
            }
            else
            {
                s = "Мы не можем съести пустоту...\n";
                return s;
            }
        }

        public string ReadBook()
        {
            hp -= (int)(uran235 * 0.05);
            iq += (int)(tennesin * 0.3);
            s = "ТЕПЕРЬ ТВОЙ IQ ПОВЫШЕН, НО ТЕБЕ ЕСТЬ КУДА СТРЕМИТЬСЯ\n";
            return s;
        }

        public string MeLife()
        {
            if (iq > 50 && hp > 0)
            {
                s = "БРАТЦЫ, ОНО НЕ ОВОЩЬ И ОЧЕНЬ ЖИВОЕ\n";
                return s;
            }
            else if (iq < 50 && hp > 0)
            {
                s = "ЭТОТ ОВОЩЬ ЕЩЕ ЖИВОЙ";
                return s;
            }
            else
            {
                s = "ОНО МЕРТВО\n";
                return s;
            }
        }

        public void ParamsFromPlants(object obj, ref int Damage, ref int Knowledge, ref int Taste)
        {
            if (obj is Nut)
            {
                Taste = (int)(nihony * 0.8);
                Damage = (int)(uran235 * 0.1);
                Knowledge = (int)(tennesin * 0.8);
            }
            if (obj is Sundew)
            {
                Taste = (int)( nihony * 0.6);
                Damage = (int)(uran235 * 0.09);
                Knowledge = (int)(tennesin * 1.0);
            }
            if (obj is Sunflower)
            {
                Taste = (int)(nihony * 0.4);
                Damage = (int)(uran235 * 0.11);
                Knowledge = (int)(tennesin * 1.2);
            }
        }

        public string Kills(object obj)
        {
            int knowledge = 0, taste = 0, damage = 0;
            //int Damage = human.DamageToPlant(human, obj);//по хорошему бы сделать для всех коэфициентов, но пока времени нет
            ParamsFromPlants(obj, ref damage, ref knowledge, ref taste);

            if (iq > 100)
            {
                if ((obj is Nut) && (obj as Nut).defend >= damage / 2)//ели будут другие с броней, то я просто введу ->
                {
                    (obj as Nut).defend -= damage / 2;//-> класс Defender, от которого будут наследоваться эти растения
                    damage = 0;
                }
                if ((obj is Nut) && (obj as Nut).defend < damage / 2 && (obj as Nut).defend > 0)
                {
                    damage = damage / 2 - (obj as Nut).defend;
                    (obj as Nut).defend = 0;
                }
                (obj as Plant).hp -= damage;
                if ((obj as Plant).hp <= 0)
                {
                    (obj as Plant).life = false;
                    iq += knowledge;
                    food += taste;
                    return s;
                }
                else
                {
                    (obj as Plant).AreLife();
                    iq += knowledge;
                    food += taste;
                    return s;
                }
            }
            return s;
        }
    }
}
