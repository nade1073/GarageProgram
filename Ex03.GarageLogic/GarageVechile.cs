namespace Ex03.GarageLogic
{
    public class GarageVechile
    {
        private string m_OwnerName;
        private string m_PhoneOfOwner;
        private Vechile m_OwnerVechile;
        private eVechileStatus m_CurrentVechileStatus;

        public string ownerName
        {
            set
            {
                m_OwnerName = ownerName;
            }
            get
            {
                return m_OwnerName;
            }
        }
        public string phoneOfOwner
        {
            set
            {
                m_PhoneOfOwner = phoneOfOwner;
            }
            get
            {
                return m_PhoneOfOwner;
            }
        }
        public Vechile ownerVechile
        {
            set
            {
                m_OwnerVechile = ownerVechile;
            }
            get
            {
                return m_OwnerVechile;
            }
        }
        public eVechileStatus currentVechileStatus
        {
            set
            {
                m_CurrentVechileStatus = currentVechileStatus;
            }
            get
            {
                return m_CurrentVechileStatus;
            }
        }
    }
}