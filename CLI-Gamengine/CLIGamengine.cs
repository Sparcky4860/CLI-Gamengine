// See https://aka.ms/new-console-template for more information
ClIPlayer player = new ClIPlayer(); 
CLISettings settings = new CLISettings();
//ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
//CLIGamePrep gameprep= new CLIGamePrep();
CLILogo logo = new CLILogo();
CLIMenu menu = new CLIMenu();
//CLIConfig config = new CLIConfig();

menu.MainMenu();
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
    logo.bootlogo1();
    Console.WriteLine("moded menu:");
    logo.bootlogo2();
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

