namespace Ex03.GarageLogic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Vechile
    {
        private readonly string r_ModelName;
        private readonly string r_LicenseNumber;
        private readonly List<Wheel> r_Wheels;
        private readonly int r_NumberOfWheels;
        private Engine m_EngineOfVechile;

        public Vechile(string i_ModelName, string i_LicenseNumber, int i_NumberOfWheels, float i_MaxAirPressure)
        {
            r_ModelName = i_ModelName;
            r_LicenseNumber = i_LicenseNumber;
            r_Wheels = new List<Wheel>(i_NumberOfWheels);
            r_NumberOfWheels = i_NumberOfWheels;
            for (int i = 0; i < i_NumberOfWheels; i++)
            {
                r_Wheels.Add(new Wheel(i_MaxAirPressure));
            }
        }

        public string ModelName
        {
            get
            {
                return r_ModelName;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return r_LicenseNumber;
            }
        }

        public float MaxAirPressureOfWheels
        {
            get
            {
                return Wheels[0].MaxAirPressure;
            }
        }

        public float CurrentAirPressureOfWheels
        {
            get
            {
                return Wheels[0].CurrentAirPressure;
            }
        }

        public List<Wheel> Wheels
        {
            get
            {
                return r_Wheels;
            }
        }

        public Engine EngineOfVechile
        {
            get
            {
                return m_EngineOfVechile;
            }

            set
            {
                m_EngineOfVechile = value;
            }
        }

        public int NumberOfWheels
        {
            get
            {
                return r_NumberOfWheels;
            }
        }

        public void WheelInflating(float i_AirPressureToAdd)
        {
            foreach (Wheel m_CurrentWheel in r_Wheels)
            {
                m_CurrentWheel.WheelInflating(i_AirPressureToAdd);
            }
        }

        public abstract override string ToString();

        protected string WheelAndEngineDetails()
        {
            StringBuilder stringToReturn = new StringBuilder();
            stringToReturn.AppendLine(string.Format("Numbers of wheels {0},Details about all the wheels: {1}", NumberOfWheels, Wheels[0].ToString()));
            stringToReturn.AppendLine(string.Format("Engin:{0}", EngineOfVechile.ToString()));
            return stringToReturn.ToString();
        }

        protected void InitializeElectricEngine(float i_AmountOfContainer, float i_MaxCapacityOfContainer)
        {
            EngineOfVechile = new ElectricEngine(i_AmountOfContainer, i_MaxCapacityOfContainer);
        }

        protected void InitializeGasolineEngine(float i_AmountOfContainer, eTypeOfFuel i_TypeOfFuel, float i_MaxCapacityOfContainer)
        {
            EngineOfVechile = new GasolineEngine(i_AmountOfContainer, i_MaxCapacityOfContainer, i_TypeOfFuel);
        }
    }
}
