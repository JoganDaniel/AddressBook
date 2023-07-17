using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Addressbook
    {
        List<Contact> addressbooklist = new List<Contact>();
        public void CreateContact()
        {
            Console.WriteLine("Enter the details\n1.First Name\n2.Last Name\n3.Address \n4.City Name \n5.State Name \n6.Zip code \n7.Phone Number \n8.Email Address ");
            Contact contact = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToInt32(Console.ReadLine()),
                PhoneNumber = Convert.ToInt32(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            Console.WriteLine("Added Contact :");
            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            addressbooklist.Add(contact);
        }
        public void EditContact(string name) 
        { 
            foreach(Contact contact in addressbooklist)
            {
                if(contact.FirstName == name || contact.LastName.Equals(name))
                {
                    Console.WriteLine("Enter what to edit\n1.Last Name\n2.Address \n3.City Name \n4.State Name \n5.Zip code \n6.Phone Number \n7.Email Address ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            contact.Email = Console.ReadLine();
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Edited Details");
                    Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
                }
            }
        }

        public void DeleteContact(string name)
        {
            Contact contact = new Contact();
            foreach (Contact data in addressbooklist)
            {
                if (data.FirstName == name || data.LastName.Equals(name))
                {
                    contact = data;
                }
            }
            addressbooklist.Remove(contact);
            Console.WriteLine("Contact Removed");
        }
        public void DisplayContacts()
        {
            int c = 1;
            foreach(Contact contact in addressbooklist)
            {
                Console.WriteLine("Contact "+c+":");
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
                c++;
            }
        }
    }
}
