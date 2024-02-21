// See https://aka.ms/new-console-template for more information
/*
   ᐰᐰ    
 ᐰ    ᐰ  
   ᐰᐰ    
          
    ᐰ    
   ᐰ ᐰ   
  ᐰ   ᐰ  
 ᐰ     ᐰ 
ᐰ       ᐰ
╔═╗╔═╗┌─┐┬  ┬
╚═╗║ ╦│  │  │
╚═╝╚═╝└─┘┴─┘┴
Console.ForegroundColor = ConsoleColor.Red; // Change text color to red
Console.WriteLine("This is some text");
Console.ResetColor(); // Reset the color
*/

// this is the first logo option not in use

/*void bootlogo1()
{
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine(" ᐰ    ᐰ  ");
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine();
    Console.WriteLine("    ᐰ    ");
    Console.WriteLine("   ᐰ ᐰ   ");
    Console.WriteLine("  ᐰ   ᐰ  ");
    Console.WriteLine(" ᐰ     ᐰ ");
    Console.WriteLine("ᐰ       ᐰ"); 
    Console.WriteLine("╔═╗╔═╗┌─┐┬  ┬");
    Console.WriteLine("╚═╗║ ╦│  │  │");
    Console.WriteLine("╚═╝╚═╝└─┘┴─┘┴"); 
}*/

// This is the second logo currently in use
bool mainenuOpen = true;
string name = "none";

void bootlogo2()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine(" ᐰ    ᐰ  ");
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine();
    Console.WriteLine("    ᐰ    ");
    Console.WriteLine("   ᐰ ᐰ   ");
    Console.WriteLine("  ᐰ   ᐰ  ╔═╗╔═╗┌─┐┬  ┬");
    Console.WriteLine(" ᐰ     ᐰ ╚═╗║ ╦│  │  │");
    Console.WriteLine("ᐰ       ᐰ╚═╝╚═╝└─┘┴─┘┴"); 
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("A stargate fan game.");
    Console.ResetColor(); 
} 
void mainenu()
{
bootlogo2();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=====menu=====");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("1. New Game");
Console.WriteLine("2. Load Game");
Console.WriteLine("3. Options");
Console.WriteLine("0. Exit");
Console.ResetColor(); 
Console.WriteLine("");
Console.WriteLine(">");
var menu =Console.ReadLine();

    switch (menu)
    {
        case "1":
            //Console.WriteLine("demo 1");
            newgame();
            break;
        case "2":
            //Console.WriteLine("demo 2");
            loadgame();
            break;
        case "3":
            //Console.WriteLine("demo 3");
            options();
            break;
        case "0":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("exiting...");
            Console.ResetColor(); 
            Thread.Sleep(999);
            mainenuOpen = false;
            break;
        default:
            
            break;
    }
}

void options()
{
    Console.WriteLine("error 404");
    Console.Clear();
}

void loadgame()
{
    Console.WriteLine("error 404");
    Console.Clear();
}

void newgame()
{
    mainenuOpen = false;
    Console.Clear();
    Console.WriteLine("name:");
    name = Console.ReadLine();
}



do{
     mainenu();
}while(mainenuOpen);