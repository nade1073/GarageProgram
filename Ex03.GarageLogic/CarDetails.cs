using System;
namespace Ex03.GarageLogic
{
    public class CarDetails : Details
    {
        private eColor m_ColorOfCar;
        private eDoors m_NumberOfDoors;

        public eColor ColorOfCar
        {
            get
            {
                return m_ColorOfCar;
            }
            set
            {
                m_ColorOfCar = value;
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

    }
}
