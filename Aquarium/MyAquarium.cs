using LessonFish.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LessonFish.Aquarium
{
    public class MyAquarium<T> where T : IFishes
    {
        public string Name { get; set; }
        public List<T> Aquarium_1;
        public MyAquarium()
        {
            this.Aquarium_1 = new List<T>();
        }

        public void Add(T item)
        {
            this.Aquarium_1.Add(item);
        }
        public void GrowAll()
        {
            foreach (T item in this.Aquarium_1)
            {
                Console.WriteLine($" {item} ");
                Console.WriteLine("--------------------");
            }
        }
       
    }
}
