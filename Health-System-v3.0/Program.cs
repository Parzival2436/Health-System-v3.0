using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Health System v3.0");
            Console.WriteLine("By Will Harding");

            //Construct Characters
            Player player = new Player();
            Enemy enemy = new Enemy();

            //show initial stats
            player.ShowStats();
            enemy.ShowStats();

            //range checking negative input
            Console.WriteLine();
            enemy.AttackPlayer(player, -10);
            Console.WriteLine();
            player.Attack(enemy, -10);
            Console.WriteLine();
            player.Heal(-15);
            Console.WriteLine();
            player.ShieldRegen(-15);
            Console.WriteLine();

            player.ShieldRegen(50);
            Console.WriteLine();
            enemy.AttackPlayer(player, enemy.attack); //Take damage through enemy
            player.ShowStats();
            player.Heal(50);
            player.ShowStats();
            player.ShieldRegen(50);
            player.ShowStats();

            enemy.AttackPlayer(player, enemy.attack);
            player.ShowStats();
            enemy.AttackPlayer(player, 75); //damage values are hardcoded for debugging purposes
            player.ShowStats();
            enemy.AttackPlayer(player, 50);
            player.ShowStats();
            enemy.AttackPlayer(player, 100);
            player.ShowStats();
            enemy.AttackPlayer(player, 200);
            player.ShowStats();
            enemy.AttackPlayer(player, 200);
            player.ShowStats();
            enemy.AttackPlayer(player, 200);
            player.ShowStats();

            player.PlayerReset();
            player.ShowStats();
            player.Attack(enemy, player.attack); //enemy Take damage through player
            enemy.ShowStats();
            player.Attack(enemy, player.attack);
            enemy.ShowStats();
            player.Attack(enemy, player.attack);
            enemy.ShowStats();

            Console.ReadKey(true);
        }

    }
}
