using System;
namespace Ex03.GarageLogic
{
    public class VechileFactory
    {
        public static bool CreateAndInsertVechile(Details i_VechileDetails)
        {
            GarageVechile m_VechileToAddToGarage=new GarageVechile(i_VechileDetails.OwnerName,i_VechileDetails.PhoneOfOwner,eVechileStatus.Repair);
            bool isAddedToGarage = false;
            //** Need To CHECK!!
            switch (i_VechileDetails.GetType().ToString())
            {
                case nameof(CarDetails):
                    {
                        CarDetails car = i_VechileDetails as CarDetails;
                        if(car!=null)                         
                        {
                            m_VechileToAddToGarage.OwnerVechile=new Car(car.ModelName, car.LicenceNumber, car.ColorOfCar, car.NumberOfDoors, car.TypeOfEngine);
                        }
                        break;
                    }
                     
                case nameof(TruckDetails):
                    {
                        TruckDetails truck = i_VechileDetails as TruckDetails;
                        if (truck != null)
                        {
                            m_VechileToAddToGarage.OwnerVechile = new Truck(truck.ModelName, truck.LicenceNumber, truck.IsTheTrunkCooled, truck.CargoCapacity);
                        }
                        break;
                    }

                case nameof(MotorCycleDetails):
                    {
                        MotorCycleDetails motorCycle = i_VechileDetails as MotorCycleDetails;
                        if (motorCycle != null)
                        {
                            m_VechileToAddToGarage.OwnerVechile = new MotorCycle(motorCycle.ModelName, motorCycle.LicenceNumber, motorCycle.LicsenseType, motorCycle.EngineCapacity, motorCycle.TypeOfEngine);
                        }
                        break;
                    }
            }
            isAddedToGarage = Garage.Instance.AddVechileToGarage(m_VechileToAddToGarage);
            return isAddedToGarage;
        }
    }
}

