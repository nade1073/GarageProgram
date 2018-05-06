namespace Ex03.GarageLogic
{
    public class CarDetails : Details
    {
        private CarProperties m_CarProperties;

        public CarProperties CarProperties
        {
            get
            {
                return m_CarProperties;
            }
            set
            {
                m_CarProperties = value;
            }
        }
    }
}
