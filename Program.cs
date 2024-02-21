// See https://aka.ms/new-console-template for more information
/*
   ᐰᐰ    
 ᐰ    ᐰ  
   ᐰᐰ    
          
    ᐰ    
   ᐰ ᐰ   
  ᐰ   ᐰ  
 ᐰ     ᐰ 
ᐰ       ᐰ
╔═╗╔═╗┌─┐┬  ┬
╚═╗║ ╦│  │  │
╚═╝╚═╝└─┘┴─┘┴
Console.ForegroundColor = ConsoleColor.Red; // Change text color to red
Console.WriteLine("This is some text");
Console.ResetColor(); // Reset the color
*/
void bootlogo1()
{
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine(" ᐰ    ᐰ  ");
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine();
    Console.WriteLine("    ᐰ    ");
    Console.WriteLine("   ᐰ ᐰ   ");
    Console.WriteLine("  ᐰ   ᐰ  ");
    Console.WriteLine(" ᐰ     ᐰ ");
    Console.WriteLine("ᐰ       ᐰ"); 
    Console.WriteLine("╔═╗╔═╗┌─┐┬  ┬");
    Console.WriteLine("╚═╗║ ╦│  │  │");
    Console.WriteLine("╚═╝╚═╝└─┘┴─┘┴"); 
}
void bootlogo2()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine(" ᐰ    ᐰ  ");
    Console.WriteLine("   ᐰᐰ    ");
    Console.WriteLine();
    Console.WriteLine("    ᐰ    ");
    Console.WriteLine("   ᐰ ᐰ   ");
    Console.WriteLine("  ᐰ   ᐰ  ╔═╗╔═╗┌─┐┬  ┬");
    Console.WriteLine(" ᐰ     ᐰ ╚═╗║ ╦│  │  │");
    Console.WriteLine("ᐰ       ᐰ╚═╝╚═╝└─┘┴─┘┴"); 
    Console.ResetColor();
    Console.WriteLine("A stargate fan game."); 
} 
bootlogo2();