using K1U2___Kontaktkatalogen.ConsoleUI.Menu.MenuAddOns;
using K1U2___Kontaktkatalogen.ConsoleUI.Services;
using K1U2___Kontaktkatalogen.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.ConsoleUI.Menu
{
    internal class Menu
    {
        private readonly ContactCatalog _contactCatalogue;

        public Menu(ContactCatalog contactCatalogue)
        {
            _contactCatalogue = contactCatalogue;
        }
        public void Run()
        {
            while (true)
            {
                string input = MainMenu();

                switch (input)
                {
                    case "1":
                        ContactAdder contactAdder = new ContactAdder(_contactCatalogue);
                        contactAdder.Run();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("--- Contact List ---");
                        foreach (var kvp in _contactCatalogue.ById)
                        {
                            Console.WriteLine($"* ({kvp.Key}) {kvp.Value}");
                        }
                        if (_contactCatalogue.ById.Count == 0) Console.WriteLine("No Contacts...");
                        Console.ReadKey(true);
                        break;
                    case "3":
                        ContactSearcher contactSearcher = new ContactSearcher(_contactCatalogue);
                        contactSearcher.Run();
                        break;
                    case "4":
                        ContactTagFilter contactTagFilter = new ContactTagFilter(_contactCatalogue);
                        contactTagFilter.Run();
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
