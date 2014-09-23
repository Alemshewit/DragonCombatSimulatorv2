using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorv2
{
   public enum AttackType
    {
        Sword = 1,
        Magic,
        Heal
    }

    class Player
    {
        public int HP {get; set;}
        public bool IsAlive 
        { 
            get { return this.HP > 0; } 
        }

        public Player(int intialHitPoints)
        {
            this.HP = intialHitPoints;
        }

        private AttackType ChooseAttack()
        {
            //print to console instructing player on the required input to commence the game
            Console.WriteLine("Enter 1 if you want to attack with sword. " +
               "\nEnter 2 if you want to attack with magic." +
               "\nEnter 3 if you want to heal your wound for 10 to 20 points.");
            //enter an extra line to separate sections  
            Console.WriteLine();
            int playerChoice = int.Parse(Console.ReadLine());
            //call the PlayerAttack function and send the players choice of weapon as a parameter             
            return (AttackType)playerChoice;
        }
        //declare a new random number generator
        private Random rng = new Random();

        public int DoAttack()
        { 
            int damage; 

             if (ChooseAttack() == AttackType.Sword)
            {
                //get a random number from 1 to 100 and store it in an integer variable
                int hitOrMiss = rng.Next(1, 101);   
                //check a condition if the stored random number is less than or equal to 70
                //and execute the following code if true
                if (hitOrMiss <= 70)
                {
                    //get a random number between 20 and 35 and store in an int variable
                    damage = rng.Next(20, 36);
                    //subtract the points player scored from the dragon's totla points
                    Enemy-= damage;
                    //print to console remaining player points
                    Console.WriteLine("You inflict {0} damages to {1}", damage, enemy.Name);
                    Console.WriteLine();

                }
                //if player failed to score print to console and inform the player has missed.
                else
                {
                    //if player's random intial random pics are greater than 70, print to console he or she missed.
                    Console.WriteLine("You missed {0} with the sword badly!", enemy.Name);

                }
            }
            //if player chose 2 print to console the chose method of attack, and execute the code inside
            else if (ChooseAttack() == AttackType.Magic)
            {
                //print to console choice
                Console.WriteLine("You have chosen magic as you method of attack!");
                //pick a random number between 10 and 16 and store in an int variable
                damage = rng.Next(10, 16);
                Enemy.HP -= damage;
                //print to console remaining points for dragon
                Console.WriteLine("You inflict {0} damages to {1}", damage, enemy.Name);

            }
             //choice 3 enter by player
            else if ( ChooseAttack() == AttackType.Heal)
            {
                //print to console player made choice 3 to console
                Console.WriteLine("You've selected to heal your wound!");
                //get a random number between 10 and 20 and store it in an int variable 
                int amountHealedBy = rng.Next(10, 21);
                //test the condition to see if the total points available for player equal 100
                if (player.HP == 100)
                {
                    //print to console informing player no more points allowed, he or she has max amount possible
                    Console.WriteLine("You already have the maximum points allowed!");
                }
                 //test the condition to see if total player points are less than 100
                else if (player.HP < 100)
                {
                    //subtract healing points awarded and add it player's total points and store in a new int variable
                    int pointDiff = player.HP + amountHealedBy;
                    //test the condition to see if the the new player total is less than 100
                    if (pointDiff < 100)
                    {
                        //if the above condition is true add healpoints to the player's points
                        player.HP += amountHealedBy;
                        //print to console informing player he or she now has the new total added
                        Console.WriteLine("You has been healed by {0} points", amountHealedBy);

                    }
                    //test the condition to see if healpoints added to the player total  are greater than 100
                    else if (pointDiff > 100)
                    {
                        //print to console informing player he or she had the original points
                        Console.WriteLine("You had " + player.HP + " points and");  
                        //because player is only allowed 100 points discard the difference and award return 100 for 
                        //new total player points
                        player.HP = 100;
                        //print to console how many points player has been awarded
                        Console.WriteLine("Ok, you now have " + player.HP + " points.");

                    }
                }
            }
        }

        public void TakeDamage(int damage)
        {
            this.HP -= damage;
            if (this.HP <= 0)
                Console.WriteLine("You've defeated the enemy!");
        }


    }
}
