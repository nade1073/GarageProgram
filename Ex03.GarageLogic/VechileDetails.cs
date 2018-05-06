using System;
namespace Ex03.GarageLogic
{
    public class VechileDetails
    {
        private eTypeOfEngine m_TypeOfEngine;
        private string m_WheelManufacture;
        private string m_CurrentAirPressure;
        private string m_ModelName;
        private string m_LicenceNumber;
        private string m_OwnerName;
        private string m_PhoneOfOwner;
        private eVechileStatus m_VechileStatus;
        private eTypeOfFuel m_TypeOfFuel;
        private float m_Amount;

        public float Amount
        {
            get
            {
                return m_Amount;
            }
            set
            {
                m_Amount = value;
            }
        }

        public eTypeOfFuel TypeOfFuel
        {
            get
            {
                return m_TypeOfFuel;
            }
            set
            {
                m_TypeOfFuel = value;
            }
            
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

        public eVechileStatus VechileStatus
        {
            get
            {
                return m_VechileStatus;
            }
            set
            {
                m_VechileStatus = value;
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

        public eTypeOfEngine TypeOfEngine
        {
            get
            {
                return m_TypeOfEngine;
            }
            set
            {
                m_TypeOfEngine = value;
            }
        }

        public string WheelManufacture
        {
            get
            {
                return m_WheelManufacture;
            }
            set
            {
                m_WheelManufacture = value;
            }
        }

        public string CurrentAirPressure
        {
            get
            {
                return m_CurrentAirPressure;
            }
            set
            {
                m_CurrentAirPressure = value;
            }
        }

        public string ModelName
        {
            get
            {
                return m_ModelName;
            }
            set
            {
                m_ModelName = value;
            }
        }

        public string LicenceNumber
        {
            get
            {
                return m_LicenceNumber;
            }
            set
            {
                m_LicenceNumber = value;
            }
        }
     
    }
}
