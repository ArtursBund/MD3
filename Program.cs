using System;

namespace MD_3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Uzd 1
            var phone = new Phone();            
            phone.Size = 5.1;
            phone.Brand = "Iphone";
            phone.Model = "5S";
            phone.Call();
            phone.SMS();

            // Uzd 2
            var NewCar = new Car();
            NewCar.Brand = "Opel";
            NewCar.NumberPlate = "FV-2356";
            NewCar.StartDriving(60);
            Console.WriteLine(NewCar.Speed);
            NewCar.IncreaseSpeed(40);
            Console.WriteLine(NewCar.Speed);
            NewCar.DecreaseSpeed(60);
            Console.WriteLine(NewCar.Speed);
            NewCar.StopDriving();
            Console.WriteLine(NewCar.Speed);
            NewCar.Signal();

            // Uzd 3
            var Milk = new Product(60,10,1);
            Console.WriteLine("Product parameters: Height: {0}, Width: {1}, Weight: {2}", Milk.Height, Milk.Width, Milk.Weight);

            // Uzd 4
            var Worker = new Person("Janis", "Ozols", "15.09.1980", "Road trips", "Male");
            
        }

    }
}
