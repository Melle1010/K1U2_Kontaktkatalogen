using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K1U2___Kontaktkatalogen.Core;

namespace K1U2___Kontaktkatalogen.ConsoleUI
{
    internal class ContactSearcher
    {
        private readonly ContactCatalog _cc;
        public ContactSearcher(ContactCatalog cc)
        {
            _cc = cc;
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("--- Search Contact ---");
            Console.Write("\nSearch by name: ");
            string inputName = Console.ReadLine();
            Console.WriteLine();
            List<Contact> searchedContacts = _cc.ById.Values.Where(c => c.Name.ToUpper().Contains(inputName.ToUpper())).ToList();
            if (searchedContacts.Count == 0) Console.WriteLine("No contacts found...");
            foreach (Contact contact in searchedContacts) {
                Console.WriteLine("* "+contact);
            }
            
            Console.ReadKey(true);
        }
    }
}
