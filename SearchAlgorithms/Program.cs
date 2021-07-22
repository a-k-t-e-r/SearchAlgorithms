using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tSearch Algorithms\n------------------------------------");

            int[] dataValues = { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };

            Console.Write("Insert the search value: ");
            int searchData = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nLinear Search:");
            string feedback = LinearSearch.FindExistence(dataValues, searchData);
            Console.WriteLine("\t" + feedback);

            Console.WriteLine("\nBinary Search:");
            Console.WriteLine("\t" + BinarySearch.FindExistence(dataValues, searchData));
        }
    }
}
