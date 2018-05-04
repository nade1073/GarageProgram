namespace Ex03.GarageLogic
{
    public class ElectricContainer : Container
    {
        private float m_Battery;

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

        public void Fill(Container x)
        {
            // Some logic
        }
    }
}
