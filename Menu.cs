using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace MiniLibrary
{
    class Menu
    {
//        public static void Hello ()
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.SetWindowSize(110, 30);
           
//            Console.CursorVisible = false;
//            string ascci = @" 
//                 ________________________________________________________________________
//                /                                                                        /     )
//               /               '\\  //`                                                 /     /
//              /                  \\//                                                  /     /
//             /                    ||    .|''|, '||  ||` '||''|                        /     /  
//            /                     ||    ||  ||  ||  ||   ||                          /     /
//           /                     .||.   `|..|'  `|..'|. .||.                        /     /         
//          /                                                                        /     /  
//         /    '||'''|,                '||      '||`                      ||`      /     /
//        /      ||   ||                 ||       ||                       ||      /     /
//       /       ||;;;;   .|''|, .|''|,  || //`   ||   '''|.  `||''|,  .|''||     /     /
//      /        ||   ||  ||  || ||  ||  ||<<     ||  .|''||   ||  ||  ||  ||    /     /
//     /        .||...|'  `|..|' `|..|' .|| \\.  .||. `|..||. .||  ||. `|..||.  /     /
//    /      __________________________________________________________________/     /          
//   (                                                                        (     / 
//  (                                                                        (     /
//   (________________________________________________________________________(   /    

//";

//            Console.SetCursorPosition(10, 0);
//            Console.Write(ascci);


//        }


        public static void Hello2()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetWindowSize(60, 40);

            Console.CursorVisible = false;
            string first = @" 
    ____________________________________________________
  |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _    ___     _____|
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|__|~|~|___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |==|x|x|+|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|__|_|_|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ _______________|
  | _____   _   __  |/      \../      \|  __   __   ___|
  ||_____|_| |_|##|_||   |   \/ __|   ||_|==|_|++|_|-|||
  ||______||=|#|--| |\   \   o    /   /| |  |~|  | | |||
  ||______||_|_|__|_|_\   \  o   /   /_|_|__|_|__|_|_|||
  |_________ __________\___\____/___/___________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ |*/  .//____//.//   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |
      __          __  _                          
      \ \        / / | |                         
       \ \  /\  / /__| | ___ ___  _ __ ___   ___ 
        \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \
         \  /\  /  __/ | (_| (_) | | | | | |  __/
          \/  \/ \___|_|\___\___/|_| |_| |_|\___|        

";

            string scnd = @"
   ____________________________________________________
  |____________________________________________________|
  | __     __   ____   ___ ||  ____    ____     _  __  |
  ||  |__ |--|_| || |_|   |||_|**|*|__|+|+||___| ||  | |
  ||==|^^||--| |=||=| |=*=||| |~~|~|  |=|=|| | |~||==| |
  ||  |##||  | | || | |JRO|||-|  | |==|+|+||-|-|~||__| |
  ||__|__||__|_|_||_|_|___|||_|__|_|__|_|_||_|_|_||__|_|
  ||_______________________||__________________________|
  | _____________________  ||      __   __  _  __    _ |
  ||=|=|=|=|=|=|=|=|=|=|=| __..\/ |  |_|  ||#||==|  / /|
  || | | | | | | | | | | |/\ \  \\|++|=|  || ||==| / / |
  ||_|_|_|_|_|_|_|_|_|_|_/_/\_.___\__|_|__||_||__|/_/__|
  |____________________ /\~()/()~//\ __________________|
  | __   __    _  _     \_  (_ .  _/ _      _     _____|
  ||~~|_|..|__| || |_ _   \ //\\ /  |=|_  /) |___| | | |
  ||--|+|^^|==|1||2| | |__/\ __ /\__| |(\/((\ +|+|=|=|=|
  ||__|_|__|__|_||_|_| /  \ \  / /  \_|_\___/|_|_|_|_|_|
  |_________________ _/    \/\/\/    \_ /   /__________|
  | _____   _   __  |/      \../      \/   /   __   ___|
  ||_____|_| |_|##|_||   |   \/ __\       /=|_|++|_|-|||
  ||______||=|#|--| |\   \   o     \_____/  |~|  | | |||
  ||______||_|_|__|_|_\   \  o     | |_|_|__|_|__|_|_|||
  |_________ __________\___\_______|____________ ______|
  |__    _  /    ________     ______           /| _ _ _|
  |\ \  |=|/   //    /| //   /  /  / |        / ||%|%|%|
  | \/\ |*/  .//____// //   /__/__/ (_)      /  ||=|=|=|
__|  \/\|/   /(____|/ //                    /  /||~|~|~|__
  |___\_/   /________//   ________         /  / ||_|_|_|
  |___ /   (|________/   |\_______\       /  /| |______|
      /                  \|________)     /  / | |
                          _        
                         | |       
                         | |_ ___  
                         | __/ _ \ 
                         | || (_) |
                          \__\___/        
           
                         
                         

";
            string s = @"   
 _________________________________________________________
||-------------------------------------------------------||
||.--.    .-._                        .----.             ||
|||==|____| |H|___            .---.___|""""|_____.--.___ ||
|||  |====| | |xxx|_          |+++|=-=|_  _|-=+=-|==|---|||
|||==|    | | |   | \         |   |   |_\/_|Black|  | ^ |||
|||  |    | | |   |\ \   .--. |   |=-=|_/\_|-=+=-|  | ^ |||
|||  |    | | |   |_\ \_( oo )|   |   |    |Magus|  | ^ |||
|||==|====| |H|xxx|  \ \ |''| |+++|=-=|""""|-=+=-|==|---|||
||`--^----'-^-^---'   `-' ""  '---^---^----^-----^--^---^||
||-------------------------------------------------------||
||-------------------------------------------------------||
||               ___                   .-.__.-----. .---.||
||              |===| .---.   __   .---| |XX|<(*)>|_|^^^|||
||         ,  /(|   |_|III|__|''|__|:x:|=|  |     |=| Q |||
||      _a'{ / (|===|+|   |++|  |==|   | |  |Illum| | R |||
||      '/\\/ _(|===|-|   |  |''|  |:x:|=|  |inati| | Y |||
||_____  -\{___(|   |-|   |  |  |  |   | |  |     | | Z |||
||       _(____)|===|+|[I]|DK|''|==|:x:|=|XX|<(*)>|=|^^^|||
||              `---^-^---^--^--'--^---^-^--^-----^-^---^||
||-------------------------------------------------------||
||_______________________________________________________||
";
            string g = @"  

                        /|~|\       
                       / |=| \         
                      /  | |  \                                           
                     |   | |   |                    
                     |   | |   |                                          
                     |   | |   |      
                     |   |=|   |     
                     |  //A\\  |     
                     | /// \\\ |       
                     |///   \\\|                                          
                     `         `   
";
            string final = @"

                  __     __                           
                  \ \   / /                          
                   \ \_/ /__  _   _ _ __             
                    \   / _ \| | | | '__|            
                     | | (_) | |_| | |                 
                     |_|\___/ \__,_|_| 
         ____              _    _                 _
        |  _ \            | |  | |               | |   
        | |_) | ___   ___ | | _| | __ _ _ __   __| |   
        |  _ < / _ \ / _ \| |/ / |/ _` | '_ \ / _` |  
        | |_) | (_) | (_) |   <| | (_| | | | | (_| |   
        |____/ \___/ \___/|_|\_\_|\__,_|_| |_|\__,_|   
           //               `V'               \\       
          //                 |                 \\      
         //__...--~~~~~~-._  |  _.-~~~~~~--...__\\   
        //__.....----~~~~._\ | /_.~~~~----.....__\\      
       ====================\\|//====================  
                           `---`                 
                                                                                             
";
            

            Console.SetCursorPosition(0, 0);
            Console.Write(first);
            Thread.Sleep(3550);
            Console.Clear();
            
            Console.Write(scnd);
            Thread.Sleep(3000);
            Console.Clear();
            Console.Write(s);
            Thread.Sleep(1500);
            Console.SetCursorPosition(0, 24);
            Console.Write(g);
            Thread.Sleep(3000);
            Console.Clear();
            
            Console.Write(final);
            Thread.Sleep(3500);
            Console.SetCursorPosition(0, 25);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }



        public static int MultipleChoice(bool canCancel, params string[] options)
        {

            
            const int startX = 40;
            const int startY = 10;
            const int optionsPerLine = 1;
            const int spacingPerLine = 15;

            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;
            //Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            string up = @"
                                    __...--~~~~~-._   _.-~~~~~--...__
                                   //               `V'               \\ 
                                  //    What would you like to do?     \\ 
                                 //__...--~~~~~~-._  |  _.-~~~~~~--...__\\ 
                                //__.....----~~~~._\ | /_.~~~~----.....__\\ 
                               ====================\\|//====================
                                                   `---`
";

            Console.SetWindowSize(110, 30);
            Console.SetCursorPosition(100, startY - 8 / optionsPerLine);
            Console.Write(up);
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
               
                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(/* startX + (i % optionsPerLine) * spacingPerLine */ 40, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write(options[i]);
                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < options.Length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.WriteLine();

            return currentSelection;
        }



        public static int UNChoice(bool canCancel, params string[] options)
        {


            const int startX = 40;
            const int startY = 10;
            const int optionsPerLine = 1;
            const int spacingPerLine = 15;

            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            string up = @" 
                                    __...--~~~~~-._   _.-~~~~~--...__
                                   //               `V'               \\ 
                                  //       Choose from categories      \\ 
                                 //__...--~~~~~~-._  |  _.-~~~~~~--...__\\ 
                                //__.....----~~~~._\ | /_.~~~~----.....__\\ 
                               ====================\\|//====================
                                                   `---`
";

            Console.SetWindowSize(110, 30);
            Console.SetCursorPosition(100, startY - 8 / optionsPerLine);
            Console.Write(up);
            Console.ForegroundColor = ConsoleColor.White;

            do
            {

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(/* startX + (i % optionsPerLine) * spacingPerLine */ 40, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.Write(options[i]);
                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < options.Length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.WriteLine();

            return currentSelection;
        }



        public static void WaitAnim()
        {
            var counter = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();

                switch (counter % 4)
                {
                    case 0:
                        {
                            Console.WriteLine("╔════╤╤╤╤════╗");
                            Console.WriteLine("║    │││ \\   ║");
                            Console.WriteLine("║    │││  O  ║");
                            Console.WriteLine("║    OOO     ║");
                            break;
                        };
                    case 1:
                        {
                            Console.WriteLine("╔════╤╤╤╤════╗");
                            Console.WriteLine("║    ││││    ║");
                            Console.WriteLine("║    ││││    ║");
                            Console.WriteLine("║    OOOO    ║");
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("╔════╤╤╤╤════╗");
                            Console.WriteLine("║   / │││    ║");
                            Console.WriteLine("║  O  │││    ║");
                            Console.WriteLine("║     OOO    ║");
                            break;
                        };
                    case 3:
                        {
                            Console.WriteLine("╔════╤╤╤╤════╗");
                            Console.WriteLine("║    ││││    ║");
                            Console.WriteLine("║    ││││    ║");
                            Console.WriteLine("║    OOOO    ║");
                            break;
                        };
                }

                counter++;
                Thread.Sleep(200);
            }
        }
    }
}
