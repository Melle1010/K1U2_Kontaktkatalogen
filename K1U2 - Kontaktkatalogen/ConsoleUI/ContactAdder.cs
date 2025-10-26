using K1U2___Kontaktkatalogen.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.ConsoleUI
{
    internal class ContactAdder
    {
        public ContactAdder(ContactCatalog cc) {
            string input1, input2, input3;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Add Contact ---");
                Console.Write("\nName: ");
                input1 = Console.ReadLine();
                Console.Write("\nEmail: ");
                input2 = Console.ReadLine();
                Console.Write("\nTags (separated by comma): ");
                input3 = Console.ReadLine();

                List<string> tags = input3.Split(',').Select(tag => tag.Trim()).ToList();

                Contact contact = new Contact(cc.MakeUniqueID(), input1, input2, tags);

                if (cc.TryAddingContact(contact)) {
                    Console.WriteLine("\nYou successfully added a new contact! ");
                    cc.AddContact(contact);
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("\nHmmm, that won't work. Try again!");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
