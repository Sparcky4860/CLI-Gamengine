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


// defolts 

//using System.Reflection.Metadata;
//using System.Runtime.CompilerServices;
//ConsoleStuff Game = new ConsoleStuff();
//pregame pregame = new pregame();
//Game.SayHello();
ClIPlayer player = new ClIPlayer(); // Create an instance of ClIPlayer
CLISettings settings = new CLISettings();
ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
CLIGamePrep gameprep= new CLIGamePrep();
#pragma warning disable CS0162
// Access name through the player instance
//var savename = "none";
// to work on

//bool mainenuOpen = true;
//bool debug = false;
//bool ModingIsOn = false;
//bool CustomLogoIsOn = false;
//var bootlogo = 1;
//var mcolor = ConsoleColor.Gray;
//var dmcolor = ConsoleColor.DarkGray;
//var color = ConsoleColor.Gray;
//player.health = 20;
//var handequipped = 2;
//var smarts = 45;
//var strength = 32;
//var speed = 10;
//bool Parasite = false;
//bool Requirehost = false;
//bool Requirepower = false;
//var Requirepowerlev = 0;
//bool PartTeck = false;
//var Damageresistance = 1.001;
//var Speciesablaty = "";
//var protohexnum = -1;
//bool caneditname = true;
//var sex = "male";
//var Species = "Human";
//var pronoud = "thay him";
//varpush();
//Game.start();
//bootlogo = pregame.Sharedbootlogo + 0;


// this is the first logo option not in use
/*void bootlogo1()
{
    if (debug == false){
        Console.Clear();
    }
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

// This is the second logo currently not in use 
void bootlogo2()
{
     if (debug == false){
        Console.Clear();
    }
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
} */

//custubootlogo
void bootlogo1(){
    if (settings.debug == false){
    Console.Clear();
    }
    Console.WriteLine();
    Console.ForegroundColor = settings.mcolor;
    Console.Write("╔═╗╦  ╦");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("  ┌─┐┌─┐┌┬┐┌─┐┌┐┌┌─┐┬┌┐┌┌─┐");
    Console.ForegroundColor = settings.mcolor;;
    Console.Write("║  ║  ║");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("  │ ┬├─┤│││├┤ ││││ ┬││││├┤ ");
    Console.ForegroundColor = settings.mcolor;;
    Console.Write("╚═╝╩═╝╩");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("  └─┘┴ ┴┴ ┴└─┘┘└┘└─┘┴┘└┘└─┘");
    Console.ResetColor(); 
}
void bootlogo2(){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("error ");
    Console.ResetColor(); 
    Console.WriteLine("404");
}
void bootlogo3(){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("error ");
    Console.ResetColor(); 
    Console.WriteLine("404");
}

// Saving functions not gameplay

void Optionsave(){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("error ");
    Console.ResetColor(); 
    Console.WriteLine("404");
}
void Optionload(){
    Console.Write(" ");
}

// Options

void options()
{
    Console.Clear();
    Console.ForegroundColor = settings.mcolor;;
    Console.WriteLine("====option====");
    Console.ForegroundColor = settings.dmcolor;
    Console.WriteLine("1. Debug");
    Console.Write("2. ");
     if (settings.ModingIsOn == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
    Console.WriteLine("moding");
    Console.ForegroundColor = settings.dmcolor;
    Console.WriteLine("3. Menu Colour");
    Console.WriteLine("0. Exit");
    Console.ResetColor(); 
    Console.WriteLine("");
    Console.Write(">");
    var optionsmenu =Console.ReadLine();

    switch (optionsmenu)
    {
        case "1":
            //Console.WriteLine("demo 1");
            debugmenu();
            break;
        case "2":
            //Console.WriteLine("demo 2");
            if (settings.ModingIsOn == true)
            {
                settings.ModingIsOn = false;
            }
            else
            {
                settings.ModingIsOn = true;
            }
            options();
            break;
        case "3":
            //Console.WriteLine("demo 3");
            MMAColoursel();
            break;
        case "0":
            Console.Clear();
            break;
        default:
            options();
            break;
    }
}

void MMAColoursel()
{
            Console.Clear();
            Console.ForegroundColor = settings.dmcolor;
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("red");
            Console.ForegroundColor = settings.dmcolor;
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Magenta");
            Console.ForegroundColor = settings.dmcolor;
            Console.Write("3. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow");
            Console.ForegroundColor = settings.dmcolor;
            Console.Write("4. ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green");
            Console.ForegroundColor = settings.dmcolor;
            Console.Write("5. ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ForegroundColor = settings.dmcolor;
            Console.Write("6. ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cyan");
            Console.ForegroundColor = settings.dmcolor;
            Console.Write("7. ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Gray");
            Console.ForegroundColor = settings.dmcolor;
            Console.WriteLine("");
            Console.Write(">");
            Console.ForegroundColor = ConsoleColor.White;
            switch (Console.ReadLine())
            {
                case "1":
                settings.mcolor = ConsoleColor.Red;
                settings.dmcolor = ConsoleColor.DarkRed;
                break;
                case "2":
                settings.mcolor = ConsoleColor.Magenta;
                settings.dmcolor = ConsoleColor.DarkMagenta;
                break;
                case "3":
                settings.mcolor = ConsoleColor.Yellow;
                settings.dmcolor = ConsoleColor.DarkYellow;
                break;
                case "4":
                settings.mcolor = ConsoleColor.Green;
                settings.dmcolor = ConsoleColor.DarkGreen;
                break;
                case "5":
                settings.mcolor = ConsoleColor.Blue;
                settings.dmcolor = ConsoleColor.DarkBlue;
                break;
                case "6":
                settings.mcolor = ConsoleColor.Cyan;
                settings.dmcolor = ConsoleColor.DarkCyan;
                break;
                case "7":
                settings.mcolor = ConsoleColor.Gray;
                settings.dmcolor = ConsoleColor.DarkGray;
                break;
                default:
                MMAColoursel();
                break;
            } 
}

// Game save loading

void loadgame()
{
    Console.WriteLine("error 404");
    Console.Clear();
}

// start a newgame

void newgame()
{
    settings.mainenuOpen = false;
    Console.Clear();
    Console.WriteLine("set a name for your save:");
    miscellaneous.savename = Console.ReadLine();
    //Playerinfo();
    gameprep.Playerinfo();

}

//main

void mainenu()
{
Optionload();
switch (/*bootlogo*/1)
{
    case 1:
    bootlogo1();
    break;
    case 2:
    bootlogo2();
    break;
    case 3:
    Console.Clear();
    bootlogo3();
    break;
    default:
    Console.Clear();
    Console.WriteLine("no logo");
    break;
}
Console.ForegroundColor = settings.mcolor;
Console.WriteLine("=====menu=====");
Console.ForegroundColor = settings.dmcolor;
Console.WriteLine("1. New Game");
Console.WriteLine("2. Load Game");
Console.WriteLine("3. Options");
Console.WriteLine("0. Exit");
Console.ResetColor(); 
Console.WriteLine("");
Console.Write(">");
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
            break;
            settings.mainenuOpen = false;
        default:
            
            break;
    }
}

//debug submenu

void debugmenu(){
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("====\\debug====");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("0. OFF");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("1. ON");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("you can also write commands here");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("");
    Console.Write(">");
    switch (Console.ReadLine())
    {
        case "1":
            //Console.WriteLine("demo 1");
            settings.debug = true;
            Console.Clear();
            break;
        case "0":
            //Console.WriteLine("demo 2");
            settings.debug = false;
            break;
        case "logo=1":
            //Console.WriteLine("demo 2");
            settings.bootlogo = 1;
            settings.CustomLogoIsOn = true;
            break;
        case "logo=2":
            //Console.WriteLine("demo 2");
            settings.bootlogo = 2;
            settings.CustomLogoIsOn = true;
            break;
        case "logo=0":
            //Console.WriteLine("demo 2");
            settings.bootlogo = 0;
            settings.CustomLogoIsOn = true;
            break;
        case "logo=3":
            //Console.WriteLine("demo 2");
            settings.bootlogo = 3;
            settings.CustomLogoIsOn = true;
            break;
        case "mod=1":
            //Console.WriteLine("demo 2");
            settings.ModingIsOn = true;
            Optionsave();
            break;
        case "mod=0":
            //Console.WriteLine("demo 2");
            settings.ModingIsOn = false;
            Optionsave();
            break;
        case "mod=true":
            //Console.WriteLine("demo 2");
            settings.ModingIsOn = true;
            Optionsave();
            break;
        case "mod=false":
            //Console.WriteLine("demo 2");
            settings.ModingIsOn = false;
            Optionsave();
            break;
        case "nfsw=false":
        break;
        default:
            debugmenu();
            break;
    }
    Console.ResetColor(); 
}

// menu logic

do{
     mainenu();
}while(settings.mainenuOpen);

//end

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("exiting...");
            Console.ResetColor(); 
            Thread.Sleep(999);
            Console.Clear();
if (settings.debug == true)
{
    Console.WriteLine("debug:");
    Console.WriteLine(settings.debug);
    Console.WriteLine("ModingIsOn:");
    Console.WriteLine(settings.ModingIsOn);
    Console.WriteLine("default menu:");
    bootlogo1();
    Console.WriteLine("moded menu:");
    bootlogo2();
    Console.WriteLine("bootlogo: ");
    Console.Write(settings.bootlogo);
    switch (settings.bootlogo)
    {
        case 1:
        Console.WriteLine(" bootlogo");
        break;
        case 2:
        Console.WriteLine(" moded menu");
        break;
        default:
        Console.WriteLine(" no logo");
        break;
    }
    //SharedVariables sharedVars = new SharedVariables();
    //sharedVars.Sharedname = name;
    //Console.WriteLine(sharedVars.Sharedname);
    Console.WriteLine($"{player.Species} HP{player.health} SM:{player.smarts} ST:{player.strength} SP:{player.speed} DR;{player.Damageresistance} handequipped:{player.handequipped} Parasite:{player.Parasite} Requirehost:{player.Requirehost} Requirepower:{player.Requirepower} Requirepowerlev:{player.Requirepowerlev} PartTeck:{player.PartTeck} Speciesablaty:{player.Speciesablaty}");
}

