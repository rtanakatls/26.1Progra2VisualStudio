using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2261
{
    internal class Menu
    {
        public void Execute()
        {
            int a;
            int b;

            a = 10;
            b = a;

            Console.WriteLine($"{a} - {b}");

            a = 20;

            Console.WriteLine($"{a} - {b}");

            Console.WriteLine("-------------------------------");

            Test t1=new Test();
            Test t2=new Test();

            t1.n = 10;
            t2.n = t1.n;

            Console.WriteLine($"{t1.n} - {t2.n}");

            t1.n = 20;

            Console.WriteLine($"{t1.n} - {t2.n}");
            
            t2 = t1;

            t1.n = 30;


            Console.WriteLine($"{t1.n} - {t2.n}");

            t2.n = 100;

            Console.WriteLine($"{t1.n} - {t2.n}");
        }

        private void CreatePlayer()
        {
            string name;

            Console.WriteLine("Introduce el nombre del personaje:");
            name = Console.ReadLine();
            Character player = new Character(name, 100);
            player.AddItem(new Item("Poción de vida menor"));
            player.AddItem(new Item("Poción de vida menor"));
            player.AddItem(new Item("Poción de vida"));

            Console.WriteLine($"Hola {player.Name}, tienes {player.Health} de vida");
            Console.WriteLine("Tienes los siguientes objetos:");
            foreach (Item item in player.Items)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
