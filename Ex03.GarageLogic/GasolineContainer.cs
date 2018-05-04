using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class GasolineContainer : Container
    {
        private eTypeOfFuel m_FuelType;
        private float? m_Amount;

        public GasolineContainer(eTypeOfFuel i_FuelType)
        {
            m_FuelType = i_FuelType;
        }

        public eTypeOfFuel FuelType
        {
            get
            {
                return m_FuelType;
            }

            set
            {
                m_FuelType = value;
            }
        }

        public float? Amount
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

        public void Fill(Container x)
        {
            //Implement
        }
    }
}
