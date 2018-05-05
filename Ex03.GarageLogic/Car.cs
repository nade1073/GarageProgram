using System;
using System.Text;

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

        public override string ToString()
        {
            StringBuilder stringToReturn = new StringBuilder();
            stringToReturn.AppendLine(String.Format("Model:{0}, Licsense Number : {1}, Color: {2},Doors: {3},   ",ModelName,LicenseNumber,ColorOfTheCar.ToString(),NumberOfDoors.ToString()));
            stringToReturn.AppendLine(WheelAndEngineDetails());
            return stringToReturn.ToString();
        }
    }
}
