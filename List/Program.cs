using System;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> numbers = new List<string> { "1", "2", "3", "4", "5"};

            Console.WriteLine($"There original list has {numbers.Count()} members");
            string[] memberArr = new string[] { "6", "7", "8"};
            numbers.AddRange(memberArr);
            Console.WriteLine($"The new list now has {numbers.Count()} members");

            Console.WriteLine("Original Numbers");
            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.WriteLine(numbers[i]);
            }

            numbers.Remove("3");

            Console.WriteLine($"The revised list now has {numbers.Count()} members");
            Console.WriteLine("Revised Numbers");
            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.WriteLine(numbers[i]);
            }

            numbers.Sort();
            Console.WriteLine("Sorted Numbers");
            foreach (string n in numbers)
            {
                Console.WriteLine(n);
            }

            numbers.Reverse();
            Console.WriteLine("Reverse Numbers");
            foreach (string n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
