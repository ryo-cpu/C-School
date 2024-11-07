using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241107._20241107_Prac02_又吉諒
{
    public static class BattleSimuator
    {
        public static void  Battle(Player player,Player enemy)
        {
            while (player.GetHP()>0&&enemy.GetHP()>0)
            {
                Random random = new Random();
                Console.WriteLine($"{enemy.GetName()}の攻撃");
                int Damege = random.Next(5, enemy.GetAttack());
                player.TakeDamage(Damege );
                Console.WriteLine($"{Damege}のダメージ　残りHP{player.GetHP()}");
                if(player.GetHP()<0)
                {
                    break;
                 }
                Console.WriteLine($"{player.GetName()}の攻撃");
                Damege = random.Next(5, player.GetAttack());
                enemy.TakeDamage(Damege);
                Console.WriteLine($"{Damege}のダメージ　あいて残りHP{enemy.GetHP()}");

            }
            if (player.GetHP() > 0)
            {
                Console.WriteLine("You Win");
                Console.WriteLine($"{player.GetName()}  {player.GetHP()}Hp   {enemy.GetName()}  {enemy.GetHP()}hp");

            }
            else
            {
                Console.WriteLine("You Lose");
                Console.WriteLine($"{player.GetName()}  {player.GetHP()}Hp   {enemy.GetName()}  {enemy.GetHP()}hp");
            }
        }

    }
}