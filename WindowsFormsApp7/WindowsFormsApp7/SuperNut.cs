using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class SuperNut : Nut
    {
        public SuperNut(bool life, int hp, bool photo, int defend)
            : base(life, hp, photo , defend)
        {
            this.defend = defend;
        }
    }
}
