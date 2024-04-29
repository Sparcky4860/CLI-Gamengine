using System.ComponentModel;
using System.Net.Sockets;


public class SGStargate
{
    public string? id { get; set; }
    public string? name { get; set; }
    public string? address { get; set; }
    public int type { get; set; }
    // 1 = SGU 2 = MW 3=PEG
    public int net { get; set; }
    // this is for the different networks In the show it's 1=MW 2=PEG ?=SGU

}
public class SGPDD : CLIHandheldDevices
{
    public bool isSGU { get; set; }
    public int MaxDial { get; set; }
    public bool isGoauld { get; set; }
    public bool HasAdressBase { get; set; }
    public string? AddressBase { get; set; }
}
public class SGSpecieList : CLISpecieList
{
    // ClIPlayer player = new ClIPlayer();
    // CLISettings settings = new CLISettings();
    public void Goauld()
    {
        CLIPlayer.Species = "Goa'uld";
        CLIPlayer.Health = 30;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 55;
        CLIPlayer.Speed = 12;
        CLIPlayer.Strength = 40;
        CLIPlayer.Parasite = true;
        CLIPlayer.Requirehost = true;
        CLIPlayer.Requirepower = false;
        CLIPlayer.Requirepowerlev = 0;
        CLIPlayer.PartTeck = false;
        CLIPlayer.Speciesablaty = "";
        CLIPlayer.Caneditname = true;
    }

    public void Tokra()
    {
        CLIPlayer.Species = "Tok'ra";
        CLIPlayer.Health = 30;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 55;
        CLIPlayer.Speed = 12;
        CLIPlayer.Strength = 40;
        CLIPlayer.Parasite = true;
        CLIPlayer.Requirehost = true;
        CLIPlayer.Requirepower = false;
        CLIPlayer.Requirepowerlev = 0;
        CLIPlayer.PartTeck = false;
        CLIPlayer.Speciesablaty = "";
        CLIPlayer.Caneditname = true;
    }
}