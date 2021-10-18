using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFish.Interfase
{
    public interface IFishes
    {
        public string NameFish { get; set; }
        public float SizeFish { get; set; }
        public string Colour { get; set; }
        public string ToString();
    }
}
