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
        public HashSet<int> Ids = new HashSet<int>();

        public bool TryAddingContact(Contact contact) => (!Emails.Contains(contact.Email) && !Ids.Contains(contact.Id));
       
    }
}

