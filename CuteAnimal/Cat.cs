using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        static int numberOfCats;
        public string Name {get; }
        private Mood moodStatus;
        private Feed feedStatus;

        public int Energy {get;set;}

        private Random rng;

        private Cat()
        {
            rng = new Random();
            Energy = rng.Next(0,101);
        }

        public Cat(string name, Mood mood, Feed feed) : this()
        {
            Name = name;
            mood = moodStatus;
            feed = feedStatus;
            numberOfCats++;
        }
        
        public Cat(string name) : this(name, Mood.Happy, Feed.AboutToExplode)
        {
            
        }

        
    }
}