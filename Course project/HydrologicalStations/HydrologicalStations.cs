using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydrologicalStations
{
    class HydrologicalStations
    {//задaча 400. Съставете програма за манипулиране на месечни данни на хидрологични станции. За целта направете два метода:
     //  а)за въвеждане валежите за всеки ден (в литри на квадратен метър) в едномерен масив от до 31 реални неотрицателни числа;
     //  б)за намиране на броя дни в месеца, през които е валяло;
     // В главния метод въведете цяло число n<=31 (брой дни в месеца) и три едномерни масива A[n], B[n] и C[n], моделиращи валежите в три станции за дадения месец. За всяка станция изчислете и отпечатайте броя дни в месеца, през които е валяло.
     // За всяка станция намерете и отпечатайте номерата на дните, в които е валяло.
        static void fillArray(double[] input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }
        }
        static double With(double[] input)
        {
            int br = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                    br++;
            }
            return br;
        }
        static void Chek(double[] input)
        {
            Console.WriteLine("Дни в които е валяло");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                    Console.WriteLine("Ден номер {0}", i + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            do
            {
                Console.Write("Въведете дни в месеца: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 31);
            Console.WriteLine("Въведете елементи за А");
            double[] A = new double[n];
            fillArray(A);
            Console.WriteLine("Въведете елементи за Б");
            double[] B = new double[n];
            fillArray(B);
            Console.WriteLine("Въведете елементи за Ц");
            double[] C = new double[n];
            fillArray(C);
            Console.WriteLine("Брой дни в които е валяло през месец А - " + With(A));
            Console.WriteLine("Брой дни в които е валяло през месец Б - " + With(B));
            Console.WriteLine("Брой дни в които е валяло през месец Ц - " + With(C));
            Console.WriteLine("За месец А");
            Chek(A);
            Console.WriteLine("За месец Б");
            Chek(B);
            Console.WriteLine("За месец Ц");
            Chek(C);


        }
    }
}
