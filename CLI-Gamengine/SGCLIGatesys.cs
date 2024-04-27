using System.ComponentModel;
using System.Net.Sockets;

public class SGStargate 
    {
        public string? id { get; set;}
        public string? name { get; set;} 
        public string? address { get; set;}
        public int type { get; set;}
        // 1 = SGU 2 = MW 3=PEG
        public int net { get; set;}
        // this is for the different networks In the show it's 1=MW 2=PEG ?=SGU
        
    }
public class SGPDD : CLIHandheldDevices
    {
        public bool isSGU { get; set;}
        public int MaxDial { get; set;}
        public bool isGoauld { get; set;}
        public bool HasAdressBase { get; set;}
        public string? AddressBase { get; set;}
    }
    
