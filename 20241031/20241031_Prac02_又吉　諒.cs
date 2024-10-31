using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _20241031.HealingItem;

namespace _20241031
{
    public abstract class Item
    {
        public string Name { get; set; }
    }
    public class Weapon : Item
    {
        public int AttackPower { get; set; }
        public Weapon(string name, int attackPower)
        {
            Name = name;
            AttackPower = attackPower;
        }
    }

    public class HealingItem : Item
    {
        public int HealAmount { get; set; }
        public HealingItem(string name, int healAmount)
        {
            Name = name;
            HealAmount = healAmount;
        }
        public class Inventory<T>() where T : Item
        {
            private List<T> items =new List<T>();
            private const int maxCapacity = 10;
            public void AddItem(T item)
            {
                if (items.Count >= maxCapacity)
                {
                    Console.WriteLine("入れすぎ");
                }
                else
                {
                    Console.WriteLine($"{item.Name} 入れた");
                    items.Add(item);
                }
            }
            public void RemoveItem(T item)
            {
                if (items.Contains(item))
                {
                    items.Remove(item);
                }
               
            }
            public int CountItems()
            {
                return items.Count;
            }
            public void DisplayItems()
            {
                Console.WriteLine("インベントリの内容:");
                foreach (var item in items)
                {
                    Console.WriteLine($"- {item.Name}");
                }
            }
        }
        public class Player
        {

            public int HP { get; private set; }
            public int AttackPower { get; private set; }
            public Inventory<Item> Inventory { get; private set; }

            public Player(int hp, int attackPower)
            {
                HP = hp;
                AttackPower = attackPower;
                Inventory = new Inventory<Item>();
            }
            public void UseItem(Item item)
            {
                if (item is Weapon weapon)
                {
                    AttackPower += weapon.AttackPower;
                    Console.WriteLine($"{weapon.Name} を使用しました。攻撃力が {weapon.AttackPower} 増加しました。現在の攻撃力: {AttackPower}");
                }
                else if (item is HealingItem healingItem)
                {
                    HP += healingItem.HealAmount;
                    Console.WriteLine($"{healingItem.Name} を使用しました。HPが {healingItem.HealAmount} 回復しました。現在のHP: {HP}");
                }
                else
                {
                    Console.WriteLine("未知のアイテムです。使用できません。");
                }

                Inventory.RemoveItem(item);
            }
            public void DisplayStatus()
            {
                Console.WriteLine($"プレイヤーのステータス - HP: {HP}, 攻撃力: {AttackPower}");
                Inventory.DisplayItems();
            }

        }



    }






    internal class _20241031_Prac02_又吉_諒
    {
        static void Main(string[] args)
        {
            // プレイヤーの作成
            Player player = new Player(hp: 100, attackPower: 10);

            // アイテムの作成
            Weapon sword = new Weapon("鋼の剣", 15);
            HealingItem potion = new HealingItem("回復ポーション", 20);

            // アイテムをインベントリに追加
            for (int i = 0; i < 6; i++)
            {
                player.Inventory.AddItem(sword);
                player.Inventory.AddItem(potion);
            }

            // プレイヤーステータスの表示
            player.DisplayStatus();

            // アイテムを使用
            player.UseItem(sword);
            player.UseItem(potion);

            // 最終的なステータスの表示
            player.DisplayStatus();
        }
    }

}


