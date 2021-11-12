using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC13
            ReadAndWriteContact uc13 = new ReadAndWriteContact();
            char choice1;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Address Book");
                uc13.readAndWrite();
                Console.WriteLine("\nDo you want to continue?  (y/n)");
                choice1 = char.Parse(Console.ReadLine());
            } while (choice1 == 'y');
            #endregion
        }
    }
}