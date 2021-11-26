using System;
namespace ExaminationQustions
{ 
    public enum Seasons
    {
        Winter,Spring,Summer,Autumn
    }
    class op30_Enumwithprop
    {
        private string _Name;
        private Seasons _Season=0;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public Seasons Season
        {
            get { return _Season; }
            set { _Season = value; }
        }
        static void Main()
        {
            op30_Enumwithprop obj = new();
            obj.Name = "Pradeep";
            obj.Season = Seasons.Autumn;
            Console.WriteLine($"your subject Name is {obj.Name}");
            Console.WriteLine($"your subject Liked season is {obj.Season}");
            obj.Name = "Gods";
            obj.Season = Seasons.Spring;
            Console.WriteLine($"your subject Name is {obj.Name}");
            Console.WriteLine($"your subject Liked season is {obj.Season}");
        }
    }
}
            //obj.Name = "Pradeep";
            //obj.s = 0;
            //Console.WriteLine($"{obj.Name} Likes {obj.s}");
            //obj.Name = "Gods";
            //obj.s = Seasons.Spring;
            //Console.WriteLine($"{obj.Name} are likes {obj.s}");