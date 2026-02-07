using Console_Counter_Strike_mini_simulation_.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Counter_Strike_mini_simulation_.Players
{
     class Terrorist : Player
    {
    
        public Terrorist(string name,int health,int money) : base(name,health,money) { 
        
        }

        public override string team => "Terrorist";


    }
}
