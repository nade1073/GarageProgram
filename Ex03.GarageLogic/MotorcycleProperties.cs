using System;
namespace Ex03.GarageLogic
{
    public class MotorcycleProperties
    {
        private int m_EngineCapacity;
        private eLicenseType m_LicsenseType;

        public MotorcycleProperties(int i_EngineCapacity,eLicenseType i_LicsenseType)
        {
            EngineCapacity = i_EngineCapacity;
            LicsenseType = i_LicsenseType;
        }

        public MotorcycleProperties()
        {
            
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

		public override string ToString()
		{
            return String.Format("Engine Capacity: {0},Type of Licsense: {1}", EngineCapacity, LicsenseType.ToString());
		}
	}
}
