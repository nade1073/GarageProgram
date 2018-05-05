using System;
using System.Collections.Generic;

namespace Ex03.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Choose what you want to do: \nAdd a new vechile to the garage write '1'\nShow all the licence numbers in the garage write '2'");
            Console.WriteLine("Change the status of the vechile write '3'\n Inflate air in the wheels to the maximum write '4'");
            Console.WriteLine("Add fuel to Gasoline Engine Car write '5'\nCharge Electric car write '6");
            Console.WriteLine("Show all the car details '7'\n");
            string chooseMenu = Console.ReadLine();
            switch (chooseMenu) // need to add Parse to all inputs
            {
                case "1":
                    addNewCarToGarage();
                    break;
                case "2":
                    showAllLicenceNumbers();
                    break;
                case "3":
                    ChangeStatusOfVechileInGarage(); //need to complete function
                    break;
                case "4":
                    InflateAirInTheWheelsToMaximum();
                    break;
                case "5":
                    addGasolineFuelToCar();
                    break;
                case "6":
                    chargeElectricCar();
                    break;
                case "7":
                    printAllCarDetails();
                    break;
            }

        }


        private static void addNewCarToGarage()
        {
            string fuelOrElectricAmount, wheelManufacture, currentAirPressure, modelName, licenceNumber, carType;
            eTypeOfEngine engineType;
            Console.WriteLine("Please Enter Current Amount of Fuel/Electric\n");
            fuelOrElectricAmount = Console.ReadLine();
            Console.WriteLine("Please Enter the wheel manufacturer\n");
            wheelManufacture = Console.ReadLine();
            Console.WriteLine("Please Enter Current Air Pressure\n");
            currentAirPressure = Console.ReadLine();
            Console.WriteLine("Please Enter the model name\n");
            modelName = Console.ReadLine();
            Console.WriteLine("Please Enter the Licence Number\n");
            licenceNumber = Console.ReadLine();
            Console.WriteLine("please enter `0` if you gasoling car, please enter `1` if you enter  electric car, `2` for MotorCycle, `3` for truck");
            carType = Console.ReadLine();
            switch (carType)
            {
                case "0":
                    engineType = eTypeOfEngine.Gasoline;
                    createNewCar(engineType, fuelOrElectricAmount, wheelManufacture, currentAirPressure, modelName, licenceNumber);
                    break;
                case "1":
                    engineType = eTypeOfEngine.Electric;
                    createNewCar(engineType, fuelOrElectricAmount, wheelManufacture, currentAirPressure, modelName, licenceNumber);
                    break;
                case "2":
                    createNewMotorcycle(fuelOrElectricAmount, wheelManufacture, currentAirPressure, modelName, licenceNumber);
                    break;
                case "3":
                    createNewTruck(fuelOrElectricAmount, wheelManufacture, currentAirPressure, modelName, licenceNumber);
                    break;
            }

        }       
        private static void createNewCar(eTypeOfEngine i_TypeOfEngine,string i_fuelOrElectricAmount,string i_WheelManufacture,string i_CurrentAirPressure,string i_ModelName,string i_LicenceNumber)
        {
            string carColor, numberOfWheels;
            Console.WriteLine("Enter the car color");
            carColor = Console.ReadLine();
            Console.WriteLine("Enter the number of wheels");
            numberOfWheels = Console.ReadLine();
            factoryvechile.addCar(i_fuelOrElectricAmount, i_WheelManufacture, i_CurrentAirPressure, i_ModelName, i_LicenceNumber, carColor, numberOfWheels, i_TypeOfEngine);
        }
        private static void createNewMotorcycle(string i_fuelOrElectricAmount, string i_WheelManufacture, string i_CurrentAirPressure, string i_ModelName, string i_LicenceNumber)
        {
            string engineCapacity, motorcylcleLicence;
            Console.WriteLine("Enter the engine capacity");
            engineCapacity = Console.ReadLine();
            Console.WriteLine("Enter the motorcycle licence");
            motorcylcleLicence = Console.ReadLine();
            factoryvechile.addMotorcycle(i_fuelOrElectricAmount, i_WheelManufacture, i_CurrentAirPressure, i_ModelName, i_LicenceNumber, engineCapacity, motorcylcleLicence);
        }
        private static void createNewTruck(string i_fuelOrElectricAmount, string i_WheelManufacture, string i_CurrentAirPressure, string i_ModelName, string i_LicenceNumber)
        {
            string truckCharge, isCooledInput;
            bool isCooled = false;
            Console.WriteLine("Enter the truck charge");
            truckCharge = Console.ReadLine();
            Console.WriteLine("Enter if is cooled '1'");
            isCooledInput = Console.ReadLine();
            if (isCooledInput == "1")
            {
                isCooled = true;
            }
            factoryvechile.addTruck(i_fuelOrElectricAmount, i_WheelManufacture, i_CurrentAirPressure, i_ModelName, i_LicenceNumber, truckCharge, isCooled);
        }
        private static void showAllLicenceNumbers()
        {
            List<string> vechilesLicenceNumbers = new List<string>();
            eVechileStatus? statusToFilterVechiles = null;
            string outputStatusFilter;
            Console.WriteLine("Filter With status of: Enter '0' to Repair,Enter '1' to Fixed,Enter '2' to Paid,Enter '3' to not filter with anything\n");
            outputStatusFilter = Console.ReadLine();
            switch (outputStatusFilter)
            {
                case "0":
                    statusToFilterVechiles = eVechileStatus.Repair;
                    break;
                case "1":
                    statusToFilterVechiles = eVechileStatus.Fixed;
                    break;
                case "2":
                    statusToFilterVechiles = eVechileStatus.Paid;
                    break;
                case "3":
                    break;
            }
            vechilesLicenceNumbers = Garage.showVechilesInGarage(statusToFilterVechiles);
            printList(vechilesLicenceNumbers);
        }
        private static void printList(List<string> i_ListToPrint)
        {
            foreach (string item in i_ListToPrint)
            {
                Console.WriteLine("{0}\n",item);
            }
        }
        private static void ChangeStatusOfVechileInGarage()
        {
            string licenceNumber,outputStatus;
            eVechileStatus statusToFilterVechiles;
            Console.WriteLine("Enter the licence number of the vechile");
            licenceNumber = Console.ReadLine();
            Console.WriteLine("Enter the status");
            outputStatus = Console.ReadLine();

            Garage.ChangeStatusOfVechile(licenceNumber, statusToFilterVechiles);
        }
        private static void InflateAirInTheWheelsToMaximum()
        {
            string licenceNumber, outputStatus;
            eVechileStatus statusToFilterVechiles;
            Console.WriteLine("Enter the licence number of the vechile");
            licenceNumber = Console.ReadLine();
            Garage.InflateAirInTheWheels(licenceNumber, statusToFilterVechiles);
        }
        private static void addGasolineFuelToCar()
        {
            eTypeOfFuel typeOfFuelToAdd;
            string amountOfFuelToAdd, licenceNumber;
            Console.WriteLine("Enter the licence number of the vechile");
            licenceNumber = Console.ReadLine();
            Console.WriteLine("Please Enter the type of fuel to add\n");
            typeOfFuelToAdd = Console.ReadLine();
            Console.WriteLine("Please Enter the amount of fuel to add\n");
            amountOfFuelToAdd = (Console.ReadLine());
            Garage.AddFuelToGasolineEngine(licenceNumber, typeOfFuelToAdd, amountOfFuelToAdd);
        }
        private static void chargeElectricCar()
        {
            string amountOfBattery, licenceNumber;
            Console.WriteLine("Enter the licence number of the vechile");
            licenceNumber = Console.ReadLine();
            Console.WriteLine("Please Enter the amount of battery to add\n");
            amountOfBattery = Console.ReadLine();
            Garage.ChargeElectricEngine(licenceNumber, amountOfBattery);
        }
        private static void printAllCarDetails()
        {
            string  licenceNumber;
            Console.WriteLine("Enter the licence number of the vechile");
            licenceNumber = Console.ReadLine();
            Garage.GetCarDetails(licenceNumber);
        }
    }
}