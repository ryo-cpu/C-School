namespace _20241017
{
    internal class Program
    {
        //静的メソッド

       
        static void Main(string[] args)
        {
            var number1=int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
             
            var sum=calcu(number1,number2);
            Console.WriteLine($"{number1}+{number2}={sum}");

        }
    }
}
