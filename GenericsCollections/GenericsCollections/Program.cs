using System;
using System.Collections;

namespace GenericsCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Lemon lemon = new Lemon("Vitamin-C");
            Pineapple lemonApple = new Pineapple("Vitamin-B");
            Apple apple = new Apple("Vitamin-A");

            Console.WriteLine("LemonList:");
            BasketList<Lemon> basketList = new BasketList<Lemon>();
            basketList.AddItem(lemon);
            foreach (var item in basketList.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("PineappleList:");

            BasketList<Pineapple> basketList2 = new BasketList<Pineapple>();
            basketList2.AddItem(lemonApple);
            foreach (var item in basketList2.GetArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("AppleList:");
            BasketList<Apple> basketList3 = new BasketList<Apple>();
            basketList3.AddItem(apple);
            foreach (var item in basketList3.GetArray())
            {
                Console.WriteLine(item);
            }
            #endregion

            
                SortedList sortedList = new SortedList();

                sortedList.Add(2001, "C#");
                sortedList.Add(1990, "Python");
                sortedList.Add(1995, "JavaScript");
                sortedList.Add(1996, "Java");

                Console.WriteLine("Key is sorting:");
                foreach (DictionaryEntry item in sortedList)
                {
                    Console.WriteLine(item.Key);
                }


                Console.WriteLine("Value is sorting:");
                foreach (DictionaryEntry item in sortedList)
                {
                    Console.WriteLine(item.Value);
                }

            
        }
    }
}
