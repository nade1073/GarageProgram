using System;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        private float m_Battery;

        public ElectricEngine(float i_MaxCapacityOfContainer=0) : base(i_MaxCapacityOfContainer)
        {
        }


        public float Battery
        {
            get
            {
                return m_Battery;
            }

            set
            {
                m_Battery = value;
                PercentageOfEnergyRemaining = m_Battery / MaxCapacityOfContainer;
            }
        }

        public override void FillTheContainer(Engine i_EnergyToAddToTheContainer)
        {
            ElectricEngine containerToFill = i_EnergyToAddToTheContainer as ElectricEngine;
            if (containerToFill != null)
            {

                float maxFuelToAdd = MaxCapacityOfContainer - Battery;
                if (containerToFill.Battery > maxFuelToAdd)
                {
                    throw new ValueOutOfRangeException(maxFuelToAdd, 0, eTypeOfEngine.Electric.ToString());
                }
                else
                {
                    Battery += containerToFill.Battery;
                }
            }
            else
            {
                throw new ArgumentException("Can't add a container to a different type of container");
            }
        }

        public override string ToString()
        {
            return String.Format("Type Of Engine: {0} ,Current of Battery: {1} ,Max capacity:{2} ", eTypeOfEngine.Electric.ToString(), Battery, MaxCapacityOfContainer);
        }
    }
}
