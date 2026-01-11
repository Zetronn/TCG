using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCGMain
{
    class Cards
    {
        public string Name;
        public int Health;
        public static int ID;
        public int Attack;
        public void showHP()
        {
            Console.WriteLine(Name + " has " + Health + " left ");
        }
    }
}
