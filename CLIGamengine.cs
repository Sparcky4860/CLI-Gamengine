﻿// See https://aka.ms/new-console-template for more information
// CLIPlayer player = new CLIPlayer();
// CLISettings settings = new CLISettings();
//ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
//CLIGamePrep gameprep= new CLIGamePrep();
CLILogo logo = new CLILogo();
CLIMenu menu = new CLIMenu();
//CLIConfig config = new CLIConfig();
//clear
Console.Clear();
//test zone
menu.textboxvar= "0";
menu.textboxname = "2257";
menu.textboxnamec = ConsoleColor.Green;
menu.TextBoxstart() ;
Console.WriteLine("hello ???");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
menu.TextBoxsend();

menu.textboxname = "0000";
menu.textboxvar= "1";
menu.textboxnamec = ConsoleColor.Red;
menu.TextBoxstart() ;
Console.WriteLine("are you a furry?");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
menu.TextBoxsend();

//
// CLIGameBackup.ReadBackup(string.Empty); //don't instantly call this, not meant for it
//i nead help
menu.MainMenu();
//end
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("exiting...");
Console.ResetColor();
Thread.Sleep(999);
Console.Clear();
if (CLISettings.Debug == true)
{
    Console.WriteLine("debug:");
    Console.ForegroundColor= ConsoleColor.Blue;
    Console.WriteLine(CLISettings.Debug);
    Console.ResetColor();
    Console.WriteLine("ModingIsOn:");
    Console.ForegroundColor= ConsoleColor.Blue;
    Console.WriteLine(CLISettings.ModingIsOn);
    Console.ResetColor();
    Console.WriteLine("error count: ");
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine(CLIRuntimevar.errors);
    Console.ResetColor();
    Console.WriteLine("bootlogo: ");
    Console.ForegroundColor= ConsoleColor.Blue;
    Console.Write(CLISettings.Bootlogo);
    switch (CLISettings.Bootlogo)
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
    Console.ResetColor();
    Console.WriteLine("moded logo:");
    logo.bootlogo2();
    Console.WriteLine("default logo:");
    logo.bootlogo1();
    Console.WriteLine($"{CLIPlayer.Species} HP{CLIPlayer.Health} SM:{CLIPlayer.Smarts} ST:{CLIPlayer.Strength} SP:{CLIPlayer.Speed} DR;{CLIPlayer.Damageresistance} handequipped:{CLIPlayer.Handequipped} Parasite:{CLIPlayer.Parasite} Requirehost:{CLIPlayer.Requirehost} Requirepower:{CLIPlayer.Requirepower} Requirepowerlev:{CLIPlayer.Requirepowerlev} PartTeck:{CLIPlayer.PartTeck} Speciesablaty:{CLIPlayer.Speciesablaty}");
    //SharedVariables sharedVars = new SharedVariables();
    //sharedVars.Sharedname = name;
    //Console.WriteLine(sharedVars.Sharedname);
}

