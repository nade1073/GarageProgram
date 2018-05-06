using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private static Garage m_Instance;

        public static Garage Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new Garage();
                }
                return m_Instance;
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

        public bool AddVechileToGarage(GarageVechile i_VechileToAddToGarage)
        {
            bool isAddedToTheGarage = false;
            GarageVechile vechileToTheGarage = getVechileByLicenceNumber(i_VechileToAddToGarage.OwnerVechile.LicenseNumber);
            if (vechileToTheGarage != null)
            {
                vechileToTheGarage.CurrentVechileStatus = eVechileStatus.Repair;
            }
            else
            {
                m_GarageVechiles.Add(i_VechileToAddToGarage);
                isAddedToTheGarage = true;
            }
            return isAddedToTheGarage;         
        }

        public List<string> ShowVechilesLicenceNumbersInGarage(eVechileStatus? i_StatusToFilterVechiles)
        {
            List<string> vechilesLicenceNumbers = new List<string>();
            foreach (GarageVechile currentVechile in m_GarageVechiles)
            {
                if (i_StatusToFilterVechiles == null)
                {
                    vechilesLicenceNumbers.Add(currentVechile.OwnerVechile.LicenseNumber.ToString());
                }

                else if (currentVechile.CurrentVechileStatus == i_StatusToFilterVechiles)
                {
                    vechilesLicenceNumbers.Add(currentVechile.OwnerVechile.LicenseNumber.ToString());
                }
            }
            return vechilesLicenceNumbers;
        }

        public bool ChangeStatusOfVechile(VechileDetails i_VechileDetails)
        {
            bool isChanged = false;
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_VechileDetails.LicenceNumber);
            if (garageVechileInList != null)
            {
                garageVechileInList.CurrentVechileStatus = i_VechileDetails.VechileStatus;
                isChanged = true;
            }
            return isChanged;
        }

        public bool InflateAirInTheWheels(VechileDetails i_VechileDetails)
        {
            bool isAdded = false;
            float currentAirPressure, maxAirPressure, missingAirPressure;
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_VechileDetails.LicenceNumber);
            if (garageVechileInList != null)
            {
                currentAirPressure = garageVechileInList.OwnerVechile.CurrentAirPressureOfWheels;
                maxAirPressure = garageVechileInList.OwnerVechile.MaxAirPressureOfWheels;
                missingAirPressure = maxAirPressure - currentAirPressure;
                garageVechileInList.OwnerVechile.WheelInflating(missingAirPressure);
                isAdded = true;

            }
            return isAdded;
        }

        public bool AddFuelToGasolineEngine(VechileDetails i_VechileDetails)
        {
            bool isAdded = false;
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_VechileDetails.LicenceNumber);
            if (garageVechileInList != null)
            {
                garageVechileInList.OwnerVechile.EngineOfVechile.FillTheContainer(new GasolineEngine(i_VechileDetails.TypeOfFuel, i_VechileDetails.Amount));
                isAdded = true;
            }
            return isAdded;
        }

        public bool ChargeElectricEngine(VechileDetails i_VechileDetails)
        {
            bool isAdded = false;
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_VechileDetails.LicenceNumber);
            if (garageVechileInList != null)
            {
                ElectricEngine electricToAdd = new ElectricEngine(i_VechileDetails.Amount);
                garageVechileInList.OwnerVechile.EngineOfVechile.FillTheContainer(electricToAdd);
                isAdded = true;
            }
            return isAdded;
        }



        public string GetCarDetails(VechileDetails i_VechileDetails)
        {
            string message = "Car not found";
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_VechileDetails.LicenceNumber);
            if (garageVechileInList != null)
            {
                message = garageVechileInList.ToString();
            }
            return message;
        }
    }

}