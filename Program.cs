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

void bootlogo1()
{
    Console.Clear();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine(" ᐰ    ᐰ  ");
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine();
    Console.WriteLine("    ᐰ    ");
    Console.WriteLine("   ᐰ ᐰ   ");
    Console.WriteLine("  ᐰ   ᐰ  ");
    Console.WriteLine(" ᐰ     ᐰ ");
    Console.WriteLine("ᐰ       ᐰ"); 
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("╔═╗╔═╗");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("┌─┐┬  ┬  ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("╔╦╗┌─┐┌┬┐┌┬┐┌─┐┌┬┐");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("╚═╗║ ╦");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("│  │  │  ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("║║║│ │ ││ ││├┤  ││");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("╚═╝╚═╝");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("└─┘┴─┘┴  ");
    Console.ForegroundColor = ConsoleColor.Yellow; 
    Console.WriteLine("╩ ╩└─┘─┴┘─┴┘└─┘─┴┘"); 
}

// This is the second logo currently in use
void bootlogo2()
{
    Console.Clear();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine(" ᐰ    ᐰ  ");
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine();
    Console.WriteLine("    ᐰ    ");
    Console.WriteLine("   ᐰ ᐰ   ");
    Console.Write("  ᐰ   ᐰ  ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("╔═╗╔═╗");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("┌─┐┬  ┬");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(" ᐰ     ᐰ ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("╚═╗║ ╦");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("│  │  │");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("ᐰ       ᐰ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("╚═╝╚═╝"); 
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("└─┘┴─┘┴");  
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("A stargate fan game.");
    Console.ResetColor(); 
} 
bool mainenuOpen = true;
string name = "none";
bool debug = false;
var bootlogo = 2;
void Optionsave(){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("error ");
    Console.ResetColor(); 
    Console.WriteLine("404");
}
void Optionload(){
    Console.Write(" ");
}
void options()
{
    Console.Clear();
    Console.WriteLine("====option====");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("1. Debug");
    Console.WriteLine("2. Load Game");
    Console.WriteLine("3. Options");
    Console.WriteLine("0. Exit");
    Console.ResetColor(); 
    Console.WriteLine("");
    Console.WriteLine(">");
    var optionsmenu =Console.ReadLine();

    switch (optionsmenu)
    {
        case "1":
            //Console.WriteLine("demo 1");
            debugmenu();
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
            break;
        default:
            options();
            break;
    }
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


//main
void mainenu()
{
Optionload();
switch (bootlogo)
{
    case 1:
    bootlogo1();
    break;
    case 2:
    bootlogo2();
    break;
    default:
    Console.Clear();
    Console.WriteLine("no logo");
    break;
}
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
            Console.Clear();
            break;
        default:
            
            break;
    }
}
void debugmenu(){
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("====\\debug====");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("0. OFF");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("1. ON");
    switch (Console.ReadLine())
    {
        case "1":
            //Console.WriteLine("demo 1");
            debug = true;
            break;
        case "0":
            //Console.WriteLine("demo 2");
            debug = false;
            break;
        case "2":
            //Console.WriteLine("demo 2");
            bootlogo = 1;
            break;
        default:
            debugmenu();
            break;
    }
    Console.ResetColor(); 
}
do{
     mainenu();
}while(mainenuOpen);
if (debug == true)
{
    Console.WriteLine("moded");
    bootlogo1();
}
