using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public interface IAddressBook
    {
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zipCode, string phoneNumber, string email);
    }

    class ContactDetails
    {
        //Variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string phoneNumber;
        public string email;
        public int zipCode;
        public ContactDetails next;

        public ContactDetails()
        {
            Console.WriteLine("Fill the Contact Details to add in Address Book:");
            Console.WriteLine("------------------------------------------------");

            //User Inputs
            Console.WriteLine("Enter First Name : ");
            this.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            this.lastName = Console.ReadLine();

            Console.WriteLine("Enter Address : ");
            this.address = Console.ReadLine();

            Console.WriteLine("Enter City Name : ");
            this.city = Console.ReadLine();

            Console.WriteLine("Enter State Name : ");
            this.state = Console.ReadLine();

            Console.WriteLine("Enter Zip-Code/ Pin-Code : ");
            this.zipCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Phone Number : ");
            this.phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email-ID : ");
            this.email = Console.ReadLine();

        }
        public ContactDetails(string firstName, string lastName, string address, string city, string state, int zipCode, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

    }
}
