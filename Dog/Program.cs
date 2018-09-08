using System;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First dog => ");
            var name1 = Console.ReadLine();
            var breed1 = Console.ReadLine();
            Dogs first = new Dogs(name1, breed1);
            Console.WriteLine("Second dog => ");
            Dogs second = new Dogs();
            second.Name = "Rex";
            second.Breed = "Deutsche dog";
            Dogs third = new Dogs();

            Dogs[] arrFromDogsData = new Dogs[] {first, second, third };

            foreach (Dogs dog in arrFromDogsData)
            {
                dog.Bau();
            }


        }
    }
}
