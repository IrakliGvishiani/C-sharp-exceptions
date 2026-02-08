using Console_Counter_Strike_mini_simulation_.Players;
using Console_Counter_Strike_mini_simulation_.Weapons;
using System.IO;
using System.IO.Pipelines;

namespace Console_Counter_Strike_mini_simulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\user\\source\\repos\\ConsoleApp2\\Console Counter-Strike(mini-simulation)\\Results.txt";
            File.WriteAllText(path, "");

            WeaponShop weaponShop = new WeaponShop();
            Player CT1 = new Counter_Terrorist("ct", 100, 1000);
            Player CT2 = new Counter_Terrorist("ct1", 100, 1000);



            Player TR1 = new Terrorist("tr", 100, 1000);
            Player TR2 = new Terrorist("tr1", 100, 1000);


            Player[] terrorists = { TR1, TR2 };


            Player[] counter_terrorists = { CT1, CT2 };
            //GetRandomCT(counter_terrorists);

            Weapon ak_47 = new Rifle();
            Weapon glock = new Pistol();
            Weapon ump_45 = new SMG();

            weaponShop.BuyWeapon(CT1, ak_47);
            weaponShop.BuyWeapon(TR1, ump_45);

            weaponShop.BuyWeapon(CT2, glock);
            weaponShop.BuyWeapon(TR2, ump_45);

            Random random = new Random();

            int round = 1;
            while ((TR1.IsAlive() || TR2.IsAlive()) && (CT1.IsAlive() || CT2.IsAlive()))
            {

                File.AppendAllText(path, $"Round {round}\n");


                Player tr = GetRandomTerrorist(terrorists);
                Player ct = GetRandomCT(counter_terrorists);

                if (WhoStarts())
                {
                    tr.shoot(ct);
                    if (ct.IsAlive())
                    {
                        ct.shoot(tr);
                    }

                }
                else
                {
                    ct.shoot(tr);
                    if (tr.IsAlive())
                    {
                        tr.shoot(ct);
                    }
                }

                //File.WriteAllText(path, "");
                round++;

            }
            if (CT1.IsAlive() || CT2.IsAlive())
            {
                File.AppendAllText(path, "WINNER TEAM : Counter-Terrorists");
            }
            else
            {
                File.AppendAllText(path, "WINNER TEAM : Terrorists");
            }


        }


        static Player GetRandomTerrorist(Player[] players)
        {
            Random random = new Random();

            while (true)
            {
                Player pl = players[random.Next(players.Length)];
                if (pl.IsAlive())
                {
                    return pl;
                }
            }

        }

        static Player GetRandomCT(Player[] players)
        {
            Random random = new Random();

            while (true)
            {
                Player pl = players[random.Next(players.Length)];
                if (pl.IsAlive())
                {
                    return pl;
                }
            }

        }

        static bool WhoStarts()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }

    }
}
