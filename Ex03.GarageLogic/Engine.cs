namespace Ex03.GarageLogic
{
    public class Engine
    {
        private float? m_PercentageOfEnergyRemaining;
        private float m_MaxCapacityOfContainer;
        private Container m_Container;

        public Engine(Container i_Container,float i_MaxCapacityOfContainer)
        {
            MaxCapacityOfContainer = i_MaxCapacityOfContainer;
            i_Container = m_Container;
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

        public float? PercentageOfEnergyRemaining
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

        public void FillTheContainer(Container i_EnergyToAddToTheContainer)
        {
            m_Container.Fill(i_EnergyToAddToTheContainer);
        }
    }
}
