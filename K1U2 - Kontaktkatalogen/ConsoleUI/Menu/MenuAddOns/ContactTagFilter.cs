using K1U2___Kontaktkatalogen.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.ConsoleUI.Menu.MenuAddOns
{
    internal class ContactTagFilter
    {
        private readonly ContactCatalog _cc;
        public ContactTagFilter(ContactCatalog cc)
        {
            _cc = cc;
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("--- Filter Contacts ---");
            Console.Write("\nFilter by tag: ");
            string inputTag = Console.ReadLine();
            Console.WriteLine();
            List<Contact> filteredContacts = _cc.ById.Values.Where(c => c.Tags.Any(t => t.ToUpper() == inputTag.ToUpper())).ToList();
            if (filteredContacts.Count == 0) Console.WriteLine("No contacts found...");
            foreach (Contact contact in filteredContacts)
            {
                Console.WriteLine("* " + contact);
            }

            Console.ReadKey(true);
        }
    }
}
