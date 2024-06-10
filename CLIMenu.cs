using System;
using System.IO;

public class CLIMenu
{
    CLILogo logo = new CLILogo();
    // CLIPlayer player = new CLIPlayer();
    //CLISettings settings = new CLISettings();
    CLIGamePrep gameprep = new CLIGamePrep();
    public void MainMenu()
    {
        // why are you doing it like this??
        // do
        // {
        //     mainenu();
        // }
        // while (CLISettings.MainenuOpen == true);
        // void mainenu()
        while (CLISettings.MainenuOpen)
        {
            //Optionload();
            if (CLISettings.Debug == false){
            // Console.Clear(); // stawp clearing for nowww
            }
            switch (CLISettings.Bootlogo)
            {
                case 1:
                    logo.bootlogo1();
                    break;
                case 2:
                    break;
                case 3:
                    // Console.Clear();
                    logo.bootlogo3();
                    break;
                default:
                    // Console.Clear();
                    Console.WriteLine("no logo");
                    break;
            }
            Console.ForegroundColor = CLISettings.Mcolor;
            Console.WriteLine("=====menu=====");
            Console.ForegroundColor = CLISettings.Dmcolor;
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
                    // break; // nothing happens after the break
                    CLISettings.MainenuOpen = false;
                    break;
                    //ClIGameBackup.WriteBackup(/*i dont know waht to put here*/); // don't do it here!
                default:

                    break;
            }
        }

    }

    void options()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.WriteLine("====option====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Debug");
        Console.Write("2. ");
        if (CLISettings.ModingIsOn == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("moding");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("3. Menu Colour");
        Console.WriteLine("4. Save");
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
                if (CLISettings.ModingIsOn == true)
                {
                    CLISettings.ModingIsOn = false;
                }
                else
                {
                    CLISettings.ModingIsOn = true;
                }
                options();
                break;
            case "3":
                //Console.WriteLine("demo 3");
                MMAColoursel();
                break;
            case "4":
                //Console.WriteLine("demo 3");
                CLIGameBackup.WriteBackup("s");
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
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("1. ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("red");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("2. ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Magenta");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("3. ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Yellow");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("4. ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Green");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("5. ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("6. ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Cyan");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("7. ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Gray");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("");
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.White;
        switch (Console.ReadLine())
        {
            case "1":
                CLISettings.Mcolor = ConsoleColor.Red;
                CLISettings.Dmcolor = ConsoleColor.DarkRed;
                break;
            case "2":
                CLISettings.Mcolor = ConsoleColor.Magenta;
                CLISettings.Dmcolor = ConsoleColor.DarkMagenta;
                break;
            case "3":
                CLISettings.Mcolor = ConsoleColor.Yellow;
                CLISettings.Dmcolor = ConsoleColor.DarkYellow;
                break;
            case "4":
                CLISettings.Mcolor = ConsoleColor.Green;
                CLISettings.Dmcolor = ConsoleColor.DarkGreen;
                break;
            case "5":
                CLISettings.Mcolor = ConsoleColor.Blue;
                CLISettings.Dmcolor = ConsoleColor.DarkBlue;
                break;
            case "6":
                CLISettings.Mcolor = ConsoleColor.Cyan;
                CLISettings.Dmcolor = ConsoleColor.DarkCyan;
                break;
            case "7":
                CLISettings.Mcolor = ConsoleColor.Gray;
                CLISettings.Dmcolor = ConsoleColor.DarkGray;
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
                CLISettings.Debug = true;
                Console.Clear();
                break;
            case "0":
                //Console.WriteLine("demo 2");
                CLISettings.Debug = false;
                break;
            case "logo=1":
                //Console.WriteLine("demo 2");
                CLISettings.Bootlogo = 1;
                CLISettings.CustomLogoIsOn = true;
                break;
            case "logo=2":
                //Console.WriteLine("demo 2");
                CLISettings.Bootlogo = 2;
                CLISettings.CustomLogoIsOn = true;
                break;
            case "logo=0":
                //Console.WriteLine("demo 2");
                CLISettings.Bootlogo = 0;
                CLISettings.CustomLogoIsOn = true;
                break;
            case "logo=3":
                //Console.WriteLine("demo 2");
                CLISettings.Bootlogo = 3;
                CLISettings.CustomLogoIsOn = true;
                break;
            case "mod=1":
                //Console.WriteLine("demo 2");
                CLISettings.ModingIsOn = true;
                //Optionsave();
                break;
            case "mod=0":
                //Console.WriteLine("demo 2");
                CLISettings.ModingIsOn = false;
                //Optionsave();
                break;
            case "mod=true":
                //Console.WriteLine("demo 2");
                CLISettings.ModingIsOn = true;
                //Optionsave();
                break;
            case "mod=false":
                //Console.WriteLine("demo 2");
                CLISettings.ModingIsOn = false;
                //Optionsave();
                break;
            case "nfsw=false":
                CLISettings.NfswIsOn = false;
                break;
            case "nfsw=0":
                CLISettings.NfswIsOn = false;
                break;
            case "nfsw=1":
                CLISettings.NfswIsOn = true;
                break;
            case "nfsw=true":
                CLISettings.NfswIsOn = true;
                break;
            default:
                debugmenu();
                break;
        }
        Console.ResetColor();
    }

    void loadgame()
    {
        // Console.WriteLine("error 404");
        // Console.Clear();
        // this is where the implementation goes :3
        // temp stop main menu
        CLISettings.MainenuOpen = false; // make sure to set this true before EVERY return

        // test code
        // fs paf, and the path of the saves dir
        string paf = Directory.GetCurrentDirectory();
        string savpaf = Path.Combine(paf,"saves");
        // Console.WriteLine("The current directory is {0}", paf);
        // Console.WriteLine(savpaf);

        // actually do checks
        Console.WriteLine("Oh? So you have a save file? (pls don't break it)");
        if(!Directory.Exists(savpaf)){
            Console.WriteLine("You don't got a saves directory! You defintely don't got any saves.");
            CLISettings.MainenuOpen = true;
            return;
        }
        // this is more useful (when I deploy it)
        string currentFileEnd = CLIGameBackup.getCurrentFileEnd();
        // gets items in the directory
        string[] items = Directory.GetFiles(savpaf);
        // adds only files to list
        List<string> files = [];
        foreach(string x in items){ // not used to foreach like that, rather "for(int x:y)"
            Console.WriteLine(x);
            // this already has only files, so make sure ite ends right :3
            if(x.Length > 4 && x.Substring(x.Length-currentFileEnd.Length).Equals(currentFileEnd)){
                // strip off the top of the file path, and the file extension
                //substring is start, then length
                files.Add(x.Substring(savpaf.Length+1,x.Length-savpaf.Length-currentFileEnd.Length-1)); // +1 makes it work as well as the -1
            }
        }
        int totalItems = files.Count;

        // now exit if there is no files
        if(totalItems == 0){
            Console.WriteLine("No save files found qwp");
            CLISettings.MainenuOpen = true;
            return;
        }
        Console.WriteLine("The following are your save game load options:");
        for(int x = 0; x < totalItems; x++){
            Console.WriteLine((x+1)+". "+files.ElementAt(x)); // note, subtract one from input
        }
        
        Console.WriteLine("You can use either the numbers or the filename to restore. (if you fluff up, it won't work, and you have to redo it. \"exit\" to exit)");
        Console.Write(">");
        string? req = Console.ReadLine();
        if(req == string.Empty || req == null){
            Console.WriteLine("Your input is empty... This will not work.");
            CLISettings.MainenuOpen = true;
            return;
        }
        if(req.Equals("exit")){
            Console.WriteLine("Exiting per user request");
            CLISettings.MainenuOpen = true;
            return;
        }

        string fin = ""; // to be used for the final load call, assigned here even though it will get assigned anyway
        // using the weird TryParse thing, if its true, the out is an int, otherwise its a str
        if (int.TryParse(req, out int i)) {
            // last bit of input sanitization
            if(i < 1){
                Console.WriteLine("... don't go at or below zero");
                CLISettings.MainenuOpen = true;
                return;
            }
            // taking one off of input
            if(i > totalItems - 1){
                Console.WriteLine("That number is too beeg");
                CLISettings.MainenuOpen = true;
                return;
            }
            fin = files.ElementAt(i-1);
        }
        else{
            // checks to see if the exact name is in the files of each thing
            bool nFinds = true; // status of finding a value
            foreach(string x in files) {
                if(req.Equals(x)) { // checks each item to see if it is in the list before using it
                    fin = x;
                    nFinds = false;
                    break; // no enable mainmenu because this is not a return, even though ourple
                }
            }
            if(nFinds){
                Console.WriteLine("Your value was not found!");
                CLISettings.MainenuOpen = true;
                return; // failure
            }
        }
        // fin now has the filename, now to add the full path back onto it
        fin = Path.Combine(savpaf,fin+currentFileEnd);

        // fin should now be set properly, so run the command
        // await Task.Run(() => YourMethod());
        // bool result = await Task.Run(() => CLIGameBackup.ReadBackup(fin));
        bool result = CLIGameBackup.ReadBackup(fin);
        if(!result){
            Console.WriteLine("Something went wrong! Likely, this is an error with the save file.");
            CLISettings.MainenuOpen = true;
            return;
        }
        Console.WriteLine("Session sucessfully restored!");
        // we're done, so now restore
        CLISettings.MainenuOpen = true;
    }

     public string textboxvar { get; set; } = "1";
    public string textboxname { get; set; } = "";
    public ConsoleColor textboxnamec { get; set; } =ConsoleColor.White;
    
    public void TextBoxstart()
    {
        switch (textboxvar)
        {
            case "1":
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"####/");
                Console.WriteLine(textboxname,Console.ForegroundColor = textboxnamec);
                Console.ForegroundColor = CLISettings.Mcolor;
            break;
            case "0":
            Console.WriteLine();
                Console.Clear();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"####/");
                Console.WriteLine(textboxname,Console.ForegroundColor = textboxnamec);
                Console.ForegroundColor = CLISettings.Mcolor;
            break;
            default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("textvar mode:error 404 perss enter to contue.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            break;
        }
    }
        public void TextBoxsend()
    {
        switch (textboxvar)
        {
            case "1":
                Console.WriteLine();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($">_");
                Console.ForegroundColor = CLIPlayer.Color;
                //var r = Console.ReadLine();
                Console.ForegroundColor = CLISettings.Mcolor;
                //return r;
            break;
            case "0":
            Console.WriteLine();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"next");
                Console.ReadLine();
                //return "null";
            break;
            default:
            break;
        }
    }
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