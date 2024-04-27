public class CLIGamePrep{
ClIPlayer player = new ClIPlayer(); 
CLISettings settings = new CLISettings();
ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
public void newgame()
{
    settings.mainenuOpen = false;
    Console.Clear();
    Console.WriteLine("set a name for your save:");
    miscellaneous.savename = Console.ReadLine();
    //Playerinfo();
    this.Playerinfo();

}
public void Playerinfo()
{
    Console.Clear();
    Console.ForegroundColor =settings.mcolor;
    Console.WriteLine("===newgame====");
    Console.ForegroundColor = settings.dmcolor;
    Console.Write("1. Name:");
    if (player.caneditname == true)
    {
    Console.ForegroundColor = player.color;
    }
    else
    {
    Console.ForegroundColor = ConsoleColor.Red;
    }
    Console.WriteLine(player.name);
    Console.ForegroundColor = settings.dmcolor;
    Console.Write("2. ");
    Console.ForegroundColor = player.color;
    Console.WriteLine("Colour");
    Console.ForegroundColor = settings.dmcolor;
    Console.Write("3. Species:");
    Console.ForegroundColor = player.color;
    Console.WriteLine(player.Species);
    Console.ForegroundColor = settings.dmcolor;
    Console.WriteLine("4. Start");
    Console.ForegroundColor = ConsoleColor.Red;
        if (player.caneditname == false)
    {
    Console.WriteLine("5. unlock");
    }
    Console.ForegroundColor = settings.dmcolor;
    Console.WriteLine("0. Exit");
    Console.ResetColor(); 
    Console.WriteLine("");
    Console.Write(">");
    var plinfo =Console.ReadLine();
    switch (plinfo)
    {
        case "1":
            //Console.WriteLine("demo 1");
            Console.Clear();
            if(player.caneditname == true){
            Console.WriteLine("name:");
            player.name = Console.ReadLine();
            }
            Playerinfo();
            break;
        case "2":
            //Console.WriteLine("demo 2");
            if (player.caneditname == true)
            {
            Coloursel();
            }
            else
            {
            Playerinfo();
            }
            break;
        case "3":
            //Console.WriteLine("demo 3");
            if (player.caneditname == true)
            {
            Speciessel();
            }
            else
            {
            Playerinfo();
            }
            break;
        case "4":
            if(settings.BuiltInDemoEnabled == true)
            {
                start();
            }
            else{}
            break;
        case "5":
            if (player.caneditname == false)
            {
            player.name = "none";
            player.caneditname = true;
            player.color = ConsoleColor.Gray;
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
            player.protohexnum = -1;
            player.Speciesablaty = "ancientGRool";
            Playerinfo();
            }
            else
            {
            Playerinfo();
            }
            break;
        case "0":
            //varpush();
            break;
        default:
            Playerinfo();
            break;
    }
}
void Speciessel()
{
Console.Clear();
    Console.ForegroundColor = settings.mcolor;
    Console.WriteLine("===Species====");
    Console.ForegroundColor = settings.dmcolor;
    Console.WriteLine("1. Humans");
    Console.WriteLine("2. Anthros");
    if (settings.ModingIsOn == true)
    {
    Console.WriteLine("3. Customs");
    }
    Console.WriteLine("0. Back");
    Console.ResetColor(); 
    Console.WriteLine("");
    Console.Write(">");
    switch (Console.ReadLine())
    {
        case "1":
            Humanssel();
            break;
        case "2":
            Furrysel();
            break;
        case "3":
            Speciessel();
            break;
        case "0":
            Playerinfo();
            break;
        default:
            Speciessel();
            break;
    }
}

void Humanssel()
{
Console.Clear();
    Console.ForegroundColor = settings.mcolor;
    Console.WriteLine("===Species====");
    Console.ForegroundColor = settings.dmcolor;
    Console.WriteLine("1. Human HP:20 SM:45 ST:32 SP:10");
    Console.Write("2. Goa'uld HP:30 SM:55 ST:40 SP:12(");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("evil");
    Console.ForegroundColor = settings.dmcolor;
    Console.WriteLine(")");
    Console.WriteLine("3. Tok'ra HP:30 SM:52 ST:40 SP:12");
    Console.WriteLine("4. Cat Boy/girl HP:18 SM:30 ST:32 SP:15 (HQ+1)");
    Console.WriteLine("0. Back");
    Console.ResetColor(); 
    Console.WriteLine("");
    Console.Write(">");
    switch (Console.ReadLine())
    {
        case "1":
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
            this.Playerinfo();
            break;
        case "2":
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
            this.Playerinfo();
            break;
        case "3":
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
            this.Playerinfo();
            break;
        case "4":
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
            this.Playerinfo();
            break;
        case "0":
            Speciessel();
            break;
        default:
            Humanssel();
            break;
    }
}

void Furrysel()
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

void K9sel()
{
Console.Clear();
    Console.ForegroundColor = settings.mcolor;
    Console.WriteLine("===Species====");
    Console.ForegroundColor = settings.dmcolor;
    Console.WriteLine("1. Wolf HP:22 SM:47 ST:32 SP:12");
    Console.WriteLine("2. Goa'uld HP:30 SM:55 ST:40 SP:12");
    Console.WriteLine("3. Tok'ra HP:30 SM:52 ST:40 SP:12");
    Console.WriteLine("4. Cat Boy/girl HP:18 SM:30 ST:32 SP:15 (HQ+1)");
    Console.WriteLine("0. Back");
    Console.ResetColor(); 
    Console.WriteLine("");
    Console.Write(">");
    switch (Console.ReadLine())
    {
        case "1":
            player.Species = "Wolf";
            player.health = 22;
            player.handequipped = 2;
            player.smarts = 47;
            player.speed = 12;
            player.strength = 32;
            Playerinfo();
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
            player.Species = "Cat Boy/girl";
            player.health = 18;
            player.handequipped = 3;
            player.smarts = 45;
            player.speed = 15;
            player.strength = 32;
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
            player.color=ConsoleColor.DarkCyan;
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

void Coloursel(){
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
}
void start()
{
                    //Console.ForegroundColor= settings.mcolor;
                Console.ForegroundColor= ConsoleColor.Gray;
                Console.WriteLine("1. Standard game");
                Console.ForegroundColor= settings.mcolor;
                Console.WriteLine("2. Demo game");
                switch (Console.ReadLine())
                {
                    case"1":
                    start();
                    break;
                    case"2":
                    //demo.demo1();
                    break;
                    default:
                    start();
                    break;
                }
}
}