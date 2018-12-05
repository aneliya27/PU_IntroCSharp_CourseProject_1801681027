using System;

namespace Seasons
{
    class Seasons
    {//тест 2, зад 4, 1 група. Да се състави програма, която по зададен номер на месец отпечатва името на сезона, като декември, януари, февруари са зима и т.н.
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter the code of the month: ");
            Console.WriteLine("1: January");
            Console.WriteLine("2: February");
            Console.WriteLine("3: March");
            Console.WriteLine("4: April");
            Console.WriteLine("5: May");
            Console.WriteLine("6: June");
            Console.WriteLine("7: July");
            Console.WriteLine("8: August");
            Console.WriteLine("9: September");
            Console.WriteLine("10: October");
            Console.WriteLine("11: November");
            Console.WriteLine("12: December");
            Console.WriteLine("----------------------------------");
            int Season = int.Parse(Console.ReadLine());
            switch (Season)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
            }
        }
    }
}
