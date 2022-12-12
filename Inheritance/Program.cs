using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bird bird1 = new Bird();

            bird1.Small = "Yes";
            bird1.Sing = "Yes";
            bird1.Carnivorous = "No";
            bird1.Pet = "Yes";

            Console.WriteLine($"{bird1.Small}, this bird is small.");
            Console.WriteLine($"{bird1.Sing} it sings!");
            Console.WriteLine($"{bird1.Carnivorous}, this bird is NOT carnivorous.");
            Console.WriteLine($"{bird1.Pet}, you can have it as a pet.");
            Console.WriteLine();


            Reptile reptile1 = new Reptile();

            reptile1.BreatheOxygen = "Yes";
            reptile1.SharpTeeth = "No";
            reptile1.Poisonous = "Yes";
            reptile1.EatBugs = "Yes";

            Console.WriteLine($"{reptile1.BreatheOxygen}, it breathes O2.");
            Console.WriteLine($"{reptile1.SharpTeeth}, it dosn't have sharp teeth!");
            Console.WriteLine($"{reptile1.Poisonous}, it's poisonous!");
            Console.WriteLine($"{reptile1.EatBugs}, it loves bugs.");


        }
    }
}
