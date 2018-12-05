using System;

namespace Methods
{
    class Methods
    { //задача 162. Да се състави програма, в която:
      //  a) се дефинира метод cor(x,y)= (|x|*|y|)/(x+y) при х различно от -y и cor(x,y)=0 в противен случай;
      //  b) се въвеждат 2 цели числа p и q в интервала [-30,30];
      //  c) се изчислява и отпечатва на екрана стойността на израза (cor(p,3q) - cor(3p, q)) / cor(p,q)
      //  d) се извеждат на екрана тези стойности на редицата cor(p,10),cor(p,14),...,cor(p,50), които са четни цели числа
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());

            if (x != -y)
            {
                Console.WriteLine("Cor = " + cor(x, y));
            }
            else
            {
                Console.WriteLine("Cor(x,y) = 0");
            }

            Console.WriteLine("----------------");

            int p, q;
            do
            {
                Console.Write("Enter p: ");
                p = int.Parse(Console.ReadLine());
            } while (p < -30 || p > 30);
            do
            {
                Console.Write("Enter q: ");
                q = int.Parse(Console.ReadLine());
            } while (q < -30 || q > 30);

            double c = (cor(p, 3 * q) - cor(3 * p, q)) / cor(p, q);
            Console.WriteLine("C = " + c);

            Console.WriteLine("----------------");
            Console.WriteLine("Whole even numbers: ");
            for (int i = 10; i <= 50; i += 4)
            {
                if (cor(p, i) > 0 && cor(p, i) % 2 == 0)
                {
                    Console.WriteLine(cor(p, i));
                }
            }
        }

        static double cor(double x, double y)
        {
            return (Math.Abs(x) * Math.Abs(y)) / (x + y);
        }
    }
}

