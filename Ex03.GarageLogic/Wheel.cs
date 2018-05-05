namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        private float m_CurrentAirPressure;
        private float m_MaxAirPressure;
        
        public Wheel(float i_MaxAirPressure)
        {
            MaxAirPressure = i_MaxAirPressure;
        }

        public string ManufacturerName
        {
            get
            {
                return m_ManufacturerName;
            }

            set
            {
                m_ManufacturerName = value;
            }
        }

        public float CurrentAirPressure
        {
            get
            {
                return m_CurrentAirPressure;
            }

            set
            {
                m_CurrentAirPressure = value;
            }
        }

        public float MaxAirPressure
        {
            get
            {
                return m_MaxAirPressure;
            }

            set
            {
                m_MaxAirPressure = value;
            }
        }

        public void WheelInflating(float i_AirPressureToAdd)
        {
            float maxAirPressureThatCanAddToTheWheel = MaxAirPressure - CurrentAirPressure;
            if(i_AirPressureToAdd>maxAirPressureThatCanAddToTheWheel)
            {
                throw new ValueOutOfRangeException(maxAirPressureThatCanAddToTheWheel, 0, "Wheel");
            }
            else
            {
                CurrentAirPressure += i_AirPressureToAdd;
            }
        }

        public override string ToString()
        {
            return string.Format("Manufacture:{0}, Current air pressure:{1}, Max air pressure:{2}",ManufacturerName,CurrentAirPressure,MaxAirPressure);
        }
    }
}
