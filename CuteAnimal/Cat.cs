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

        public Cat(string name, Mood mood, Feed feed)
        {
            this.name = name;
            mood = moodStatus;
            feed = feedStatus;
            numberOfCats++;
        }


        
    }
}