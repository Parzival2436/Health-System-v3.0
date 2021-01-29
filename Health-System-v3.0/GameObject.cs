using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    abstract class GameObject
    {
        //protected int damage;
        public string name;
        protected string type;

        protected void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine(type);
            Console.WriteLine("Name: " + name);
        }
    }
}
