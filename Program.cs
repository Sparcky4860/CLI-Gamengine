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

void bootlogo2()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine(" ᐰ    ᐰ  ");
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine();
    Console.WriteLine("    ᐰ    ");
    Console.WriteLine("   ᐰ ᐰ   ");
    Console.WriteLine("  ᐰ   ᐰ  ╔═╗╔═╗┌─┐┬  ┬");
    Console.WriteLine(" ᐰ     ᐰ ╚═╗║ ╦│  │  │");
    Console.WriteLine("ᐰ       ᐰ╚═╝╚═╝└─┘┴─┘┴"); 
    Console.ResetColor();
    Console.WriteLine("A stargate fan game."); 
} 
void mainenu()
{
bootlogo2();
Console.WriteLine("=====menu=====");
Console.WriteLine("1. demo");
Console.WriteLine("2. demo");
Console.WriteLine("3. demo");
Console.WriteLine("0. exit");
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
            Console.WriteLine("exiting...");
            Thread.Sleep(999);
            mainenuOpen = false;
            break;
        default:
            
            break;
    }
}

void options()
{
    throw new NotImplementedException();
}

void loadgame()
{
    throw new NotImplementedException();
}

void newgame()
{
    throw new NotImplementedException();
}



do{
     mainenu();
}while(mainenuOpen);