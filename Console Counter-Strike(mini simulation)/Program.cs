namespace Console_Counter_Strike_mini_simulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Rifle ak47 = new Rifle() { Name = "AK-47", Damage = 35, Price = 2700 };
            Console.WriteLine(ak47.shoot());

        }
    }
}
