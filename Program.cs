using System;
using TCGMain;



namespace TCGMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Player1 = new Player();
            Cards Bulbazaur = new Cards();
            Bulbazaur.Name = "Bulbazaur";
            Bulbazaur.Health = 100;
            Player1.points = 0;
            Bulbazaur.Visual = @"             ;,;.;,;.;.
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
            Bulbazaur.showCard();
            Player1.showPoints();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}