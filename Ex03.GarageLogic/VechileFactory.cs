namespace Ex03.GarageLogic
{
    public class VechileFactory
    {
        public static bool CreateAndInsertVechile(Details i_VechileDetails)
        {
            GarageVechile m_VechileToAddToGarage = new GarageVechile(i_VechileDetails.VechileDetails.OwnerName, i_VechileDetails.VechileDetails.PhoneOfOwner, eVechileStatus.Repair);
            bool isAddedToGarage = false;
            switch (i_VechileDetails.GetType().Name.ToString())
            {
                case nameof(CarDetails):
                    {
                        CarDetails car = i_VechileDetails as CarDetails;
                        if (car != null)                         
                        {
                            m_VechileToAddToGarage.OwnerVechile = new Car(car.VechileDetails.ModelName, car.VechileDetails.LicenceNumber, car.CarProperties.ColorOfTheCar, car.CarProperties.NumberOfDoors, car.VechileDetails.TypeOfEngine, car.VechileDetails.Amount);
                        }

                        break;
                    }
                     
                case nameof(TruckDetails):
                    {
                        TruckDetails truck = i_VechileDetails as TruckDetails;
                        if (truck != null)
                        {
                            m_VechileToAddToGarage.OwnerVechile = new Truck(truck.VechileDetails.ModelName, truck.VechileDetails.LicenceNumber, truck.TruckProperties.IsTheTrunkCooled, truck.TruckProperties.CargoCapacity, truck.TruckProperties.CargoCapacity);
                        }

                        break;
                    }

                case nameof(MotorCycleDetails):
                    {
                        MotorCycleDetails motorCycle = i_VechileDetails as MotorCycleDetails;
                        if (motorCycle != null)
                        {
                            m_VechileToAddToGarage.OwnerVechile = new MotorCycle(motorCycle.VechileDetails.ModelName, motorCycle.VechileDetails.LicenceNumber, motorCycle.MotorcycleProperties.LicsenseType, motorCycle.MotorcycleProperties.EngineCapacity, motorCycle.VechileDetails.TypeOfEngine, motorCycle.VechileDetails.Amount);
                        }

                        break;
                    }
            }

            isAddedToGarage = Garage.Instance.AddVechileToGarage(m_VechileToAddToGarage);
            return isAddedToGarage;
        }
    }
}
