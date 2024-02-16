using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadz dowolny ciag znakow: ");
            var input = Console.ReadLine();
            var groups = input.ToArray().Order().GroupBy(a => a); //Odrazu tworze tablice, sortuje i grupuje
                                                                 
            Console.WriteLine($"W linie:  {input}");

            foreach (var num_group in groups)
                Console.WriteLine($"Jest {num_group.Count()} znak(-i,-ow) {num_group.Key}");

            Console.ReadKey();
        }
    }
}