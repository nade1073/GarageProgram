using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Choose what you want to do: \nAdd a new vechile to the garage write '1'\nShow all the licence numbers in the garage write '2'");
            Console.WriteLine("Add a new vechile to the garage write '3'\nShow all the licence numbers in the garage write '4'");
            Console.WriteLine("Change the status of the vechile write '5'\n Inflate air in the wheels to the maximum write '6'");
            Console.WriteLine("Add fuel to Gasoline Engine Car write '7'\nCharge Electric car write '8'");
            Console.WriteLine("Show all the car details '9'\n");
            string chooseMenu = Console.ReadLine();
            switch (chooseMenu)
            {
                case "1":
                    addNewCarToGarage();
                    break;
                case "2":
                    showAllLicenceNumbers();
                    break;
                case "3":


                    break;
                case "4":


                    break;
                case "5":


                    break;
                case "6":


                    break;
                case "7":


                    break;
                case "8":


                    break;
                case "9":


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
    }
}