using LessonFish.Aquarium;
using LessonFish.Fish;
using LessonFish.Interfase;
using System;

namespace LessonFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Aquarium! ---");

            Console.WriteLine("\n********************************\n");

            MyAquarium<IFishes> aquarium = new()
            {
                Name = " Aquarium Big "
            };

            aquarium.Add(new BigFish() { NameFish="carp1", SizeFish = 0.8F, Colour ="grin" });
            aquarium.Add(new BigFish() { NameFish = "carp2", SizeFish = 0.9F, Colour = "grin" });
            aquarium.Add(new SmallFish() { NameFish="guppi", SizeFish = 0.2F, Colour= "red", });
            aquarium.Add(new AverageFish() { NameFish = "gold_fish", SizeFish = 0.6F, Colour = "red-gold" });

            Console.WriteLine(aquarium.Name);

            Console.WriteLine("\n********************************\n");

            aquarium.GrowAll();

            Console.WriteLine("\n********************************\n");
            //Aqua<IFauna, IFishes> aqua = new();





            Console.ReadLine();

        }
    }
}
