using System;
using System.Collections.Generic;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcom To The Garage Program designed by : Nadav Shalev & Ben Magriso\nMenu: -Choose one of the folowing options-");
            Console.WriteLine("1.Add a new vechile to the garage.\n2Show all the licence numbers in the garage.");
            Console.WriteLine("3.Change the status of the vechile\n4.Inflate air in the wheels to the maximum");
            Console.WriteLine("5.Add fuel to Gasoline Engine Car.\n6.Charge Electric car write");
            Console.WriteLine("7.Show all the cars details inside the gargae\nYour choise:");
            string chooseMenu = Console.ReadLine();
            //EnterALoop//
            switch (chooseMenu) // need to add Parse to all inputs
            {
                case "1":
                    addVechileToGarage();
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

        private static void addVechileToGarage()
        {
            VechileDetails vechileDetails = new VechileDetails();
            Console.WriteLine("Enter Owner name:");
            vechileDetails.OwnerName = Console.ReadLine();
            Console.WriteLine("Enter Phonenumber of Owner:");
            vechileDetails.PhoneOfOwner = Console.ReadLine();
            Console.WriteLine("Enter Model name:");
            vechileDetails.ModelName = Console.ReadLine();
            Console.WriteLine("Enter Licencenumber of the vechile:");
            vechileDetails.LicenceNumber = Console.ReadLine();
            Console.WriteLine("Enter the wheel manufacture");
            vechileDetails.WheelManufacture = Console.ReadLine();
            Console.WriteLine("Enter Current air pressure of the wheels:");
            vechileDetails.CurrentAirPressure = Console.ReadLine();
            Console.WriteLine("Choose one of the folowing options:");
            Console.WriteLine("1.Car\n2.MotorCycle\n3.Truck\nYour choise:");
            //Insert Loop 
            string chooseMenu = Console.ReadLine();
            switch(chooseMenu)
            {
                case "1":
                    {
                        vechileDetails.TypeOfEngine = getTypeOfEngineFromClient();
                        addNewCarToGarage(vechileDetails);
                        break;
                    }
                case "2":
                    {
                        vechileDetails.TypeOfEngine = getTypeOfEngineFromClient();
                        //MOTORCYCLE
                        break;
                    }
                case "3":
                    {
                        vechileDetails.TypeOfEngine = eTypeOfEngine.Gasoline;
                        //TRUCK
                        break;
                    }
            }
            
        }
        private static eTypeOfEngine getTypeOfEngineFromClient()
        {
 
            eTypeOfEngine typeOfEngine=eTypeOfEngine.Electric;
            Console.WriteLine("Choose one of the folowing engine type options:");
            Console.WriteLine("1.Gasoline\n2.Electric\nYour choise:");
            string chooseMenu = Console.ReadLine();
            //Add while
            switch (chooseMenu)
            {
                case "1":
                    {
                        typeOfEngine = eTypeOfEngine.Gasoline;
                        break;
                    }
                case "2":
                    {
                        break;
                    }
            }
            return typeOfEngine;
        }

        private static void addNewCarToGarage(VechileDetails i_VechileDetails)
        {
            CarDetails carDetails = new CarDetails();
            carDetails.VechileDetails = i_VechileDetails;
            Console.WriteLine("Please Enter Number Of Doors: (2,3,4,5)");
            //Try Prase??
            carDetails.NumberOfDoors = (eDoors)Enum.Parse(typeof(eDoors), Console.ReadLine());
            Console.WriteLine("Please Enter Color Of Car: (Blue,White,Black,Gray)");
            //Try Prase??
            carDetails.ColorOfCar = (eColor)Enum.Parse(typeof(eColor), Console.ReadLine());
            VechileFactory.CreateAndInsertVechile(carDetails);

        }       

        private static void addNewMotorcycleToGarage(VechileDetails i_VechileDetails)
        {
            MotorCycleDetails motorcycleDetails = new MotorCycleDetails();
            motorcycleDetails.VechileDetails = i_VechileDetails;
            Console.WriteLine("Please Enter Engine Capacity:");
            //Try Prase??
            motorcycleDetails.EngineCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Licsene of Motorcycle: (A,A1,B1,B2)");
            //Try Prase??
            motorcycleDetails.LicsenseType = (eLicenseType)Enum.Parse(typeof(eLicenseType), Console.ReadLine());
            VechileFactory.CreateAndInsertVechile(motorcycleDetails);

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