using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241017
{
    public static class ScoreManager
    {
        private static int CurrentScore=0;
        private static int HightScore=0;
        public static void AddScore(int points)
        {
            CurrentScore += points;
        }
        public static void ResetScore()
        { 
            CurrentScore =0;
        }
        public static bool IsHighScore(int threshold)
        {
            if (CurrentScore > threshold)
            {
                return true;
            }
            return false;
        }
        public static int GetScore()
        {
            return CurrentScore;    
        }
        public static int GetHightScore()
        {
            return HightScore;
        }
        public static void SetHightScore(int NewHightScore)
        {
            HightScore = NewHightScore; 
        }
       
    }
   
}
