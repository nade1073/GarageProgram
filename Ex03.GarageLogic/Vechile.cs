using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vechile
    {
        private String m_ModelName;
        private String m_LicenseNumber;
        private readonly List<Wheel> m_Wheels;
        private readonly int r_NumberOfWheels;
        protected Engine m_EngineOfVechile;

        public Vechile(String i_ModelName,String i_LicenseNumber,int i_NumberOfWheels,float i_MaxAirPressure)
        {
            ModelName = i_ModelName;
            LicenseNumber = i_LicenseNumber;
            Wheels = new List<Wheel>(i_NumberOfWheels);
            r_NumberOfWheels = i_NumberOfWheels;
            for(int i=0;i<i_NumberOfWheels;i++)
            {
                m_Wheels.Add(new Wheel(i_MaxAirPressure));
            }
        }

        public void WheelInflating(float? i_AirPressureToAdd)
        {
            foreach(Wheel m_CurrentWheel in m_Wheels)
            {
                m_CurrentWheel.WheelInflating(i_AirPressureToAdd);
            }
        }

        protected void initializeElectricEngine(float i_MaxCapacityOfContainer)
        {
            EngineOfVechile = new Engine(new ElectricContainer(), i_MaxCapacityOfContainer);
        }

        protected void initializeGasolineEngine(eTypeOfFuel i_TypeOfFuel,float i_MaxCapacityOfContainer)
        {
            EngineOfVechile = new Engine(new GasolineContainer(i_TypeOfFuel), i_MaxCapacityOfContainer);
        }

        public string ModelName
        {
            get
            {
                return m_ModelName;
            }

            set
            {
                m_ModelName = value;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }

            set
            {
                m_LicenseNumber = value;
            }
        }

        public float MaxAirPressureOfWheels
        {
            get
            {
                return Wheels[0].MaxAirPressure;
            }
        }
        public float? CurrentAirPressureOfWheels
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
                return m_Wheels;
            }

            set
            {
                m_Wheels = value;
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
    }
}
