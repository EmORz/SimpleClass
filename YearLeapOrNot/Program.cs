using System;

namespace YearLeapOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която прочита от конзолата година и проверява дали е високосна.
            var input = int.Parse(Console.ReadLine());

            //First => check with if
            var typeOfYear = (input % 400 == 0) || (input % 100 == 0) || (input % 4 == 0) ? "leap" : "common";
            Console.WriteLine(typeOfYear);

            //Second => use DateTime Method => take int and return true or false
            var chechWithDateTimeMethod = (DateTime.IsLeapYear(input)) ? "leap" : "common";
            Console.WriteLine(chechWithDateTimeMethod);

        }
    }
}
