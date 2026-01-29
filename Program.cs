using System;
using System.Threading.Tasks;
using TCGMain;



namespace TCGMain
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //object and variables creation and initialization
        Player Player1 = new Player();
        Player Player2 = new Player();
        Cards Bulbazaur = new Cards();
        Bulbazaur.Name = "Bulbazaur";
        Bulbazaur.Health = 100;
        Player1.points = 0;
        int i = 0;
        int Timer = 90;
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
            //Player nicknames
            Console.WriteLine(" Player one name yourself ");
                Player1.Username = Console.ReadLine();

            Console.WriteLine(" Player two name yourself ");
                Player2.Username = Console.ReadLine();
            //Main game Loop
            while (Player1.points < 3 && Player2.points < 3)
            {
            Timer = 90;
                Console.WriteLine(i + "Round");
                    while (Player1.movePoint != 0 || Timer != 0)
                    {
                        Console.WriteLine("Players " + Player1.Username + "'s turn");

                            if (Console.KeyAvailable)
                            {
                            ConsoleKeyInfo key = Console.ReadKey(true);
                                if (key.Key == ConsoleKey.Enter)
                                {
                                Player1.movePoint -= 1;
                                break;
                                }
                            }

                    
                    await Task.Delay(1000);
                    Timer--;
                    Console.WriteLine(" Time left " + Timer);
                    }
            Timer = 90;
                Console.WriteLine("Player " + Player2.Username + "'s turn");
                    while (Player2.movePoint != 0 || Timer != 0)
                    {
                    Console.WriteLine("Players " + Player1.Username + "'s turn");

                
                    await Task.Delay(1000);
                    Timer--;
                    Console.WriteLine(" Time left " + Timer);
                    }
            i++;
            }
            
        }
    }
}