using System;
namespace Ex03.GarageLogic
{
    public class MotorCycleDetails : Details
    {
        private eLicenseType m_LicsenseType;
        private int m_EngineCapacity;

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
        
    }
}
