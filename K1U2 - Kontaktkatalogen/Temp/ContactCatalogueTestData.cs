using K1U2___Kontaktkatalogen.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.Temp
{
    internal class ContactCatalogueTestData
    {
        private ContactCatalog _cc;
        public ContactCatalogueTestData(ContactCatalog cc)
        {
            _cc = cc;
        }

        public void Run()
        {
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Ava Harper", "ava.harper@example.com", "friend, coworker"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Ben Carter", "ben.carter@example.com", "family"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Clara Nguyen", "clara.nguyen@example.org", "work"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Diego Morales", "diego.morales@gmail.com", "gym, friend"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Eva Thompson", "eva.thompson@outlook.com", "neighbor"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Frank Liu", "frank.liu@company.com", "work, manager"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Grace Lee", "grace.lee@gmail.com", "friend, school"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Hector Ramirez", "hector.ramirez@mail.com", "guitar, band"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Iris Patel", "iris.patel@domain.com", "friend, colleague"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Jon Smith", "jon.smith@example.com", "school"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Kira Johnson", "kira.johnson@pobox.com", "friend"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Liam O'Connor", "liam.oconnor@example.com", "young"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Mona Rossi", "mona.rossi@art.com", "artist"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Noah Brown", "noah.brown@home.com", "family"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Olivia Martin", "olivia.martin@example.com", "work, lead"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Pablo Suarez", "pablo.suarez@studio.com", "photography"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Quinn Blake", "quinn.blake@example.com", "gym"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Rita Gomez", "rita.gomez@mail.com", "friend, cooking"));
            _cc.AddContact(new Contact(_cc.MakeUniqueID(), "Sam Walker", "sam.walker@tech.io", "dev, coworker"));
        }
    }
}
