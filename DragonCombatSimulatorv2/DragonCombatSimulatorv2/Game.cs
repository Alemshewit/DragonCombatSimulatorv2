using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorv2
{
    class Game
    {
        public string Player { get; set; }
        public string Enemy { get; set; }

        public Game()
        {
            this.Player = "Alem";
            this.Enemy = "Dragon";
        }

        static void DisplayCombatInfo()
        {
            //Console.WriteLine(this.Player.hp);
            
        }

        static void PlayGame()
        {
            while (this.Player.IsAlive && this.Enemy.IsAlive)
            {
                DisplayCombatInfo();
                this.Enemy.TakeDamage(this.Player.DoAttack());
                this.Player.TakeDamage(this.Enemy.DoAttack());
            }

            if (this.Player.IsAlive)
            {
                Console.WriteLine("You won!");

            }
            else
            {
                Console.WriteLine("You lost!");
            }
        }
    }
}
