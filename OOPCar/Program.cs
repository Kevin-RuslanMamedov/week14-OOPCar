using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odo;
            int fuelTank;

            public Car(string _mark, string _model, string _regNumber, string _color)
            {
                mark = _mark;
                model = _model;
                regNumber = _regNumber;
                color = _color;
                odo = 0;
                fuelTank = 60;
                Console.WriteLine($"{color} {mark} {model} {regNumber} has been created.");
            }
            public string Model
            {
                get { return model; }
            }
            public string Mark
            {
                get { return mark; }
            }
            public string RegNumber
            {
                get { return regNumber; }
            }
            public string Color
            {
                get { return color; }
            }
            public int Odo
            {
                get { return odo; }
            }
            public int FuelTank
            {
                get { return fuelTank; }
            }
            public void Drive()
            {
                fuelTank -= 5;
                odo += 100;
                Console.WriteLine("Vroom-vroom");
            }
            public void ShowCarInfo()
            {
                Console.WriteLine($"Mark: {mark}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"RegNumber: {regNumber}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Odo: {odo}");
                Console.WriteLine($"Fuel: {fuelTank}");

            }

        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Lada", "Niva", "6969BT", "Pink");

            while(myCar.FuelTank > 0)
            {
                myCar.Drive();
            }
            myCar.ShowCarInfo();
        }
    }
}
