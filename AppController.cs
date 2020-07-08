using System;
using library.Models;

namespace library
{
  public class App
  {
    public Library Library {get; set; }
    public bool Running { get; private set; }
    public void Run()
    {
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Library = new Library("Boise, ID", "Jake's Books");
      Console.WriteLine($"\nWelcome to {Library.Name} in {Library.Location}");
      Console.WriteLine("----------------------------------------------");
      Running = true;
      while (Running)
      {
        Console.WriteLine("What would you like to do? Books(b)/Magazines(m)/Leave(n)");
        Console.WriteLine("---------------------------------------------------------------");
        string input = Console.ReadLine().ToLower();
        switch (input)
        {
          case "b":
            CheckOut();
          break;
          case "m":
            CheckOutMagazine();
          break;
          case "n":
          Console.Clear();
            Console.WriteLine("Then what are you botherin me for?");
            Running = false;
            break;
            case "death be not proud":
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine(@"
            
             *********
           *************
          *****     *****
         ***           ***
        ***             ***
        **    0     0    **
        **               **                  ____
        ***             ***             //////////
        ****           ****        ///////////////  
        *****         *****    ///////////////////
        ******       ******/////////         |  |
      *********     ****//////               |  |
   *************   **/////*****              |  |
  *************** **///***********          *|  |*
 ************************************    ****| <=>*
*********************************************|<===>* 
*********************************************| <==>*
***************************** ***************| <=>*
******************************* *************|  |*
********************************** **********|  |*  
*********************************** *********|  |

");
          Console.WriteLine("\nYour time has come.");
          Console.WriteLine("------------------------------------------");
          Running = false;
            break;
          case "speak friend and enter":
          Console.Clear();
          Console.WriteLine("\n");
            Console.WriteLine(@"

 ______________     _             _,-----------._        ___
|              |   (_,.-      _,-'_,-----------._`-._    _)_)
| THE _  _  _  |      |     ,'_,-'  ___________  `-._`.
| |  / \|_)| \ |     `'   ,','  _,-'___________`-._  `.`.
| |__\_/| \|_/ |        ,','  ,'_,-'     .     `-._`.  `.`.
|              |       /,'  ,','        >|<        `.`.  `.\
| OF THE  _ _  |      //  ,','      ><  ,^.  ><      `.`.  \\
| |_)||\|/_(_  |     //  /,'      ><   / | \   ><      `.\  \\
| | \|| |\_|_) |    //  //      ><    \/\^/\/    ><      \\  \\
|______________|   ;;  ;;              `---'              ::  ::
                   ||  ||              (____              ||  ||
 DOORS OF DURIN   _||__||_            ,'----.            _||__||_
                 (o.____.o)____        `---'        ____(o.____.o)
                   |    | /,--.)                   (,--.\ |    |
                   |    |((  -`___               ___`   ))|    |
                   |    | \\,'',  `.           .'  .``.// |    |
                   |    |  // (___,'.         .'.___) \\  |    |
                  /|    | ;;))  ____) .     . (____  ((\\ |    |\
                  \|.__ | ||/ .'.--.\/       `/,--.`. \;: | __,|;
                   |`-,`;.| :/ /,'  `)-'   `-('  `.\ \: |.;',-'|
                   |   `..  ' / \__.'         `.__/ \ `  ,.'   |
                   |    |,\  /,                     ,\  /,|    |
                   |    ||: : )          .          ( : :||    |
                  /|    |:; |/  .      ./|\,      ,  \| :;|    |\
                  \|.__ |/  :  ,/-    <--:-->    ,\.  ;  \| __,|;
                   |`-.``:   `'/-.     '\|/`     ,-\`;   ;'',-'|
                   |   `..   ,' `'       '       `  `.   ,.'   |
                   |    ||  :                         :  ||    |
                   |    ||  |                         |  ||    |
                   |    ||  |                         |  ||    |
                   |    |'  |            _            |  `|    |
                   |    |   |          '|))           |   |    |
                   ;____:   `._        `'           _,'   ;____:
                  {______}     \___________________/     {______}
              SSt |______|_______________________________|______|
            ");
            break;
        }

      }
    }
      void CheckOut()
      {
        Console.Clear();
        Library.ViewBooks();
        Console.WriteLine("\nThese are the only books we have so either pick one or get outta here.");
         Console.WriteLine("------------------------------------------------------------");
         string selection = Console.ReadLine();
         Book selectedBook = Library.checkBookAvailability(selection);
         if (selectedBook == null)
         {
           Console.WriteLine("Invalid Selection");
           return;
         }
         Console.WriteLine($"Are you sure you want to check out {selectedBook.Title}? (y/n)");

         Console.WriteLine("------------------------------------------------------------");
         string input = Console.ReadLine();
         switch(input)
         {
          case "y":
         int quantity;
         string checkedOutBook = "1";
         bool valid = Int32.TryParse(checkedOutBook, out quantity);
         
      
         if (selectedBook.InStock >= quantity)
         {
           selectedBook.InStock -= quantity;
           Console.WriteLine($"Thanks for checking out {selectedBook.Title} by {selectedBook.Author}");
           Console.WriteLine("------------------------------------------------------------");
           return;
         }
         break;
         }

      }
        void CheckOutMagazine()
        {
        Console.Clear();
        Console.WriteLine("Would you like to check out a magazine?");
        Library.ViewMagazines();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Pick Something");
        Console.WriteLine("------------------------------------");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\nYou can't checkout magazines stupid.");
        Console.WriteLine("------------------------------------");
        

        }

    }
  }


