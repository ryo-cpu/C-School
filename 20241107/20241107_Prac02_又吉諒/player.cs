using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241107._20241107_Prac02_又吉諒
{
    struct PlayerK
    {
        public string Name {  get; set; }
        public int HP {  get; set; }
        public int Attack {  get; set; }
    }

    public class Player
    {
        private PlayerK playerK = new PlayerK();

        public void Initalize(string name)
        {
            playerK.Name = name;
            Random random = new Random();

            playerK.Attack = random.Next(15,55);
            playerK.HP = random.Next(15, 55);
        }
        public void TakeDamage(int Dameage)
        {
            playerK.HP-=Dameage;
            if (playerK.HP < 0) { playerK.HP = 0; }
        }
        public int GetHP() { return playerK.HP; }
        public int GetAttack() { return playerK.Attack; }
        public string GetName() { return playerK.Name; }

        public void DisPlay()
        {
            Console.WriteLine($"Name{playerK.Name}\nHP{playerK.HP}\nAttack{playerK.Attack}");
        }


    }



}
