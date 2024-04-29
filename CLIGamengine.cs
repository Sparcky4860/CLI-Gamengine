// See https://aka.ms/new-console-template for more information
// CLIPlayer player = new CLIPlayer();
// CLISettings settings = new CLISettings();
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

