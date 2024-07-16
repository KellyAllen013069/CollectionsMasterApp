using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var array50 = new int[50];
            

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populator(array50);

            //TODO: Print the first number of the array
            Console.WriteLine(array50[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(array50[49]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(array50);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(array50);
            NumberPrinter(array50);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(array50);
            NumberPrinter(array50);
            
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(array50);
            NumberPrinter(array50);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(array50);
            NumberPrinter(array50);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numberList = new List<int>();
            
            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity at initialization: {numberList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populator(numberList);
            NumberPrinter(numberList);

            //TODO: Print the new capacity
            Console.WriteLine($"Capacity after populating with 50: {numberList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            var isNumber = false;
            int searchNumber = 0;
            while (!isNumber)
            {
                Console.WriteLine("What integer will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out searchNumber);
                if (!isNumber) Console.WriteLine("That was not a valid integer. Please try again.");
            };
            
            NumberChecker(numberList, searchNumber);
            
    
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);
            
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            NumberPrinter(numberList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
           
            var numberArray = numberList.ToArray();
            Console.WriteLine("Number List as an array: ");
            NumberPrinter(numberArray);

            //TODO: Clear the list
            numberList.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i=0; i< numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0) numbers[i] = 0;
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(n => n % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Number {searchNumber} is in the list.");
                return;
            }
            Console.WriteLine($"Number {searchNumber} is not in the list.");
        }

        private static void Populator(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0,51));
            }

        }

        private static void Populator(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0,51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
           
            var reversedArray = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = reversedArray[i];
            }
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
