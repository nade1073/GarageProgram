namespace Ex03.GarageLogic
{
    using System;
    using System.Text;

    public class Truck : Vechile
    {
        public const int k_MaxAirPressureOfWheelOfTruck = 28;
        public const int k_FuelContainerOfTruck = 115;
        private const int k_NumberOfWheelsOfTruck = 12;
        private TruckProperties m_TruckProperties;

        public Truck(string i_ModelName, string i_LicenseNumber, bool i_IsTheTrunkCooled, float i_CargoCapacity, float i_AmountOfContainer) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfTruck, k_MaxAirPressureOfWheelOfTruck)
        {
            TruckProperties = new TruckProperties(i_IsTheTrunkCooled, i_CargoCapacity);
            InitializeGasolineEngine(i_AmountOfContainer, eTypeOfFuel.Soler, k_FuelContainerOfTruck);
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
            stringToReturn.AppendLine(string.Format("Model:{0}, Licsense Number : {1}, {2}", ModelName, LicenseNumber, TruckProperties.ToString()));
            stringToReturn.AppendLine(base.WheelAndEngineDetails());
            return stringToReturn.ToString();
        }
    }
}
