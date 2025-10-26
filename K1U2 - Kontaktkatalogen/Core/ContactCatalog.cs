using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.Core
{
    internal class ContactCatalog
    {
        public List<Contact> Contacts = new List<Contact>();
        public HashSet<String> Emails = new HashSet<String>();
        public HashSet<String> Ids = new HashSet<String>();


        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
            Emails.Add(contact.Email);
            Ids.Add(contact.Id);
        }
        public bool TryAddingContact(Contact contact) => (!Emails.Contains(contact.Email) && !Ids.Contains(contact.Id));
        public string MakeUniqueID()
        {
            int id;
            Random random = new Random();
            do
            {
                id = random.Next(10000);
            } while (Ids.Contains(id.ToString("D4")));

            return id.ToString("D4");
        }
    }
}

