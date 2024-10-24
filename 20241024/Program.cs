namespace _20241024
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = new List<int>();
            List<string> name = new List<string>() { "太郎","次郎","花子","一茂","敦也"};

            Console.WriteLine("数字を入力してください");
            int num=int.Parse(Console.ReadLine());
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            numbers.Add(num);
            Console.WriteLine("リストを開示");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("削除したい数字を入力してください");
            int reNumber=int.Parse(Console.ReadLine());
            numbers.Remove(reNumber);

            int fistNumber = numbers[0];
            Console.WriteLine($"最初の数字は{fistNumber}");

            Console.WriteLine("検索したい数字を入力してください");
            int costainsNumber=int.Parse(Console.ReadLine());
            bool contains=numbers.Contains(costainsNumber);

            if (contains)
            {
                Console.WriteLine("あります。");
            }
            else
            {
                Console.WriteLine("ないです");
            }



        }
    }
}
