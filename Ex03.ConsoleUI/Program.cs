namespace Ex03.ConsoleUI
{
    using System;
    using System.Collections.Generic;
    using Ex03.GarageLogic;

    public class Program
    {
        public static void Main()
        {
            eContinueOrExit continueProgram = eContinueOrExit.Continue;
            while (continueProgram.Equals(eContinueOrExit.Continue))
            {
                Console.WriteLine("Wellcom To The Garage Program designed by : Nadav Shalev & Ben Magriso\nMenu: -Choose one of the folowing options-");
                Console.WriteLine("1.Add a new vechile to the garage.\n2.Show all the licence numbers in the garage.");
                Console.WriteLine("3.Change the status of the vechile\n4.Inflate air in the wheels to the maximum");
                Console.WriteLine("5.Add fuel to Gasoline Engine Car.\n6.Charge Electric car write");
                Console.WriteLine("7.Show all the cars details inside the gargae\nYour choise:");
                string chooseMenu = Console.ReadLine();
                try
                {
                    switch (chooseMenu)
                    {
                        case "1":
                            try
                            {
                                if (addVechileToGarage())
                                {
                                    Console.WriteLine("Succsses to a add a new car to the garage");
                                }
                                else
                                {
                                    Console.WriteLine("Change Status repeair of the car");
                                }
                            }
                            catch (ValueOutOfRangeException i_Exception)
                            {
                                Console.WriteLine(i_Exception.Message);
                            }

                            break;
                        case "2":
                            {
                                showAllLicenceNumbers();
                                break;
                            }

                        case "3":
                            { 
                                if (changeStatusOfVechileInGarage())
                                {
                                    Console.WriteLine("Succsses to a change status");
                                }
                                else
                                {
                                    Console.WriteLine("Not found vechie");
                                }

                                break;
                            }

                        case "4":
                            {
                                try
                                {
                                    if (inflateAirInTheWheelsToMaximum())
                                    {
                                        Console.WriteLine("Succsses to a add Air in The Wheels");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not found vechie to add a air");
                                    }
                                }
                                catch (ValueOutOfRangeException exception)
                                {
                                    Console.WriteLine(exception.Message);
                                }

                                break;
                            }

                        case "5":
                            {
                                try
                                {
                                    if (addGasolineFuelToCar())
                                    {
                                        Console.WriteLine("Succsses to a add Fuel to the Vechile");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not found vechie to add a fuel");
                                    }
                                }
                                catch (ValueOutOfRangeException i_Exception)
                                {
                                    Console.WriteLine(i_Exception.Message);
                                }

                                break;
                            }

                        case "6":
                            {
                                try
                                {
                                    if (chargeElectricCar())
                                    {
                                        Console.WriteLine("Succsses to charge to electric Container");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not found vechie to charge");
                                    }
                                }
                                catch (ValueOutOfRangeException i_Exception)
                                {
                                    Console.WriteLine(i_Exception.Message);
                                }
                            }

                            break;
                        case "7":
                            {
                                printAllCarDetails();
                                break;
                            }

                        default:
                            Console.WriteLine("Wrong Input Entered");
                            break;
                    }
                }
                catch (ArgumentException i_Exception)
                {
                    Console.WriteLine(i_Exception.Message);
                }

                Console.WriteLine("Please Enter 'Continue' if you want to continue or 'Exit' if you want to Exit");
                bool isValidInput = false;
                while (!isValidInput)
                {
                    try
                    {
                        continueProgram = (eContinueOrExit)Enum.Parse(typeof(eContinueOrExit), Console.ReadLine());
                        isValidInput = true;
                    }
                    catch (ArgumentException i_Exception)
                    {
                        Console.WriteLine(i_Exception.Message);
                    }
                }
            }
       }
        
        private static bool addVechileToGarage()
        {
                bool isAdded = false;
                bool correctInputEntered = false;
                VechileDetails vechileDetails = new VechileDetails();
                Console.WriteLine("Enter Owner name:");
                vechileDetails.OwnerName = Console.ReadLine();
                Console.WriteLine("Enter Phonenumber of Owner:");
                vechileDetails.PhoneOfOwner = Console.ReadLine();
                Console.WriteLine("Enter Model name:");
                vechileDetails.ModelName = Console.ReadLine();
                vechileDetails.LicenceNumber = getLicsenceNumberFromClient();
                Console.WriteLine("Enter the wheel manufacture");
                vechileDetails.WheelManufacture = Console.ReadLine();
                Console.WriteLine("Choose one of the folowing options:");
                Console.WriteLine("1.Car\n2.MotorCycle\n3.Truck\nYour choise:");
            string chooseMenu = Console.ReadLine();
            do
            {
                correctInputEntered = false;
                switch (chooseMenu)
                {
                    case "1":
                        {
                            vechileDetails.TypeOfCar = eTypeOfCar.Car;
                            vechileDetails.TypeOfEngine = getTypeOfEngineFromClient();
                            vechileDetails.Amount = getAmountFromClient();
                            vechileDetails.CurrentAirPressure = getAirPressureFromClient();
                            isAdded = addNewCarToGarage(vechileDetails);
                            break;
                        }

                    case "2":
                        {
                            vechileDetails.TypeOfCar = eTypeOfCar.Motorcycle;
                            vechileDetails.TypeOfEngine = getTypeOfEngineFromClient();
                            vechileDetails.Amount = getAmountFromClient();
                            vechileDetails.CurrentAirPressure = getAirPressureFromClient();
                            isAdded = addNewMotorcycleToGarage(vechileDetails);
                            break;
                        }

                    case "3":
                        {
                            vechileDetails.TypeOfCar = eTypeOfCar.Truck;
                            vechileDetails.TypeOfEngine = eTypeOfEngine.Gasoline;
                            vechileDetails.CurrentAirPressure = getAirPressureFromClient();
                            isAdded = addNewTruckToGarage(vechileDetails);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Wrong Input Entered, Please Try Again");
                            chooseMenu = Console.ReadLine();
                            correctInputEntered = true;
                            break;
                        }
                }
            }
            while (correctInputEntered);
            return isAdded; 
        }

        private static float getAirPressureFromClient()
        {
           Console.WriteLine("Enter Current air pressure of the wheels:");
           return float.Parse(Console.ReadLine());
        }

        private static float getAmountFromClient()
        {
            Console.WriteLine("Enter The Amount of the Container of the engine:");
            return float.Parse(Console.ReadLine());
        }

        private static eTypeOfEngine getTypeOfEngineFromClient()
        {
            bool correctInputEntered = false;
            eTypeOfEngine typeOfEngine = eTypeOfEngine.Electric;
            Console.WriteLine("Choose one of the folowing engine type options:");
            Console.WriteLine("1.Gasoline\n2.Electric\nYour choise:");
            string chooseMenu = Console.ReadLine();
            do
            {
                correctInputEntered = false;
                switch (chooseMenu)
                {
                    case "1":
                        {
                            correctInputEntered = false;
                            typeOfEngine = eTypeOfEngine.Gasoline;
                            break;
                        }

                    case "2":
                        {
                            correctInputEntered = false;
                            typeOfEngine = eTypeOfEngine.Electric;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Wrong Input Entered, Please Try Again");
                            chooseMenu = Console.ReadLine();
                            correctInputEntered = true;
                            break;
                        }
                }
            }
            while (correctInputEntered);
            return typeOfEngine;
        }

        private static bool addNewCarToGarage(VechileDetails i_VechileDetails)
        {
            CarDetails carDetails = new CarDetails();
            carDetails.VechileDetails = i_VechileDetails;
            CarProperties carProperties = new CarProperties();
            Console.WriteLine("Please Enter Number Of Doors: (2,3,4,5)");
            carProperties.NumberOfDoors = (eDoors)Enum.Parse(typeof(eDoors), Console.ReadLine());
            Console.WriteLine("Please Enter Color Of Car: (Blue,White,Black,Gray)");
            carProperties.ColorOfTheCar = (eColor)Enum.Parse(typeof(eColor), Console.ReadLine());
            carDetails.CarProperties = carProperties;
            return VechileFactory.CreateAndInsertVechile(carDetails);
        }       

        private static bool addNewMotorcycleToGarage(VechileDetails i_VechileDetails)
        {
            MotorCycleDetails motorcycleDetails = new MotorCycleDetails();
            MotorcycleProperties motorcycleProperties = new MotorcycleProperties();
            motorcycleDetails.VechileDetails = i_VechileDetails;
            Console.WriteLine("Please Enter Engine Capacity:");
            motorcycleProperties.EngineCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Licsene of Motorcycle: (A,A1,B1,B2)");
            motorcycleProperties.LicsenseType = (eLicenseType)Enum.Parse(typeof(eLicenseType), Console.ReadLine());
            motorcycleDetails.MotorcycleProperties = motorcycleProperties;
            return VechileFactory.CreateAndInsertVechile(motorcycleDetails);
        } 

        private static bool addNewTruckToGarage(VechileDetails i_VechileDetails)
        {
            TruckDetails truckDetails = new TruckDetails();
            TruckProperties truckProperties = new TruckProperties();
            truckDetails.VechileDetails = i_VechileDetails;
            Console.WriteLine("Please Enter The Cargo Capacity:");
            truckProperties.CargoCapacity = float.Parse(Console.ReadLine());
            Console.WriteLine("Please eneter if the Trunk of the truck is cooled: (True,False)");
            truckProperties.IsTheTrunkCooled = bool.Parse(Console.ReadLine());
            truckDetails.TruckProperties = truckProperties;
            return VechileFactory.CreateAndInsertVechile(truckDetails);
        }

        private static void showAllLicenceNumbers()
        {
            bool correctInputEntered = false;
            List<string> vechilesLicenceNumbers = new List<string>();
            eVechileStatus? statusToFilterVechiles = null;
            string outputStatusFilter;
            Console.WriteLine("Filter With status of: Enter '0' to Repair,Enter '1' to Fixed,Enter '2' to Paid,Enter '3' to not filter with anything\n");
            outputStatusFilter = Console.ReadLine();
            do
            {
                correctInputEntered = false;
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
                    default:
                        {
                            Console.WriteLine("Wrong Input Entered, Please Try Again");
                            outputStatusFilter = Console.ReadLine();
                            correctInputEntered = true;
                            break;
                        }    
                }
            }
            while (correctInputEntered);
            vechilesLicenceNumbers = Garage.Instance.ShowVechilesLicenceNumbersInGarage(statusToFilterVechiles);
            printList(vechilesLicenceNumbers);
        }

        private static void printList(List<string> i_ListToPrint)
        {
            int i = 0;
            foreach (string currentItem in i_ListToPrint)
            {
                i++;
                Console.WriteLine(string.Format("{0}.{1}", i, currentItem));
            }
        }

        private static bool changeStatusOfVechileInGarage()
        {    
            VechileDetails vechileDetails = new VechileDetails();
            vechileDetails.LicenceNumber = getLicsenceNumberFromClient(); 
            Console.WriteLine("Please Enter The status of the car: (Repair,Fixed,Paid)");
            vechileDetails.VechileStatus = (eVechileStatus)Enum.Parse(typeof(eVechileStatus), Console.ReadLine());
            return Garage.Instance.ChangeStatusOfVechile(vechileDetails);
        }
                                  
        private static bool inflateAirInTheWheelsToMaximum()
        {
            VechileDetails vechileDetails = new VechileDetails();
            vechileDetails.LicenceNumber = getLicsenceNumberFromClient();  
            return Garage.Instance.InflateAirInTheWheels(vechileDetails);  
        }
                                  
        private static bool addGasolineFuelToCar()
        {
            VechileDetails vechileDetails = new VechileDetails();
            vechileDetails.LicenceNumber = getLicsenceNumberFromClient();
            Console.WriteLine("Please Enter the Type Of Fuel : (Ocatn95,Ocatn96,Ocatn98,Soler2)");
            vechileDetails.TypeOfFuel = (eTypeOfFuel)Enum.Parse(typeof(eTypeOfFuel), Console.ReadLine());
            Console.WriteLine("Please Enter the amount of fuel to add\n");
            vechileDetails.Amount = float.Parse(Console.ReadLine());
            return Garage.Instance.AddFuelToGasolineEngine(vechileDetails);      
        }

        private static bool chargeElectricCar()
        {
            VechileDetails vechileDetails = new VechileDetails();
            vechileDetails.LicenceNumber = getLicsenceNumberFromClient();  
            Console.WriteLine("Please Enter the amount of battery to add\n");
            vechileDetails.Amount = float.Parse(Console.ReadLine());
            return Garage.Instance.ChargeElectricEngine(vechileDetails);
        }

        private static void printAllCarDetails()
        { 
            VechileDetails vechileDetails = new VechileDetails();
            vechileDetails.LicenceNumber = getLicsenceNumberFromClient();
            string message = Garage.Instance.GetCarDetails(vechileDetails);
            Console.WriteLine(message);
        }

        private static String getLicsenceNumberFromClient()
        {
            Console.WriteLine("Enter the licence number of the vechile");
            return Console.ReadLine();            
        }
    }
}