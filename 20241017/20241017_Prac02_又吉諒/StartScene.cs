using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241017._20241017_Prac02_又吉諒
{
    public static class StartScene
    {
        public static void drwa()
        {
          Console.WriteLine("5回戦のじゃんけんを行い、各回で以下のポイントを加算します。\r\n勝利: 15点\r\n引き分け: 5点\r\n敗北: 1点\r\nじゃんけんの手は「グー」「チョキ」「パー」から選びます。\r\nCPU の手はランダムで決定します。");
           var key = Console.ReadKey(true);
            while(key.Key != ConsoleKey.Enter)
            {
              key = Console.ReadKey(true);
            }

        }
       
    }
}
