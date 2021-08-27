using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBook
{
    class AddressBookBuilder : IAddressBook
    {
        //Dictionary and List 
        private List<ContactDetails> contactDetailsList;
        private Dictionary<string, List<ContactDetails>> AddressBookDictionary;

        //Constructor
        public AddressBookBuilder()
        {
            this.contactDetailsList = new List<ContactDetails>();
            this.AddressBookDictionary = new Dictionary<string, List<ContactDetails>>();
        }

        // Add contact in AddressBook 
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zipCode, string phoneNumber, string email)
        {
            //Variable
            string userConfirmation;

            //Object Created to Add Contact to List
            ContactDetails contactDetails = new ContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
            this.contactDetailsList.Add(contactDetails);
            Console.WriteLine("Contact Details Added SuccessFully !\n");
            Console.WriteLine("-------------------------------");

            //Asking to Add More Contact
            while (true)
            {
                Console.WriteLine("Want to Add New Contact ? ");
                Console.WriteLine("Enter 'Yes' to Add New Contact");
                Console.WriteLine("Enter 'No' to Continue");
                Console.WriteLine("-------------------------------");
                userConfirmation = Console.ReadLine();

                if (string.Equals(userConfirmation, "yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    //Add Contact
                    ContactDetails contactDetails1 = new ContactDetails();
                    this.contactDetailsList.Add(contactDetails1);
                    Console.WriteLine("Contact Details Added SuccessFully !\n");
                    Console.WriteLine("-------------------------------");
                }
                else if (string.Equals(userConfirmation, "no", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Thank You");
                    break;
                }
            }
        }

        //Modify Contact from AddressBook
        public void ModifyContact()
        {
            //Variables 
            string userFirstName, dataFirstName;

            //User-Input To Modify Data
            Console.WriteLine("Enter First Name To Modify Data : ");
            userFirstName = Console.ReadLine();

            //Check User-Input Match from AddressBook
            foreach (var item in this.contactDetailsList)
            {
                dataFirstName = item.firstName;

                //Modify Data
                if (dataFirstName == userFirstName)
                {
                    Console.WriteLine("Data Matched :");
                    Display();
                    Console.WriteLine("Enter What You Wnat to Modify :");
                    Console.WriteLine("First Name, Last Name, Address, City, State, ZipCode, Phone Number, Email");
                    Console.WriteLine("Example :: Phone number ::");
                    Console.WriteLine("---------------------------------------------------");
                    string userModifyInput = Console.ReadLine();

                    if (string.Equals(userModifyInput, "First Name", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter First Name : ");
                        item.firstName = Console.ReadLine();
                        Console.WriteLine("Updated First Name : " + item.firstName);
                    }
                    else if (string.Equals(userModifyInput, "Last Name", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Last Name : ");
                        item.lastName = Console.ReadLine();
                        Console.WriteLine("Updated Last Name : " + item.lastName);
                    }
                    else if (string.Equals(userModifyInput, "Address", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Address : ");
                        item.address = Console.ReadLine();
                        Console.WriteLine("Updated Address : " + item.address);
                    }
                    else if (string.Equals(userModifyInput, "City", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter City Name : ");
                        item.city = Console.ReadLine();
                        Console.WriteLine("Updated City  : " + item.city);
                    }
                    else if (string.Equals(userModifyInput, "state", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter State : ");
                        item.state = Console.ReadLine();
                        Console.WriteLine("Updated State : " + item.state);
                    }
                    else if (string.Equals(userModifyInput, "ZipCode", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Zip-Code : ");
                        item.zipCode = int.Parse(Console.ReadLine());
                        Console.WriteLine("Updated Zip-Code : " + item.zipCode);
                    }
                    else if (string.Equals(userModifyInput, "phone Number", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Phone Number: ");
                        item.phoneNumber = Console.ReadLine();
                        Console.WriteLine("Updated Phone Number : " + item.phoneNumber);
                    }
                    else if (string.Equals(userModifyInput, "Email", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Enter Email - ID: ");
                        item.email = Console.ReadLine();
                        Console.WriteLine("Updated Email- ID : " + item.email);
                    }
                }
                else
                {
                    //Display Message
                    Console.WriteLine("Entered Name : " + userFirstName + " not Found!");
                }
            }
        }
        //Delete Contact from AddressBook
        public void DeleteContact()
        {
            //Variables 
            string userFirstName, dataFirstName;
            string userConfirmation;

            //User-Input To Modify Data
            Console.WriteLine("Enter First Name To Delete Contact : ");
            userFirstName = Console.ReadLine();

            //Check User-Input Match from AddressBook
            for (int i = 0; i < contactDetailsList.Count; i++)
            {
                dataFirstName = contactDetailsList[i].firstName;
                Console.WriteLine("Firstname : " + contactDetailsList[i].firstName);

                if (userFirstName == dataFirstName)
                {
                    Console.WriteLine("Are You Sure want to Delete This Contact ? ");
                    Console.WriteLine("Enter 'Yes' to delete Contact");
                    Console.WriteLine("Enter 'No' to avoid delete Contact");
                    userConfirmation = Console.ReadLine();
                    if (string.Equals(userConfirmation, "yes", StringComparison.CurrentCultureIgnoreCase))
                    {
                        contactDetailsList.RemoveAt(i);
                        Console.WriteLine("Contact Details deleted SuccessFully");
                    }
                    else
                    {
                        Console.WriteLine("Contact Details Not Deleted");
                    }
                }
            }
        }
        //Display Data
        public void Display()
        {
            //Display Message
            Console.WriteLine("-----------------------");
            Console.WriteLine("Your Contact Details  :");
            Console.WriteLine("-----------------------");

            foreach (var item in this.contactDetailsList)
            {
                Console.WriteLine("First Name : " + item.firstName);
                Console.WriteLine("Last Name : " + item.lastName);
                Console.WriteLine("Address : " + item.address);
                Console.WriteLine("City : " + item.city);
                Console.WriteLine("State : " + item.state);
                Console.WriteLine("Zip-Code : " + item.zipCode);
                Console.WriteLine("Phone Number : " + item.phoneNumber);
                Console.WriteLine("Email-ID : " + item.email);
                Console.WriteLine("-----------------------");
            }
        }


        public void AddressBookCreator()
        {
            int userInputAddressBook;
            string nameOfAddressBook;

            //Display Messages
            Console.WriteLine("================================");
            Console.WriteLine("Choose Option to Continue : ");
            Console.WriteLine("Press 1 : Create New AddressBook");
            Console.WriteLine("Press 2 : Display AddressBooks");
            Console.WriteLine("================================");

            //Taking Name of AddressBook from User
            userInputAddressBook = int.Parse(Console.ReadLine());

            //Operations to Choose
            switch (userInputAddressBook)
            {
                case 1:
                    //Display Message
                    Console.WriteLine("Write Name of Your AddressBook");
                    Console.WriteLine("NOTE : Name Must Be Unique :");
                    Console.WriteLine("------------------------------");
                    nameOfAddressBook = Console.ReadLine();

                    //Read Data from Json File
                    string datafile = File.ReadAllText(@"C:\Users\DELL\source\repos\NewAddressBook\NewAddressBook\AddressBooksData.json");
                    JObject a = JObject.Parse(datafile);

                    //Check AddressBook Name is Available Or Not
                    foreach (var item in a)
                    {
                        if (nameOfAddressBook == item.Key)
                        {
                            Console.WriteLine("AddressBook Already Exist! Try Again");
                            AddressBookCreator();
                        }
                    }

                    if (nameOfAddressBook != "")
                    {
                        //Display Message
                        Console.WriteLine(nameOfAddressBook + " - AddressBook is created.");

                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Wanted To Add Person Data ?");
                        Console.WriteLine("Press 1 : Yes");
                        Console.WriteLine("Press 2 : Main Menu");
                        Console.WriteLine("Press 3 : Exit");
                        Console.WriteLine("----------------------------");

                        int userChoice;
                        userChoice = int.Parse(Console.ReadLine());
                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine("Hello You are In Case 1");

                                ContactDetails CD = new ContactDetails();
                                AddContact(CD.firstName, CD.lastName, CD.address, CD.city, CD.state, CD.zipCode, CD.phoneNumber, CD.email);
                                
                                List<string> keyList = new List<string>();
                                Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();
                                
                                //Add Key and Values in Dictionary
                                AddressBookDictionary.Add(nameOfAddressBook, contactDetailsList);
                                

                                foreach (var item in a)
                                {
                                    Console.WriteLine(item.Key);
                                }

                                //Serialize JSON 
                                string json = JsonConvert.SerializeObject(AddressBookDictionary);
                                File.WriteAllText(@"C:\Users\DELL\source\repos\NewAddressBook\NewAddressBook\AddressBooksData.json", json);

                                Console.WriteLine("Person Data Added SuccessFully");
                                break;
                            case 2:
                                AddressBookCreator();
                                break;
                            case 3:
                                System.Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        Console.WriteLine("Name Should have some characters !!!");

                    break;

                case 2:
                    //variable
                    int counter = 1;
                    Console.WriteLine("----------------------");
                    Console.WriteLine("List Of Dictionaries :");
                    Console.WriteLine("----------------------");

                    //Read Data from Json File
                    string datafile1 = File.ReadAllText(@"C:\Users\DELL\source\repos\NewAddressBook\NewAddressBook\AddressBooksData.json");
                    JObject a1 = JObject.Parse(datafile1);
                   
                    //Check AddressBook Name is Available Or Not
                    foreach (var item in a1)
                    {
                        Console.WriteLine(counter + " " + item.Key);                        
                        counter++;
                    }
                    break;
                default:
                    break;

            }
        }
    }
}