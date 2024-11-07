using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241107._20241107_Prac02_又吉諒
{
    internal class main
    {
        static void Main(string[] args)
        {

            Player player = new Player();
            Player Enemy = new Player();
            Console.WriteLine("プレイヤーネームを入力してください");
            player.Initalize(Console.ReadLine());
            Console.WriteLine("敵を入力してください");
            Enemy.Initalize(Console.ReadLine());
            player.DisPlay();
            Enemy.DisPlay();
            BattleSimuator.Battle(player,Enemy);


        }
    }
}
