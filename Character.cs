using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2261
{
    internal class Character : Entity
    {
        protected List<Item> items;
        protected int health;

        public int Health { get { return health; } }

        public List<Item> Items { get { return items; } }

        public Character(string name, int health) : base(name)
        {
            this.items = new List<Item>();
            this.health = health;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }


    }
}
