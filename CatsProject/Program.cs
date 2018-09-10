using System;
using System.Collections.Generic;

namespace CatsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCats = new List<Cats>();
            var name = "";
            for (int i = 0; i < 10; i++)
            {
                name = "Cats" + i;
                var temp = new Cats(name);
                listOfCats.Add(temp);
            }
            foreach (var cat in listOfCats)
            {
                Console.WriteLine(cat.Name);
            }
        }
    }
}
