using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsTask.Models
{
    internal class PineApple : Fruit
    {
        public override void Taste()
        {
            Console.WriteLine("Sweet");
        }
        public string VitaminE;
        public string VitaminD;
        public PineApple(string name , string vitaminE,string vitaminD)
        {
            Sort = name;
            VitaminE= vitaminE;
            VitaminD= vitaminD;
        }
        
    }
}
