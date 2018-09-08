using System;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {

        static Random rndGenerator = new Random();

        static void InsertSymbols(int iterate, StringBuilder password, string symbol)
        {
            for (int i = 0; i < iterate; i++)
            {
                char getSymbol = symbol[rndGenerator.Next(0, symbol.Length)];
                int position = rndGenerator.Next(0, password.Length);
                password.Insert(position, getSymbol);
            }
        }
        static void Main(string[] args)
        {
            var smallLetters = "abcdefghijklmnopqrstuvwxyz";
            var capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var digits = "0123456789";
            var specialChar = "!#$%&@*";
            var password = new StringBuilder();
            //
            InsertSymbols(2, password, smallLetters);
            InsertSymbols(2, password, capitalLetters);
            InsertSymbols(1, password, digits);
            InsertSymbols(3, password, specialChar);
            InsertSymbols(rndGenerator.Next(0, 7), password, specialChar + smallLetters + digits + capitalLetters);
            Console.WriteLine(password.ToString());
            Console.ReadKey();
           
        }
    }
}
