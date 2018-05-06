namespace Ex03.GarageLogic
{
    public class MotorCycleDetails : Details
    {
        private MotorcycleProperties m_MotorcycleProperties;

        public MotorcycleProperties MotorcycleProperties
        {
            get
            {
                return m_MotorcycleProperties;
            }

            set
            {
                m_MotorcycleProperties = value;
            }
        }   
    }
}
