using System;
namespace AddressBook
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            Addressbook addressbook = new Addressbook();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Create Contact\n2.Edit Contact\n3.Display Contacts\n4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressbook.CreateContact();
                        break;
                    case 2:
                        Console.WriteLine("Enter the first name");
                        string fname = Console.ReadLine();
                        addressbook.EditContact(fname);
                        break;
                    case 3:
                        addressbook.DisplayContacts();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct choice");
                        break;
                }
            
            }
        }
    }
}