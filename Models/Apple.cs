using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsTask.Models
{
    internal class Apple : Fruit
    {
        
        public string _vitaminA;
        public string _vitaminB;
        public override void Taste()
        {
            Console.WriteLine("sweet and sour");
        }
        public string VitaminA;
        public string VitaminB;
        public Apple(string name, string vitaminA,string vitaminB)
        {
            Sort = name;
            VitaminA = vitaminA;
            VitaminB = vitaminB;
        }
    }
}



//foreach(Fruit fruit in basket)
//{
//    if(fruit is Apple apple1)
//    {
//        apple1.Taste();
//        Console.WriteLine(apple1.Sort);
//        Console.WriteLine(apple1.VitaminA);
//    }
//    else if(fruit is Orange orange1)
//    {
//        orange.Taste();
//        Console.WriteLine(orange.Sort);
//        Console.WriteLine(orange.VitaminC);
//    } 
//    else if(fruit is PineApple pineapple1)
//    {
//        Console.WriteLine(pineapple1.Sort);
//        pineapple.Taste();
//    }

//}
