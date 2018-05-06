using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vechile
    {
        private readonly String r_ModelName;
        private readonly String r_LicenseNumber;
        private readonly List<Wheel> r_Wheels;
        private readonly int r_NumberOfWheels;
        protected Engine m_EngineOfVechile;

        public Vechile(String i_ModelName,String i_LicenseNumber,int i_NumberOfWheels,float i_MaxAirPressure)
        {
            r_ModelName = i_ModelName;
            r_LicenseNumber = i_LicenseNumber;
            r_Wheels = new List<Wheel>(i_NumberOfWheels);
            r_NumberOfWheels = i_NumberOfWheels;
            for(int i=0;i<i_NumberOfWheels;i++)
            {
                r_Wheels.Add(new Wheel(i_MaxAirPressure));
            }
        }

        public void WheelInflating(float i_AirPressureToAdd)
        {
            foreach(Wheel m_CurrentWheel in r_Wheels)
            {
                m_CurrentWheel.WheelInflating(i_AirPressureToAdd);
            }
        }

        protected void InitializeElectricEngine(float i_MaxCapacityOfContainer)
        {
            EngineOfVechile = new ElectricEngine(i_MaxCapacityOfContainer);
        }

        protected void InitializeGasolineEngine(eTypeOfFuel i_TypeOfFuel,float i_MaxCapacityOfContainer)
        {
            EngineOfVechile = new GasolineEngine(i_MaxCapacityOfContainer, i_TypeOfFuel);
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

        protected string WheelAndEngineDetails()
        {
            StringBuilder stringToReturn = new StringBuilder();
            stringToReturn.AppendLine(String.Format("Numbers of wheels {0},Details about all the wheels: {1}", NumberOfWheels, Wheels[0].ToString()));
            stringToReturn.AppendLine(String.Format("Engin:{0}", EngineOfVechile.ToString()));
            return stringToReturn.ToString();
        }

        public abstract override string ToString();
    }
}
