using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCombatSimulatorv2
{
    enum AttackType
    {
        Sword = 1,
        Magic,
        Heal
    }

    class Player
    {
        public int HP {get; set;}
        public bool IsAlive { get; }

        public Player(int hp)
        {
            this.HP = hp;
        }

        public int DoAttack()
        { 
            Random rng = new Random();
            int swordAttack = 0;
            int Magic = 0;
            int Heal = 0;
            ChooseAttack();

             if (ChooseAttack() == sword )
            {
                int damage; 

                //print to the console what choice the player made
                Console.WriteLine("You have chosen sword as you method of attack!");
                Console.WriteLine("_______________________________________________________________");
                //get a random number from 1 to 100 and store it in an integer variable
                int hitOrMiss = rng.Next(1, 101);   
                //check a condition if the stored random number is less than or equal to 70
                //and execute the following code if true
                if (hitOrMiss <= 70)
                {
                    //get a random number between 20 and 35 and store in an int variable
                    int swordHit = rng.Next(20, 36);
                    //print to the console to inform player has scored a hit and for how many points
                    Console.WriteLine("Boom! You hit the Dragon for " + swordHit + " points");
                    //subtract the points player scored from the dragon's totla points
                    return swordHit;
                    //print to console remaining dragon points
                    Console.WriteLine("Dragon has " + dragonHitPoints + " points left");
                    //print to console remaining player points
                    Console.WriteLine("You still have " + playerHitPoints + " left");
                    Console.WriteLine();

                }
                //if player failed to score print to console and inform the player has missed.
                else
                {
                    //if player's random intial random pics are greater than 70, print to console he or she missed.
                    Console.WriteLine("Sorry, You Missed!" + "\nIt is the Dragon's turn to strike, good luck!");
                    Console.WriteLine();

                }
            }
            //if player chose 2 print to console the chose method of attack, and execute the code inside
            else if (ChooseAttack() == 2)
            {
                //print to console choice
                Console.WriteLine("You have chosen magic as you method of attack!");
                Console.WriteLine("_______________________________________________________________");
                //pick a random number between 10 and 16 and store in an int variable
                int magicHit = rng.Next(10, 16);
                //print to console informing player has scored a hit, and for how many points
                Console.WriteLine("Nice! You hit the Dragon for " + magicHit + " points");
                //subtract the points scored from the dragon's total
                return magicHit;
                ////print to console remaining points for dragon
                //Console.WriteLine("Dragon has " + dragonHitPoints + " points left");
                ////print to console remaining points for player
                //Console.WriteLine("You still have " + playerHitPoints + " left");

            }
             //choice 3 enter by player
            else if ( ChooseAttack() == 3)
            {
                //print to console player made choice 3 to console
                Console.WriteLine("You have chosen to heal your wound instead of attacking!");
                Console.WriteLine("_______________________________________________________________");
                //get a random number between 10 and 20 and store it in an int variable 
                int healCost = rng.Next(10, 21);
                //test the condition to see if the total points available for player equal 100
                if (playerHitPoints == 100)
                {
                    //print to console informing player no more points allowed, he or she has max amount possible
                    Console.WriteLine("Sorry, but you already have the maximum points allowed");
                }
                 //test the condition to see if total player points are less than 100
                else if (playerHitPoints < 100)
                {
                    //subtract healing points awarded and add it player's total points and store in a new int variable
                    int pointDiff = playerHitPoints + healCost;
                    //test the condition to see if the the new player total is less than 100
                    if (pointDiff < 100)
                    {
                        //if the above condition is true add healpoints to the player's points
                        playerHitPoints += healCost;
                        //print to console informing player he or she now has the new total added
                        Console.WriteLine("You're being rewarded " + healCost + " points" +
                            "\nso, you now have " + playerHitPoints + " points.");

                    }
                    //test the condition to see if healpoints added to the player total  are greater than 100
                    else if (pointDiff > 100)
                    {
                        //print to console informing player he or she had the original points
                        Console.WriteLine("You had " + playerHitPoints + " points and");  
                        //because player is only allowed 100 points discard the difference and award return 100 for 
                        //new total player points
                        playerHitPoints = 100;
                        //print to console how many points player has been awarded
                        Console.WriteLine("Ok, you now have " + playerHitPoints + " points.");

                    }
                }
            }
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
            return AttackType;
        }

        public void TakeDamage(int damage)
        {

        }


    }
}
