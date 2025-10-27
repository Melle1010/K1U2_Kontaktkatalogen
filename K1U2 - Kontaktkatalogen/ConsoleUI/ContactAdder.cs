using K1U2___Kontaktkatalogen.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K1U2___Kontaktkatalogen.Core.Validators;

namespace K1U2___Kontaktkatalogen.ConsoleUI
{
    internal class ContactAdder
    {
        public ContactAdder(ContactCatalog cc) {
            string nameInput, emailInput, tagsInput;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Add Contact ---");
                Console.Write("\nName: ");
                nameInput = Console.ReadLine();
                Console.Write("\nEmail: ");
                emailInput = Console.ReadLine();
                Console.Write("\nTags (separated by comma): ");
                tagsInput = Console.ReadLine();

                List<string> tags = tagsInput.Split(',').Select(tag => tag.Trim()).ToList();

                Contact contact = new Contact(cc.MakeUniqueID(), nameInput, emailInput, tags);

                if (cc.TryAddingContact(contact) && ValidationService.IsValidEmail(emailInput)) {
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
