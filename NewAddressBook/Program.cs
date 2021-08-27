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

            //Call AddressBook
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.Book();

        }
    }
}