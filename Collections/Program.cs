﻿

using System.Runtime.InteropServices.ComTypes;
using AnimalLibrary;

namespace Collections // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ActionsWithList();
            //ActionWithDictionary();
            ActionWithBubbleSorting();
            ActionWithQueue();
            Console.ReadLine();
            Console.ReadLine();

        }

        public static void ActionsWithList()
        {
            var list = new List<string>() { "val1", "val2", "val3", "val4", "val5" };
            list.Add("val6");
            list.ForEach(Console.WriteLine);
        }

        public static void ActionWithDictionary()
        {
            var animal1 = new Animals()
            {
                Name = "Fox"
            };
            var animal2 = new Animals()
            {
                Name = "Cat"
            };
            var animal3 = new Animals()
            {
                Name = "Dog"
            };

            var dictionary = new Dictionary<int, Animals>();

            dictionary.Add(1, animal1);
            dictionary.Add(2, animal2);
            dictionary.Add(3, animal3);

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value.Name}");
            }
        }

        public static void ActionWithStack()
        {
            var films = new Stack<string>();
            films.Push("4. Batmen");
            films.Push("3. SuperMan");
            films.Push("2. AntMan");
            films.Push("1. Hulk");

            foreach (var film in films)
            {
                Console.WriteLine(film);
            }
        }

        public static void ActionWithQueue()
        {
            var films = new Queue<string>();
            films.Enqueue("4. Batmen");
            films.Enqueue("3. SuperMan");
            films.Enqueue("2. AntMan");
            films.Enqueue("1. SpiderMan");

            foreach (var film in films)
            {
                Console.WriteLine(film);
            }

            var list = films.ToList();
            if (list.Contains("1. SpiderMan"))
            {
                var index = list.IndexOf("1. SpiderMan");
                list[index] = "1. Hulk";
            }
        }

        public static void ActionWithBubbleSorting()
        {         //Indexes0  1   2   3   4
            int[] arr = { 78, 55, 45, 98, 13 };

            Console.WriteLine("Unsorted array: :");
            foreach (int el in arr)
            {
                Console.Write(el + Environment.NewLine);
            }

            for (int i = 0; i <= arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //55, 78, 45, 98, 13
                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            
            Console.WriteLine("Sorted array: :");
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }

            Console.Read();
        }
    }
}