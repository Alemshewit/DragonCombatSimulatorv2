using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorv2
{
    class Enemy
    {
        private string Name { get; set; }
        private int HP { get; set; }
        private bool IsAlive { get; }

        public Enemy(string name, int intialHitPoints)
        {
            this.Name = name.ToUpper();
            this.HP = intialHitPoints;
        }

        public bool IsAlive
        {
            get{return this.HP > 0;}
        }

        private Random rng = new Random();

        public int DoAttack()
        {
            int damage;
            //pick random number between 1 and 100 and store it in hitOrMiss
            int hitOrMiss = rng.Next(1, 101);
            //check condition to see if the hit was successful or not
            if (hitOrMiss <= 80)
            {
                //if the above condition is true get a random number between 5 and 15 and assign it to an int variable 
               damage = rng.Next(5, 16);
                //subtract the damage from players total
               Player.HP -= damage;
                //print t console the output
               Console.WriteLine("{0} inflicts pain on Player for {2} damage!", this.Name, damage);
            }
            else
            {
                //if dragon misses print to console missed.
                Console.WriteLine("Dragon Missed");
            }
        }
        //take damage takes the damage argument and applies it to enemy
        public void TakeDamage(int damage)
        {
            this.HP -= damage;
            if (this.HP <= 0)
                Console.WriteLine("Enemy defeats player!");
        }

    }
}
