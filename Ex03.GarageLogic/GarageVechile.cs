namespace Ex03.GarageLogic
{
    public class GarageVechile
    {
        private string m_OwnerName;
        private string m_PhoneOfOwner;
        private Vechile m_OwnerVechile;
        private eVechileStatus m_CurrentVechileStatus;

        public string OwnerName
        {
            get
            {
                return m_OwnerName;
            }

            set
            {
                m_OwnerName = value;
            }
        }

        public string PhoneOfOwner
        {
            get
            {
                return m_PhoneOfOwner;
            }

            set
            {
                m_PhoneOfOwner = value;
            }
        }

        public Vechile OwnerVechile
        {
            get
            {
                return m_OwnerVechile;
            }

            set
            {
                m_OwnerVechile = value;
            }
        }

        public eVechileStatus CurrentVechileStatus
        {
            get
            {
                return m_CurrentVechileStatus;
            }

            set
            {
                m_CurrentVechileStatus = value;
            }
        }
    }
}