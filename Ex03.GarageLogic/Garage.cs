using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Garage
    {

        private static Garage instance;

        public static Garage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Garage();
                }
                return instance;
            }
        }
        private readonly List<GarageVechile> m_GarageVechiles;

        private Garage()
        {
            m_GarageVechiles = new List<GarageVechile>();
        }

        private GarageVechile getVechileByLicenceNumber(string i_LicenceNumber)
        {
            GarageVechile garageVechileToReturn = null;
            foreach (GarageVechile currentVechile in m_GarageVechiles)
            {
                if (currentVechile.OwnerVechile.LicenseNumber == i_LicenceNumber)
                {
                    garageVechileToReturn = currentVechile;
                }
            }
            return garageVechileToReturn;
        }

        public bool AddVechileToGarage(Vechile i_VechileToAdd, string i_OwnerName, string i_PhoneOfOwner)
        {
            bool isAddedToTheGarage = false;
            GarageVechile vechileToTheGarage = new GarageVechile();
            vechileToTheGarage = getVechileByLicenceNumber(i_VechileToAdd.LicenseNumber);
            if (vechileToTheGarage != null)
            {
                vechileToTheGarage.CurrentVechileStatus = eVechileStatus.Repair;
            }
            else
            {
                vechileToTheGarage.OwnerVechile = i_VechileToAdd;
                vechileToTheGarage.OwnerName = i_OwnerName;
                vechileToTheGarage.PhoneOfOwner = i_PhoneOfOwner;
                vechileToTheGarage.CurrentVechileStatus = eVechileStatus.Repair;
                m_GarageVechiles.Add(vechileToTheGarage);
                isAddedToTheGarage = true;
            }
            return isAddedToTheGarage;         
        }

        public List<string> showVechilesInGarage(eVechileStatus? i_statusToFilterVechiles)
        {
            List<string> vechilesLicenceNumbers = new List<string>();
            foreach (GarageVechile garageVechile in m_GarageVechiles)
            {
                if (i_statusToFilterVechiles == null)
                {
                    vechilesLicenceNumbers.Add(garageVechile.ownerVechile.LicenseNumber);
                }

                if (garageVechile.currentVechileStatus == i_statusToFilterVechiles)
                {
                    vechilesLicenceNumbers.Add(garageVechile.ownerVechile.LicenseNumber);
                }
            }
            return vechilesLicenceNumbers;
        }
        public void changeStatusOfVechile(string i_LicenceNumber, eVechileStatus i_NewStatus)
        {
            GarageVechile garageVechileInList = new GarageVechile();
            garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                garageVechileInList.currentVechileStatus = i_NewStatus;
            }
        }
        public void inflateAirInTheWheels(Vechile i_VechileToAddPressure)
        {
            float currentAirPressure, maxAirPressure, missingAirPressure;
            GarageVechile garageVechileInList = new GarageVechile();
            garageVechileInList = getVechileByLicenceNumber(i_VechileToAddPressure.LicenseNumber);
            if (garageVechileInList != null)
            {
                currentAirPressure = i_VechileToAddPressure.CurrentAirPressureOfWheels;
                maxAirPressure = i_VechileToAddPressure.MaxAirPressureOfWheels;
                missingAirPressure = maxAirPressure - currentAirPressure;
                i_VechileToAddPressure.WheelInflating(missingAirPressure);
            }


        }
        public void putInFuelInGasolineEngine(string i_LicenceNumber, eTypeOfFuel i_TypeOfFuelToAdd, float i_AmountOfFuelToAdd)
        {
            GarageVechile garageVechileInList = new GarageVechile();
            garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                garageVechileInList.ownerVechile.EngineOfVechile.FillInTheContainer(i_AmountOfFuelToAdd); // check it!!!!!!!!!
            }
        }
        public void chargeElectricEngine(string i_LicenceNumber, float i_AmountOfMinToAdd)
        {
            GarageVechile garageVechileInList = new GarageVechile();
            garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                garageVechileInList.ownerVechile.EngineOfVechile.FillInTheContainer(i_AmountOfMinToAdd);  // check it!!!!!!!!!
            }
        }
        public string getCarDetails(string i_LicenceNumber)
        {
            string carDetails = null;
            GarageVechile garageVechileInList = new GarageVechile();
            garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                carDetails = string.Format("The Licence number is {0}, The Model Name is {1}, The Owner Name is {2}\n The type in the garage is {3}, The Wheel Pressure is {4}");
            }


            return carDetails;
        }
    }

}