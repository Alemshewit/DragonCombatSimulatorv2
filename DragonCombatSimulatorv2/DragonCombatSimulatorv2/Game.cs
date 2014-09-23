using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorv2
{
    class Game
    {
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }

        public Game()
        {
            this.Player = new Player(100);
            this.Enemy = new Enemy("Dragon", 200);
        }

        private void DisplayCombatInfo()
        {
            //Console.WriteLine(this.Player.hp);
            Console.WriteLine("Player " + Player.HP,
                "\nEnemy" + Enemy.HP);
        }

        public void PlayGame()
        {
            while (Player.IsAlive && Enemy.IsAlive)
            {
                DisplayCombatInfo();
                Enemy.TakeDamage(Player.DoAttack());
                Player.TakeDamage(Enemy.DoAttack());
            }

            if (!Player.IsAlive)
            {
                Console.WriteLine("You have been defeated!");

            }
            else
            {
                Console.WriteLine("Congrats! You win, Enemy loses!");
            }
        }
    }
}
