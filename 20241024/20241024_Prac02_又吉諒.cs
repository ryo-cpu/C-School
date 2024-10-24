using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241024
{
    internal class _20241024_Prac02_又吉諒
    {
        static void Main()
        {
            //   ゲームフィールド
            //1から10までの10個のエリアがあります。
            List<bool> Field=new List<bool>();
            for(int i=0; i<10;i++)
            {
                Field.Add(false);
            }
            //エリアには1つだけ宝が隠されています。
            //宝の位置はゲーム開始時にランダムに決まります。
            int FieldNum =Field.Count;
            Random random = new Random();
            int Correct= random.Next(0,FieldNum);
            Field[Correct] = true;
            bool isWin = false;
            for(int i=0;i<5;i++)
            {
                //プレイヤーの行動
                Console.WriteLine("捜索する番号を選んでください");
                int checkField = int.Parse(Console.ReadLine());
                //プレイヤーはエリアの番号を入力して、宝があるかをチェックします。
                if (Field[checkField])
                {
                    Console.WriteLine("お宝を見つけた");

                    isWin = true;
                    break;
                }
                else
                {
                    Console.WriteLine("残念");

                }
                //宝の位置を見つけるとゲームクリアです。
                //プレイヤーには5回まで探索するチャンスが与えられます。
                //各ターンで、プレイヤーはエリア番号（1〜10）を入力します。
                //宝のあるエリアを当てたら勝利、当たらなければ残りの回数が減ります。
                //プレイヤーが5回のチャンス以内に宝を見つけられなかった場合、ゲームオーバーとなります。
            }
            if (isWin)
            {
                Console.WriteLine("you win");
            }
            else 
            {
                Console.WriteLine("GameOver");
            }





        }



        
       
        //ゲームの進行

        

    }
}
