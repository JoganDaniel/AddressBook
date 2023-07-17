using System;
namespace AddressBook
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            AddressBook addressBook = new AddressBook();
            addressBook.CreateContact();
        }
    }
}