using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Pintas", Mood.Happy, Feed.Hungry);
            Cat cat2 = new Cat("Rasgão", Mood.Grumpy, Feed.Starving);
            Cat cat3 = new Cat("Piruças");

            Console.WriteLine(cat1.GetName());
            Console.WriteLine(cat2.GetName());
            Console.WriteLine(cat3.GetName());

        }
    }
}
