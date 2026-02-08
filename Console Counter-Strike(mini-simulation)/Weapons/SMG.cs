using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Counter_Strike_mini_simulation_.Weapons
{
     class SMG : Weapon
    {
        public SMG() : base("UMP-45",100, 700)
        {
        }
        public override int Shoot()
        {
            Random random = new Random();
            int dealtDamage = random.Next(20, Damage + 1);
                
             return dealtDamage;

        }
    }
}
