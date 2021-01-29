using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Enemy : CharacterObject
    {
        //Constructor
        public Enemy() //#1
        {
            type = "Enemy";
            name = "Frank";
            attack = 50;
            health = 50;
        }

        public void AttackPlayer(Player target, int damageDealt)
        {
            if (damageDealt <= 0) //Error checking negative input
            {
                Console.WriteLine("Error: damage argument must be positive. Damage = " + damageDealt);
                return;
            }

            Console.WriteLine(this.name + " attacked " + target.name);

            target.PlayerDamage(damageDealt);
        }

        public void KillEnemy() //should work this into health check
        {
            if (health <= 0)
            {
                Console.WriteLine(name + " Has been killed"); 
            }
        }
    }
}
