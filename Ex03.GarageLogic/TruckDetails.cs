using System;
namespace Ex03.GarageLogic
{
    public class TruckDetails : Details
    { 
        private bool m_IsTheTrunkCooled;
        private float m_CargoCapacity;

        public bool IsTheTrunkCooled
        {
            get
            {
                return m_IsTheTrunkCooled;
            }

            set
            {
                m_IsTheTrunkCooled = value;
            }
        }

        public float CargoCapacity
        {
            get
            {
                return m_CargoCapacity;
            }

            set
            {
                m_CargoCapacity = value;
            }
        }
    }
}
