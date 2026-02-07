using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Counter_Strike_mini_simulation_
{
    abstract class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Price { get; set; }

        public abstract int shoot();
    }
}
