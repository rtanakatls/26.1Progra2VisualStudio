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
            Console.WriteLine("Esto es un arreglo");
            int[] values = new int[5];
            values[0] = 0;
            values[1] = 10;
            values[2] = 20;
            values[3] = 30;
            values[4] = 40;

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Esto es una lista");
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);


            foreach (int value in list)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Esto es un diccionario");

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Pepito", 0);
            dictionary.Add("Pablito", 10);
            dictionary["Pedrito"] = 20;
            dictionary["Periquito"] = 30;
            dictionary["Lolcito"] = 40;

            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            Console.WriteLine("Esto es un cola");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            } 

            Console.WriteLine("Esto es una pila");
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }

        private void Example()
        {
            int a;
            int b;

            a = 10;
            b = a;

            Console.WriteLine($"{a} - {b}");

            a = 20;

            Console.WriteLine($"{a} - {b}");

            Console.WriteLine("-------------------------------");

            Test t1 = new Test();
            Test t2 = new Test();

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
