using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            #region Arrays
            var intArray = new int[50];
            Populater(intArray);

            Console.WriteLine(intArray[0]);
            Console.WriteLine($"{intArray[intArray.Length - 1]}");

                      

            Console.WriteLine("All Numbers Original");
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");
            Console.WriteLine("");


            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(intArray);
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");
            Console.WriteLine("");


            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(intArray);
            Console.WriteLine("-------------------");
            Console.WriteLine("");


            Console.WriteLine("Sorted numbers:");
            Array.Sort(intArray);
            NumberPrinter(intArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");


            var intList = new List<int>();
            Console.WriteLine("Initial Capacity:");
            Console.WriteLine(intList.Capacity);
            Console.WriteLine("");
            Populater(intList);
            Console.WriteLine("New Capacity:");
            Console.WriteLine(intList.Capacity);
                        

            Console.WriteLine("---------------------");

           
            Console.WriteLine("What number will you search for in the number list?");
            var userInput = int.Parse(Console.ReadLine());
            NumberChecker(intList, userInput);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            Console.WriteLine("Evens Only!!");
            OddKiller(intList);
            NumberPrinter(intList);
            
            Console.WriteLine("------------------");

            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
           
            
            Console.WriteLine("------------------");

            int[] newArray = intList.ToArray();


            intList.Clear();
            
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
           
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);

        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(num => num % 2 != 0);

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Your number, {searchNumber}, is on the list!");
            }
            else
            {
                Console.WriteLine($"Sorry, {searchNumber} is not on the list.");
            }

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for(int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(1, 51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 51); 
            }

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
