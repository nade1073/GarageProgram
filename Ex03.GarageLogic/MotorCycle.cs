namespace Ex03.GarageLogic
{
    class MotorCycle : Vechile
    {
        private int m_EngineCapacity;
        private eLicenseType m_LicsenseType;
        private const int k_NumberOfWheelsOfMotorCycle = 2;
        private const int k_MaxAirPressureOfWheelOfMotorCycle = 30;

        public MotorCycle(string i_ModelName, string i_LicenseNumber, eLicenseType i_LicsenseType, int i_EngineCapacity, eTypeOfEngine i_TypeOfEngine) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfMotorCycle, k_MaxAirPressureOfWheelOfMotorCycle)
        {
            EngineCapacity = i_EngineCapacity;
            LicsenseType = i_LicsenseType;
            switch (i_TypeOfEngine)
            {
                case eTypeOfEngine.Electric:
                    {
                        initializeElectricEngine(1.8f);
                        break;
                    }
                case eTypeOfEngine.Gasoline:
                    {
                        initializeGasolineEngine(eTypeOfFuel.Ocatn96,6);
                        break;
                    }
            }
        }


        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }

            set
            {
                m_EngineCapacity = value;
            }
        }

        public eLicenseType LicsenseType
        {
            get
            {
                return m_LicsenseType;
            }

            set
            {
                m_LicsenseType = value;
            }
        }
    }
}
