using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Address Book Management System Development!");
            Console.WriteLine("======================================================");

            //Call AddressBook Options
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            addressBookBuilder.AddressBookCreator();

            //addressBookBuilder.Display(); //Display Contact
            //addressBookBuilder.ModifyContact();//Modify Contact
            //addressBookBuilder.DeleteContact();//Delete Contact
        }
    }
}