using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241031
{

    

    internal class _20241031_Prac01_又吉_諒
    {
      

        static void Main()
        {
           static T FindMin<T>(List<T> items, Func<T, bool> predicate) where T : IComparable<T>
            {
                // 条件を満たす要素のみを抽出
                var filteredItems = items.Where(predicate).ToList();

                // 条件を満たす要素がなければ default(T) を返す
                if (filteredItems.Count == 0)
                    return default(T);

                // 最小値を見つける
                T minItem = filteredItems[0];
                foreach (var item in filteredItems)
                {
                    if (item.CompareTo(minItem) < 0)
                    {
                        minItem = item;
                    }
                }

                return minItem;
            }
            // 1～50のランダムな整数を10個生成し、リストに追加
            List<int> numbers = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(1, 50));
            }

            Console.WriteLine("数字は: " + string.Join(", ", numbers));

            // 条件：20以上の数の最小値を探す
            int result = FindMin(numbers, n => n>= 20);

            // 結果の表示
            if (!EqualityComparer<int>.Default.Equals(result, default(int)))
            {
                Console.WriteLine("条件下での最小値は: " + result);
            }
            else
            {
                Console.WriteLine("条件に当てはまるものはありません.");
            }
        }
    }
}
