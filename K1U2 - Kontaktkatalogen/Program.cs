using K1U2___Kontaktkatalogen.ConsoleUI;
using K1U2___Kontaktkatalogen.Core;

namespace K1U2___Kontaktkatalogen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactCatalog cc = new ContactCatalog();
            Menu menu = new Menu(cc);
            menu.Run();
        }
    }
}
