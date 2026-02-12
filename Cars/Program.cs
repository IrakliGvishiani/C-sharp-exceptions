namespace Cars
{

    public class Cars
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Cylinder { get; set; }
        public decimal Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public int City { get; set; }
        public int Combined { get; set; }
        public int Highway { get; set; }


        public static Cars Parsee(string input)
        {
            string[] parts = input.Split(',');

            Cars result = new Cars() { 
            
                Make = parts[0],
                Model = parts[1],
                Cylinder = int.Parse(parts[2]),
                Engine = Convert.ToDecimal(parts[3]),
                Drive = parts[4],
                Transmission = parts[5],
                City = int.Parse(parts[6]),
                Combined = int.Parse(parts[7]),
                Highway = int.Parse(parts[8]),

            };

            return result;

        }

        public void display()
        {
           string path = "C:\\Users\\user\\source\\repos\\ConsoleApp2\\Cars\\vehicles.csv";

            string[] lines = System.IO.File.ReadAllLines(path);

            for (int  i = 1;i < lines.Length;i++)
            {
               var car = Parsee(lines[i]);


                if (car.Make == "Mercedes-Benz")
                {
                    Console.WriteLine(
                      $@"Mercedes-Benz 
                    Model: {car.Model}
                    Cylinder: {car.Cylinder}
                    Engine : {car.Engine}
                    Drive : {car.Drive}
                    Transmission : {car.Transmission}
                    City : {car.City}
                    Combined : {car.Combined}
                    Highway : {car.Highway}
                   -----------------------------------");
                }
            }
        }

        public void FilterCar(string carToFilter)
        {
            string path = "C:\\Users\\user\\source\\repos\\ConsoleApp2\\Cars\\vehicles.csv";

            string[] lines = System.IO.File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++)
            {
                var car = Parsee(lines[i]);


                if (car.Make == carToFilter)
                {
                    Console.WriteLine(
                      $@"{carToFilter} 
                    Model: {car.Model}
                    Cylinder: {car.Cylinder}
                    Engine : {car.Engine}
                    Drive : {car.Drive}
                    Transmission : {car.Transmission}
                    City : {car.City}
                    Combined : {car.Combined}
                    Highway : {car.Highway}
                   -----------------------------------");
                }
                else
                {
                    Console.WriteLine("");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Cars car = new Cars();

            //car.display();
            car.FilterCar("Dodge");
        }
    }
}
