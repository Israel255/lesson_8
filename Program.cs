using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8
{
    class Program
    {
        static bool TARGIL_1(int a, int b)
        {
            if (a % b == 0)
            {
                Console.WriteLine("no module");
                return true;
            }
            else
            {
                Console.WriteLine("some modolue");
                return false;
            }
        }
        static int TARGIL_2(ref int a, ref int b)
        {
            a++;
            b *= 2;
            return a;
        }
        static int TARGIL_3(out int c, out int d)
        {
            Console.WriteLine("enter a number");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number");
            d = Convert.ToInt32(Console.ReadLine());
            return c;
        }
        static double TARGIL_4(params int[] list)
        {
            double sum = 0;
            double mult = 0;
            for (int i = 0; i < list.Length; i++)
            {
                mult = Math.Pow(list[i], i + 1);
                sum = sum + mult;
            }
            Console.WriteLine(sum);
            return sum;
        }
        static void TARGIL_5(int a, int b = 1, int c = -1)
        {
            Console.WriteLine(a * b * c);
        }
        static void TARGIL_6(int a = 1, int b = 1, int c = -1)
        {
            Console.WriteLine(a * b * c);
        }
        static void TARGIL_7 (int[] full_numbers, int[] positive, params int[] negative)
        {
            positive = new int[full_numbers.Length];
            negative = new int[full_numbers.Length];
            int positive_index = 0;
            int negative_index = 0;
            for (int i = 0; i < full_numbers.Length; i++)
            {
                if (full_numbers[i] > 0)
                {
                    positive[positive_index] = full_numbers[i];
                    positive_index++;
                }
                else if (full_numbers[i] < 0)
                {
                    negative[negative_index] = full_numbers[i];
                    negative_index++;
                }
            }
            Console.Write(positive[0]);
            Console.Write(positive[1]);
            Console.WriteLine(positive[2]);
            Console.Write(negative[0]);
            Console.WriteLine(negative[1]);
        }

        static void Main(string[] args)
        {
             TARGIL_1(10, 5);
             Console.WriteLine("_________________________________________________________________________");
             int a = 10;
             int b = 5;
             TARGIL_2(ref a, ref b);
             Console.WriteLine(a);
             Console.WriteLine(b);
             Console.WriteLine("_________________________________________________________________________");
             int c, d;
             TARGIL_3(out c, out d);
             Console.WriteLine(c);
             Console.WriteLine(d);
             Console.WriteLine("_________________________________________________________________________");
             TARGIL_4(1, 3, 6, 2, 4);
             Console.WriteLine("_________________________________________________________________________");
             TARGIL_5(10);
             Console.WriteLine("_________________________________________________________________________");
             TARGIL_6(c: 10);
             Console.WriteLine("_________________________________________________________________________");
            int[] full_numbers = { 1, -6, 32, -23, 90 };
            int[] positive_1 = { -100 };
            TARGIL_7(full_numbers,positive_1);
            Console.WriteLine("_________________________________________________________________________");
        }
    }
}
