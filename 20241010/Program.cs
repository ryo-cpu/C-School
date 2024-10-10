namespace _20241010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///割り算の例外処理
            try
            {
                Console.WriteLine("わられるすうじをにゅうりょくしてください");
                int num1=int.Parse(Console.ReadLine());
                Console.WriteLine("わるすうじをにゅうりょくしてください");
                int num2=int.Parse(Console.ReadLine());
                int result = Divide(num1, num2);
                Console.WriteLine($"{num1}/{num2}={result}");

            }
            catch(DivideByZeroException ex)
            {
                Console.Error.WriteLine("err ０で割ろうとしています" );
                Console.Error.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.Error.WriteLine("err 数字が正しく認識されていません");
                Console.Error.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("プログラムを終了する"); }

            static int Divide(int num1, int num2) 
            {
                if(num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                return num1/num2;   
            }

        }
    }
}
 