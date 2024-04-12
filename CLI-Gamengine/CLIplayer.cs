public class ClIPlayer{
    public string? name { get; set; } = "none"; 
    public ConsoleColor color {get; set;} = ConsoleColor.Gray; 
    public double health {get; set;} = 20;
    public double  handequipped {get; set;} = 2;
    public double smarts {get; set;}= 45;
    public double strength {get; set;}= 32;
    public double speed {get; set;}= 10;
    public bool Parasite {get; set;} = false; 
    public bool Requirehost {get; set;} = false; 
    public bool Requirepower {get; set;} = false; 
    public double Requirepowerlev = 0; 
    public bool PartTeck = false; 
    public double Damageresistance {get; set;} = 1.001; 
    public string? Speciesablaty {get; set;} = ""; 
    public double protohexnum {get; set;}= -1;
    public bool caneditname {get; set;}= true; 
    public string? sex {get; set;}= "male"; 
    public string? Species {get; set;}= "Human"; 
    public bool islatex {get; set;} = false;
    public bool canTF {get; set;} = false;
    public string? latextipe {get; set;}= ""; 
    public string? PevusSpecies {get; set;}= ""; 
    public string? pronoud {get; set;}= "thay him"; 
}