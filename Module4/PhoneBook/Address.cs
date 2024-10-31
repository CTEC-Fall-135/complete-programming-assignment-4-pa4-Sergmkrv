using System;

namespace PhoneBook
{
    public class Address
    {
        #region Properties
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        #endregion

        #region Constructor
        public Address(string streetAddress, string city, string state, string zip)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }
        #endregion

        #region Methods
        public void PrintAddress()
        {
            Console.WriteLine($"{StreetAddress}");
            Console.WriteLine($"{City}, {State} {Zip}");
        }
        #endregion
    }
}