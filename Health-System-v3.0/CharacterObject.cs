using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    abstract class CharacterObject : GameObject
    {
        protected int health;
        public int attack;

        public new void ShowStats()
        {
            base.ShowStats();
            //base GameObject
            //Console.WriteLine("Name: " + name);
            Console.WriteLine("Attack: " + attack);
            Console.WriteLine("Health: " + health);
        }

        //(protected?)TakeDamage for use in Enemy and Player
        public void TakeDamage(int damage){
            if (damage <= 0)
            {
                Console.WriteLine("Error: damage argument must be positive. Damage = " + damage);
                return;
            }

            health -= damage;

            HealthCheck();
        }

        public void Attack(CharacterObject target , int damageDealt)
        {
            if (damageDealt <= 0) //Error checking negative input
            {
                Console.WriteLine("Error: damage argument must be positive. Damage = " + damageDealt);
                return;
            }
            if (target.health <= 0)
            {
                Console.WriteLine(this.name + " has killed " + target.name);
            }

            Console.WriteLine(this.name + " Dealt " + damageDealt + " damage to " + target.name);
            
            target.TakeDamage(damageDealt);
        }

        //Range Checking
        protected void HealthCheck()
        {
            if (health <= 0)
            {
                health = 0;
            }
            if (health >= 100)
            {
                health = 100;
            }
        }
    }
}
