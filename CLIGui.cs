public class ClIGui
{
    CLIPlayer player = new CLIPlayer();
    // CLISettings settings = new CLISettings();
    ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
    CLILogo logo = new CLILogo();


    //CLIItems Items = new CLIItems();
    /*public void chat()
    {
        Console.WriteLine("");
    }*/
    public void InGameControls()
    {
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("enter a action uns /help for available options.");
        Console.Write(">");
        Console.ForegroundColor = CLIPlayer.Color;
        switch (Console.ReadLine())
        {
            case "inventory":
                break;
            case "inv":
                break;
            case "chat":
                break;
            case "thalk":
                break;
            case "101":
                //Items.sustoygun.InUse = true;
                //Items.Start();
                break;
            case "/help":
                Console.WriteLine("inv/inventory for your inventory");
                Console.WriteLine("/ for your ");
                Console.WriteLine("Chat/thalk to thalk");
                break;
            case "help":
                Console.WriteLine("try /help");
                break;
            default:
                break;
        }
    }


}