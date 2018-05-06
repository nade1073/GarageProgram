﻿namespace Ex03.GarageLogic
{
    using System;

    public class CarProperties
    {
        private eColor m_ColorOfTheCar;
        private eDoors m_NumberOfDoors;

        public CarProperties(eColor i_Color, eDoors i_Doors)
        {
            ColorOfTheCar = i_Color;
            NumberOfDoors = i_Doors;
        }

        public CarProperties()
        {            
        }

        public eColor ColorOfTheCar
        {
            get
            {
                return m_ColorOfTheCar;
            }

            set
            {
                m_ColorOfTheCar = value;
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
<<<<<<< HEAD
               /* if((int)NumberOfDoors<2 || (int)NumberOfDoors>5)
                {
                    throw new ArgumentException("Cannot set" + (int)NumberOfDoors + " doors");
                }*/
=======
                if ((int)NumberOfDoors < 2 || (int)NumberOfDoors > 5)
                {
                    throw new ArgumentException("Cannot set" + (int)NumberOfDoors + " doors");
                }

>>>>>>> b26b8dcb084e393c4d02e0774421fe0d22a8dc8d
                m_NumberOfDoors = value;
            }
        }

		public override string ToString()
		{
            return string.Format("Color: {0},Doors: {1}", ColorOfTheCar, NumberOfDoors);
		}
	}
}
