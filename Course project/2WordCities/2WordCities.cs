using System;

namespace _2WordCities
{
    class Program
    { //задача 372. Елементите на масив са имена на населени места, започващи с главна буква. Да се съставят методи за:
      //  a) въвеждане на елементите на масива (не повече от 50).
      //  г) извеждане на екрана на всички населени мест, чиито имена се състоят от две думи, разделени с един или няколко интервала.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of cities: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 50)
            {
                string[] City = new string[n];
                InputArray(City);
                TwoWordCities(City);
                break;
            }
        }

        static void InputArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("City[" + i + "]= ");
                array[i] = Console.ReadLine();
            }
        }

        static void TwoWordCities(string[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Cities with more than 1 word: ");
            foreach (string city in array)
            {
                var x = city.ToCharArray();
                foreach (char c in x)
                {
                    if (Char.IsWhiteSpace(c))
                    {
                        Console.WriteLine(city);
                    }
                }
            }
        }
    }
}
    
