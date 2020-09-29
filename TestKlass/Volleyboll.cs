using System;

namespace TestKlass
{
    public class League
    {
        public string lName {get;set;}
        public int teamSpot {get;set;}
        public bool relegation{get;set;}
        public bool promotion{get;set;}
    }
    public class Team
    {
        public string tName{get;set;}
        public int players{get;set;}
        
    }
    public class players
    {
        public string pName{get;set;}
        public int overall{get;set;}
        public int height{get;set;}
        public int weight{get;set;}
        public int spike{get;set;}
        public int block{get;set;}
        public int dig{get;set;}
        public int serve{get;set;}
        public int reaction{get;set;}
        public int vertical{get;set;}
        public int toss{get;set;}
    }
}