using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241107
{
    struct Student
    { 
        public string Name {  get; set; }
        public int Score { get; set; }

        public char Grade;

        public Student(string Name,int Score) 
        {
            this.Name = Name;
            this.Score = Score;
            GetGrade(Score);
        }
        public void  GetGrade(int Score)
        {
            if (Score >= 90)
            {
                Grade = 'S';
            }
            else if (Score >= 70)
            {
                Grade = 'A';

            }
            else if (Score >= 50)
            {
                Grade = 'B';
            }
            else if (Score >= 30)
            {
                Grade = 'C';

            }
            else {
                Grade = 'D';

            }


        }
        public void Display()
        {
            Console.WriteLine($"名前：{Name}\n点数{Score}\n評価{Grade}");
        }
    }

    internal class _20241107_Prac01_又吉諒
    {
        static void Main(string[] args)
        {

            Console.WriteLine("名前を入力してください");
            var name = Console.ReadLine();
            Console.WriteLine("スコアを入力してください");
            var score = int.Parse(Console.ReadLine());

          Student student = new Student(name, score);
           student.Display();

          
        }
    }
}
