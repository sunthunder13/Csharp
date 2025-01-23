using cmd;

namespace Santander_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Data data = new Data();
            List<car_specs> car_list = data.GetcarList();
            foreach (car_specs car in car_list)
            {
                Console.WriteLine($"Car Brand: {car.carBrand} - {car.carYearModel}");
            }
            Console.WriteLine("");
            Console.WriteLine("======================================================");

            //Filter
            List<car_specs> caryear = car_list.Where(x => x.carYearModel == 2000).ToList();

            Console.WriteLine("");
            Console.WriteLine($"The Count Toyota is {caryear.Count}");
            Console.WriteLine("");
            Console.WriteLine("======================================================");
            
            //Order by
            List<car_specs> orderCars = car_list.OrderBy(x => x.carYearModel).ToList();
            Console.WriteLine("");
            foreach (var car in orderCars)
            {
                Console.WriteLine($"Car Brand: {car.carBrand} - Year Model: {car.carYearModel}");
            }
            Console.WriteLine("");
            Console.WriteLine("======================================================");

            //Group
            var groupCars = orderCars.GroupBy(x => x.carYearModel);

            Console.WriteLine("");
            foreach (var car in groupCars)
            {
                Console.WriteLine($"Car Year Model: {car.Key}");
            }
            Console.WriteLine("");
            Console.WriteLine("======================================================");

            //firstOrDefault
            var lastestcar = car_list.OrderByDescending(x => x.carYearModel).FirstOrDefault();

            Console.WriteLine("");
            Console.WriteLine("Latest Car");
            Console.WriteLine($"Car Brand: {lastestcar.carBrand} - {lastestcar.carYearModel}");
            Console.WriteLine("");
            Console.WriteLine("======================================================");
            
            var oldestcar = car_list.OrderBy(x => x.carYearModel).FirstOrDefault();

            Console.WriteLine("");
            Console.WriteLine("Oldest Car");
            Console.WriteLine($"Car Brand: {oldestcar.carBrand} - {oldestcar.carYearModel}");
            Console.WriteLine("");
            Console.WriteLine("======================================================");


























            //List<car_specs> carList = new List<car_specs>();
            //car_specs car1 = new car_specs();
            //car1.carBrand = "Honda";
            //car1.carYearModel = 1995;

            //car_specs car2 = new car_specs();
            //car2.carBrand = "Toyota";
            //car2.carYearModel = 2000;

            //car_specs car3 = new car_specs();
            //car3.carBrand = "Ford";
            //car3.carYearModel = 1997;

            //car_specs car4 = new car_specs()
            //{
            //    carBrand = "Mazda",
            //    carYearModel = 2005
            //};

            //car_specs car5 = new car_specs()
            //{
            //    carBrand = "Hyundai",
            //    carYearModel = 1998
            //};

            //carList.Add(car1);
            //carList.Add(car2);
            //carList.Add(car3);
            //carList.Add(car4);
            //carList.Add(car5);

            //foreach (car_specs car in carList)
            //{
            //    Console.WriteLine($"Motor Brand: {car.carBrand} \nMotor CC: {car.carYearModel}");
            //    Console.WriteLine(" ");
            //}


        }
    }
}
