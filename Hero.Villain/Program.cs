using System.Net.Http.Headers;

namespace Hero.Villain
{

    public class Character { 
        public string Name { get; set; }
        public int money { get; set; }
        public int health { get; set; }


        public virtual void attack(Character target)
        {

        }



        public Character(string name,int money,int health)
        {
            this.Name = name;
            this.money = money;
            this.health = health;
        }


    }

    public class Hero : Character
    {
        public int LightAbility { get; set; }
        public void Heal(Hero teammate)
        {
            int healAmount = 20;
            if (health <= 20)
            {
                Console.WriteLine($"{Name} does not have enough health to heal.");
            }
            else if (teammate.health >= 100)
            {
                Console.WriteLine($"{teammate.Name} is already at full health.");
            }
            else if (teammate.health + healAmount > 100)
            {
                healAmount = 100 - teammate.health;
                health -= healAmount;
                teammate.health += healAmount;
                //Console.WriteLine(health);
                Console.WriteLine($"{Name} healed {teammate.Name}. {teammate.Name}'s health is now {teammate.health}.");
            }
            else
            {
                health -= 20;
                teammate.health += 20;
                Console.WriteLine($"{Name} healed {teammate.Name}. {teammate.Name}'s health is now {teammate.health}.");
            }
        }

        public Hero(string name, int money, int health, int lightAbility) : base(name, money, health)
        {
            this.LightAbility = lightAbility;
           
        }

        public override void attack(Character target)
        {

            if (target.health <= 0)
            {
                Console.WriteLine("Cannot attack a defeated target.");
                return;
            }
            else
            {
                base.attack(target);
                target.health -= LightAbility;

                if (target.health <= 0)
                {
                    target.health = 0;
                    Console.WriteLine($"{Name} attacked  for {LightAbility} Damage");
                    Console.WriteLine($"{target.Name} has been defeated by {Name}");
                }
                else
                {
                    Console.WriteLine($"{Name} attacked {target.Name} for {LightAbility} damage.");
                }

               
            }

     
            
        }
 



    }
    public class Villain : Character
    {
        public int DarkAbility { get; set; }

        public Villain(string name, int money, int health, int darkAbility) : base(name, money, health)
        {
            this.DarkAbility = darkAbility;
        }

        public override void attack(Character target)
        {
            if (target.health <= 0)
            {
                Console.WriteLine("Cannot attack a defeated target.");
                return;
            }
            else {
                base.attack(target);
                target.health -= DarkAbility;

                if (target.health < 0)
                {
                    target.health = 0;
                    Console.WriteLine($"{target.Name} has been defeated by {Name}");
                }
                else
                {
                    Console.WriteLine($"{Name} attacked {target.Name} for {DarkAbility} damage.");
                }
            }
            

            
        }   
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Superman", 1000, 100, 50);
            Hero hero2 = new Hero("Batman", 900, 90, 30);

            Villain villain = new Villain("Lex Luthor", 800, 90, 40);
       
            //hero.attack(villain);
            //hero2.attack(villain);
            //villain.attack(hero);
            hero.Heal(hero2);
        }
    }
}
