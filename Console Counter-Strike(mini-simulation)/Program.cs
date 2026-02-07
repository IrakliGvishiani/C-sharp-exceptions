using Console_Counter_Strike_mini_simulation_.Weapons;

namespace Console_Counter_Strike_mini_simulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeaponShop weaponShop = new WeaponShop();
             Players.Player CT1 = new Players.Counter_Terrorist("ct", 100,3000);
            Players.Player TR1 = new Players.Terrorist("tr", 100, 1500);

            Weapon ak_47 = new Rifle();
            Weapon glock = new Pistol();
            Weapon ump_45 = new SMG();

            weaponShop.BuyWeapon(CT1, ak_47);
            weaponShop.BuyWeapon(TR1, ump_45);

            
        }
    }
}
