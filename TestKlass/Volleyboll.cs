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
        public float overall{get;set;}
        public int height{get;set;}
        public int weight{get;set;}
        public float spike{get;set;}
        public float block{get;set;}
        public float dig{get;set;}
        public float serve{get;set;}
        public float reaction{get;set;}
        public float vertical{get;set;}
        public float toss{get;set;}
    }
}