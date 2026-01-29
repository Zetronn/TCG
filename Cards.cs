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
        public string Visual;
        public static int ID;
        public int Attack;
        public string SpecialInfo;

        public void showHP()
        {
            Console.WriteLine(Name + " has " + Health + " left ");
        }
        public void showCard()
        {
            Console.WriteLine(Visual);
        }
        public void showSpecial()
        {
            Console.WriteLine(SpecialInfo);
        }
    }
    class Player
    {
        public int points;
        public string Username;
        public int movePoint;
        public void showPoints()
        {
            Console.WriteLine("This player has " + points + " points " );
        }
    }
}
