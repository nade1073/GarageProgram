namespace Ex03.GarageLogic
{
    using System;
    using System.Text;

    public class GarageVechile
    {
        private string m_OwnerName;
        private string m_PhoneOfOwner;
        private Vechile m_OwnerVechile;
        private eVechileStatus m_CurrentVechileStatus;

        public GarageVechile(string i_OwnerName, string i_PhoneOfOwner, eVechileStatus i_Status)
        {
            OwnerName = i_OwnerName;
            PhoneOfOwner = i_PhoneOfOwner;
            CurrentVechileStatus = i_Status;
        }

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

        public override string ToString()
        {
            StringBuilder stringToReturn = new StringBuilder();
            stringToReturn.AppendLine(string.Format("The owner Name is {0}, the Phone of the owner is {1} , the status of the vechile is {2}\n The Car Details are: {3}", OwnerName, PhoneOfOwner, CurrentVechileStatus.ToString(), OwnerVechile.ToString()));
            return stringToReturn.ToString();
        }
    }
}