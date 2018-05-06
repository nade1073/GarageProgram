namespace Ex03.GarageLogic
{
    using System;
    using System.Text;

    public class Car : Vechile
    {   
        public const int k_MaxAirPressureOfWheelOfCar = 32;
        public const float k_MaxOfContainerOfElectricEngine = 3.2f;
        public const float k_MaxOfContainerOfGasolineEngine = 45;
        private const int k_NumberOfWheelsOfCar = 4;
        private CarProperties m_CarProperties;

        public Car(string i_ModelName, string i_LicenseNumber, eColor i_ColorOfTheCar, eDoors i_NumberOfDoors, eTypeOfEngine i_TypeOfEngine, float i_AmountOfContainer) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfCar, k_MaxAirPressureOfWheelOfCar)
        {
            m_CarProperties = new CarProperties(i_ColorOfTheCar, i_NumberOfDoors);
            switch (i_TypeOfEngine)
            {
                case eTypeOfEngine.Electric:
                    {
                        InitializeElectricEngine(i_AmountOfContainer, k_MaxOfContainerOfElectricEngine);
                        break;
                    }

                case eTypeOfEngine.Gasoline:
                    {
                        InitializeGasolineEngine(i_AmountOfContainer, eTypeOfFuel.Ocatn98, k_MaxOfContainerOfGasolineEngine);
                        break;
                    }
            }
        }

        public CarProperties CarProperties
        {
            get
            {
                return m_CarProperties;
            }

            set
            {
                m_CarProperties = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringToReturn = new StringBuilder();
            stringToReturn.AppendLine(string.Format("Model:{0}, Licsense Number : {1}, {2}", ModelName, LicenseNumber, m_CarProperties.ToString()));
            stringToReturn.AppendLine(base.WheelAndEngineDetails());
            return stringToReturn.ToString();
        }
    }
}
