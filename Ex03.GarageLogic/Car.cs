namespace Ex03.GarageLogic
{
    public class Car : Vechile
    {
        private eColor m_ColorOfTheCar;
        private eDoors m_NumberOfDoors;
        private const int k_NumberOfWheelsOfCar= 4;
        private const int k_MaxAirPressureOfWheelOfCar = 32;

        public Car(string i_ModelName, string i_LicenseNumber,eColor i_ColorOfTheCar,eDoors i_NumberOfDoors,eTypeOfEngine i_TypeOfEngine) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfCar, k_MaxAirPressureOfWheelOfCar)
        {
            ColorOfTheCar = i_ColorOfTheCar;
            NumberOfDoors = i_NumberOfDoors;
            switch(i_TypeOfEngine)
            {
                case eTypeOfEngine.Electric:
                    {
                        initializeElectricEngine(3.2f);
                        break;
                    }
                case eTypeOfEngine.Gasoline:
                    {
                        initializeGasolineEngine(eTypeOfFuel.Ocatn98, 45);
                        break;
                    }
            }
        }

        public eColor ColorOfTheCar
        {
            get
            {
                return m_ColorOfTheCar;
            }

            set
            {
                m_ColorOfTheCar = value;
            }
        }

        public eDoors NumberOfDoors
        {
            get
            {
                return m_NumberOfDoors;
            }

            set
            {
                m_NumberOfDoors = value;
            }
        }
    }
}
