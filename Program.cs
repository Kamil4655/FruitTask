using System;
using System.Reflection;
using FruitsTask.Models;

namespace FruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Smirimka", "25", "27");
            PineApple pineapple = new PineApple("Italian Pineapples", "55", "23");
            Orange orange = new Orange("Italian orange", "100");

            Fruit[] basket = { apple, pineapple, orange };

            foreach (var fruit in basket)
            {
                Type fruitType = fruit.GetType();
                Console.WriteLine(fruitType.Name);

                FieldInfo[] fields = fruitType.GetFields();
                foreach (var item in fields)
                {


                    Console.WriteLine(item.GetValue(fruit));
                }
            }
        }
    }
}
