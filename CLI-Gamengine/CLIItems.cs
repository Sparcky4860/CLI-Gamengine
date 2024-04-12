public class CLIItems
{
    public CLIItemsStats.gun sustoygun {get; set;}= new CLIItemsStats.gun();
    public void Start()
    {
        //Suspicious Toy Gun item will tf user in to a latex fox
        sustoygun.Name = "Suspicious Toy Gun";
        sustoygun.Description = "is it Leaking?";
        sustoygun.GunID = "LTFTG";
    }
}