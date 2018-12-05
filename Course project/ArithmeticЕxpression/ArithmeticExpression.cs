using System;

namespace ArithmeticЕxpression
{
    class ArithmeticExpression
    {// задача 4. Да се напишат като аритметични изрази на езика C# следните алгебрични изрази:
     //  а) {((b - a) / (2 * b + c)) * (a - c)}* cos.x
        static void Main(string[] args)
        {
            Console.WriteLine("Input b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input c");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Input x");
            double x = double.Parse(Console.ReadLine());
            double lastResult = 0;
            double result1;
            result1 = Math.Cos(x);
            double result2;
             result2 = ((b - a) / (2 * b + c)) * (a - c);
            lastResult = result1 * result2;

            Console.WriteLine("Result is :" + lastResult);
            Console.ReadKey(true);
   
        



        }
    }
}
