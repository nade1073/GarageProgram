using System;
using System.Collections.Generic;
using System.Text;

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

        public List<string> ShowVechilesInGarage(eVechileStatus? i_StatusToFilterVechiles)
        {
            List<string> vechilesLicenceNumbers = new List<string>();
            foreach (GarageVechile currentVechile in m_GarageVechiles)
            {
                if (i_StatusToFilterVechiles == null)
                {
                    vechilesLicenceNumbers.Add(currentVechile.ToString());
                }

                else if (currentVechile.CurrentVechileStatus == i_StatusToFilterVechiles)
                {
                    vechilesLicenceNumbers.Add(currentVechile.ToString());
                }
            }
            return vechilesLicenceNumbers;
        }

        public bool ChangeStatusOfVechile(string i_LicenceNumber, eVechileStatus i_NewStatus)
        {
            bool isChanged = false;
            GarageVechile garageVechileInList = new GarageVechile();
            garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                isChanged = true;
                garageVechileInList.CurrentVechileStatus = i_NewStatus;
            }
            return isChanged;
        }

        public string InflateAirInTheWheels(string i_LicenceNumber)
        {
            string message=null;
            float currentAirPressure, maxAirPressure, missingAirPressure;
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                currentAirPressure = garageVechileInList.OwnerVechile.CurrentAirPressureOfWheels;
                maxAirPressure = garageVechileInList.OwnerVechile.MaxAirPressureOfWheels;
                missingAirPressure = maxAirPressure - currentAirPressure;
                try
                {
                    garageVechileInList.OwnerVechile.WheelInflating(missingAirPressure);
                }
                catch (ValueOutOfRangeException exception)
                {
                    message = exception.Message;
                }
            }
            return message;
        }

        public string AddFuelToGasolineEngine(string i_LicenceNumber, eTypeOfFuel i_TypeOfFuelToAdd, float i_AmountOfFuelToAdd)
        {
            string message=null;
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                try
                {
                    garageVechileInList.OwnerVechile.EngineOfVechile.FillTheContainer(new GasolineEngine(i_TypeOfFuelToAdd, i_AmountOfFuelToAdd));
                    message = "Sucsses To add";
                }
                catch(ArgumentException exception)
                {
                    message = exception.Message;
                }
                catch(ValueOutOfRangeException exception)
                {
                    message = exception.Message;
                }
            }
            return message;
        }

        public string ChargeElectricEngine(string i_LicenceNumber, float i_AmountOfBatteryToAdd)
        {
            string message = null;
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                ElectricEngine electricToAdd = new ElectricEngine();
                electricToAdd.Battery = i_AmountOfBatteryToAdd;
                try
                {
                    garageVechileInList.OwnerVechile.EngineOfVechile.FillTheContainer(electricToAdd);
                    message = "Sucsses To add";
                }
                catch(ArgumentException exception)
                {
                    message = exception.Message;
                }
                catch(ValueOutOfRangeException exception)
                {
                    message = exception.Message;
                }
            }
            return message;
        }

        public string GetCarDetails(string i_LicenceNumber)
        {
            string message=null;
            GarageVechile garageVechileInList = getVechileByLicenceNumber(i_LicenceNumber);
            if (garageVechileInList != null)
            {
                message = garageVechileInList.ToString();
            }
            return message;
        }
    }

}