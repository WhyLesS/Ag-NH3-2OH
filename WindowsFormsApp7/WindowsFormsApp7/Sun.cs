using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Sun
    {
        public string s;
        public bool light { get; set; }

        public Sun(bool light)
        {
            this.light = light;
        }

        public string DorL()
        {
            if (light)
            {
                light = false;
                s = "Dark";
                return s;
            }
            else
            {
                light = true;
                s = "Sun";
                return s;
            }
        }
    }
}
