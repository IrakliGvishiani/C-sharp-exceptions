using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Counter_Strike_mini_simulation_.Weapons
{
     class Rifle : Weapon
    {
        public Rifle() : base("AK-47", 100, 2500)
        {
        }
        public override int Shoot()
        {
            Random random = new Random();
            int dealtDamage = random.Next(40, Damage + 1);
                
             return dealtDamage;
        }
    }
}
