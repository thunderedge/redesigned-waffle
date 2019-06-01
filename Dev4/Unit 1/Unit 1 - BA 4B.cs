using System;
using System.Diagnostics;
using System.Threading;

namespace U1BA4B
{
    class Simple
    {
        public static void Main(string[] args)
        {
            var boreCar = new Car("Boremobile", 1990, 0);
            var mainCar = new Primary("BMW X6", 2015, 20000);
            var weekendCar = new Weekend("Ford mustang", 1965, 160000);
            Car storePrimaryInCarVar = new Primary("Toyota Yaris", 2015, 222);
            Car storeWeekendInCarVar = new Primary("Ferrari 458 Italia Coupe", 2018, 10000);
            string output = "";
            output = boreCar.CarInfo();
            output = boreCar.RoofType();
            output = mainCar.CarInfo();
            output = mainCar.DriveFast();
            output = mainCar.RoofType();
            output = weekendCar.CarInfo();
            output = weekendCar.DriveInStyle();
            output = weekendCar.RoofType();
            output = storePrimaryInCarVar.RoofType();
            output = storeWeekendInCarVar.RoofType();
        }
    }

    class Car
    {
        public string carName;
        public int carYear;
        public int mileage;
        public string carType;

        public Car(string carName, int carYear, int mileage)
        {
            this.carName = carName;
            this.carYear = carYear;
            this.mileage = mileage;
            this.carType = "Boredom";
        }

        public string CarInfo() => "Car type: " + this.carType + ". Build year: " + this.carYear + ". Car name: " + this.carName + "\n" + " I drove it for " + this.mileage + " KM";
        // Add a virtual method named RoofType
        // that does not take in any paramaters
        // and returns the string "unknown"
        //
        // input: none
        // output: string: "unknown"

        public virtual string RoofType()
        {
            return "unknown";
        }
    }

    // Create a class Primary that inherits from Car
    // In the constructor, take in the necessary data for
    // the base class and set carType to "Primary"
    // Add a method DriveFast() that returns the string "Whoop I am fast"
    // Override the RoofType, so that it returns "Sunroofs".

    class Primary : Car
    {
        public Primary(string carName, int carYear, int mileage): base(carName, carYear, mileage)
        {
            this.carName = carName;
            this.carYear = carYear;
            this.mileage = mileage;
            this.carType = "Primary";
        }

        public string DriveFast()
        {
            return "Whoop I am fast";
        }

        public override string RoofType()
        {
            return "Sunroofs";
        }
    }

    // Create a class Weekend that inherits from Car
    // In the constructor, take in the necessary data for
    // the base class and set carType to "Weekend"
    // Add a method DriveInStyle() that returns the string "I am cruising on the highway"
    // Override the RoofType, so that it returns "Convertible".

    class Weekend : Car
    {
        public Weekend(string carName, int carYear, int mileage) : base(carName, carYear, mileage)
        {
            this.carName = carName;
            this.carYear = carYear;
            this.mileage = mileage;
            this.carType = "Weekend";
        }

        public string DriveInStyle()
        {
            return "I am cruising on the highway";
        }

        public override string RoofType()
        {
            return "Convertible";
        }
    }
}
