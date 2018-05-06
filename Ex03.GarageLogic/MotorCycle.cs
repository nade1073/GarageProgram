using System;
using System.Text;

namespace Ex03.GarageLogic
{
    class MotorCycle : Vechile
    {
        private MotorcycleProperties m_MotorcycleProperties;
        private const int k_NumberOfWheelsOfMotorCycle = 2;
        private const int k_MaxAirPressureOfWheelOfMotorCycle = 30;
        private const float k_MaxCapacityOfElectricEngine = 1.8f;
        private const float k_MaxCapacityOfGasolineEngine = 6;

        public MotorCycle(string i_ModelName, string i_LicenseNumber, eLicenseType i_LicsenseType, int i_EngineCapacity, eTypeOfEngine i_TypeOfEngine) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfMotorCycle, k_MaxAirPressureOfWheelOfMotorCycle)
        {
            MotorcycleProperties = new MotorcycleProperties(i_EngineCapacity, i_LicsenseType);
            switch (i_TypeOfEngine)
            {
                case eTypeOfEngine.Electric:
                    {
                        initializeElectricEngine(k_MaxCapacityOfElectricEngine);
                        break;
                    }
                case eTypeOfEngine.Gasoline:
                    {
                        initializeGasolineEngine(eTypeOfFuel.Ocatn96,k_MaxCapacityOfGasolineEngine);
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
            stringToReturn.AppendLine(String.Format("Model:{0}, Licsense Number : {1}, {2}", ModelName, LicenseNumber, MotorcycleProperties.ToString()));
            stringToReturn.AppendLine(WheelAndEngineDetails());
            return stringToReturn.ToString();
        }
    }
}
