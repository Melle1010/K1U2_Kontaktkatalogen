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
        private readonly ContactCatalog _cc;

        public ContactAdder(ContactCatalog cc)
        {
            _cc = cc;
        }
        public void Run()
        {
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



                    if (_cc.AddContact(new Contact(_cc.MakeUniqueID(), nameInput, emailInput, tagsInput))) {
                        Console.WriteLine("\nYou successfully added a new contact! ");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nHmmm, that won't work. Try again!");
                        Console.ReadKey(true);
                    }
                }
            }
    }
}
