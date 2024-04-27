public class CLISpecieList : CLIGamePrep
{
    ClIPlayer player = new ClIPlayer();
    CLISettings settings = new CLISettings();
    ClIMiscellaneous miscellaneous = new ClIMiscellaneous();

    void Human()
    {
        player.Species = "Human";
        player.health = 20;
        player.handequipped = 2;
        player.smarts = 45;
        player.speed = 10;
        player.strength = 32;
        player.Parasite = false;
        player.Requirehost = false;
        player.Requirepower = false;
        player.Requirepowerlev = 0;
        player.PartTeck = false;
        player.Speciesablaty = "ancientGRool";
        player.caneditname = true;
    }
    /*void Goauld()
    {
        player.Species = "Goa'uld";
        player.health = 30;
        player.handequipped = 2;
        player.smarts = 55;
        player.speed = 12;
        player.strength = 40;
        player.Parasite = true;
        player.Requirehost = true;
        player.Requirepower = false;
        player.Requirepowerlev = 0;
        player.PartTeck = false;
        player.Speciesablaty = "";
        player.caneditname = true;
    }

    void Tokra()
    {
        player.Species = "Tok'ra";
        player.health = 30;
        player.handequipped = 2;
        player.smarts = 55;
        player.speed = 12;
        player.strength = 40;
        player.Parasite = true;
        player.Requirehost = true;
        player.Requirepower = false;
        player.Requirepowerlev = 0;
        player.PartTeck = false;
        player.Speciesablaty = "";
        player.caneditname = true;
    }*/

    void CatBoyGirl()
    {
        player.Species = "Cat Boy/girl";
        player.health = 18;
        player.handequipped = 3;
        player.smarts = 45;
        player.speed = 15;
        player.strength = 32;
        player.Parasite = false;
        player.Requirehost = false;
        player.Requirepower = false;
        player.Requirepowerlev = 0;
        player.PartTeck = false;
        player.Speciesablaty = "ancientGRool";
        player.caneditname = true;
    }

    void Wolf()
    {
        player.Species = "Wolf";
        player.health = 22;
        player.handequipped = 2;
        player.smarts = 47;
        player.speed = 12;
        player.strength = 32;
        player.Parasite = false;
        player.Requirehost = false;
        player.Requirepower = false;
        player.Requirepowerlev = 0;
        player.PartTeck = false;
        player.Speciesablaty = "";
        player.caneditname = true;
    }

    void Cat()
    {
        player.Species = "Cat";
        player.health = 20;
        player.handequipped = 3;
        player.smarts = 47;
        player.speed = 12;
        player.strength = 32;
        player.Parasite = false;
        player.Requirehost = false;
        player.Requirepower = false;
        player.Requirepowerlev = 0;
        player.PartTeck = false;
        player.Speciesablaty = "";
        player.caneditname = true;
    }

void Avali()
    {
        player.Species = "Avali";
        player.health = 30;
        player.handequipped = 2;
        player.smarts = 20;
        player.speed = 16;
        player.strength = 36;
        player.Parasite = false;
        player.Requirehost = false;
        player.Requirepower = false;
        player.Requirepowerlev = 0;
        player.PartTeck = false;
        player.Speciesablaty = "Fly";
        player.caneditname = true;
    }

void a() { }


    /*void Furrysel()
    {
        Console.Clear();
        Console.ForegroundColor = settings.mcolor;
        Console.WriteLine("===Species====");
        Console.ForegroundColor = settings.dmcolor;
        Console.WriteLine("1. K9");
        Console.WriteLine("2. Feline");
        Console.WriteLine("3. ...");
        Console.WriteLine("4. OG speses");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                K9sel();
                break;
            case "2":
                player.Species = "Goa'uld";
                player.health = 30;
                player.handequipped = 2;
                player.smarts = 55;
                player.speed = 12;
                player.strength = 40;
                Playerinfo();
                break;
            case "3":
                player.Species = "Tok'ra";
                player.health = 30;
                player.handequipped = 2;
                player.smarts = 55;
                player.speed = 12;
                player.strength = 40;
                Playerinfo();
                break;
            case "4":
                FOGsel();
                break;
            case "0":
                Speciessel();
                break;
            default:
                Furrysel();
                break;
        }
    }


    void FOGsel()
    {
        Console.Clear();
        Console.ForegroundColor = settings.mcolor;
        Console.WriteLine("===Species====");
        Console.ForegroundColor = settings.dmcolor;
        Console.WriteLine("1. odhex by sparcky_ancientpack");
        Console.WriteLine("2. Corpse crawler by Frico⚠️");
        Console.WriteLine("3. protogen by Malice-Risu HP:22 SM:57 ST:32 SP:10");
        Console.WriteLine("4. Cat Boy/girl HP:18 SM:30 ST:32 SP:15");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                Odhexsel();
                break;
            case "2":
                Playerinfo();
                break;
            case "3":
                player.Species = "protogen";
                player.health = 22;
                player.handequipped = 2;
                player.smarts = 57;
                player.strength = 32;
                player.speed = 10;
                player.Parasite = false;
                player.Requirehost = false;
                player.Requirepower = false;
                player.Requirepowerlev = 0;
                player.PartTeck = true;
                player.Damageresistance = 1.3;
                player.Speciesablaty = "none";
                player.caneditname = true;
                Playerinfo();
                break;
            case "4":
                Playerinfo();
                break;
            case "0":
                Speciessel();
                break;
            default:
                K9sel();
                break;
        }
    }

    void Odhexsel()
    {
        Console.Clear();
        Console.ForegroundColor = settings.mcolor;
        Console.WriteLine("====Odhex=====");
        Console.ForegroundColor = settings.dmcolor;
        Console.WriteLine("1. Odhex");
        Console.WriteLine("2. ");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                player.Species = "Odhex";
                player.health = 30;
                player.handequipped = 2;
                player.smarts = 60;
                player.strength = 32;
                player.speed = 10;
                player.Parasite = false;
                player.Requirehost = false;
                player.Requirepower = false;
                player.Requirepowerlev = 0;
                player.PartTeck = true;
                player.Damageresistance = 1.2;
                player.Speciesablaty = "";
                player.caneditname = true;
                Playerinfo();
                break;
            case "2":
                player.Species = "protohex";
                player.health = 25;
                player.handequipped = 2;
                player.smarts = 55;
                player.strength = 32;
                player.speed = 10;
                player.Parasite = false;
                player.Requirehost = false;
                player.Requirepower = true;
                player.Requirepowerlev = 1700;
                player.PartTeck = true;
                player.Damageresistance = 1.3;
                player.Speciesablaty = "";
                player.protohexnum = 005;
                player.name = "Axel Wrenchblade";
                player.color = ConsoleColor.DarkCyan;
                settings.dmcolor = ConsoleColor.DarkBlue;
                settings.mcolor = ConsoleColor.Cyan;
                player.caneditname = false;
                Playerinfo();
                break;
            case "0":
                Speciessel();
                break;
            default:
                Odhexsel();
                break;
        }
    }

    void Coloursel()
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
                player.color = ConsoleColor.Red;
                break;
            case "2":
                player.color = ConsoleColor.Magenta;
                break;
            case "3":
                player.color = ConsoleColor.Yellow;
                break;
            case "4":
                player.color = ConsoleColor.Green;
                break;
            case "5":
                player.color = ConsoleColor.Blue;
                break;
            case "6":
                player.color = ConsoleColor.Cyan;
                break;
            case "7":
                player.color = ConsoleColor.Gray;
                break;
            default:
                Coloursel();
                break;
        }
        Playerinfo();
    }*/

}