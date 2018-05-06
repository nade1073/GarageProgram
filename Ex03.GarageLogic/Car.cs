using System;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Car : Vechile
    {
        private CarProperties m_CarProperties;
        private const int k_NumberOfWheelsOfCar= 4;
        private const int k_MaxAirPressureOfWheelOfCar = 32;
        private const float k_MaxOfContainerOfElectricEngine = 3.2f;
        private const float k_MaxOfContainerOfGasolineEngine = 45;

        public Car(string i_ModelName, string i_LicenseNumber,eColor i_ColorOfTheCar,eDoors i_NumberOfDoors,eTypeOfEngine i_TypeOfEngine) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfCar, k_MaxAirPressureOfWheelOfCar)
        {
            m_CarProperties = new CarProperties(i_ColorOfTheCar, i_NumberOfDoors);
            switch(i_TypeOfEngine)
            {
                case eTypeOfEngine.Electric:
                    {
                        InitializeElectricEngine(k_MaxOfContainerOfElectricEngine);
                        break;
                    }
                case eTypeOfEngine.Gasoline:
                    {
                        InitializeGasolineEngine(eTypeOfFuel.Ocatn98, k_MaxOfContainerOfGasolineEngine);
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
            stringToReturn.AppendLine(String.Format("Model:{0}, Licsense Number : {1}, {2}",ModelName,LicenseNumber,m_CarProperties.ToString()));
            stringToReturn.AppendLine(WheelAndEngineDetails());
            return stringToReturn.ToString();
        }
    }
}
