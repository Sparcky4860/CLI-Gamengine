#pragma warning disable CS0162
public class CLIMenu
{
    CLILogo logo = new CLILogo();
    ClIPlayer player = new ClIPlayer();
    CLISettings settings = new CLISettings();
    CLIGamePrep gameprep = new CLIGamePrep();
    public void MainMenu()
    {
        do
        {
            mainenu();
        }
        while (settings.mainenuOpen == true);
        void mainenu()
        {
            //Optionload();
            switch (/*bootlogo*/1)
            {
                case 1:
                    logo.bootlogo1();
                    break;
                case 2:
                    break;
                case 3:
                    Console.Clear();
                    logo.bootlogo3();
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
            var menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    //Console.WriteLine("demo 1");
                    gameprep.newgame();
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

    }

    void options()
    {
        Console.Clear();
        Console.ForegroundColor = settings.mcolor; ;
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
        var optionsmenu = Console.ReadLine();

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

    void debugmenu()
    {
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
                //Optionsave();
                break;
            case "mod=0":
                //Console.WriteLine("demo 2");
                settings.ModingIsOn = false;
                //Optionsave();
                break;
            case "mod=true":
                //Console.WriteLine("demo 2");
                settings.ModingIsOn = true;
                //Optionsave();
                break;
            case "mod=false":
                //Console.WriteLine("demo 2");
                settings.ModingIsOn = false;
                //Optionsave();
                break;
            case "nfsw=false":
                settings.NfswIsOn = false;
                break;
            case "nfsw=0":
                settings.NfswIsOn = false;
                break;
            case "nfsw=1":
                settings.NfswIsOn = true;
                break;
            case "nfsw=true":
                settings.NfswIsOn = true;
                break;
            default:
                debugmenu();
                break;
        }
        Console.ResetColor();
    }

    void loadgame()
    {
        Console.WriteLine("error 404");
        Console.Clear();
    }

    public string textboxvar { get; set; } = "1";
    public string textboxname { get; set; } = "";
    public ConsoleColor textboxnamec { get; set; } =ConsoleColor.White;
    
    public void TextBox()
    {
        switch (textboxvar)
        {
            case "1":
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"####/");
                Console.WriteLine(textboxname,Console.ForegroundColor = textboxnamec);
                Console.ForegroundColor = ConsoleColor.White;
            break;
            case "0":
            break;
            default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("textvar mode:error 404 perss enter to contue.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            break;
        }
    }
}