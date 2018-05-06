namespace Ex03.GarageLogic
{
    public abstract class Details
    {
        private VechileDetails m_VechileDetails;

        public VechileDetails VechileDetails
        {
            get
            {
                return m_VechileDetails;
            }

            set
            {
                m_VechileDetails = value;
            }
        }
    }
}
