using LessonFish.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonFish.Fish
{
    class AverageFish : IFishes, IGrow
    {
        public string NameFish { get; set; }
        public float SizeFish { get; set; }
        public string Colour { get; set; }


        public void Grow()
        {
            this.SizeFish += 0.5F;
        }
        public override string ToString()
        {
            return $" Название: {this.NameFish} " +
                   $" \n Размер: {this.SizeFish} " +
                   $" \n Окраска рыбки: {this.Colour} ! ";
        }
    }
}
