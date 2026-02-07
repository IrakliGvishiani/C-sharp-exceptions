using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Counter_Strike_mini_simulation_.Weapons
{
    abstract class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Price { get; set; }


        public Weapon(string name, int damage, int price)
        {
            Name = name;
            Damage = damage;
            Price = price;
        }

        public abstract int Shoot();
    }
}
