using K1U2___Kontaktkatalogen.ConsoleUI;
using K1U2___Kontaktkatalogen.Core;
using K1U2___Kontaktkatalogen.Temp;

namespace K1U2___Kontaktkatalogen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactCatalog cc = new ContactCatalog();

            //Gives the contact catalogue some test data
            ContactCatalogueTestData cctd = new ContactCatalogueTestData();
            cctd.Run(cc);

            Menu menu = new Menu(cc);
            menu.Run();
        }
    }
}
