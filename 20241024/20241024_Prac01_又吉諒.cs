using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241024
{
    internal class _20241024_Prac01_又吉諒
 {
        static void Main()
        {
            List<int> list = new List<int>();
            // / 整数のリストを作成します。
            Console.WriteLine("数字を入力してください");
            int AddNunber=int.Parse(Console.ReadLine());
            //追加する数値はユーザーから入力を受け付け、0を入力したら追加を終了します。
            while(AddNunber!=0)
            {
                //リストに整数を追加する機能を実装します
                list.Add(AddNunber);
                AddNunber=int.Parse(Console.ReadLine());

            }

            //リスト内のすべての要素を表示する機能を実装します。
            Console.WriteLine("リストを開示");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            int sum=0;
            foreach (int i in list)
            {
                //リスト内の要素の合計を計算し、表示してください。
                sum += i;
            }
            Console.WriteLine("合計");

            Console.WriteLine(sum);
            //リスト内の要素を昇順にソートし、再度表示してください。
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }


        
     
    }
}
