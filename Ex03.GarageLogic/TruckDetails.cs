using System;
namespace Ex03.GarageLogic
{
    public class TruckDetails : Details
    {
        private TruckProperties m_TruckProperties;

        public TruckProperties TruckProperties
        {
            get
            {
                return m_TruckProperties;
            }
            set
            {
                m_TruckProperties = value;
            }
        }
    }
}
