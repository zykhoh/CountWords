using System;
using System.Collections.Generic;
using System.Linq;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfInput = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < NumberOfInput; i++)
                words.Add(Console.ReadLine());

            var groupedWords = words
                .GroupBy(x => x)
                .Select(group => group.ToList())
                .OrderByDescending(group => group.Count)
                .ToList();

            foreach (var itemGroup in groupedWords)
                Console.WriteLine($"{itemGroup[0]} {itemGroup.Count}");
        }
    }
}
