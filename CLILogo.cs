public class CLILogo
{
    // CLISettings settings = new CLISettings();
    public void bootlogo1()
    {
        if (CLISettings.Debug == false)
        {
            Console.Clear();
        }
        Console.WriteLine();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.Write("╔═╗╦  ╦");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  ┌─┐┌─┐┌┬┐┌─┐┌┐┌┌─┐┬┌┐┌┌─┐");
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.Write("║  ║  ║");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  │ ┬├─┤│││├┤ ││││ ┬││││├┤ ");
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.Write("╚═╝╩═╝╩");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  └─┘┴ ┴┴ ┴└─┘┘└┘└─┘┴┘└┘└─┘");
        Console.ResetColor();
    }
    public void bootlogo2()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("error ");
        Console.ResetColor();
        Console.WriteLine("404");
    }
    public void bootlogo3()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("error ");
        Console.ResetColor();
        Console.WriteLine("404");
    }
}