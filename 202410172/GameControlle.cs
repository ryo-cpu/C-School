﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241017._20241017_Prac02_又吉諒
{
    public static class GameControlle
    {
     public static  void LoopGeam()
        {
            while (true)
            {
                StartScene.DrwaStart();
                GameScene.PlayGame();
                ResultScene.DrawResult();
            }
        }
    }
}