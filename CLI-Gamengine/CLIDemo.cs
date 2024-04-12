public class CLIDemo
{
ClIPlayer player = new ClIPlayer(); // Create an instance of ClIPlayer
CLISettings settings = new CLISettings();
ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
CLIItems Items = new CLIItems();
 public void demo1()
 {
    Items.Start();
    Console.WriteLine(Items.sustoygun.Name);
    Console.ReadLine();
 }
}