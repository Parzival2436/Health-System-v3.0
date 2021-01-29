using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Player : CharacterObject
    {
        protected int shield;
        protected int lives;
        public bool LivesRemaining;

        //Constructor
        public Player()
        {
            type = "Player";
            name = "Mogar";
            attack = 25;
            lives = 3;
            shield = 100;
            health = 100;
            LivesRemaining = true;
        }

        public void PlayerReset()
        {
            Console.WriteLine("Player has been Reset");
            attack = 25;
            lives = 3;
            shield = 100;
            health = 100;
            LivesRemaining = true;
        }

        public void PlayerDamage(int damage)
        {
            if (damage <= 0) //Error checking negative input
            {
                Console.WriteLine("Error: damage argument must be positive. damage = " + damage);
                return;
            }

            Console.WriteLine(name + " took " + damage + " damage");

            if (shield <= 0)
            {
                TakeDamage(damage); //from CharacterObject
            }
            else if(damage <= shield)
            {
                shield -= damage;
            }
            else
            {
                int spillOver = damage - shield;
                shield -= damage;
                health -= spillOver;
            }

            ShieldCheck(); //Range Checking
            HealthCheck(); //Range Checking
        }

        public void Heal(int Hp)
        {

            if (Hp <= 0) //Error checking negative input
            {
                Console.WriteLine("Error: Hp argument must be positive. Hp input = " + Hp);
                return;
            }

            Console.WriteLine(name + " collected " + Hp + " Hp");

            if (health >= 100)
            {
                Console.WriteLine(name + "'s Health is Full");
                return;
            }

            health += Hp;

        }

        public void ShieldRegen(int Shieldenergy)
        {
            if (Shieldenergy <= 0) //Error checking negative input
            {
                Console.WriteLine("Error: Shieldenergy argument must be positive. Shieldenergy input = " + Shieldenergy);
                return;
            }

            Console.WriteLine(name + " collected " + Shieldenergy + " shield energy");

            if (shield >= 100)
            {
                Console.WriteLine(name + "'s Shields are Full");
                return;
            }

            Console.WriteLine(name + " regenerated " + Shieldenergy + " shield energy");
            shield += Shieldenergy;
        }

        //Range Checking
        private void ShieldCheck() 
        {
            if (shield <= 0)
            {
                shield = 0;
            }
            if (shield >= 100)
            {
                shield = 100;
            }
        }

        protected new void HealthCheck()
        {
            base.HealthCheck(); //From CharacterObject

            if (health <= 0)
            {
                KillPlayer(); //lose life, reset Health & shield
            }
        }

        protected void KillPlayer()
        {
            Console.WriteLine(name + " has died");
            lives -= 1;
            if (lives >= 0)
            {
                Respawn(); //reset Health & shield
            }
            else //Range checking lives
            {
                lives = 0;
                LivesRemaining = false;
                Console.WriteLine();
                Console.WriteLine("---GAME OVER---");
                Console.WriteLine();
            }
        }

        protected void Respawn()
        {
            shield = 100;
            health = 100;
        }

        public new void ShowStats() {
            base.ShowStats();
            //base CharacterObject
            //Console.WriteLine();
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Attack: " + attack);
            //Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
        }
    }
}
