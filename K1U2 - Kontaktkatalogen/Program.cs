using K1U2___Kontaktkatalogen.ConsoleUI.Menu;
using K1U2___Kontaktkatalogen.Core;
using K1U2___Kontaktkatalogen.Temp;

namespace K1U2___Kontaktkatalogen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactCatalog cc = new ContactCatalog();

            // Asks if you want to load test data or not
            Console.Write("Do you want test data? y/n: ");
            string? answer = Console.ReadLine();

            if (answer?.ToLower() == "y")
            {
                ContactCatalogueTestData cctd = new ContactCatalogueTestData(cc);
                cctd.Run();
            }


            Menu menu = new Menu(cc);
            menu.Run();
        }
    }
}
