namespace _20241031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 10; i++) 
                {
                numbers.Add(random.Next(1,20));
                Console.WriteLine(numbers[i]);
                }
            numbers.Remove(20);

            Console.WriteLine("検索したい数字を入力してください");
            int num=int.Parse(Console.ReadLine());
            numbers.IndexOf(num);

            if (num != -1)
            {
                Console.WriteLine($"検索した数字は{num}");
            }
            else
            {
                Console.WriteLine("検索した数字はありません");
            }
            List<int> evenNumber=numbers.Where( n=>n%2==0).ToList();
            Console.WriteLine($"偶数：{string.Join(", ", evenNumber)}");

            numbers.Reverse();
            Console.WriteLine($"逆数：{string.Join(",", numbers)}");
        }
    }
}
