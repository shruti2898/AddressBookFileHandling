using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AddressBook
{
    class ReadAndWriteContact
    {
        public string file = @"C:\Users\Mehta\source\AddressBook\AddressBook\Contact.txt";

        class Person
        {
            internal string name;
            internal long phone;
            internal string email;
            internal string address;
            internal string city;
            internal string state;
            internal int zip;
        }
        void write(string[] text)
        {  
            Person person = new Person();
            Console.WriteLine("\nPlease Enter Contact Details: \n");
            Console.Write("Name:  ");
            person.name = Console.ReadLine();
            Console.Write("Phone Number:  ");
            person.phone = long.Parse(Console.ReadLine());
            Console.Write("Email:  ");
            person.email = Console.ReadLine();
            Console.Write("Address:  ");
            person.address = Console.ReadLine();
            Console.Write("City:  ");
            person.city = Console.ReadLine();
            Console.Write("State:  ");
            person.state = Console.ReadLine();
            Console.Write("Zip:  ");
            person.zip = int.Parse(Console.ReadLine());

            string contact = person.name + " " + person.phone + " " + person.email + " " + person.address + " " + person.city + " " + person.state + " " + person.zip;
            File.AppendAllLines(file, new[] { contact });
        }
        void read(string[] addressBook)
        {   
            if (addressBook.Length != 0)
            {
                int count = 1;
                Console.WriteLine("\n\nContacts: ");
                foreach (var contact in addressBook)
                { 
                    Console.WriteLine(count+".  "+contact);
                    count++;
                }

            }
            else
            {
                Console.WriteLine("AddressBook is Empty");
            }
        }

        public void readAndWrite()
        {

            string[] text = File.ReadAllLines(file);

            Console.WriteLine("Select an option: \n1. Create Contact \n2. Display Contacts\n0. Exit\n");
            Console.Write("Option:   ");
            int option = Convert.ToInt32(Console.ReadLine());

            if(option == 1)
            {
                write(text);
            }
            else if(option == 2)
            {
                read(text);
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }    
        }
    }
}