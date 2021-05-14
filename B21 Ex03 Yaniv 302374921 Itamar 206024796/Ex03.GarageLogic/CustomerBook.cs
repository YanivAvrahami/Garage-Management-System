﻿using System.Collections.Generic;

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
    }
}
