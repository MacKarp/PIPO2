using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    public class Silnia
    {
        public int n;

        public int oblicz()
        {
            if (n == 0 || n == 1) return 1;
            int silnia = 1;
            int i = 2;
            while (i <= n)
            {
                silnia = silnia * i;
                i++;
            }

            return silnia;
        }
    }
}
