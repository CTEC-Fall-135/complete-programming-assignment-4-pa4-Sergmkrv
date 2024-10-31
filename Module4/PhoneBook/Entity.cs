using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    public abstract class Entity
    {
        #region Properties
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        #region Constructor
        public Entity(Address address, string phoneNumber)
        {
            Address = address;
            PhoneNumber = phoneNumber;
        }
        #endregion

        #region Methods
        public abstract void PrintEntity();
        #endregion
    }

    public class Business : Entity
    {
        #region Properties
        public string BusinessName { get; set; }
        #endregion

        #region Constructor 
        public Business(string businessName, Address address, string phoneNumber)
            : base(address, phoneNumber)
        {
            BusinessName = businessName;
        }
        #endregion

        #region Methods 
        public override void PrintEntity()
        {
            Console.WriteLine($"{BusinessName}");
            Address.PrintAddress();
            Console.WriteLine($"Phone: {PhoneNumber}");
        }
        #endregion
    }

    public class Person : Entity
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Constructor 
        public Person(string firstName, string lastName, Address address, string phoneNumber)
            : base(address, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Methods
        public override void PrintEntity()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            Address.PrintAddress();
            Console.WriteLine($"Phone: {PhoneNumber}");
        }
        #endregion
    }
}