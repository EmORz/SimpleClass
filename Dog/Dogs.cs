using System;
using System.Collections.Generic;
using System.Text;

namespace Dog
{
    class Dogs
    {
        public Dogs()
        {
            this.Name = "Balkans";
            this.Breed = "street excellent";
        }
        public Dogs(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }
        public string Breed { get; set; }

        public string Name { get; set; }
        public void Bau()
        {
            Console.WriteLine($"{Name} is {Breed} said: Bauuuuuuuuuuuuuu!");
        }
    }
}
