namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        private float m_PercentageOfEnergyRemaining;
        private float m_MaxCapacityOfContainer;

        public Engine(float i_MaxCapacityOfContainer)
        {
            MaxCapacityOfContainer = i_MaxCapacityOfContainer;     
        }

        public float PercentageOfEnergyRemaining
        {
            get
            {
                return m_PercentageOfEnergyRemaining;
            }

            set
            {
                m_PercentageOfEnergyRemaining = value;
            }
        }

        public float MaxCapacityOfContainer
        {
            get
            {
                return m_MaxCapacityOfContainer;
            }

            set
            {
                m_MaxCapacityOfContainer = value;
            }
        }

        public abstract void FillTheContainer(Engine i_EnergyToAddToTheContainer);

        public abstract override string ToString();
    }
}
