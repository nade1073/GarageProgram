using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue;
        private float m_MinValue;
        private String m_Item;

        public ValueOutOfRangeException(Exception i_InnerException,float i_MaxValue,float i_MinValue,string i_Item)
            :base(string.Format("an error occured while trying to add value to the {0},\n The Maximum Value that you can add is : {1} and the Minimum value is {2}",i_Item,i_MaxValue,i_MinValue)
                 ,i_InnerException)
        {
            MaxValue = i_MaxValue;
            MinValue = i_MinValue;
            Item = i_Item;
        }
        public ValueOutOfRangeException(float i_MaxValue, float i_MinValue, string i_Item)
       : base(string.Format("an error occured while trying to add value to the {0},\n The Maximum Value that you can add is : {1} and the Minimum value is {2}", i_Item, i_MaxValue, i_MinValue)
            )
        {
            MaxValue = i_MaxValue;
            MinValue = i_MinValue;
            Item = i_Item;
        }


        public float MaxValue
        {
            get
            {
                return m_MaxValue;
            }

            set
            {
                m_MaxValue = value;
            }
        }

        public float MinValue
        {
            get
            {
                return m_MinValue;
            }

            set
            {
                m_MinValue = value;
            }
        }

        public string Item
        {
            get
            {
                return m_Item;
            }

            set
            {
                m_Item = value;
            }
        }
    }
}
