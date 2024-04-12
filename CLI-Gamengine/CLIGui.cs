public class ClIGui
{
    ClIPlayer player = new ClIPlayer(); 
    CLISettings settings = new CLISettings();
    ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
    /*public void chat()
    {
        Console.WriteLine("");
    }*/
    public void InGameControls()
    {
        Console.ForegroundColor = settings.mcolor;
        Console.WriteLine("enter a action uns /help for available options.");
        Console.Write(">");
        Console.ForegroundColor = player.color;
        switch (Console.ReadLine())
        {
            case "inventory":
            break;
            case "inv":
            break;
            case "/help":
            Console.WriteLine("inv/inventory for your inventory");
            break;
            case "help":
            Console.WriteLine("try /help");
            break;
            default:
            break;
        }
    }
}