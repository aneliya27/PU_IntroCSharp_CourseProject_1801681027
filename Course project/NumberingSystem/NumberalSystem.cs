using System;

namespace NumberingSystem
{
    class NumberalSystem
    {
        static void Main(string[] args)
        {
            //задача 1. 
            int mynumber= 2027;

            string binary = Convert.ToString(mynumber, 2);
            string octal = Convert.ToString(mynumber, 8);
            string hexadecimal = Convert.ToString(mynumber, 16);

            Console.WriteLine("Convert 2027 to binary, octal, hexadecimal.");
            Console.WriteLine("Binary: " + binary);
            Console.WriteLine("Octal: " + octal);
            Console.WriteLine("Hexadecimal: " + hexadecimal);


        }
    }
}
