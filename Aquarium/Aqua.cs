using LessonFish.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonFish.Fish;

namespace LessonFish.Aquarium
{
    public class Aqua<TKey, TValue> where TKey:TValue,IFauna, IFishes
    {
        public string Name { get; set; }
        public Dictionary<TKey, TValue> Aquarium_2;
        public Aqua()
        {
            Aquarium_2 = new Dictionary<TKey, TValue>();
        }
        public void Add_2(TKey key , TValue value) 
        {
            Aquarium_2.Add(key, value);
            
        }
        
        public void GrowAll_2()
        {
            foreach (KeyValuePair<TKey, TValue>  item in Aquarium_2)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
                Console.WriteLine("--------------------");
            }
        }
    }
}
