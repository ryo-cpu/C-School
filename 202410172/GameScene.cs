using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241017._20241017_Prac02_又吉諒
{
    public static class GameScene
    {

        public static void PlayGame()
        {
            const int WinPoints = 15;
            const int LosePoints = 1;
            const int DrawPoints = 5;
            for(int i=0;i<5;i++)
            {
                int Player=int.Parse(Console.ReadLine());
                int jag = Player - Cpu();
                if(jag==0)
                {
                    Console.WriteLine("Draw");
                    ScoreManager.AddScore(DrawPoints);
                }
                else if(jag==-1||jag==2)
                {
                    Console.WriteLine("Win");

                    ScoreManager.AddScore(WinPoints);

                }
                else
                {
                    Console.WriteLine("Lose");

                    ScoreManager.AddScore(LosePoints);

                }

            }
        }
        public static int Cpu()
        {
            Random rnd = new Random();
            return rnd.Next(0,2);
        }
    }
}
