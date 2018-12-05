using System;

namespace DivideBy7
{
    class DivideBy7
    {// задача 209. Да се генерира редица от 100 случайни цели числа принадлежащи на интервала [0,132]. Да се отпечатат тези от тях, които:
     //  г) при деление на 7 дават остатък 1
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number;
            for (int i = 1; i <= 100; i++)
            {
                number = rnd.Next(0, 133);
                
                if (number % 7 == 1)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
