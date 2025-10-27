using K1U2___Kontaktkatalogen.ConsoleUI.Services;
using K1U2___Kontaktkatalogen.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.ConsoleUI
{
    internal class Menu
    {
        private readonly ContactCatalog _contactCatalog;
        public Menu(ContactCatalog contactCatalog)
        {
            _contactCatalog = contactCatalog;
        }
        public void Run()
        {
            while (true)
            {
                string input = MainMenu();

                switch (input)
                {
                    case "1":
                        ContactAdder contactAdder = new ContactAdder(_contactCatalog);
                        contactAdder.Run();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("--- Contact List ---");
                        foreach (var contact in _contactCatalog.Contacts)
                        {
                            Console.WriteLine("* " + contact);
                        }
                        if (_contactCatalog.Contacts.Count == 0) Console.WriteLine("No Contacts...");
                        Console.ReadLine();
                        break;
                    case "3":
                        ContactSearcher contactSearcher = new ContactSearcher(_contactCatalog);
                        contactSearcher.Run();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        return;
                }
            }
        }
        public string MainMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Contact Catalog ===");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) List");
            Console.WriteLine("3) Search");
            Console.WriteLine("4) Filter by Tag");
            Console.WriteLine("5) Export CSV");
            Console.WriteLine("0) Exit");
            Console.WriteLine("- - - - - - - - - - - -");
            Console.Write("> ");
            return MenuService.HandleInput(0, 5);
        }
    }
}
