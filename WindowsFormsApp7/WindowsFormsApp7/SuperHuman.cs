using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class SuperHuman : ISuperHuman
    {
        public int destroy { get; set; } //пусть пока что будет неиспользованной переменной
        public string s;

        public string KillAll(Human human, Sundew sundew, Sunflower sunflower, Nut nut) //vot
        {
            human.life = false;
            sundew.life = false;
            sunflower.life = false;
            nut.life = false;

            s = "ты убил всех... и что дальше, тебе просто нечего делать...\n";
            return s;
        }
    }
}
