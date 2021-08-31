using AddressBook;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewAddressBook
{
    class ContactManager
    {
        //options to select operation
        public static void Operations()
        {
            //Display Message
            Console.WriteLine("\nAvailable options :\n1.Add_contact\n2.Edit_contact\n3.Delete_Contact\n4.View_contacts\n5.New_address_book\n6.Search_person_by_cityOrState\n7.ViewPerson_ByCityOrState \n8.Sort_addressBook_contacts \n9.Read_Write_Contacts_UsingFileOperations \n0.Exit \n");
            Console.Write("Provide option :  ");
            
            //userInput
            int userAction = int.Parse(Console.ReadLine());
            string findName, searchAdrBookName;
            switch (userAction)
            {
                case 1:
                    AddressBookMain.DisplayABList();
                    Console.Write("\nEnter addressbook name to select and add contact : ");
                    searchAdrBookName = Console.ReadLine();
                    CheckAddresssBook(searchAdrBookName);
                    AddressBookMain.AddPersonInfo(searchAdrBookName);
                    Operations();
                    break;

                case 2:
                    AddressBookMain.DisplayABList();
                    Console.Write("\n  Enter addressbook name to find and edit contact : ");
                    searchAdrBookName = Console.ReadLine();
                    Console.Write("\n  Enter Firstname to find and edit contact : ");
                    findName = Console.ReadLine();
                    CheckAddresssBook(searchAdrBookName);

                    AddressBookMain.ModifyPersonInfo(searchAdrBookName, findName);
                    AddressBookMain.DisplayContacts(searchAdrBookName);
                    Operations();
                    break;

                case 3:
                    AddressBookMain.DisplayABList();
                    Console.Write("\n  Enter addressbook name to find and delete contact : ");
                    searchAdrBookName = Console.ReadLine();
                    Console.Write("\n  Enter Firstname to find and delete contact : ");
                    findName = Console.ReadLine();
                    CheckAddresssBook(searchAdrBookName);

                    AddressBookMain.DeletePersonInfo(searchAdrBookName, findName);
                    AddressBookMain.DisplayContacts(searchAdrBookName);
                    Operations();
                    break;

                case 4:
                    AddressBookMain.DisplayABList();
                    Console.Write("\n Here are available address books : ");                    
                    Console.Write("\n\n Enter address book name : ");
                    searchAdrBookName = Console.ReadLine();
                    AddressBookMain.DisplayContacts(searchAdrBookName);
                    Operations();
                    break;

                case 5:
                    AddressBookMain.NewAdrBook();
                    Operations();
                    break;
                
                case 6:                
                    AddressBookMain.SearchPerson();
                    Operations();
                    break;

                case 7:
                    AddressBookMain.DisplayByCityState();
                    Operations();
                    break;

                case 8:
                    AddressBookMain.DisplayByCityState();
                    Operations();
                    break;
                
                case 9:
                    ContactFileOperations.FileOps();
                    Operations();
                    break;
                
                case 0: break;
                
                default:
                    break;
            }

            void CheckAddresssBook(string searchAdrBookName)
            {
                int bookFound = 1;
                foreach (var ab in AddressBookMain.contactsDictionary)
                {                    
                    if ((ab.Key).ToUpper().Equals(searchAdrBookName.ToUpper()))                    
                        continue;                    
                    else                    
                        bookFound = 0;                    
                }
                if (bookFound == 0)
                {
                    Console.WriteLine(" --> Address book not found.");
                    Operations();
                }
            }

        }

    }
}
