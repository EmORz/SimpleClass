using System;
using System.Collections.Generic;
using System.Text;

namespace CatsProject
{
    class Cats
    {
        private string name;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Cats()
        { }
        public Cats(string name)
        {
            this.name = name;
        }

    }
}
