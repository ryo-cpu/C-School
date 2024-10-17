using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241017._20241017_Prac02_又吉諒
{
    public static class ResultScene
    {
        public static void DrawResult()
        {
            int Score=ScoreManager.GetScore();
            Console.WriteLine(Score);
            if(ScoreManager.IsHighScore(ScoreManager.GetHightScore()))
            {
                Console.WriteLine("ハイスコアに到達しました！");
                ScoreManager.SetHightScore(Score);
                ScoreManager.ResetScore();
            }
        }
    }
}
