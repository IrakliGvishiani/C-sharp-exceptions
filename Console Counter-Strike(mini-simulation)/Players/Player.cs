using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Console_Counter_Strike_mini_simulation_.Players
{
    abstract class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Money { get; set; }
        public Weapons.Weapon EquippedWeapon { get; set; }

        public abstract string team { get; }
        public Player(string name, int health, int money)
        {
            Name = name;
            Health = health;
            Money = money;
            //EquippedWeapon = equippedWeapon;


        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public void shoot (Player target)
        {
            bool isTargetAlive = target.IsAlive();

            if (EquippedWeapon == null)
            {
                Console.WriteLine($"{Name} has no weapon to shoot with!");
                return;
            }
            else if (!IsAlive() || !isTargetAlive)
            {
                Console.WriteLine($"{Name} is dead and cannot shoot!");
                return;
            }
            else
            {
                int damageDealt = EquippedWeapon.Shoot();
                target.Health -= damageDealt;

                if (target.Health < 0)
                {
                    target.Health = 0;
                    Console.WriteLine($"{Name} shoots {target.Name} with {EquippedWeapon.Name} for {damageDealt} damage! {target.Name} is killed!");
                }
                else
                {
                    Console.WriteLine($"{Name} shoots {target.Name} with {EquippedWeapon.Name} for {damageDealt} damage! {target.Name} now has {target.Health} health.");

                }
            }

        }
    }
}
