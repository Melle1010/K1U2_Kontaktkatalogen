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
        private MenuService _menuService = new MenuService();
        private ContactCatalog _contactCatalog = new ContactCatalog();
        public Menu()
        {
            while (true)
            {
                string input = MainMenu();

                switch (input)
                {
                    case "1":
                        ContactAdder contactAdder = new ContactAdder(_contactCatalog);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("--- Contact List ---");
                        foreach (var contact in _contactCatalog.Contacts) {
                            Console.WriteLine("* "+contact);
                        }
                        if (_contactCatalog.Contacts.Count == 0) Console.WriteLine("No Contacts...");
                        Console.ReadLine();
                        break;
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
            return _menuService.HandleInput(0, 5);
        }
    }
}
