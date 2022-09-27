using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat Cat1 = new Cat("Pintas", Mood.Happy, Feed.Hungry);
            Cat Cat2 = new Cat("Rasgão", Mood.Grumpy, Feed.Starving);
        }
    }
}
