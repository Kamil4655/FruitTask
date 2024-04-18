using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsTask.Models
{
    internal class Orange : Fruit
    {
        public override void Taste()
        {
            Console.WriteLine("Sour");
        }
        public string VitaminC;

        public Orange(string name, string vitaminC)
        {
            Sort = name;
            VitaminC= vitaminC;
        }
    }
}
