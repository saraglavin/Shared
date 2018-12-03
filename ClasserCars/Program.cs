using System;

namespace ClasserCars
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Ändra till ett språk
            Car c1 = new Car("Blå", 200);
            Car c2 = new Car();

            Console.Write("Ange bilens färg och vikt, separerat med komma: ");
            string input = Console.ReadLine();

            string[] separated = input.Split("0");

            string x = separated[0];
            int y = int.Parse(separated[1]);

            c1.Color = x;
            c1.Weight = y;



            //Console.Write("Vilken färg på bil 1? ");
            //string x = Console.ReadLine();
            //Console.Write("Vilken färg på bil 2? ");
            //string y = Console.ReadLine();

            // GetColor här gör att man ex. kan inkludera .Trim eller andra saker för att få output bättre. Till skillnad från om man
            // man använder variabel x. 
            //c1.SetColor(x.Trim());
            //c1.SetWeight(y.Trim());

            //Håll dig till antingen svenska eller engelska :) nu blir det the color of the first car is blå
            //Båda bilar heter the first car
            Console.WriteLine($"Den första bilens färg är {c1.Color} och den väger {c1.Weight} kg");
            Console.WriteLine($"Den andra bilens färg är {c2.Color} och den väger {c2.Weight} kg");

        }
    }
}
