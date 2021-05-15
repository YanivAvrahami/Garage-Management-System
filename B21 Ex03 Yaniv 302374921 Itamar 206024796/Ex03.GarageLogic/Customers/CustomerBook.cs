﻿using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class CustomerBook
    {
        // TODO: remove this class and Garage will have the Dictionary
        public Dictionary<string, CustomerTicket> CustomerDictionary { get; set; }

        public CustomerBook()
        {
            CustomerDictionary = new Dictionary<string, CustomerTicket>();
        }

        public bool IsCustomerExist(string i_LicenseNumber)
        {
            return CustomerDictionary.ContainsKey(i_LicenseNumber);
        }

        public CustomerTicket GetCustomer(string i_LicenseNumber)
        {
            return CustomerDictionary[i_LicenseNumber];
        }

        public void AddCustomer(CustomerTicket i_Customer)
        {
            CustomerDictionary.Add(i_Customer.Vehicle.LicenseNumber, i_Customer);
        }

        public string GetCustomerInformationAsAstring(string i_LicenseNumber)
        {
            StringBuilder customerInfoStr = new StringBuilder();
            CustomerTicket customer = GetCustomer(i_LicenseNumber);
            Vehicle vehicle = customer.Vehicle;

            customerInfoStr.AppendLine($"License number: {i_LicenseNumber}");
            customerInfoStr.AppendLine($"Model Name: {vehicle.ModelName}");
            customerInfoStr.AppendLine($"Owner Name: {customer.FullName}");
            customerInfoStr.AppendLine($"Vehicle State: {customer.VehicleState}");
            customerInfoStr.AppendLine($"Wheel Air Pressure: {vehicle.Wheels[0].CurrentAirPressure}");
            customerInfoStr.AppendLine($"Wheel Max Pressure: {vehicle.Wheels[0].MaxAirPressure}");
            customerInfoStr.AppendLine(vehicle.GetInformationAboutVehicleAsString());

            return customerInfoStr.ToString();
        }
    }
}