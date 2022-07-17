using System;

namespace deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for soda. How many people are in your group? Please, parties of 6 or lower.");
            int P = int.Parse(Console.ReadLine());
            

            if (P <= 6)
            {
                Console.WriteLine($" A table for {P}! Please follow me and take a seat.");
                Console.WriteLine("Can I get you started with some drinks? your options for today are Soda or water.");

                int people = 1;
                int water = 0;
                int soda = 0;
                double buffet = P * 9.99;
              

                while (people <= P)
                {
                    Console.WriteLine($"Alright guest number {people++}, would you like a water or soda?");
                    string order = Console.ReadLine().ToLower();

                    if (order == "soda")
                    {

                        Console.WriteLine("Ok, a soda for you");
                        soda++;
                    }

                    else if (order == "water")
                    {

                        Console.WriteLine("Ok, a water for you.");
                        water++;
                    }


                    else
                    {
                        Console.WriteLine("Sorry no drink for you");
                    }

                }

                double dtotal = (soda * 2.99);
                double total = buffet + dtotal;
                var sodas = soda > 1 ? "sodas" : "soda";
                var waters = water > 1 ? "waters" : "water";
                Console.WriteLine($"So you had {soda} {sodas} at $2.99 each.");
                Console.WriteLine($"So you had {water} {waters} that are free.");
                Console.WriteLine($"and {P} people for the buffet");
                Console.WriteLine($"your total for food will be ${buffet}.");
                Console.WriteLine($"your total for drinks will be ${dtotal}.");
                Console.WriteLine($"your total will be ${Math.Round(total, 2)}.");

            }
            else
            {
                Console.WriteLine("Sorry your party size is too large for us to seat");
            }




        }
    }
}
