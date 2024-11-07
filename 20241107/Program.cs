namespace _20241107
{
    internal class Program
    {
        struct Point
        {
            public double x;
            public double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public void Display()
            {
                Console.WriteLine($"ｘ座標{x}ｙ座標{y}");
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("x座標を入力してください");
            var xPoint=double.Parse(Console.ReadLine());
            Console.WriteLine("y座標を入力してください");
            var yPoint = double.Parse(Console.ReadLine());

            Point point = new Point(xPoint, yPoint);
            point.Display();
        }
    }
}
