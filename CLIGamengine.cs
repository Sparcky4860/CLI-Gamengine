// See https://aka.ms/new-console-template for more information
CLIPlayer player = new CLIPlayer();
CLISettings settings = new CLISettings();
//ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
//CLIGamePrep gameprep= new CLIGamePrep();
CLILogo logo = new CLILogo();
CLIMenu menu = new CLIMenu();
//CLIConfig config = new CLIConfig();
//clear
Console.Clear();
//test zone
menu.textboxvar= "1";
menu.textboxname = "2257";
menu.textboxnamec = ConsoleColor.Green;
menu.TextBox() ;

Console.WriteLine("press enter to contuu");
Console.ReadLine();
menu.textboxname = "0000";
menu.textboxnamec = ConsoleColor.Red;
menu.TextBox() ;

Console.WriteLine("press enter to contuu");
Console.ReadLine();

menu.textboxvar= "";
menu.TextBox() ;
//
CLIGameBackup.ReadBackup(string.Empty);
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
    Console.WriteLine(CLISettings.Debug);
    Console.WriteLine("ModingIsOn:");
    Console.WriteLine(CLISettings.ModingIsOn);
    Console.WriteLine("default menu:");
    logo.bootlogo1();
    Console.WriteLine("moded menu:");
    logo.bootlogo2();
    Console.WriteLine("bootlogo: ");
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
    //SharedVariables sharedVars = new SharedVariables();
    //sharedVars.Sharedname = name;
    //Console.WriteLine(sharedVars.Sharedname);
    Console.WriteLine($"{CLIPlayer.Species} HP{CLIPlayer.Health} SM:{CLIPlayer.Smarts} ST:{CLIPlayer.Strength} SP:{CLIPlayer.Speed} DR;{CLIPlayer.Damageresistance} handequipped:{CLIPlayer.Handequipped} Parasite:{CLIPlayer.Parasite} Requirehost:{CLIPlayer.Requirehost} Requirepower:{CLIPlayer.Requirepower} Requirepowerlev:{CLIPlayer.Requirepowerlev} PartTeck:{CLIPlayer.PartTeck} Speciesablaty:{CLIPlayer.Speciesablaty}");
}

