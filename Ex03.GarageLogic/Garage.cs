
using System.Collections.Generic;
namespace Ex03.GarageLogic
{
    public class Garage
    {
        private List<GarageVechile> m_GarageVechiles;

        private GarageVechile getVechileByLicenceNumber(string i_LicenceNumber)
        {
            GarageVechile garageVechileToReturn = null;
            foreach (GarageVechile garageVechile in m_GarageVechiles)
            {
                if (garageVechile.ownerVechile.LicenseNumber == i_LicenceNumber)
                {
                    garageVechileToReturn = garageVechile;
                }
            }
            return garageVechileToReturn;
        }
        public string addVechileToGarage(Vechile i_VechileToAdd, string i_OwnerName, string i_PhoneOfOwner)
        {
            string message = null;
            GarageVechile newGarageVechileToAdd = new GarageVechile();
            GarageVechile garageVechileInList = new GarageVechile();
            garageVechileInList = getVechileByLicenceNumber(i_VechileToAdd.LicenseNumber);
            if (garageVechileInList != null)
            {
                message = "The Vechile is already in the garage";
                garageVechileInList.currentVechileStatus = eVechileStatus.Repair;
            }
            else
            {
                newGarageVechileToAdd.ownerVechile = i_VechileToAdd;
                newGarageVechileToAdd.ownerName = i_OwnerName;
                newGarageVechileToAdd.phoneOfOwner = i_PhoneOfOwner;
                newGarageVechileToAdd.currentVechileStatus = eVechileStatus.Repair;
                m_GarageVechiles.Add(newGarageVechileToAdd);
                message = "The Vechile added to the garage";
            }

            return message;
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
                currentAirPressure = i_VechileToAddPressure.Wheels.CurrentAirPressure;
                maxAirPressure = i_VechileToAddPressure.Wheels.MaxAirPressure;
                missingAirPressure = maxAirPressure - currentAirPressure;
                i_VechileToAddPressure.Wheels.WheelInflating(missingAirPressure);
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