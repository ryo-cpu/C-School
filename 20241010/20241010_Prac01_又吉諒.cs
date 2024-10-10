using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241010
{
    internal class _20241010_Prac01_又吉諒
    {
        static void Main(string[] args)
        {
            ///割り算の例外処理
            try
            {
                Console.WriteLine("すうじをにゅうりょくしてください");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("すうじをにゅうりょくしてください");
                int num2 = int.Parse(Console.ReadLine());
                int sum = Add(num1, num2);
                Console.WriteLine($"合計{sum}");
              int sub = Sub(num1, num2);
                Console.WriteLine($"差{sub}");
                int molt= Multiplication(num1, num2);
                Console.WriteLine($"積{molt}");
                int result = Divide(num1, num2);
                Console.WriteLine($"商{result}");

            }
            catch (DivideByZeroException ex)
            {
                Console.Error.WriteLine("err ０で割ろうとしています");
                Console.Error.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.Error.WriteLine("err 数字が正しく認識されていません");
                Console.Error.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("計算を終了する"); }

            static int Divide(int num1, int num2)
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                return num1 / num2;
            }
            static int Add(int num1, int num2) 
            {
                return num1 + num2;
            }
            static int Sub(int num1, int num2) 
            {
                return num1 - num2;
            }
            static int Multiplication(int num1, int num2)
            { 
                return num1 * num2;
            }
        }
    }

}

