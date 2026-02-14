namespace Cars
{

    public class Cars
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public byte Cylinder { get; set; }
        public float Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public byte City { get; set; }
        public byte Combined { get; set; }
        public byte Highway { get; set; }


        public static Cars Parsee(string input)
        {
            string[] parts = input.Split(',');

            Cars result = new Cars();
            result.Make = parts[0];

            result.Model = parts[1];

            byte.TryParse(parts[2], out byte cylinder);
            result.Cylinder = cylinder;

            float.TryParse(parts[3], out float engine);
            result.Engine = engine;

            result.Drive = parts[4];

            result.Transmission = parts[5];

            byte.TryParse(parts[6], out byte city);
            result.City = city;

            byte.TryParse(parts[7], out  byte combined);
           result.Combined = combined;

            byte.TryParse(parts[8], out byte highway);
            result.Highway = highway;

           

            return result;

        }

        //public void display()
        //{
        //   string path = "C:\\Users\\user\\source\\repos\\ConsoleApp2\\Cars\\vehicles.csv";

        //    string[] lines = System.IO.File.ReadAllLines(path);

        //    for (int  i = 1;i < lines.Length;i++)
        //    {
        //       var car = Parsee(lines[i]);


        //        if (car.Make == "Mercedes-Benz")
        //        {
        //            Console.WriteLine(
        //              $@"Mercedes-Benz 
        //            Model: {car.Model}
        //            Cylinder: {car.Cylinder}
        //            Engine : {car.Engine}
        //            Drive : {car.Drive}
        //            Transmission : {car.Transmission}
        //            City : {car.City}
        //            Combined : {car.Combined}
        //            Highway : {car.Highway}
        //           -----------------------------------");
        //        }
        //    }
        //}

        //public void FilterCar(string carToFilter)
        //{
        //    string path = "C:\\Users\\user\\source\\repos\\ConsoleApp2\\Cars\\vehicles.csv";

        //    string[] lines = System.IO.File.ReadAllLines(path);

        //    for (int i = 1; i < lines.Length; i++)
        //    {
        //        var car = Parsee(lines[i]);


        //        if (car.Make == carToFilter)
        //        {
        //            Console.WriteLine(
        //              $@"{carToFilter} 
        //            Model: {car.Model}
        //            Cylinder: {car.Cylinder}
        //            Engine : {car.Engine}
        //            Drive : {car.Drive}
        //            Transmission : {car.Transmission}
        //            City : {car.City}
        //            Combined : {car.Combined}
        //            Highway : {car.Highway}
        //           -----------------------------------");
        //        }
        //        else
        //        {
        //            Console.WriteLine("");
        //        }
        //    }
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars();

            //car.display();
            //car.FilterCar("Dodge");

            string[] path = File.ReadAllLines("C:\\Users\\user\\source\\repos\\ConsoleApp2\\Cars\\vehicles.csv");

            var cars = Transfrom(path);

            var sortedCars = SortByDescending(cars);
            //var filtered = filterCarsByName(sortedCars);

            //var top10 = GetTop10EconomicCars(sortedCars);
            //var filtered = filterCarsByName(sortedCars);


            foreach (var item in sortedCars)
            {
                Console.WriteLine(
                         $@"{item.Make} 
                            Model: {item.Model}
                            Cylinder: {item.Cylinder}
                            Engine : {item.Engine}
                            Drive : {item.Drive}
                            Transmission : {item.Transmission}
                            City : {item.City}
                            Combined : {item.Combined}
                            Highway : {item.Highway}
                           -----------------------------------");
            }

        }

        static List<Cars> GetTop10EconomicCars(List<Cars> allSortedCars)
        {
            List<Cars> result = new();

            for (int i = 0; i < 10; i++)
            {
                result.Add(allSortedCars[i]);
            }

            return result;
        }


        static List<Cars> SortByDescending(List<Cars> cars) {
            for (int i = 0; i < cars.Count - 1; i++)
            {
                for (int j = i + 1; j < cars.Count; j++) {
                    if (cars[j].Combined > cars[i].Combined)
                    {
                        var temp = cars[j];
                        cars[j] = cars[i];
                        cars[i] = temp;
                    }
                }
            }
            return cars;
        }

        static List<Cars> filterCarsByName(List<Cars> allCars)
        {
            List<Cars> filteredCar = new List<Cars>();

            for (int i = 0; i < allCars.Count; i++)
            {
                if (allCars[i].Make.ToLower().Trim().Contains("dodge"))
                {
                    filteredCar.Add(allCars[i]);
                }
            }
            return filteredCar;
        }


        static List<Cars> Transfrom(string[] rawData)
        {
            List<Cars> cars = new List<Cars>();
            for (int i = 1; i < rawData.Length; i++) {
                cars.Add(Cars.Parsee(rawData[i]));
            }
            return cars;
        }

        //static List<Cars> GetTop10Fastest(List<Cars> cars)
        //{
        //    List<Cars> fastestCars = new List<Cars>();

        //    for (int i = 0; i < cars.Count; i++)
        //    {

        //    }


        //}
    }
}
