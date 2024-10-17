using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241017
{
    public static class Calcu
    {
        public static int Add (int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        public static bool isEven(int n1)
        {
            if(n1%2==0)
            {
                Console.WriteLine($"{n1}は偶数");
                return true;
            }
            Console.WriteLine($"{n1}は奇数");

            return false;
        }
        public static int Max(int n1, int n2)
        {
            if(n1>n2) { return n1; }
            return n2;
        }
    }

    internal class _20241017_Prac01_又吉諒
    {
        static void Main(string[] args)
        {
            try
            {
                var Snumber1 = Console.ReadLine();
                var Snumber2 = Console.ReadLine();

                var number1 = int.Parse(Snumber1);
                var number2 = int.Parse(Snumber2);
         


            var sum = Calcu.Add(number1, number2);
            var multiply = Calcu.Multiply(number1, number2);
            Console.WriteLine($"{number1}+{number2}={sum}");
            Console.WriteLine($"{number1}*{number2}={multiply}");
            Calcu.isEven(sum);
            Calcu.isEven(multiply);
            Console.WriteLine($"最大は{Calcu.Max(sum, multiply)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("エラー: 入力は数字である必要があります。");
            }

        }


    }

   
    
}
