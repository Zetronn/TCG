using System;
using TCGMain;

namespace TCGMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Cards Bulbazaur = new Cards();
            Bulbazaur.Name = "Bulbazaur";
            Bulbazaur.Health = 100;
            Bulbazaur.visualisation = @"             ;,;.;,;.;.
              ..:;:;::;: 
        ..--             --.  
      / .   .        .   .`\
     | /    /            \   .|
     | |   :             :    :|
   .| |   :             :    :|
 ,: /\ \.._\ __..===..__/_../ /`.
| |  :.|  `          `   |.  ::.
|   |  |    :;           | ,  `\
|.:  \/  |    /-.` :.-\  |  \,   |
|   /  /  |  / |...  | \ |  |  |;|
 \ _ |:.|  |_\_|`.   |_/_|  |.:| _ |
/,.,.| \__       . .      __/ |.,.,\
     | :`.`----._____.---.   |
     \   `:------- |   | ----:
       ,-,-,             .-=,=,";
            Bulbazaur.showHP();

            
            Bulbazaur.ShowCard();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}