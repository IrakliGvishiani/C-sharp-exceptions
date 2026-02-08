using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Counter_Strike_mini_simulation_.Weapons
{
     class Pistol : Weapon
    
        {
        public Pistol() : base("Glock", 100, 400)
        {
        }
        public override int Shoot()
        {
            Random random = new Random();
            int dealtDamage = random.Next(10, Damage + 1);
                 
             return dealtDamage;
        }
    }
}
