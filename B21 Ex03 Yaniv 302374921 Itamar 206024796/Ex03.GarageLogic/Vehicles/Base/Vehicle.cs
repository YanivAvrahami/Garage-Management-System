﻿using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }
        public float EnergyPercentage { get; set; }
        public List<Wheel> Wheels { get; set; }

        public Vehicle(string i_ModelName, float i_CurrentEnergy)
        {
            ModelName = i_ModelName;
            EnergyPercentage = i_CurrentEnergy;
        }

    }
}
