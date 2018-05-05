using System;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        private float m_Battery;

        public ElectricEngine(float i_MaxCapacityOfContainer) : base(i_MaxCapacityOfContainer)
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
                    throw new ValueOutOfRangeException(maxFuelToAdd, 0, "ElectricEngine");
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
    }
}
