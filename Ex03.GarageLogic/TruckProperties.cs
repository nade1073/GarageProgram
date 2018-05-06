using System;
namespace Ex03.GarageLogic
{
    public class TruckProperties
    {
        private bool m_IsTheTrunkCooled;
        private float m_CargoCapacity;

        public TruckProperties(bool i_IsTheTrunkCooled,float i_CargoCapacity)
        {
            IsTheTrunkCooled = i_IsTheTrunkCooled;
            CargoCapacity = i_CargoCapacity;
        }

        public TruckProperties()
        {}

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

		public override string ToString()
		{
            return String.Format("Trunk Cooled: {0},Cargo capacity: {1}", IsTheTrunkCooled, CargoCapacity);
		}
	}
}
