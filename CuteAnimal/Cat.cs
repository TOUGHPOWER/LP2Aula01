using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        static int numberOfCats;
        private string name;
        private Mood moodStatus;
        private Feed feedStatus;

        private int energy;

        private Random rng;

        private Cat()
        {
            rng = new Random();
            energy = rng.Next(0,101);
        }

        public Cat(string name, Mood mood, Feed feed) : this()
        {
            this.name = name;
            mood = moodStatus;
            feed = feedStatus;
            numberOfCats++;
        }
        
        public Cat(string name) : this(name, Mood.Happy, Feed.AboutToExplode)
        {
            
        }

        public string GetName() => name;
    }
}