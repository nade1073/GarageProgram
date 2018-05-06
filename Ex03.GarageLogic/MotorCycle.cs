namespace Ex03.GarageLogic
{
    using System;
    using System.Text;

    public class MotorCycle : Vechile
    {
        public const int k_MaxAirPressureOfWheelOfMotorCycle = 30;
        public const float k_MaxCapacityOfElectricEngine = 1.8f;
        public const float k_MaxCapacityOfGasolineEngine = 6;
        private const int k_NumberOfWheelsOfMotorCycle = 2;
        private MotorcycleProperties m_MotorcycleProperties;

        public MotorCycle(string i_ModelName, string i_LicenseNumber, eLicenseType i_LicsenseType, int i_EngineCapacity, eTypeOfEngine i_TypeOfEngine, float i_AmountOfContainer) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfMotorCycle, k_MaxAirPressureOfWheelOfMotorCycle)
        {
            MotorcycleProperties = new MotorcycleProperties(i_EngineCapacity, i_LicsenseType);
            switch (i_TypeOfEngine)
            {
                case eTypeOfEngine.Electric:
                    {
                        InitializeElectricEngine(i_AmountOfContainer, k_MaxCapacityOfElectricEngine);
                        break;
                    }

                case eTypeOfEngine.Gasoline:
                    {
                        InitializeGasolineEngine(i_AmountOfContainer, eTypeOfFuel.Ocatn96, k_MaxCapacityOfGasolineEngine);
                        break;
                    }
            }
        }

        public MotorcycleProperties MotorcycleProperties
        {
            get
            {
                return m_MotorcycleProperties;
            }

            set
            {
                m_MotorcycleProperties = value;
            }
        }
     
        public override string ToString()
        {
            StringBuilder stringToReturn = new StringBuilder();
            stringToReturn.AppendLine(string.Format("Model:{0}, Licsense Number : {1}, {2}", ModelName, LicenseNumber, MotorcycleProperties.ToString()));
            stringToReturn.AppendLine(base.WheelAndEngineDetails());
            return stringToReturn.ToString();
        }
    }
}
