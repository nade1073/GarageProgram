using System;

namespace Ex03.GarageLogic
{
    public class GasolineEngine : Engine
    {
        private eTypeOfFuel m_FuelType;
        private float m_Amount;

        public GasolineEngine(float i_Amount,float i_MaxCapacityOfContainer, eTypeOfFuel i_FuelType) : base(i_MaxCapacityOfContainer)
        {
            FuelType = i_FuelType;
            Amount = i_Amount;
        }

        public GasolineEngine(eTypeOfFuel i_FuelType,float i_AmountOfFuel):base (0)
        {
            FuelType = i_FuelType;
            Amount = i_AmountOfFuel;
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

        public float Amount
        {
            get
            {
                return m_Amount;
            }

            set
            {
                m_Amount = value;
                PercentageOfEnergyRemaining = m_Amount / MaxCapacityOfContainer;
            }
        }

        public override void FillTheContainer(Engine i_EnergyToAddToTheContainer)
        {
            GasolineEngine containerToFill = i_EnergyToAddToTheContainer as GasolineEngine;
            if(containerToFill!=null)
            {
                if(containerToFill.FuelType!=this.FuelType)
                {
                    throw new ArgumentException("Can't add a fuel to a different type of fuel");
                }
                else
                {
                    float maxFuelToAdd = MaxCapacityOfContainer - Amount;
                    if(containerToFill.Amount>maxFuelToAdd)
                    {
                        throw new ValueOutOfRangeException(maxFuelToAdd, 0, typeof(GasolineEngine).ToString());
                    }
                    else
                    {
                        Amount = Amount + containerToFill.Amount;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Can't add a container to a different type of container");
            }
        }

        public override string ToString()
        {
            return String.Format("Type Of Engine: {0} ,Current of fuel: {1} , Type of fuel: {2} Max capacity:{3}", eTypeOfEngine.Gasoline.ToString(),Amount,FuelType.ToString() , MaxCapacityOfContainer);
        }
    }
}
