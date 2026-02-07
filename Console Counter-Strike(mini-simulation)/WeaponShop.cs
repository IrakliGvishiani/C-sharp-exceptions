using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Counter_Strike_mini_simulation_
{
     class WeaponShop
    {
        public void BuyWeapon(Players.Player player, Weapons.Weapon weapon)
        {
            if (player.Money >= weapon.Price)
            {
                player.Money -= weapon.Price;
                player.EquippedWeapon = weapon;
                Console.WriteLine($"{player.Name} bought {weapon.Name} for ${weapon.Price}. Remaining money: ${player.Money}");
            }
            else
            {
                Console.WriteLine($"{player.Name} does not have enough money to buy {weapon.Name}. Required: ${weapon.Price}, Available: ${player.Money}");
            }
        }
    }
}
