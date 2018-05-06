using System;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Truck:Vechile
    {
        private TruckProperties m_TruckProperties;
        private const int k_NumberOfWheelsOfTruck = 12;
        private const int k_MaxAirPressureOfWheelOfTruck = 28;
        private const int k_FuelContainerOfTruck = 115;

        public Truck(string i_ModelName, string i_LicenseNumber, bool i_IsTheTrunkCooled, float i_CargoCapacity) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfTruck, k_MaxAirPressureOfWheelOfTruck)
        {
            TruckProperties = new TruckProperties(i_IsTheTrunkCooled, i_CargoCapacity);
            initializeGasolineEngine(eTypeOfFuel.Soler,k_FuelContainerOfTruck);
        }

        public TruckProperties TruckProperties
        {
            get
            {
                return m_TruckProperties;
            }
            set
            {
                m_TruckProperties = value;
            }
        }


        public override string ToString()
        {
            StringBuilder stringToReturn = new StringBuilder();
            stringToReturn.AppendLine(String.Format("Model:{0}, Licsense Number : {1}, {2}", ModelName, LicenseNumber,TruckProperties.ToString()));
            stringToReturn.AppendLine(WheelAndEngineDetails());
            return stringToReturn.ToString();
        }
    }
}
