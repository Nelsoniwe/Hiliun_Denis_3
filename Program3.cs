using System;
using System.Linq;
using System.Collections.Generic;

namespace laba3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random ran = new Random();

            for (int i = 0; i < 26; i++)
            {
                numbers.Add(ran.Next(0, 51));
            }

            Console.Write("List: ");

            foreach (var item in numbers)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();

            var SelectedNumbers = from n in numbers
                                  where n >= 5 && n <= 15
                                  select n;

            int sum=0;
            int count = 0;

            Console.Write("Matching numbers: ");
            
            foreach(int n in SelectedNumbers)
            {
                sum = sum + n;
                count++;
                Console.Write(n+" ");
            }

            Console.WriteLine();
            Console.Write("Average number: ");

            Console.WriteLine(sum/count);




            Console.ReadLine();
        }
    }
}
