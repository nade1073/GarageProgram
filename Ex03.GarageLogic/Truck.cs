﻿using System;
namespace Ex03.GarageLogic
{
    public class Truck:Vechile
    {
        private bool m_IsTheTrunkCooled;
        private float m_CargoCapacity;
        private const int k_NumberOfWheelsOfTruck = 12;
        private const int k_MaxAirPressureOfWheelOfTruck = 28;

        public Truck(string i_ModelName, string i_LicenseNumber, bool i_IsTheTrunkCooled, float i_CargoCapacity) : 
            base(i_ModelName, i_LicenseNumber, k_NumberOfWheelsOfTruck, k_MaxAirPressureOfWheelOfTruck)
        {
            IsTheTrunkCooled = i_IsTheTrunkCooled;
            CargoCapacity = i_CargoCapacity;
            initializeGasolineEngine(eTypeOfFuel.Soler,115);
        }

        public bool IsTheTrunkCooled
        {
            get
            {
                return m_IsTheTrunkCooled;
            }

            set
            {
                m_IsTheTrunkCooled = value;
            }
        }

        public float CargoCapacity
        {
            get
            {
                return m_CargoCapacity;
            }

            set
            {
                m_CargoCapacity = value;
            }
        }
    }
}
